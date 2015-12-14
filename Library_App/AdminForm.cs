using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_App
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;            
        }
        
        private void buttonUserAdd_Click(object sender, EventArgs e)
        {            
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            groupBox3.Visible = !groupBox3.Visible;
        }

        private void buttonUserDel_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = !groupBox3.Visible;
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
        }

        private void buttonProcessAdd_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = !groupBox4.Visible;
        }

        private void buttonProccesDel_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = !groupBox6.Visible;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {            
            try 
            {
                Service.DbConnectRequest connectAndRequest = new Service.DbConnectRequest();
                string command1 = "SELECT FName, LName FROM Users WHERE FName='" + textBoxFName.Text + "' AND LName='" + textBoxLName.Text + "'";
                DataTable dt = new DataTable();
                dt = connectAndRequest.dbConnectRequest(command1);
                string fName = dt.Rows[0]["FName"].ToString();
                string lName = dt.Rows[0]["LName"].ToString();
                string nameStaff = fName + " " + lName;                
                if (MessageBox.Show("Вы действительно хотите удалить '" + nameStaff + "'?", "Подтверждение!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
                {
                    string command2 = "DELETE FROM Users WHERE FName='" + textBoxFName.Text + "' AND LName='" + textBoxLName.Text + "' AND Patronymic='" + textBoxPatronymic.Text + "'";
                    connectAndRequest.dbConnectRequest(command2);
                    MessageBox.Show("Пользователь '" + nameStaff + "' удален!");
                    textBoxFName.Clear();
                    textBoxLName.Clear();
                    textBoxPatronymic.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Пользователь не найден! Проверьте введенные вами данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void textBoxPatronymic_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFName.Text != "" && textBoxLName.Text != "" && textBoxPatronymic.Text != "")
                buttonDel.Enabled = true;
            else
                buttonDel.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Service.DbConnectRequest connectAndRequest = new Service.DbConnectRequest();
                string command = "INSERT INTO Users ([FName], [LName], [Patronymic], [Login], [Password], [RegiserDate], [RoleId]) VALUES ('" + textBoxFNameAdd.Text + "'," + "'" + textBoxLNameAdd.Text + "'," +"'" + textBoxPatronymicAdd.Text + "'," + "'" + textBoxLogin.Text + "'," + "'" + textBoxPassword.Text + "'," +"'" + dateTimePickerRegister.Value.ToString("yyyy-MM-dd") + "'," +"(SELECT Id FROM Roles where RoleTitle LIKE '" + comboBoxRole.Text + "'))";
                DataTable dt = new DataTable();
                dt = connectAndRequest.dbConnectRequest(command);
                string nameStaff = textBoxFNameAdd.Text + " " + textBoxLNameAdd.Text;
                MessageBox.Show(nameStaff, "Добавленно", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Пользователь не был добавлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lyashevskyDataSet.Dimensions". При необходимости она может быть перемещена или удалена.
            this.dimensionsTableAdapter.Fill(this.lyashevskyDataSet.Dimensions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lyashevskyDataSet.Roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.lyashevskyDataSet.Roles);

            processFCBx.DropDownStyle = ComboBoxStyle.DropDownList;
            dimensionCBx.DropDownStyle = ComboBoxStyle.DropDownList;

            Service.DbConnectRequest cBxFill = new Service.DbConnectRequest();
            DataTable dt = new DataTable();
            dt = cBxFill.dbConnectRequest(string.Format("SELECT Title, Id FROM Processes WHERE ParentId is NULL"));
            processFCBx.DataSource = dt;
            processFCBx.DisplayMember = "Title";
            processFCBx.ValueMember = "Id";
            
        }

        private void addProcessButton_Click(object sender, EventArgs e)
        {
            Service.DbConnectRequest connectRequest = new Service.DbConnectRequest();
            DataTable dt = new DataTable();
            dt = connectRequest.dbConnectRequest(string.Format("INSERT INTO ......"));
        }

        private void buttonDelProcces_Click(object sender, EventArgs e)
        {
            try
            {
                Service.DbConnectRequest connectRequest = new Service.DbConnectRequest();
                DataTable dt = new DataTable();
                if (MessageBox.Show("Вы действительно хотите удалить '" + titleDelTb.Text + "'?", "Подтверждение!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dt = connectRequest.dbConnectRequest(string.Format("DELETE FROM Processes WHERE [Title]='" + titleDelTb.Text + "'"));
                }   
                else
                    MessageBox.Show("Процесс не был удален!");
            }
            catch
            {
                MessageBox.Show("Процесс не был удален! проверте правильность введеннных данных");
            }
        }

        private void processFCeckBox_CheckedChanged(object sender, EventArgs e)
        {
            //connect( ui->checkBox, SIGNAL( toggled(bool) ), ui->processFCBx, SLOT( setEnabled(bool) ) );
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Service.DbConnectRequest connectRequest = new Service.DbConnectRequest();
            DataTable dt = new DataTable();
            dt = connectRequest.dbConnectRequest(string.Format("SELECT Value, ProcessId FROM ProcessData "));
            List<int> uniqueId = new List<int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!uniqueId.Contains((int)dt.Rows[i]["ProcessId"]))
                {
                    uniqueId.Add((int)dt.Rows[i]["ProcessId"]);
                }
            }

            Dictionary<int, int> a = new Dictionary<int, int>();


            for (int g = 0; g < uniqueId.Count; g++)
            {
                a.Add(uniqueId[g], 0);

                MessageBox.Show(uniqueId[g].ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(uniqueId[g]==(int)dt.Rows[i]["ProcessId"])
                    a[uniqueId[g]]+=(int)dt.Rows[i]["Value"];
                }
            }
            MessageBox.Show(a[uniqueId[1]].ToString());
        }
    }
}
