using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MG_Server
{
    
    public class Network
    {
        private static Network network;
        //Network 
        public static int ConnectionPort { get; set; }
        private Socket tcp_listenSocket;
        private IPEndPoint localEndPoint;

        

        private Network()
        {
            //this.connectionPort = connectionPort;
        }

        public static Network getNetwork()
        {
            if (ConnectionPort !=0)
            {
                if (network == null)
                {
                    network = new Network();
                }

                return network;
            }
            else
            {
                return null;
            }
        }


        #region INITIALISATION
        public string tcp_initialiseServer()
        {
            try
            {
                //Initialise Sockets 
                tcp_listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                localEndPoint = new IPEndPoint(IPAddress.Any, ConnectionPort);
                tcp_Bind();
                tcp_listenSocket.Blocking = false;
                return "Server Initialised \n";
            }
            catch (Exception)
            {
                return "Could now initialise server \n";
            }
        }

        private void tcp_Bind()
        {
            try
            {
                tcp_listenSocket.Bind(localEndPoint);
            }
            catch (Exception )
            {

            }
        }

        public string tcp_startListen(int listenBuffer)
        {
            try
            {
                tcp_listenSocket.Listen(listenBuffer);
                return "Listening for incomming connections (" + listenBuffer + ")\n";
            }
            catch (Exception)
            { 
                return "Could not listen for incoming connections\n";
            }
        }
        #endregion  INITIALISATION 

        #region GENERAL METHODS
        public Socket tcp_acceptConnection()
        {
            Socket connectionSocket;

            try
            {
                connectionSocket = tcp_listenSocket.Accept();
                connectionSocket.Blocking = false;
                return connectionSocket;
            }
            catch (SocketException se)
            {
                // If an exception occurs, display an error message
                if (10053 == se.ErrorCode || 10054 == se.ErrorCode) // Remote end closed the connection
                {
                    //tcp_closeConnection(playerID);
                }
                else if (10035 != se.ErrorCode)
                {   // Ignore error messages relating to normal behaviour of non-blocking sockets

                }
                connectionSocket = null;             
            }

            return connectionSocket;
        }

        private void closeConnection(Socket connectionSocket)
        {
            
            connectionSocket.Shutdown(SocketShutdown.Both);
            
        }
        
        public Messages.MESSAGE receiveMessage(Socket clientConnectionSocket)
        {
            Messages.MESSAGE msg = new Messages.MESSAGE();

            try
            {
                EndPoint remoteEndPoint = (EndPoint)localEndPoint;     //case IPEndPoint to EndPoint 
                byte[] recBuffer = new byte[1024];                      //Initialise Buffer for recived messages 
                int recByteCount;
                recByteCount = clientConnectionSocket.ReceiveFrom(recBuffer, ref remoteEndPoint);
                byte[] data = new byte[recByteCount];
                Array.Copy(recBuffer, data, recByteCount);

                if (recByteCount > 0)
                {
                    msg = DeSerialize(data);
                }
                else
                {
                    msg.msgID = 0; 
                }


            }
            catch (SocketException se)
            {
                // If an exception occurs, display an error message
                if (10053 == se.ErrorCode || 10054 == se.ErrorCode) // Remote end closed the connection
                {
                    msg.msgID = -1;
                    closeConnection(clientConnectionSocket);
                }
                else if (10035 != se.ErrorCode)
                {

                }
            }
            catch
            {
                //Silently catch other exceptions 
            }

            return msg;
        }

        public void sendMessage(Messages.MESSAGE msg, Socket clientConnectionSocket)
        {
            byte[] byteData = Serialize(msg);
            clientConnectionSocket.Send(byteData, SocketFlags.None);
        }

        #endregion GENERAL METHODS 

        #region RICHARDS METHODS 
        public static IPAddress GetLocalIPAddress()
        {
            string szHost = Dns.GetHostName();
            string szLocalIPaddress = "127.0.0.1";  // Default is local loopback address
            IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in IPHost.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork) // Match only the IPv4 address
                {
                    szLocalIPaddress = IP.ToString();
                    break;
                }
            }
            return IPAddress.Parse(szLocalIPaddress);
        }
        private byte[] Serialize(Object myObject)
        {
            int size = Marshal.SizeOf(myObject);
            IntPtr ip = Marshal.AllocHGlobal(size); //allocate unmanaged memory equivelent to the size of the object
            Marshal.StructureToPtr(myObject, ip, false); //marshal the object into the allocated memory
            byte[] byteArray = new byte[size];
            Marshal.Copy(ip, byteArray, 0, size); //place the contents of memory into a byte[]
            Marshal.FreeHGlobal(ip); //free unmanaged memory
            return byteArray;
        }

        private Messages.MESSAGE DeSerialize(byte[] received)
        {
            IntPtr ip = Marshal.AllocHGlobal(received.Length); //allocate unmanaged memory
            Marshal.Copy(received, 0, ip, received.Length); //copy the byte[] to the unmanaged memory
            Messages.MESSAGE structure = (Messages.MESSAGE)Marshal.PtrToStructure(ip, typeof(Messages.MESSAGE)); //Marshal the unmanaged memory contents to the Message_PDU structure
            Marshal.FreeHGlobal(ip); //free unmanaged memory
            return structure;
        }
        #endregion RICHARDS METHODS

      
    }
}
