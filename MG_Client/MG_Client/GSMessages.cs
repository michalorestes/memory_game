using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Client
{
    class GSMessages : Messages
    {
        public int gameID;
        public GSMessages(int gameID)
        {
            this.gameID = gameID;
        }

        public void playerReady()
        {
            MESSAGE msg = new MESSAGE();
            msg.gameSession = gameID;
            msg.boolParam = true;
            msg.msgID = 9;
            tcp.sendMessage(msg);
        }


    }
}
