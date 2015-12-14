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
    public partial class ServiseForm : Form
    {

        public int id;

        public ServiseForm(bool userState, string nameShtuff, int id)
        {
            InitializeComponent();
            labelName.Text = nameShtuff;

            if (userState)
                groupBoxAdmin.Enabled = true;
            else
                groupBoxAdmin.Enabled = false;

            this.id = id;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var newForm = new AdminForm();
            newForm.Show();
        }

        private void ServiseForm_Load(object sender, EventArgs e)
        {
            comboBoxProcessF.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProcessS.DropDownStyle = ComboBoxStyle.DropDownList;           

            Service.DbConnectRequest connectAndRequest = new Service.DbConnectRequest();
            DataTable dt = new DataTable();
            dt = connectAndRequest.dbConnectRequest(string.Format("SELECT Title, Id FROM Processes WHERE ParentId is NULL"));
            comboBoxProcessF.DataSource = dt;
            comboBoxProcessF.DisplayMember = "Title";
            comboBoxProcessF.ValueMember = "Id";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var newForm = new LoginForm();
            newForm.Show();
        }

        private void comboBoxProcessF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service.DbConnectRequest connectAndRequest = new Service.DbConnectRequest();
            DataTable dt = new DataTable();
            dt = connectAndRequest.dbConnectRequest(string.Format("SELECT Title, Id FROM Processes WHERE ParentId=" + (int)comboBoxProcessF.SelectedValue +"" ));
            comboBoxProcessS.DataSource = dt;
            comboBoxProcessS.DisplayMember = "Title";
            comboBoxProcessS.ValueMember = "Id";
            string a =  comboBoxProcessF.SelectedValue.ToString();
        }        

        private void buttonOk_Click(object sender, EventArgs e)
        {            
            try
            {
                Service.DbConnectRequest connectRequest = new Service.DbConnectRequest();
                DataTable dt = new DataTable();
                dt = connectRequest.dbConnectRequest(string.Format("INSERT INTO ProcessData ([Value], [CreateDate], [EditUserId], [ProcessId]) VALUES ('" + Convert.ToInt32(valueTb.Text.ToString()) + "','" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "', '" + this.id + "', '" + Convert.ToInt32(comboBoxProcessS.SelectedValue.ToString()) + "')"));
                MessageBox.Show("Добавленно");
            }
            catch
            {
                MessageBox.Show("Операция не выполнена");
            }            
        }

        private void buttonCansler_Click(object sender, EventArgs e)
        {
            valueTb.Clear();
        }

        private void valueTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (valueTb.Text.IndexOf(",") == -1) && (valueTb.Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }                

    }
}
