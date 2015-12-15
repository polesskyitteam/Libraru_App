namespace Library_App
{
    partial class ServiseForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCansler = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.valueTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProcessS = new System.Windows.Forms.ComboBox();
            this.comboBoxProcessF = new System.Windows.Forms.ComboBox();
            this.processesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lyashevskyDataSet = new Library_App.lyashevskyDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dimensionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.processesTableAdapter = new Library_App.lyashevskyDataSetTableAdapters.ProcessesTableAdapter();
            this.dimensionsTableAdapter = new Library_App.lyashevskyDataSetTableAdapters.DimensionsTableAdapter();
            this.processesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.chatButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyashevskyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionsBindingSource)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.buttonCansler);
            this.groupBox1.Controls.Add(this.buttonOk);
            this.groupBox1.Controls.Add(this.valueTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxProcessS);
            this.groupBox1.Controls.Add(this.comboBoxProcessF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(200, 212);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker.TabIndex = 9;
            // 
            // buttonCansler
            // 
            this.buttonCansler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCansler.Location = new System.Drawing.Point(300, 298);
            this.buttonCansler.Name = "buttonCansler";
            this.buttonCansler.Size = new System.Drawing.Size(100, 36);
            this.buttonCansler.TabIndex = 8;
            this.buttonCansler.Text = "Отмена";
            this.buttonCansler.UseVisualStyleBackColor = true;
            this.buttonCansler.Click += new System.EventHandler(this.buttonCansler_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(194, 298);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 36);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // valueTb
            // 
            this.valueTb.Location = new System.Drawing.Point(24, 212);
            this.valueTb.Name = "valueTb";
            this.valueTb.Size = new System.Drawing.Size(100, 24);
            this.valueTb.TabIndex = 6;
            this.valueTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество:";
            // 
            // comboBoxProcessS
            // 
            this.comboBoxProcessS.FormattingEnabled = true;
            this.comboBoxProcessS.Location = new System.Drawing.Point(23, 111);
            this.comboBoxProcessS.Name = "comboBoxProcessS";
            this.comboBoxProcessS.Size = new System.Drawing.Size(377, 26);
            this.comboBoxProcessS.TabIndex = 2;
            // 
            // comboBoxProcessF
            // 
            this.comboBoxProcessF.DataSource = this.processesBindingSource;
            this.comboBoxProcessF.DisplayMember = "Title";
            this.comboBoxProcessF.FormattingEnabled = true;
            this.comboBoxProcessF.Location = new System.Drawing.Point(23, 66);
            this.comboBoxProcessF.Name = "comboBoxProcessF";
            this.comboBoxProcessF.Size = new System.Drawing.Size(377, 26);
            this.comboBoxProcessF.TabIndex = 1;
            this.comboBoxProcessF.ValueMember = "Id";
            this.comboBoxProcessF.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcessF_SelectedIndexChanged);
            // 
            // processesBindingSource
            // 
            this.processesBindingSource.DataMember = "Processes";
            this.processesBindingSource.DataSource = this.lyashevskyDataSet;
            // 
            // lyashevskyDataSet
            // 
            this.lyashevskyDataSet.DataSetName = "lyashevskyDataSet";
            this.lyashevskyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мероприятие:";
            // 
            // dimensionsBindingSource
            // 
            this.dimensionsBindingSource.DataMember = "Dimensions";
            this.dimensionsBindingSource.DataSource = this.lyashevskyDataSet;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(12, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(421, 71);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(19, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФИО";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(454, 379);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(135, 36);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdmin.Location = new System.Drawing.Point(15, 26);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(135, 48);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Администрирование";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.buttonAdmin);
            this.groupBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAdmin.Location = new System.Drawing.Point(439, 220);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(158, 86);
            this.groupBoxAdmin.TabIndex = 4;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Администрирование";
            // 
            // processesTableAdapter
            // 
            this.processesTableAdapter.ClearBeforeFill = true;
            // 
            // dimensionsTableAdapter
            // 
            this.dimensionsTableAdapter.ClearBeforeFill = true;
            // 
            // processesBindingSource1
            // 
            this.processesBindingSource1.DataMember = "Processes";
            this.processesBindingSource1.DataSource = this.lyashevskyDataSet;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Image = global::Library_App.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(445, 24);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(180, 201);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // chatButton
            // 
            this.chatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatButton.Location = new System.Drawing.Point(454, 324);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(135, 36);
            this.chatButton.TabIndex = 3;
            this.chatButton.Text = "Чат";
            this.chatButton.UseVisualStyleBackColor = true;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // ServiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 439);
            this.ControlBox = false;
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServiseForm";
            this.Text = "Учет библиотека";
            this.Load += new System.EventHandler(this.ServiseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyashevskyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionsBindingSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCansler;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox valueTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProcessS;
        private System.Windows.Forms.ComboBox comboBoxProcessF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private lyashevskyDataSet lyashevskyDataSet;
        private System.Windows.Forms.BindingSource processesBindingSource;
        private lyashevskyDataSetTableAdapters.ProcessesTableAdapter processesTableAdapter;
        private System.Windows.Forms.BindingSource dimensionsBindingSource;
        private lyashevskyDataSetTableAdapters.DimensionsTableAdapter dimensionsTableAdapter;
        private System.Windows.Forms.BindingSource processesBindingSource1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button chatButton;
    }
}