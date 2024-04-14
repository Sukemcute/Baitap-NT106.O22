using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Server
{
    public class MyTcpServer
    {
        private TcpListener _server;
        private List<TcpClient> _clients = new List<TcpClient>();
        private readonly string _ipAddress;
        private readonly int _port;

        public event EventHandler<string> MessageReceived;

        public int Port => _port;
        public List<TcpClient> Clients => _clients;

        
        /// <param name="ipAddress">Default at loopback IP (Cannot be accessed from the outside world)</param>
        /// <param name="port"></param>
        public MyTcpServer(string ipAddress, int port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public async Task Start()
        {
            
            if (_server != null)
            {
                throw new InvalidOperationException("Server is already running!");
            }

            IPAddress localAddr = IPAddress.Parse(_ipAddress);
            _server = new TcpListener(localAddr, _port);
            _server.Start();

            OnMessageReceived("[SERVER] Started");

            while (true)
            {
                
                TcpClient client = await _server.AcceptTcpClientAsync();
                _clients.Add(client);
                OnMessageReceived($"[SERVER] Client Connected. IP: {client.Client.RemoteEndPoint}");
                _ = HandleClientAsync(client);
            }
        }

        public void Stop()
        {
            _server?.Stop();
            _server = null;
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[1024];
            StringBuilder messageBuilder = new StringBuilder();

            
            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    OnMessageReceived($"[SERVER] Client Disconnected. IP: {client.Client.RemoteEndPoint}");
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
        }

        
        /// <param name="message"></param>
        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(this, message);
        }
        
       
        /// <param name="client"></param>
        /// <param name="message"></param>
        public void SendTextMessage(TcpClient client, string message)
        {
            
                NetworkStream stream = client.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(message + Environment.NewLine);
                stream.Write(buffer, 0, buffer.Length);
        }
        
        
        /// <param name="client"></param>
        /// <param name="message"></param>
        public void SendImageMessage(TcpClient client, Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {  
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                string base64String = Convert.ToBase64String(imageBytes);
                
                StringBuilder sb = new StringBuilder();
                sb.Append("image;");
                sb.Append(base64String);

                NetworkStream stream = client.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(sb + Environment.NewLine);
                stream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
