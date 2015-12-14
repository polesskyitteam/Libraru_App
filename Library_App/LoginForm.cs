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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonDbSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var newForm = new DbConfigForm();
            newForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {            
            try
            {
                Service.DbConnectRequest connectAndRequest = new Service.DbConnectRequest();
                DataTable dt = new DataTable();
                dt = connectAndRequest.dbConnectRequest(string.Format("SELECT Id, FName, LName, Login, Password, RoleId FROM Users WHERE Login='" + textBoxLogin.Text + "' AND Password='" + textBoxPassword.Text + "' "));                
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Проверьте логин или пароль", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (dt.Rows.Count > 1)
                    MessageBox.Show("Ошибка баз данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (dt.Rows.Count == 1)
                {
                    int id = (int)dt.Rows[0]["Id"];
                    string fName = dt.Rows[0]["FName"].ToString();
                    string lName = dt.Rows[0]["LName"].ToString();
                    string nameStaff = fName + " " + lName;
                    this.Visible = false;
                    if (dt.Rows[0]["RoleId"].ToString() == "1")
                    {
                        var newForm = new ServiseForm(true, nameStaff, id);
                        newForm.Show();
                    }
                    else
                    {
                        var newForm = new ServiseForm(false, nameStaff, id);
                        newForm.Show();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка подключения базы данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
