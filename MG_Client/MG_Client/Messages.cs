using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_Client
{
    public class Messages
    {
        GameScreen gameScreen;
        protected    Network tcp;
        private List<Client> connectedClients; //not used
        public List<Client> ConnectedClients
        {
            get
            {
                return connectedClients;
            }

            set
            {
                connectedClients = value;
            }
        }   //not used 

        private int waitingList;
        public MainScreen MainScreen { get; set; }

        [StructLayout(LayoutKind.Sequential)]
        public struct MESSAGE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string gameID;
            public int msgID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strParam1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strParam2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strParam3;
            public int intParam1;
            public int intParam2;
            public int intParam3;
            public bool boolParam;
            public bool boolParam2;
            public int gameSession;
            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            //public char[] clientsArray;
        }
        
        public Messages(List<Client> connectedClients)
        {
            this.tcp = Network.getNetwork();
            this.connectedClients = connectedClients;     
        }

        public Messages()
        {
            this.tcp = Network.getNetwork();
            this.ConnectedClients = MainScreen.ConnectedClients;
        }

        //To server
        //Send to server client's details 
        public void initialiseClient(Client client)
        {
            MESSAGE msg = new MESSAGE();
            msg.msgID = 1;
            msg.strParam1 = client.Alias;
            msg.strParam2 = client.Ip.ToString();

            tcp.sendMessage(msg);
        }

        //ID 4 
        //invite client to play with 
        public void requestClient(int clientID)
        {
            MESSAGE msg = new MESSAGE();
            msg.msgID = 4;
            msg.intParam1 = clientID;

            tcp.sendMessage(msg);  
        }

        //Response 
        public void resetConnectedClients(MESSAGE msg)
        {
            waitingList = msg.intParam1;
            connectedClients.Clear();
        }

        public void getPlayers(MESSAGE msg)
        {
            Client client = new Client();
            client.Alias = msg.strParam1;
            client.ClientID = msg.intParam1;
            client.Available = msg.boolParam; 
            connectedClients.Add(client);

            if (connectedClients.Count >= waitingList)
            {
                waitingList = 0;
            }
        }

        // Response ID 6 
        //decide to either accept or decline invitation 
        public void invitationAcceptReject(MESSAGE msg)
        {
            MESSAGE message = msg;
            message.msgID = 6;
            ///strParm1 = inviting client's alias 
            ///intParm1 = inviting clinnt's ID 
            ///strParm2 = invited client's alias 
            ///intParm2 = invited client's ID 
            ///boolParam = Accept/Decline 
            
            DialogResult dialogResult = MessageBox.Show("You have been invited to play with " + message.strParam1, "Game Invitation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                message.boolParam = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                message.boolParam = false;
            }

            tcp.sendMessage(message); 
        }

        //Rec ID - 7
        //if invitation accepted, start game session
        //if declined, inform the player 
        public void startGameSession(MESSAGE msg)
        {
            //MESSAGE RECIEVED 
            //p1Msg.msgID = 7;
            //p2Msg.msgID = 7;
            //p1Msg.boolParam = true; //Confirm accepted invitation
            //p2Msg.boolParam = true; //Confirm accepted invitation
            //p1Msg.intParam1 = player2.ClientID; //C1 is inviting
            //p2Msg.intParam1 = player1.ClientID; //C2 is invited

            //p1Msg.strParam1 = seed; //Provide seed for generating cards in sequence 
            //p2Msg.strParam1 = seed; //Provide seed for generatings cards in sequenc 

            ////Assign turns to each player 
            //p1Msg.boolParam2 = turn;
            //p2Msg.boolParam2 = !turn;
            //msg.intParam2 = game id 

            if (msg.boolParam)
            {
                MainScreen.timer.Stop();
                MainScreen.Hide();
                Client invitedClient = MainScreen.getClient(msg.intParam1);
                gameScreen = new GameScreen(invitedClient, msg.strParam1, msg.boolParam2, msg.intParam2);
                gameScreen.FormClosed += new FormClosedEventHandler(gameSessionEnded);
                gameScreen.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Player has declined yor invitation");
            }
        }

        

        /////EVENTS ////////////

        //Show mainScreen when game sessions has eneded 
        private void gameSessionEnded(Object obj, EventArgs evt)
        {
            gameScreen.disableTimers();
            gameScreen.Dispose();
            MainScreen.timer.Start();
            MainScreen.Show();
            
        }
    }
}
