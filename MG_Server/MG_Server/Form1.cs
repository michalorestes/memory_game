using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_Server
{
    public partial class Server : Form
    {
        System.Windows.Forms.Timer periodicActivityCheckTimer;


        Network tcp;
        public static List<Client> ConnectedClients { get; set; }
        public static List<GameSession> gameSessions { get; set; }
        Messages decoder; 
       
        
        public Server()
        {
            InitializeComponent();
            Client.NoOfClients = 0;
            btn_initTCP.Enabled = true;
            btn_listenTCP.Enabled = false;
            btn_accept.Enabled = false;
            txt_ip.Text = Network.GetLocalIPAddress().ToString();
            ConnectedClients = new List<Client>();
            gameSessions = new List<GameSession>();
             
                        
            ///Set up timer that periodically accepts incomming connections
            ///and messages 
            ///Timer's current state = DISABLED 
            periodicActivityCheckTimer = new Timer();
            periodicActivityCheckTimer.Tick += new EventHandler(periodicActivityCheck);
            periodicActivityCheckTimer.Interval = 100;
            periodicActivityCheckTimer.Enabled = false;

           // GameSession gs = new GameSession(); 
            
        }

        #region SYSTEM METHODS  
        private void updatePlayersList()
        {
            lb_playersList.DataSource = null;
            lb_playersList.DataSource = ConnectedClients;
            lb_playersList.DisplayMember = "alias";
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

        public static GameSession getGameSession(int ID)
        {
            foreach (var session in gameSessions)
            {
                if (session.gameID == ID)
                {
                    return session;
                }
            }

            return null;
        }

        #endregion SYSTEM METHODS 


        private void periodicActivityCheck(object myObject, EventArgs myEventArgs)
        {
            //ACCEPT CONNECTIONS
            Socket tempSocket = tcp.tcp_acceptConnection();
            if (tempSocket != null)
            {
                Client client = new Client();
                client.ConnectionSocket = tempSocket;
                ConnectedClients.Add(client);
                txt_clients.Text = ConnectedClients.Count.ToString();
            }

            //RECIEVE MESSAGES 
            for (int i = 0; i < ConnectedClients.Count; i++)
            {
                Messages.MESSAGE msg = tcp.receiveMessage(ConnectedClients[i].ConnectionSocket);
                #region MESSAGE DECODER 
                switch (msg.msgID)
                {
                    //Handle Error Message (Closed connection)
                    case -1:
                        ConnectedClients.RemoveAt(i);
                        txt_clients.Text = ConnectedClients.Count.ToString();
                        txt_output.AppendText("Player Disconnected \n");
                        updatePlayersList();
                        break;

                    case 0:
                        break;
                    //Initialise player 
                    case 1:
                        decoder.initialiseClient(msg, ConnectedClients[i]);
                        updatePlayersList();
                        decoder.updateAllPlayersInfo();
                        break;
                    //Request to invite player recieved 
                    case 4:
                        txt_output.AppendText("recieved request \n");
                        decoder.inviteClient(ConnectedClients[i].ClientID, msg);
                        break;
                    //invitation response recieved 
                    case 6:
                        decoder.invitationResponse(msg);
                        break;

                    default: //pass message to appriopriate game sessession 
                        getGameSession(msg.gameSession).getMessage(msg, ConnectedClients[i].ClientID);
                        break;
                }
                #endregion MESSAGE DECODER 

            }
        }
        private void btn_initTCP_Click(object sender, EventArgs e)
        {
            Network.ConnectionPort = Int32.Parse(txt_conPort.Text);
            tcp = Network.getNetwork();
            txt_output.AppendText(tcp.tcp_initialiseServer());
            btn_initTCP.Enabled = false;
            btn_listenTCP.Enabled = true;
            decoder = new Messages(ConnectedClients);
        }

        private void btn_listenTCP_Click(object sender, EventArgs e)
        {
            txt_output.AppendText(tcp.tcp_startListen(4));
            btn_listenTCP.Enabled = false;
            btn_accept.Enabled = true;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            periodicActivityCheckTimer.Start();
            btn_accept.Enabled = false;
            txt_output.AppendText("Accepting Incomming Connections \n");
        }

        private void LBox_ClientsView(object sender, EventArgs e)
        {
            Client player = ConnectedClients[lb_playersList.SelectedIndex];
            txt_playerInfo.Text =
                "Alias: " + player.Alias + " \n" +
                "IP: " + player.IP
                ;
        }

        private void btn_testSend_Click(object sender, EventArgs e)
        {
            decoder.updateAllPlayersInfo();
        }
    }
}
