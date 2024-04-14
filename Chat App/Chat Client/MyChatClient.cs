using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Client
{
    public class MyChatClient
    {
        private TcpClient _client;

        public event EventHandler<string> MessageReceived;

        /// <param name="ipAddress"></param>
        /// <param name="port"></param>
        public void Connect(string ipAddress, int port)
        {
            _client = new TcpClient();
            _client.Connect(ipAddress, port);

            _ = ReceiveDataAsync();
        }

        /// <param name="message"></param>
        public void SendMessage(string message)
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(message + Environment.NewLine);
            stream.Write(buffer, 0, buffer.Length);
        }
        
        public void SendImageMessage(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                
                StringBuilder sb = new StringBuilder();
                sb.Append("image;");
                sb.Append(base64String);

                NetworkStream stream = _client.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(sb + Environment.NewLine);
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        private async Task ReceiveDataAsync()
        {
            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            StringBuilder messageBuilder = new StringBuilder();

            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    break; 
                }

                string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                messageBuilder.Append(data);

                if (data.EndsWith("\n")) 
                {
                    string receivedMessage = messageBuilder.ToString();
                    OnMessageReceived(receivedMessage); 
                    messageBuilder.Clear();
                }
            }

            _client.Close();
        }

        public void Disconnect()
        {
            _client?.Close();
        }

        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(this, message);
        }
    }
}
