using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;


namespace ChatUdp
{
    public partial class ChatUdp : Form
    {
        public class FileDetails
        {
            public string fileType = "";
            public long fileSize = 0;
        }

        bool alive = false; // будет ли работать поток для приема
        UdpClient client;
        int LOCALPORT = 8001; // порт для приема сообщений
        int REMOTEPORT = 8001; // порт для отправки сообщений
        int TTL = 20;
        string HOST = "235.5.5.1"; // хост для групповой рассылки
        IPAddress groupAddress; // адрес для групповой рассылки
        string userName;


        public int LocalPort
        {
            get { return LOCALPORT; }
            set { LOCALPORT = Convert.ToInt32(value); }
        }

        public int RemoterPort
        {
            get { return REMOTEPORT; }
            set { REMOTEPORT = Convert.ToInt32(value); }
        }

        public int TtL
        {
            get { return TTL; }
            set { TTL = Convert.ToInt32(value); }
        }

        public string Host
        {
            get { return HOST; }
            set { HOST = value; }
        }



        public ChatUdp(string userName)
        {           
            InitializeComponent();

            usersLabel.Text = userName;
            this.userName = userName;
                        
        }

        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
 
                    // добавляем полученное сообщение в текстовое поле
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        ChatUdpTextBox.Text = time + " " + message + "\r\n" + ChatUdpTextBox.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        public ChatUdp()
        {
            // TODO: Complete member initialization
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                string message = userName + " покидает чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                client.DropMulticastGroup(groupAddress);

                alive = false;
                client.Close();  
            }
            catch
            {
                MessageBox.Show("Error!!!");
            }
                   
        }
     
        private void sendMessagesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName, sendMessageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                sendMessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnteringButton_Click(object sender, EventArgs e)
        {
            try
            {
                groupAddress = IPAddress.Parse(HOST);

                try
                {
                    client = new UdpClient(LOCALPORT);
                    // присоединяемся к групповой рассылке
                    client.JoinMulticastGroup(groupAddress, TTL);

                    // запускаем задачу на прием сообщений
                    Task receiveTask = new Task(ReceiveMessages);
                    receiveTask.Start();

                    // отправляем первое сообщение о входе нового пользователя
                    string message = userName + " вошел в чат";
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    client.Send(data, data.Length, HOST, REMOTEPORT);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!!!");
                }
            }
            catch
            {
                MessageBox.Show("Error!!!");
            }
            
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wayTextBox.Text = Path.GetDirectoryName(openFileDialog1.FileName) + "'\'" + Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            var newForm = new ServerSetting(LOCALPORT, REMOTEPORT, TTL, HOST);
            newForm.Show();
            newForm.Owner = this;
        }


    }
}
