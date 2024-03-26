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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MessBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bnt_connect = new System.Windows.Forms.Button();
            this.bnt_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(232)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(99, 436);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 89);
            this.textBox1.TabIndex = 1;
            // 
            // MessBox
            // 
            this.MessBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MessBox.Location = new System.Drawing.Point(97, 151);
            this.MessBox.Multiline = true;
            this.MessBox.Name = "MessBox";
            this.MessBox.Size = new System.Drawing.Size(615, 253);
            this.MessBox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(108, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 15);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(291, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 15);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(472, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 15);
            this.textBox4.TabIndex = 5;
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
            // 
            // Clientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 605);
            this.Controls.Add(this.bnt_send);
            this.Controls.Add(this.bnt_connect);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MessBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Clientform";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox MessBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button bnt_connect;
        private System.Windows.Forms.Button bnt_send;
    }
}

