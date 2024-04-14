namespace Chat_Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chatView = new System.Windows.Forms.RichTextBox();
            this.inputMessageTextbox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatView
            // 
            this.chatView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chatView.Location = new System.Drawing.Point(4, 0);
            this.chatView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chatView.Name = "chatView";
            this.chatView.ReadOnly = true;
            this.chatView.Size = new System.Drawing.Size(372, 259);
            this.chatView.TabIndex = 1;
            this.chatView.Text = "";
            // 
            // inputMessageTextbox
            // 
            this.inputMessageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMessageTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputMessageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMessageTextbox.Location = new System.Drawing.Point(33, 265);
            this.inputMessageTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputMessageTextbox.Name = "inputMessageTextbox";
            this.inputMessageTextbox.Size = new System.Drawing.Size(272, 24);
            this.inputMessageTextbox.TabIndex = 2;
            this.inputMessageTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputMessageTextbox_KeyDown);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageButton.Location = new System.Drawing.Point(309, 263);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(66, 27);
            this.sendMessageButton.TabIndex = 3;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFileButton.BackColor = System.Drawing.Color.Transparent;
            this.openFileButton.BackgroundImage = global::Chat_Client.Properties.Resources.attachment_icon;
            this.openFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(4, 263);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(25, 27);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(280, 11);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 31);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chat with Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 357);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(397, 18);
            this.statusBar1.TabIndex = 8;
            this.statusBar1.Text = "Status OK";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.openFileButton);
            this.panel1.Controls.Add(this.sendMessageButton);
            this.panel1.Controls.Add(this.inputMessageTextbox);
            this.panel1.Controls.Add(this.chatView);
            this.panel1.Location = new System.Drawing.Point(5, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 297);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Chat Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Button sendMessageButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.RichTextBox chatView;
        private System.Windows.Forms.TextBox inputMessageTextbox;
        private System.Windows.Forms.Button connectButton;

        #endregion
    }
}