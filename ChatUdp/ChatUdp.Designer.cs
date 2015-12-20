namespace ChatUdp
{
    partial class ChatUdp
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendMessagesButton = new System.Windows.Forms.Button();
            this.ChatUdpTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageTextBox = new System.Windows.Forms.TextBox();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.EnteringButton = new System.Windows.Forms.Button();
            this.usersLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.addFileButton = new System.Windows.Forms.Button();
            this.wayTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.settingButton = new System.Windows.Forms.Button();
            this.nameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMessagesButton
            // 
            this.sendMessagesButton.Location = new System.Drawing.Point(378, 289);
            this.sendMessagesButton.Name = "sendMessagesButton";
            this.sendMessagesButton.Size = new System.Drawing.Size(130, 26);
            this.sendMessagesButton.TabIndex = 0;
            this.sendMessagesButton.Text = "Send a message";
            this.sendMessagesButton.UseVisualStyleBackColor = true;
            this.sendMessagesButton.Click += new System.EventHandler(this.sendMessagesButton_Click);
            // 
            // ChatUdpTextBox
            // 
            this.ChatUdpTextBox.Enabled = false;
            this.ChatUdpTextBox.Location = new System.Drawing.Point(12, 61);
            this.ChatUdpTextBox.Multiline = true;
            this.ChatUdpTextBox.Name = "ChatUdpTextBox";
            this.ChatUdpTextBox.Size = new System.Drawing.Size(496, 222);
            this.ChatUdpTextBox.TabIndex = 1;
            // 
            // sendMessageTextBox
            // 
            this.sendMessageTextBox.Location = new System.Drawing.Point(12, 289);
            this.sendMessageTextBox.Multiline = true;
            this.sendMessageTextBox.Name = "sendMessageTextBox";
            this.sendMessageTextBox.Size = new System.Drawing.Size(360, 41);
            this.sendMessageTextBox.TabIndex = 2;
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.EnteringButton);
            this.nameGroupBox.Controls.Add(this.usersLabel);
            this.nameGroupBox.Controls.Add(this.Exit);
            this.nameGroupBox.Location = new System.Drawing.Point(12, 10);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(496, 45);
            this.nameGroupBox.TabIndex = 3;
            this.nameGroupBox.TabStop = false;
            // 
            // EnteringButton
            // 
            this.EnteringButton.Location = new System.Drawing.Point(340, 16);
            this.EnteringButton.Name = "EnteringButton";
            this.EnteringButton.Size = new System.Drawing.Size(65, 23);
            this.EnteringButton.TabIndex = 2;
            this.EnteringButton.Text = "Entering";
            this.EnteringButton.UseVisualStyleBackColor = true;
            this.EnteringButton.Click += new System.EventHandler(this.EnteringButton_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersLabel.Location = new System.Drawing.Point(16, 16);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(46, 18);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "Name";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(411, 16);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(378, 335);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(130, 26);
            this.addFileButton.TabIndex = 4;
            this.addFileButton.Text = "Add file";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // wayTextBox
            // 
            this.wayTextBox.Enabled = false;
            this.wayTextBox.Location = new System.Drawing.Point(12, 339);
            this.wayTextBox.Name = "wayTextBox";
            this.wayTextBox.Size = new System.Drawing.Size(360, 20);
            this.wayTextBox.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // settingButton
            // 
            this.settingButton.BackgroundImage = global::ChatUdp.Properties.Resources.settings;
            this.settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingButton.Location = new System.Drawing.Point(494, 10);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(24, 24);
            this.settingButton.TabIndex = 7;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // ChatUdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 367);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.wayTextBox);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.sendMessageTextBox);
            this.Controls.Add(this.ChatUdpTextBox);
            this.Controls.Add(this.sendMessagesButton);
            this.Name = "ChatUdp";
            this.Text = "Чат библиотеки";
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMessagesButton;
        private System.Windows.Forms.TextBox ChatUdpTextBox;
        private System.Windows.Forms.TextBox sendMessageTextBox;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Button EnteringButton;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.TextBox wayTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button settingButton;
    }
}

