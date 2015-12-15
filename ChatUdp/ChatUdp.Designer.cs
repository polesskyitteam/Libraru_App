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
            this.usersLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.EnteringButton = new System.Windows.Forms.Button();
            this.nameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMessagesButton
            // 
            this.sendMessagesButton.Location = new System.Drawing.Point(400, 331);
            this.sendMessagesButton.Name = "sendMessagesButton";
            this.sendMessagesButton.Size = new System.Drawing.Size(108, 53);
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
            this.sendMessageTextBox.Location = new System.Drawing.Point(12, 331);
            this.sendMessageTextBox.Multiline = true;
            this.sendMessageTextBox.Name = "sendMessageTextBox";
            this.sendMessageTextBox.Size = new System.Drawing.Size(360, 53);
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
            this.Exit.Location = new System.Drawing.Point(425, 16);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EnteringButton
            // 
            this.EnteringButton.Location = new System.Drawing.Point(354, 16);
            this.EnteringButton.Name = "EnteringButton";
            this.EnteringButton.Size = new System.Drawing.Size(65, 23);
            this.EnteringButton.TabIndex = 2;
            this.EnteringButton.Text = "Entering";
            this.EnteringButton.UseVisualStyleBackColor = true;
            this.EnteringButton.Click += new System.EventHandler(this.EnteringButton_Click);
            // 
            // ChatUdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 396);
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
    }
}

