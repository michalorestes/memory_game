using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MG_Server
{
    public class Client
    {
        private static int noOfClients;
        public int ClientID { get; set; } 
        public int id;
        private string ip;
        private Socket connectionSocket;
        private string alias;
        private int score;
        public bool Available { get; set; } 
        public string IP
            {
                get
                {
                    return ip;
                }

                set
                {
                    ip = value;
                }
            }

        public Socket ConnectionSocket
            {
                get
                {
                    return connectionSocket;
                }

                set
                {
                    connectionSocket = value;
                }
            }

        public string Alias
            {
                get
                {
                    return alias;
                }

                set
                {
                    alias = value;
                }
            }

        public int Score
            {
                get
                {
                    return score;
                }

                set
                {
                    score = value;
                }
            }

        public static int NoOfClients
        {
            get
            {
                return noOfClients;
            }

            set
            {
                noOfClients = value;
            }
        }

        public bool ready { get; set; }

        public Client()
        {
            NoOfClients++;
            ClientID = NoOfClients;
            Available = true;
            ready = false;
        }
    }
}
