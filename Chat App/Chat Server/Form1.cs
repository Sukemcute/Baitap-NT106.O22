using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Chat_Server
{
    public enum User
    {
        Current,
        Other,
    }

    public partial class Form1 : Form
    {
        private MyTcpServer _server;
        private int _clientCount;
        private string _selectedImageFileName;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            panel1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3000; 
            timer.Tick += Timer_Tick;
            
            _server = new MyTcpServer(IPAddress.Loopback.ToString(), 5050);

            _server.MessageReceived += OnMessageReceived;

            _ = _server.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
        
            statusBar1.Text = "";
        }

        private void OnMessageReceived(object sender, string message)
        {
            if (message.StartsWith("[SERVER"))
            {
                ProcessCommandFromServerBackend(message);
                return;
            }

            if (message.StartsWith("image;"))
            {
                message = message.Replace("image;", "");

                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(message)));
                Bitmap imgBitmap = new Bitmap(img);

                Bitmap myBitmap = new Bitmap(imgBitmap);
                AppendImageToChatView(myBitmap, User.Other);
                
                
                chatView.ScrollToCaret();

                return;
            }

            AppendMessageToChatView(message.TrimEnd(), User.Other);
            chatView.ScrollToCaret();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputMessageTextbox.Text)) return;

            if (inputMessageTextbox.Text.StartsWith("[Image]") && _selectedImageFileName != null)
            {
                Image image = Image.FromFile(_selectedImageFileName);
                _server.SendImageMessage(_server.Clients.Last(), image, image.RawFormat);

                Bitmap myBitmap = new Bitmap(_selectedImageFileName);
                AppendImageToChatView(myBitmap, User.Current);

                inputMessageTextbox.Clear();
               
                
                chatView.ScrollToCaret();

                inputMessageTextbox.ReadOnly = false;
                _selectedImageFileName = null;
                return;
            }

            AppendMessageToChatView(inputMessageTextbox.Text, User.Current);
            var client = _server.Clients.Last();
            _server.SendTextMessage(client, inputMessageTextbox.Text);
            
            chatView.ScrollToCaret();
            
            inputMessageTextbox.Clear();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select image";
            fileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                inputMessageTextbox.Text = $"[Image] {fileDialog.SafeFileName}";
                
                inputMessageTextbox.ReadOnly = true;
                
                _selectedImageFileName = fileDialog.FileName;
            }
        }

       
        /// <param name="message"></param>
        /// <exception cref="Exception"></exception>
        private void ProcessCommandFromServerBackend(string message)
        {
            if (!message.Contains("[SERVER]")) throw new Exception("Invalid command");
           
            var command = message.Replace("[SERVER]", "").Trim();

            if (command == "Started")
            {
                statusLabel.Text = "Server Online. Awaiting connection...";
            }
            else if (command.Contains("Client Connected"))
            {
                panel1.Enabled = true;
                statusLabel.BackColor = Color.Green;
                _clientCount++;
                statusLabel.Text = "Server Online. Connected";
            }
            else if (command.Contains("Client Disconnected"))
            {
                _clientCount--;
                if (_clientCount == 0)
                {
                    statusLabel.BackColor = Color.Orange;
                    panel1.Enabled = false;
                    statusLabel.Text = "Server Online. Awaiting connection...";
                }
                else
                {
                    statusLabel.Text = $"Server Connected";
                }
            }
        }

        /// <param name="message"></param>
        /// <param name="user"></param>
        private void AppendMessageToChatView(string message, User user)
        {
            var time = DateTime.Now.ToString("HH:mm");
            chatView.Invoke((MethodInvoker)(() => 
                    {
                        Color sendColor = user == User.Current ? Color.LightBlue : Color.Aqua;
                        chatView.SelectionAlignment =
                            user == User.Current ? HorizontalAlignment.Right : HorizontalAlignment.Left;

                        chatView.AppendText("  ");
                        chatView.SelectionFont = new Font(chatView.Font.FontFamily, 12, FontStyle.Regular);
                        chatView.SelectionBackColor = sendColor;
                        chatView.AppendText(" " + message + " ");

                        chatView.SelectionBackColor = Color.Transparent;
                        chatView.SelectionFont = new Font(chatView.Font.FontFamily, 9, FontStyle.Italic);
                        chatView.AppendText($" {time}");

                        chatView.SelectionColor = Color.Transparent;
                        chatView.AppendText("😺");

                        chatView.AppendText(Environment.NewLine);
                        chatView.AppendText(Environment.NewLine);
                    }
                ));
        }

        private void AppendImageToChatView(Bitmap bitmap, User user)
        {
            chatView.Invoke((MethodInvoker)(() =>
            {
                int maxWidth = 300;
                int maxHeight = 300;

                int newWidth, newHeight;
                double aspectRatio = (double)bitmap.Width / bitmap.Height;

                if (aspectRatio > 1)
                {
                    newWidth = maxWidth;
                    newHeight = (int)(maxWidth / aspectRatio);
                }
                else
                {
                    newHeight = maxHeight;
                    newWidth = (int)(maxHeight * aspectRatio);
                }

                Bitmap resized = new Bitmap(bitmap, new Size(newWidth, newHeight));
                Clipboard.SetDataObject(resized);
                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                
                chatView.ReadOnly = false; 
                
                chatView.Select(chatView.Text.Length, 0);

                if (chatView.CanPaste(myFormat))
                {
                    chatView.SelectionAlignment =
                        user == User.Current ? HorizontalAlignment.Right : HorizontalAlignment.Left;

                    chatView.Paste(myFormat);
                }
                
                chatView.ReadOnly = true;
            }));
            chatView.AppendText(Environment.NewLine);
            AppendMessageToChatView("Sent an image", user);
        }

        private void inputMessageTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sendMessageButton.PerformClick();
            }
        }
    }
}