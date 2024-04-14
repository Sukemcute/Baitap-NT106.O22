using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Chat_Client
{
    public enum User
    {
        Current,
        Other,
    }

    public partial class Form1 : Form
    {
        private readonly MyChatClient _chatClient = new MyChatClient();
        private string _selectedImageFileName;

        private bool _isConnected = false;

        public Form1()
        {
            InitializeComponent();
            _chatClient.MessageReceived += OnMessageReceived;

            panel1.Enabled = false;
        }

        private void OnMessageReceived(object sender, string message)
        {
            if (message.StartsWith("image;"))
            {
                message = message.Replace("image;", "");

                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(message)));
                Bitmap imgBitmap = new Bitmap(img);

                AppendImageToChatView(imgBitmap, User.Other);
                
                chatView.ScrollToCaret();
                return;
            }
            
            AppendMessageToChatView(message.TrimEnd(), User.Other);
            chatView.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ipAddress = IPAddress.Loopback.ToString();
            var port = 5050;

            if (!_isConnected)
            {
                try
                {
                    _chatClient.Connect(ipAddress, port);
                    _isConnected = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                panel1.Enabled = true;
                statusBar1.Text = $@"Connected to server at {ipAddress}:{port}";
                connectButton.Text = @"Disconnect";
            }
            else
            {
                _chatClient.Disconnect();
                statusBar1.Text = "Disconnected";
                connectButton.Text = "Connect";
                _isConnected = false;
                panel1.Enabled = false;
            }
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputMessageTextbox.Text)) return;

            if (inputMessageTextbox.Text.StartsWith("[Image]") && _selectedImageFileName != null)
            {
                Image image = Image.FromFile(_selectedImageFileName);
                _chatClient.SendImageMessage(image, image.RawFormat);

                Bitmap myBitmap = new Bitmap(_selectedImageFileName);
                AppendImageToChatView(myBitmap, User.Current);
                
                inputMessageTextbox.ReadOnly = false;
                
                openFileButton.BackgroundImage = Properties.Resources.attachment_icon;
                _selectedImageFileName = null;
            }
            else
            {
                _chatClient.SendMessage(inputMessageTextbox.Text);
                AppendMessageToChatView(inputMessageTextbox.Text, User.Current);
            }

            chatView.ScrollToCaret();
            inputMessageTextbox.Clear();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (_selectedImageFileName != null)
            {
                _selectedImageFileName = null;
                openFileButton.BackgroundImage = Properties.Resources.attachment_icon;
                
                inputMessageTextbox.Text = "";
                inputMessageTextbox.ReadOnly = false;
                return;
            }
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select image";
            fileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileButton.BackgroundImage = Properties.Resources.cancel_icon;
                
                inputMessageTextbox.Text = $"[Image] {fileDialog.SafeFileName}";
                inputMessageTextbox.ReadOnly = true;
                _selectedImageFileName = fileDialog.FileName;
            }
        }

        private void AppendMessageToChatView(string message, User user)
        {
            var time = DateTime.Now.ToString("HH:mm");
            chatView.Invoke((MethodInvoker)(() =>
                    {
                        Color sendColor = user == User.Current ? Color.Bisque : Color.Pink;
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

                chatView.AppendText(Environment.NewLine);
                AppendMessageToChatView("Sent an image", user);
            }));
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