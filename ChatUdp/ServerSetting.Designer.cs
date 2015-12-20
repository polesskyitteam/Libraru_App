namespace ChatUdp
{
    partial class ServerSetting
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
            this.saveButton = new System.Windows.Forms.Button();
            this.localPortTextBox = new System.Windows.Forms.TextBox();
            this.remotePortTextBox = new System.Windows.Forms.TextBox();
            this.limitSteapsTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.localPortLab = new System.Windows.Forms.Label();
            this.remotePortLab = new System.Windows.Forms.Label();
            this.limitStepsLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(172, 191);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // localPortTextBox
            // 
            this.localPortTextBox.Location = new System.Drawing.Point(108, 28);
            this.localPortTextBox.Name = "localPortTextBox";
            this.localPortTextBox.Size = new System.Drawing.Size(139, 20);
            this.localPortTextBox.TabIndex = 1;
            // 
            // remotePortTextBox
            // 
            this.remotePortTextBox.Location = new System.Drawing.Point(108, 67);
            this.remotePortTextBox.Name = "remotePortTextBox";
            this.remotePortTextBox.Size = new System.Drawing.Size(139, 20);
            this.remotePortTextBox.TabIndex = 2;
            // 
            // limitSteapsTextBox
            // 
            this.limitSteapsTextBox.Location = new System.Drawing.Point(108, 109);
            this.limitSteapsTextBox.Name = "limitSteapsTextBox";
            this.limitSteapsTextBox.Size = new System.Drawing.Size(139, 20);
            this.limitSteapsTextBox.TabIndex = 3;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(108, 153);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(139, 20);
            this.hostTextBox.TabIndex = 4;
            // 
            // localPortLab
            // 
            this.localPortLab.AutoSize = true;
            this.localPortLab.Location = new System.Drawing.Point(17, 28);
            this.localPortLab.Name = "localPortLab";
            this.localPortLab.Size = new System.Drawing.Size(54, 13);
            this.localPortLab.TabIndex = 5;
            this.localPortLab.Text = "Local port";
            // 
            // remotePortLab
            // 
            this.remotePortLab.AutoSize = true;
            this.remotePortLab.Location = new System.Drawing.Point(17, 67);
            this.remotePortLab.Name = "remotePortLab";
            this.remotePortLab.Size = new System.Drawing.Size(66, 13);
            this.remotePortLab.TabIndex = 6;
            this.remotePortLab.Text = "Remote Port";
            // 
            // limitStepsLabel
            // 
            this.limitStepsLabel.AutoSize = true;
            this.limitStepsLabel.Location = new System.Drawing.Point(17, 109);
            this.limitStepsLabel.Name = "limitStepsLabel";
            this.limitStepsLabel.Size = new System.Drawing.Size(58, 13);
            this.limitStepsLabel.TabIndex = 7;
            this.limitStepsLabel.Text = "Limit Steps";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(17, 153);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(42, 13);
            this.hostLabel.TabIndex = 8;
            this.hostLabel.Text = "IP Host";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.localPortTextBox);
            this.groupBox1.Controls.Add(this.hostLabel);
            this.groupBox1.Controls.Add(this.remotePortTextBox);
            this.groupBox1.Controls.Add(this.limitStepsLabel);
            this.groupBox1.Controls.Add(this.limitSteapsTextBox);
            this.groupBox1.Controls.Add(this.remotePortLab);
            this.groupBox1.Controls.Add(this.hostTextBox);
            this.groupBox1.Controls.Add(this.localPortLab);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 230);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server setting";
            // 
            // ServerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServerSetting";
            this.Text = "Server Setting";
            this.Load += new System.EventHandler(this.ServerSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox localPortTextBox;
        private System.Windows.Forms.TextBox remotePortTextBox;
        private System.Windows.Forms.TextBox limitSteapsTextBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label localPortLab;
        private System.Windows.Forms.Label remotePortLab;
        private System.Windows.Forms.Label limitStepsLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}