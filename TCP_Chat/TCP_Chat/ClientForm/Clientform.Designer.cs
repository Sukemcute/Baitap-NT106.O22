namespace ClientForm
{
    partial class Clientform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessSend = new System.Windows.Forms.TextBox();
            this.SvAddress = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Friend = new System.Windows.Forms.TextBox();
            this.bnt_connect = new System.Windows.Forms.Button();
            this.bnt_send = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MessBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MessSend
            // 
            this.MessSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.MessSend.Location = new System.Drawing.Point(99, 436);
            this.MessSend.Multiline = true;
            this.MessSend.Name = "MessSend";
            this.MessSend.Size = new System.Drawing.Size(536, 89);
            this.MessSend.TabIndex = 1;
            // 
            // SvAddress
            // 
            this.SvAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SvAddress.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SvAddress.Location = new System.Drawing.Point(117, 94);
            this.SvAddress.Name = "SvAddress";
            this.SvAddress.Size = new System.Drawing.Size(106, 20);
            this.SvAddress.TabIndex = 3;
            this.SvAddress.Text = "127.0.0.1";
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Location = new System.Drawing.Point(291, 96);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(130, 15);
            this.Username.TabIndex = 4;
            // 
            // Friend
            // 
            this.Friend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Friend.Location = new System.Drawing.Point(472, 96);
            this.Friend.Name = "Friend";
            this.Friend.Size = new System.Drawing.Size(130, 15);
            this.Friend.TabIndex = 5;
            // 
            // bnt_connect
            // 
            this.bnt_connect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bnt_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnt_connect.FlatAppearance.BorderSize = 2;
            this.bnt_connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_connect.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_connect.Location = new System.Drawing.Point(628, 72);
            this.bnt_connect.Name = "bnt_connect";
            this.bnt_connect.Size = new System.Drawing.Size(109, 39);
            this.bnt_connect.TabIndex = 6;
            this.bnt_connect.Text = "Connect";
            this.bnt_connect.UseVisualStyleBackColor = false;
            this.bnt_connect.Click += new System.EventHandler(this.bnt_connect_Click);
            // 
            // bnt_send
            // 
            this.bnt_send.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bnt_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_send.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_send.Location = new System.Drawing.Point(644, 459);
            this.bnt_send.Name = "bnt_send";
            this.bnt_send.Size = new System.Drawing.Size(71, 47);
            this.bnt_send.TabIndex = 7;
            this.bnt_send.Text = "Send";
            this.bnt_send.UseVisualStyleBackColor = false;
            this.bnt_send.Click += new System.EventHandler(this.bnt_send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ClientForm.Properties.Resources.MessImg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ClientForm.Properties.Resources.MessImg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MessBox
            // 
            this.MessBox.Location = new System.Drawing.Point(101, 154);
            this.MessBox.Name = "MessBox";
            this.MessBox.Size = new System.Drawing.Size(613, 247);
            this.MessBox.TabIndex = 8;
            this.MessBox.Text = "";
            // 
            // Clientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 605);
            this.Controls.Add(this.MessBox);
            this.Controls.Add(this.bnt_send);
            this.Controls.Add(this.bnt_connect);
            this.Controls.Add(this.Friend);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.SvAddress);
            this.Controls.Add(this.MessSend);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Clientform";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MessSend;
        private System.Windows.Forms.TextBox SvAddress;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Friend;
        private System.Windows.Forms.Button bnt_connect;
        private System.Windows.Forms.Button bnt_send;
        private System.Windows.Forms.RichTextBox MessBox;
    }
}

