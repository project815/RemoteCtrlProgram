using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;

namespace remote
{
    public static class SetupClient
    {
        public static event EventHandler ConnectedEventHandler = null;
        public static event EventHandler ConnectFailEventHandler = null;
        static Socket sock;
        public static void SetUp(string ip, int port)
        {
            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);

            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            //sock.Connect(ep); //동기식으로 처리함
            sock.BeginConnect(ep, DoConnect, sock); //비동기식으로 처리해야 함.
        }

        static void DoConnect(IAsyncResult result)
        {
            AsyncResult ar = result as AsyncResult;
            try
            {
                sock.EndConnect(result);
                if (ConnectedEventHandler != null)
                {
                    ConnectedEventHandler(null, new EventArgs());
                }
            }
            catch
            {
                if(ConnectFailEventHandler !=null)
                {
                    ConnectFailEventHandler(null, new EventArgs());
                }
            }
            sock.Close();
        }
    }
}
