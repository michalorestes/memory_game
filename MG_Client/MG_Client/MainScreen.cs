using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_Client
{
    public partial class MainScreen : Form
    {
        private Client myDetails;
        private Network tcp;
        public static System.Windows.Forms.Timer timer;
        private Messages.MESSAGE msg;
        private Messages decoder;
        public static List<Client> ConnectedClients { set; get; }
        
        public MainScreen(Client client)
        {
            InitializeComponent();
            this.myDetails = client;
            lb_welcome.Text = "Welcome " + client.Alias;
            msg = new Messages.MESSAGE();
            Network._IP = "192.168.56.1";
            Network._ConnPort = client.ConnectionPort;
            tcp = Network.getNetwork();
            ConnectedClients = new List<Client>();
            decoder = new Messages(ConnectedClients);
            decoder.MainScreen = this;
            tcp.connectToServer();
            decoder.initialiseClient(client);
            //timer set up
            timer = new Timer();
            timer.Tick += new EventHandler(periodicMessageCheck);
            timer.Interval = 100;
            timer.Enabled = true;

            this.FormClosed += new FormClosedEventHandler(MainClosed);
            
        }

        private void updateAvailableClients()
        {
            lBox_playersList.DataSource = null;
            lBox_playersList.DataSource = ConnectedClients;
            lBox_playersList.DisplayMember = "alias"; 
        }

        private void MainClosed(object obj, EventArgs evt)
        {
            Messages.MESSAGE m = new Messages.MESSAGE();
            m.msgID = -1;
            tcp.sendMessage(msg);
        }

        private void periodicMessageCheck(object obj, EventArgs evt)
        {
            //Recieve messages from server 
            msg = tcp.receiveMessage();
            switch (msg.msgID)
            {
                case 0:
                    //0 byte messages
                    break;
                case 2:     //re-instantiate array of conected clients 
                    decoder.resetConnectedClients(msg);
                    Console.WriteLine("Waiting for players");
                    break;
                case 3:     //wait for incoming list of connected clients 
                    decoder.getPlayers(msg);
                    updateAvailableClients();
                    Console.WriteLine("Player recieved: " + ConnectedClients.Last().Alias);
                    break;
                case 5: //display message accept/decline invitation
                    Console.WriteLine("Recieved invitation");
                    decoder.invitationAcceptReject(msg);
                    break;
                case 7: //start game on client 
                    decoder.startGameSession(msg); 
            
                    break;
            }

        }

        private void lBox_playersList_DoubleClick(object sender, EventArgs e)
        {
            //invite player to join game
            int selectedClinet = ConnectedClients[lBox_playersList.SelectedIndex].ClientID;
            decoder.requestClient(selectedClinet);
        }

        //Get client from Connected Client base on his/her unique ID number 
        public static Client getClient(int ClientID)
        {
            foreach (var client in ConnectedClients)
            {
                if (client.ClientID == ClientID)
                {
                    return client;
                }
            }
            return null;
        }
    }
}
