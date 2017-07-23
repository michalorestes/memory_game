using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Server
{
    public class GameSession
    {
        private static int noOfSessions; 
        public int gameID; 
        private int C1Score;
        private int C2Scrore;
        private bool turn;              //C1 = True, C2 = False
        private GSMessages sessionDecoder;
        List<Client> players;
        private System.Windows.Forms.Timer timer;
        
        bool p1Turn;
        public static bool p1ready;
        public static bool p2ready; 
        Network tcp;
        Messages.MESSAGE msg; 

        public GameSession(Client player1, Client player2, Messages decoder)
        {
            noOfSessions++;
            gameID = noOfSessions;
            Server.gameSessions.Add(this);

            p1ready = p2ready = false;
            this.players = new List<Client>();
            this.players.Add(player1);
            this.players.Add(player2);
            sessionDecoder = new GSMessages(this.players[0], this.players[1], gameID);
            tcp = Network.getNetwork();

            //Assign first turn 
            //0 = false - p2 turn 
            //1= true - p1 turn
            Random random = new Random();
            int turn = random.Next(2);
            p1Turn = Convert.ToBoolean(turn);

            //Generate Seed 
            //populate List with available symbols 
            List <String> icons = new List<string>()
            {
                "!", "!", "N", "N", ",", ",", "k", "k",
                "b", "b", "v", "v", "w", "w", "z", "z"
            };

            //assign random icon to each label card
            string seed = "";
            for (int i = 0; i < 16; i++)
            {
                int iconIndex = random.Next(icons.Count);
                seed = seed + icons[iconIndex];
                icons.RemoveAt(iconIndex);
            }

            sessionDecoder.gameInitialisation(p1Turn, seed);         
        }      
        public void getMessage(Messages.MESSAGE msg, int clientID)
        {
            sessionDecoder.messageReader(msg, clientID); 
        }
    }
}
