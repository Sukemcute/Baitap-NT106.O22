namespace Server_Form
{
    partial class Serverform
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnt_listen = new System.Windows.Forms.Button();
            this.bnt_send = new System.Windows.Forms.Button();
            this.MessShow = new System.Windows.Forms.RichTextBox();
            this.IP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server_Form.Properties.Resources.ServerImg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 693);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bnt_listen
            // 
            this.bnt_listen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bnt_listen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnt_listen.FlatAppearance.BorderSize = 2;
            this.bnt_listen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_listen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_listen.Location = new System.Drawing.Point(560, 82);
            this.bnt_listen.Name = "bnt_listen";
            this.bnt_listen.Size = new System.Drawing.Size(109, 39);
            this.bnt_listen.TabIndex = 7;
            this.bnt_listen.Text = "Listen";
            this.bnt_listen.UseVisualStyleBackColor = false;
            this.bnt_listen.Click += new System.EventHandler(this.bnt_listen_Click);
            // 
            // bnt_send
            // 
            this.bnt_send.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bnt_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_send.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_send.Location = new System.Drawing.Point(598, 528);
            this.bnt_send.Name = "bnt_send";
            this.bnt_send.Size = new System.Drawing.Size(71, 47);
            this.bnt_send.TabIndex = 8;
            this.bnt_send.Text = "Send";
            this.bnt_send.UseVisualStyleBackColor = false;
            // 
            // MessShow
            // 
            this.MessShow.Location = new System.Drawing.Point(97, 176);
            this.MessShow.Name = "MessShow";
            this.MessShow.Size = new System.Drawing.Size(571, 285);
            this.MessShow.TabIndex = 9;
            this.MessShow.Text = "";
            // 
            // IP
            // 
            this.IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(106, 107);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(102, 20);
            this.IP.TabIndex = 10;
            this.IP.Text = "127.0.0.1";
            // 
            // Serverform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Server_Form.Properties.Resources.MessImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 697);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.MessShow);
            this.Controls.Add(this.bnt_send);
            this.Controls.Add(this.bnt_listen);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Serverform";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bnt_listen;
        private System.Windows.Forms.Button bnt_send;
        private System.Windows.Forms.RichTextBox MessShow;
        private System.Windows.Forms.TextBox IP;
    }
}

