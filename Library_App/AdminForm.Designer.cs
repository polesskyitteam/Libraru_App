namespace Library_App
{
    partial class AdminForm
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
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lyashevskyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lyashevskyDataSet = new Library_App.lyashevskyDataSet();
            this.buttonExit = new System.Windows.Forms.Button();
            this.rolesTableAdapter = new Library_App.lyashevskyDataSetTableAdapters.RolesTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportButton = new System.Windows.Forms.Button();
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.usersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRegister = new System.Windows.Forms.DateTimePicker();
            this.textBoxPatronymicAdd = new System.Windows.Forms.TextBox();
            this.textBoxLNameAdd = new System.Windows.Forms.TextBox();
            this.textBoxFNameAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUserDel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ReportControl = new System.Windows.Forms.TabControl();
            this.processTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addProcessButton = new System.Windows.Forms.Button();
            this.processFCBx = new System.Windows.Forms.ComboBox();
            this.dimensionCBx = new System.Windows.Forms.ComboBox();
            this.dimensionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processFCeckBox = new System.Windows.Forms.CheckBox();
            this.nameProcessTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonDelProcces = new System.Windows.Forms.Button();
            this.titleDelTb = new System.Windows.Forms.TextBox();
            this.dimensionsTableAdapter = new Library_App.lyashevskyDataSetTableAdapters.DimensionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyashevskyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyashevskyDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.userTabPage.SuspendLayout();
            this.usersFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ReportControl.SuspendLayout();
            this.processTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionsBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.lyashevskyDataSetBindingSource;
            // 
            // lyashevskyDataSetBindingSource
            // 
            this.lyashevskyDataSetBindingSource.DataSource = this.lyashevskyDataSet;
            this.lyashevskyDataSetBindingSource.Position = 0;
            // 
            // lyashevskyDataSet
            // 
            this.lyashevskyDataSet.DataSetName = "lyashevskyDataSet";
            this.lyashevskyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(465, 479);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 25);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа с отчетами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(6, 17);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(135, 23);
            this.reportButton.TabIndex = 1;
            this.reportButton.Text = "Отчет за весь период";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // userTabPage
            // 
            this.userTabPage.AutoScroll = true;
            this.userTabPage.Controls.Add(this.usersFlowLayoutPanel);
            this.userTabPage.Location = new System.Drawing.Point(4, 22);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(521, 444);
            this.userTabPage.TabIndex = 0;
            this.userTabPage.Text = "Работа с пользователями";
            this.userTabPage.UseVisualStyleBackColor = true;
            // 
            // usersFlowLayoutPanel
            // 
            this.usersFlowLayoutPanel.Controls.Add(this.panel1);
            this.usersFlowLayoutPanel.Controls.Add(this.groupBox1);
            this.usersFlowLayoutPanel.Controls.Add(this.groupBox2);
            this.usersFlowLayoutPanel.Controls.Add(this.panel2);
            this.usersFlowLayoutPanel.Controls.Add(this.groupBox3);
            this.usersFlowLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.usersFlowLayoutPanel.Name = "usersFlowLayoutPanel";
            this.usersFlowLayoutPanel.Size = new System.Drawing.Size(492, 556);
            this.usersFlowLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonUserAdd);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить пользователя";
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.BackgroundImage = global::Library_App.Properties.Resources.arrow_down;
            this.buttonUserAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUserAdd.Location = new System.Drawing.Point(20, 8);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(48, 22);
            this.buttonUserAdd.TabIndex = 0;
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerRegister);
            this.groupBox1.Controls.Add(this.textBoxPatronymicAdd);
            this.groupBox1.Controls.Add(this.textBoxLNameAdd);
            this.groupBox1.Controls.Add(this.textBoxFNameAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о пользователе";
            // 
            // dateTimePickerRegister
            // 
            this.dateTimePickerRegister.Location = new System.Drawing.Point(209, 111);
            this.dateTimePickerRegister.Name = "dateTimePickerRegister";
            this.dateTimePickerRegister.Size = new System.Drawing.Size(274, 21);
            this.dateTimePickerRegister.TabIndex = 7;
            // 
            // textBoxPatronymicAdd
            // 
            this.textBoxPatronymicAdd.Location = new System.Drawing.Point(209, 84);
            this.textBoxPatronymicAdd.Name = "textBoxPatronymicAdd";
            this.textBoxPatronymicAdd.Size = new System.Drawing.Size(274, 21);
            this.textBoxPatronymicAdd.TabIndex = 6;
            // 
            // textBoxLNameAdd
            // 
            this.textBoxLNameAdd.Location = new System.Drawing.Point(209, 57);
            this.textBoxLNameAdd.Name = "textBoxLNameAdd";
            this.textBoxLNameAdd.Size = new System.Drawing.Size(274, 21);
            this.textBoxLNameAdd.TabIndex = 5;
            // 
            // textBoxFNameAdd
            // 
            this.textBoxFNameAdd.Location = new System.Drawing.Point(209, 30);
            this.textBoxFNameAdd.Name = "textBoxFNameAdd";
            this.textBoxFNameAdd.Size = new System.Drawing.Size(274, 21);
            this.textBoxFNameAdd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата регистрации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.comboBoxRole);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxLogin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Системная информация";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(408, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DataSource = this.rolesBindingSource;
            this.comboBoxRole.DisplayMember = "RoleTitle";
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(209, 84);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(274, 23);
            this.comboBoxRole.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(209, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(274, 21);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(209, 30);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(274, 21);
            this.textBoxLogin.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Роль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Пароль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Логин";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonUserDel);
            this.panel2.Location = new System.Drawing.Point(3, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 36);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(74, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Удалить пользователя";
            // 
            // buttonUserDel
            // 
            this.buttonUserDel.BackgroundImage = global::Library_App.Properties.Resources.arrow_down;
            this.buttonUserDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUserDel.Location = new System.Drawing.Point(20, 7);
            this.buttonUserDel.Name = "buttonUserDel";
            this.buttonUserDel.Size = new System.Drawing.Size(48, 22);
            this.buttonUserDel.TabIndex = 0;
            this.buttonUserDel.UseVisualStyleBackColor = true;
            this.buttonUserDel.Click += new System.EventHandler(this.buttonUserDel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDel);
            this.groupBox3.Controls.Add(this.textBoxPatronymic);
            this.groupBox3.Controls.Add(this.textBoxLName);
            this.groupBox3.Controls.Add(this.textBoxFName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(3, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 148);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о пользователе";
            this.groupBox3.Visible = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Enabled = false;
            this.buttonDel.Location = new System.Drawing.Point(408, 111);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 31);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(209, 84);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(274, 21);
            this.textBoxPatronymic.TabIndex = 6;
            this.textBoxPatronymic.TextChanged += new System.EventHandler(this.textBoxPatronymic_TextChanged);
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(209, 57);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(274, 21);
            this.textBoxLName.TabIndex = 5;
            this.textBoxLName.TextChanged += new System.EventHandler(this.textBoxPatronymic_TextChanged);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(209, 30);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(274, 21);
            this.textBoxFName.TabIndex = 4;
            this.textBoxFName.TextChanged += new System.EventHandler(this.textBoxPatronymic_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Отчество";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Имя";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Фамилия";
            // 
            // ReportControl
            // 
            this.ReportControl.Controls.Add(this.userTabPage);
            this.ReportControl.Controls.Add(this.processTabPage);
            this.ReportControl.Controls.Add(this.tabPage2);
            this.ReportControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportControl.Location = new System.Drawing.Point(6, 3);
            this.ReportControl.Name = "ReportControl";
            this.ReportControl.SelectedIndex = 0;
            this.ReportControl.Size = new System.Drawing.Size(529, 470);
            this.ReportControl.TabIndex = 0;
            // 
            // processTabPage
            // 
            this.processTabPage.Controls.Add(this.flowLayoutPanel1);
            this.processTabPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.processTabPage.Location = new System.Drawing.Point(4, 22);
            this.processTabPage.Name = "processTabPage";
            this.processTabPage.Size = new System.Drawing.Size(521, 444);
            this.processTabPage.TabIndex = 2;
            this.processTabPage.Text = "Работа с процессами";
            this.processTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 483);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 36);
            this.panel3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(74, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Добавить процесс";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Library_App.Properties.Resources.arrow_down;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(20, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 22);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addProcessButton);
            this.groupBox4.Controls.Add(this.processFCBx);
            this.groupBox4.Controls.Add(this.dimensionCBx);
            this.groupBox4.Controls.Add(this.processFCeckBox);
            this.groupBox4.Controls.Add(this.nameProcessTb);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(3, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 171);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о процессе";
            this.groupBox4.Visible = false;
            // 
            // addProcessButton
            // 
            this.addProcessButton.Location = new System.Drawing.Point(408, 122);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(75, 31);
            this.addProcessButton.TabIndex = 11;
            this.addProcessButton.Text = "Добавить";
            this.addProcessButton.UseVisualStyleBackColor = true;
            this.addProcessButton.Click += new System.EventHandler(this.addProcessButton_Click);
            // 
            // processFCBx
            // 
            this.processFCBx.FormattingEnabled = true;
            this.processFCBx.Location = new System.Drawing.Point(194, 28);
            this.processFCBx.Name = "processFCBx";
            this.processFCBx.Size = new System.Drawing.Size(289, 23);
            this.processFCBx.TabIndex = 10;
            // 
            // dimensionCBx
            // 
            this.dimensionCBx.DataSource = this.dimensionsBindingSource;
            this.dimensionCBx.DisplayMember = "Text";
            this.dimensionCBx.FormattingEnabled = true;
            this.dimensionCBx.Location = new System.Drawing.Point(173, 84);
            this.dimensionCBx.Name = "dimensionCBx";
            this.dimensionCBx.Size = new System.Drawing.Size(310, 23);
            this.dimensionCBx.TabIndex = 9;
            this.dimensionCBx.ValueMember = "Id";
            // 
            // dimensionsBindingSource
            // 
            this.dimensionsBindingSource.DataMember = "Dimensions";
            this.dimensionsBindingSource.DataSource = this.lyashevskyDataSetBindingSource;
            // 
            // processFCeckBox
            // 
            this.processFCeckBox.AutoSize = true;
            this.processFCeckBox.Location = new System.Drawing.Point(173, 32);
            this.processFCeckBox.Name = "processFCeckBox";
            this.processFCeckBox.Size = new System.Drawing.Size(15, 14);
            this.processFCeckBox.TabIndex = 8;
            this.processFCeckBox.UseVisualStyleBackColor = true;
            this.processFCeckBox.CheckedChanged += new System.EventHandler(this.processFCeckBox_CheckedChanged);
            // 
            // nameProcessTb
            // 
            this.nameProcessTb.Location = new System.Drawing.Point(173, 57);
            this.nameProcessTb.Name = "nameProcessTb";
            this.nameProcessTb.Size = new System.Drawing.Size(310, 21);
            this.nameProcessTb.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Измерение";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Имя процесса";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Заголовок";
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.button);
            this.panel4.Location = new System.Drawing.Point(3, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 36);
            this.panel4.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(74, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Удалить процесс";
            // 
            // button
            // 
            this.button.BackgroundImage = global::Library_App.Properties.Resources.arrow_down;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button.Location = new System.Drawing.Point(20, 7);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(48, 22);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.buttonDelProcces);
            this.groupBox6.Controls.Add(this.titleDelTb);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(3, 264);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(499, 119);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Информация о процессе";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Наименование процесса";
            // 
            // buttonDelProcces
            // 
            this.buttonDelProcces.Location = new System.Drawing.Point(408, 67);
            this.buttonDelProcces.Name = "buttonDelProcces";
            this.buttonDelProcces.Size = new System.Drawing.Size(75, 31);
            this.buttonDelProcces.TabIndex = 2;
            this.buttonDelProcces.Text = "Удалить";
            this.buttonDelProcces.UseVisualStyleBackColor = true;
            this.buttonDelProcces.Click += new System.EventHandler(this.buttonDelProcces_Click);
            // 
            // titleDelTb
            // 
            this.titleDelTb.Location = new System.Drawing.Point(209, 30);
            this.titleDelTb.Name = "titleDelTb";
            this.titleDelTb.Size = new System.Drawing.Size(274, 21);
            this.titleDelTb.TabIndex = 4;
            // 
            // dimensionsTableAdapter
            // 
            this.dimensionsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 508);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.ReportControl);
            this.Name = "AdminForm";
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyashevskyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyashevskyDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.userTabPage.ResumeLayout(false);
            this.usersFlowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ReportControl.ResumeLayout(false);
            this.processTabPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionsBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.BindingSource lyashevskyDataSetBindingSource;
        private lyashevskyDataSet lyashevskyDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private lyashevskyDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage userTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegister;
        private System.Windows.Forms.TextBox textBoxPatronymicAdd;
        private System.Windows.Forms.TextBox textBoxLNameAdd;
        private System.Windows.Forms.TextBox textBoxFNameAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUserDel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl ReportControl;
        private System.Windows.Forms.TabPage processTabPage;
        private System.Windows.Forms.BindingSource dimensionsBindingSource;
        private lyashevskyDataSetTableAdapters.DimensionsTableAdapter dimensionsTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addProcessButton;
        private System.Windows.Forms.ComboBox processFCBx;
        private System.Windows.Forms.ComboBox dimensionCBx;
        private System.Windows.Forms.CheckBox processFCeckBox;
        private System.Windows.Forms.TextBox nameProcessTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonDelProcces;
        private System.Windows.Forms.TextBox titleDelTb;
        private System.Windows.Forms.FlowLayoutPanel usersFlowLayoutPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button reportButton;
    }
}