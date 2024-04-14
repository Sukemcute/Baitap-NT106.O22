namespace Chat_Server
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.chatView = new System.Windows.Forms.RichTextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.inputMessageTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.BackColor = System.Drawing.Color.Red;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusLabel.Location = new System.Drawing.Point(13, 11);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(539, 46);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Initializing...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chatView
            // 
            this.chatView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chatView.Location = new System.Drawing.Point(9, 7);
            this.chatView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chatView.Name = "chatView";
            this.chatView.ReadOnly = true;
            this.chatView.Size = new System.Drawing.Size(539, 354);
            this.chatView.TabIndex = 2;
            this.chatView.Text = "";
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFileButton.BackColor = System.Drawing.Color.Transparent;
            this.openFileButton.BackgroundImage = global::Chat_Server.Properties.Resources.attachment_icon;
            this.openFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openFileButton.Location = new System.Drawing.Point(7, 367);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(33, 33);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageButton.Location = new System.Drawing.Point(461, 370);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(88, 33);
            this.sendMessageButton.TabIndex = 7;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // inputMessageTextbox
            // 
            this.inputMessageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMessageTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputMessageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMessageTextbox.Location = new System.Drawing.Point(45, 370);
            this.inputMessageTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputMessageTextbox.Name = "inputMessageTextbox";
            this.inputMessageTextbox.Size = new System.Drawing.Size(409, 28);
            this.inputMessageTextbox.TabIndex = 6;
            this.inputMessageTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputMessageTextbox_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.statusBar1);
            this.panel1.Controls.Add(this.openFileButton);
            this.panel1.Controls.Add(this.sendMessageButton);
            this.panel1.Controls.Add(this.inputMessageTextbox);
            this.panel1.Controls.Add(this.chatView);
            this.panel1.Location = new System.Drawing.Point(3, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 431);
            this.panel1.TabIndex = 10;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 409);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(561, 22);
            this.statusBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Chat Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.StatusBar statusBar1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox inputMessageTextbox;

        private System.Windows.Forms.RichTextBox chatView;

        private System.Windows.Forms.Label statusLabel;

        #endregion
    }
}