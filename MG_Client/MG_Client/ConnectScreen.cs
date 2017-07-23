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
namespace MG_Client
{
    public partial class ConnectScreen : Form
    {
        
        public ConnectScreen()
        {
            InitializeComponent();
            txt_IP.Enabled = false;
            txt_IP.Text = Network.GetLocalIPAddress().ToString();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Client client = new Client(txt_name.Text, IPAddress.Parse(txt_IP.Text), Int32.Parse(txt_connectionPort.Text));
            MainScreen ms = new MainScreen(client);
            ms.FormClosed += new FormClosedEventHandler(MainScreenClosed);
            this.Hide();
            ms.ShowDialog();
        }

        public void MainScreenClosed(object obj, EventArgs evt)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       
        }
    }
}
