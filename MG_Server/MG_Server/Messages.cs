using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MG_Server
{

    public class Messages
    {
        protected Network tcp;
        protected List<Client> connectedClients;
        protected List<Client> ConnectedClients
        {
            get
            {
                return connectedClients;
            }

            set
            {
                connectedClients = value;
            }
        }
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
            this.ConnectedClients = connectedClients;
        }

        public Messages()
        {
            this.tcp = Network.getNetwork();
        }

        //To client
        //Send - 2 & 3-- Server to Client Instructions 
        private void noOfIncomingMsg()
        {
            int noOfClients = ConnectedClients.Count;
            MESSAGE msg = new MESSAGE();
            msg.msgID = 2;              //Ensure that the client waits for N number of messages in a row
            msg.intParam1 = noOfClients; //Inform the client about number of messages being sent 

            //Inform all clients that updateList will be sent shortly 
            foreach (var client in ConnectedClients)
            {
                tcp.sendMessage(msg, client.ConnectionSocket);
            }
        }

        public void updateAllPlayersInfo()
        {
            noOfIncomingMsg();
            //send updateList to each player in turn  
            foreach (var client in ConnectedClients)
            {        
                foreach (var update in ConnectedClients)
                {
                    MESSAGE clientDetails = new MESSAGE();
                    clientDetails.msgID = 3;
                    clientDetails.strParam1 = update.Alias;
                    clientDetails.intParam1 = update.ClientID;
                    clientDetails.boolParam = update.Available;

                    //check if client details that are being currentely sent 
                    //are same as recieving client
                    //only send if details do not match 
                    if (client.ClientID != update.ClientID)
                    {
                        System.Threading.Thread.Sleep(200);
                        tcp.sendMessage(clientDetails, client.ConnectionSocket);
                    }         
                }
            }
        }


        //Response  
        //RecID - 1
        public void initialiseClient(MESSAGE msg, Client client)
        {
            client.Alias = msg.strParam1;
            client.IP = msg.strParam2;
        }

        //RecID - 4
        public void inviteClient(int requestorID, MESSAGE recMsg )
        {
            MESSAGE msg = new MESSAGE();
            int invitedClientID = recMsg.intParam1;
            Client invitedClient = Server.getClient(invitedClientID);
            if (invitedClient.Available == true)
            {  
                msg.msgID = 5;
                //inviting client details 
                msg.intParam1 = requestorID;            
                msg.strParam1 = Server.getClient(requestorID).Alias;
                //invited client 
                msg.strParam2 = invitedClient.Alias;
                msg.intParam2 = invitedClient.ClientID; 

                
                tcp.sendMessage(msg, invitedClient.ConnectionSocket);
            }
            else
            {
                //unavailable player
            }
        }

        //Send ID 7 || Rec 6
        public void invitationResponse(MESSAGE msg)
        {
            ///Recived 
            ///strParm1 = inviting client's alias 
            ///intParm1 = inviting clinnt's ID 
            ///strParm2 = invited client's alias 
            ///intParm2 = invited client's ID 
            ///boolParam = Accept/Decline

            MESSAGE client1Msg = new MESSAGE();
            MESSAGE client2Msg = new MESSAGE();
            client1Msg.intParam1 = msg.intParam2; //C1 is inviting 
            client2Msg.intParam1 = msg.intParam1; //C2 is invited
            client1Msg.msgID = 7;
            client2Msg.msgID = 7; 
           
            //Invitation accepted
            if (msg.boolParam)
            {
                GameSession gs = new GameSession(Server.getClient(msg.intParam1), Server.getClient(msg.intParam2), this);
                //Server.gameSessions.Add(gs);
                //client1Msg.boolParam = true; 
                //client2Msg.boolParam = true;
                //tcp.sendMessage(client1Msg, Server.getClient(msg.intParam1).ConnectionSocket);
                //tcp.sendMessage(client2Msg, Server.getClient(msg.intParam2).ConnectionSocket);
            }
            //invitation declined 
            else
            {
                client1Msg.boolParam = false;
                tcp.sendMessage(client1Msg, Server.getClient(msg.intParam1).ConnectionSocket);
                Console.WriteLine("Invitation declined");
            }
        }




    }//end of calss 
}
