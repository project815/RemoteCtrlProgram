﻿using RCEventArgsLib;
using System;
using System.Net;
using System.Net.Sockets;

namespace remote
{
    public class SetupServer
    {
        static Socket lis_sock;
        static public event RecvRCInfoEventHandler RecvedRCInfoEventHandler = null;

        static string ip;
        static int port;

        public static void Start(string ip, int port)
        {
            SetupServer.ip = ip;
            SetupServer.port = port;

            SocketBooting();
        }

        private static void SocketBooting()
        {
            IPAddress ipaddr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(ipaddr, port);

            lis_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            lis_sock.Bind(ep);
            lis_sock.Listen(1); //동시에 연결요청 대기 큐, 한 명 요청보내고 수락하고 나면 또 가능함.

            lis_sock.BeginAccept(DoAccept, null);
        }

        static void DoAccept(IAsyncResult result)
        {
            if (lis_sock == null)
            {
                return;
            }

            try
            {
                Socket sock = lis_sock.EndAccept(result);
                DoIt(sock);

                lis_sock.BeginAccept(DoAccept, null);
            }
            catch
            {
                Close();
            }
        }

        static void DoIt(Socket dosock)
        {
            if(RecvedRCInfoEventHandler != null)
            {
                RecvRCInfoEventArgs e = new RecvRCInfoEventArgs(dosock.RemoteEndPoint);
                RecvedRCInfoEventHandler(null, e);
            }

            dosock.Close();
        }
        public static void Close()
        {
            if(lis_sock != null)
            {
                lis_sock.Close();
                lis_sock = null;
            }
        }
    }
}
