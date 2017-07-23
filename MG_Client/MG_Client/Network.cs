using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MG_Client
{
   public class Network
    {
        private static Network network;
        public static int _ConnPort;
        public static string _IP; 
        private int connectionPort;
        public static Socket tcp_Socket;
        private IPEndPoint localEndPoint;
        private IPEndPoint serverEndPoint;
        private IPAddress serverIPAddress;

        public Network(int connectionPort)
        {
            this.connectionPort = connectionPort;
            this.serverIPAddress = IPAddress.Parse("192.168.56.1");
            this.serverEndPoint = new IPEndPoint(serverIPAddress, connectionPort);
            this.localEndPoint = new IPEndPoint(IPAddress.Any, connectionPort);

            try
            {
                tcp_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcp_Socket.Blocking = true;
            }
            catch (Exception)
            {
                closeConnection();
            }
        }

        private Network(int connectionPort, string serverIP)
        {
            this.connectionPort = connectionPort;
            this.serverIPAddress = IPAddress.Parse(serverIP);
            this.serverEndPoint = new IPEndPoint(serverIPAddress, connectionPort);
            this.localEndPoint = new IPEndPoint(IPAddress.Any, connectionPort);

            try
            {
                tcp_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcp_Socket.Blocking = true;
            }
            catch (Exception)
            {
                closeConnection();
            }
        }



        public static Network getNetwork()
        {
            if (_ConnPort != 0 & _IP != null)
            {
                if (network == null)
                {
                    network = new Network(_ConnPort, _IP);
                }

                return network;
            }
            else
            {
                return null;
            }
        }



        public void sendMessage(Messages.MESSAGE msg)
        {
            byte[] byteData = Serialize(msg);
            tcp_Socket.Send(byteData, SocketFlags.None);
        }
        public Messages.MESSAGE receiveMessage()
        {
            Messages.MESSAGE msg = new Messages.MESSAGE();

            try
            {
                byte[] recBuffer = new byte[1024];                      //Initialise Buffer for recived messages 
                int recByteCount;
                recByteCount = tcp_Socket.Receive(recBuffer, SocketFlags.None);
                byte[] data = new byte[recByteCount];
                Array.Copy(recBuffer, data, recByteCount);
                
                if (recByteCount > 0)
                {
                    return msg = DeSerialize(data);
                }
                else
                {
                    msg.msgID = 0;
                }
            }
            catch (SocketException se) // Handle socket-related exception
            {   // If an exception occurs, display an error message
                if (10053 == se.ErrorCode || 10054 == se.ErrorCode) // Remote end closed the connection
                {
                    closeConnection();
                }
                else if (10035 != se.ErrorCode)
                {   // Ignore error messages relating to normal behaviour of non-blocking sockets
                    Console.Write(se.Message);
                }
            }
            catch // Silently handle any other exception
            {
                Console.WriteLine("Server Lost");
            }

            return msg;


        }
        public void connectToServer()
        {
            try
            {
                tcp_Socket.Connect(serverEndPoint);
                tcp_Socket.Blocking = false;
                Console.WriteLine("Connected");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to connect");
            }
        }
        private void closeConnection()
        {
            try
            {
                tcp_Socket.Shutdown(SocketShutdown.Both);
            }
            catch // Silently handle any exceptions
            {
            }
            try
            {
                tcp_Socket.Close();
            }
            catch // Silently handle any exceptions
            {
            }
        }

        //Richard's method 
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
        public Messages.MESSAGE DeSerialize(byte[] received)
        {
            IntPtr ip = Marshal.AllocHGlobal(received.Length); //allocate unmanaged memory
            Marshal.Copy(received, 0, ip, received.Length); //copy the byte[] to the unmanaged memory
            Messages.MESSAGE structure = (Messages.MESSAGE)Marshal.PtrToStructure(ip, typeof(Messages.MESSAGE)); //Marshal the unmanaged memory contents to the Message_PDU structure
            Marshal.FreeHGlobal(ip); //free unmanaged memory
            return structure;
        }

    }
}
