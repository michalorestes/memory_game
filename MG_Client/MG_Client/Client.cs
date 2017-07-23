using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace MG_Client
{
    
    public class Client
    {
        public string Alias { get; set; } 
        public IPAddress Ip { get; set; }
        public int ConnectionPort { get; set; }
        public bool Available { get; set; } 
        public int ClientID { get; set; }


        public Client(string alias, IPAddress ip, int connectionPort)
        {
            this.Alias = alias;
            this.Ip = ip;
            this.ConnectionPort = connectionPort;

        }

        public Client()
        {

        }



    }
}
