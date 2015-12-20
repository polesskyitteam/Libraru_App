using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUdp
{
    public partial class ServerSetting : Form
    {
        int localPort;
        int remotePort;
        int limitSteps;
        string host = "";

        public ServerSetting(int localPort, int remotePort, int limitSteps, string host)
        {
            InitializeComponent();

            this.localPort = localPort;
            this.remotePort = remotePort;
            this.limitSteps = limitSteps;
            this.host = host;
        }       

        private void ServerSetting_Load(object sender, EventArgs e)
        {
            localPortTextBox.Text = localPort.ToString();
            remotePortTextBox.Text = remotePort.ToString();
            limitSteapsTextBox.Text = limitSteps.ToString();
            hostTextBox.Text = host;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChatUdp chat = (ChatUdp)this.Owner;
                chat.LocalPort = Convert.ToInt32(localPortTextBox.Text);
                chat.RemoterPort = Convert.ToInt32(remotePortTextBox.Text);
                chat.TtL = Convert.ToInt32(limitSteapsTextBox.Text);
                chat.Host = hostTextBox.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
