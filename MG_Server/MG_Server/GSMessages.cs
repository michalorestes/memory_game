using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Server
{
    class GSMessages : Messages
    {
        private Client player1;
        private Client player2;
        private int gameID;
        public GSMessages(Client player1, Client player2, int gameID)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.gameID = gameID;
        }

        public void messageReader(MESSAGE msg, int playerID)
        {
            switch (msg.msgID)
            {
                case 9://Indicated when players are ready 
                    Server.getClient(playerID).ready = msg.boolParam;
                    if (player1.ready && player2.ready)
                    {
                        startTimer();
                    }
                    break;
            }
        }

        //send ID - 8 
        //inform players about game being accepted 
        //asign turns and provide generated seed string 
        public void gameInitialisation(bool turn, string seed)
        {
            
            MESSAGE p1Msg = new MESSAGE();
            MESSAGE p2Msg = new MESSAGE();
            p1Msg.msgID = 7;
            p2Msg.msgID = 7;
            p1Msg.boolParam = true; //Confirm accepted invitation
            p2Msg.boolParam = true; //Confirm accepted invitation
            p1Msg.intParam1 = player2.ClientID; //C1 is inviting
            p2Msg.intParam1 = player1.ClientID; //C2 is invited
            
            p1Msg.strParam1 = seed; //Provide seed for generating cards in sequence 
            p2Msg.strParam1 = seed; //Provide seed for generatings cards in sequenc 
            
            //Assign turns to each player 
            p1Msg.boolParam2 = turn;
            p2Msg.boolParam2 = !turn;

            //provide game session ID to each player
            p1Msg.intParam2 = gameID;
            p2Msg.intParam2 = gameID;


            //Send messages to clients 
            tcp.sendMessage(p1Msg, player1.ConnectionSocket);
            tcp.sendMessage(p2Msg, player2.ConnectionSocket);
        }

        //Rec ID - 9  Send 8- ready message 
        public void startTimer()
        {
            MESSAGE message = new MESSAGE();
            message.msgID = 8;
            tcp.sendMessage(message, player1.ConnectionSocket);
            tcp.sendMessage(message, player2.ConnectionSocket);
        }



    }
}
