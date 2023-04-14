﻿////원격제어이벤트 전송 클래스
//using System;
//using System.Data.Common;
//using System.Net;
//using System.Net.Sockets;
//using System.Security.Principal;
//using System.Windows.Forms;

//namespace Image_Capture_Transmission_Class
//{
//    public enum MsgType
//    {
//        MT_KDOWN = 1, MT_KEYUP, MT_M_LEFTDOWN,
//        MT_M_LEFTUP, MT_M_RIGHTDOWN, MT_M_RIGHTUP,
//        MT_M_MIDDLEDOWN, MT_M_MIDDLEUP, MT_M_MOVE
//    }
//    public class SendEventClient
//    {
//        IPEndPoint ep;
//        public SendEventClient(string ip, int port)
//        {
//            ep = new IPEndPoint(IPAddress.Parse(ip), port);
//        }
//        public void SendKeyDown(int key)
//        {
//            byte[] data = new byte[9];
//            data[0] = (byte)MsgType.MT_KDOWN;
//            Array.Copy(BitConverter.GetBytes(key), 0, data, 1, 4); //1~4에 키보드 누른 값이 들어가게 됨.
//            SendData(data);
//        }

//        private void SendData(byte[] data)
//        {
//            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            sock.Connect(ep);
//            sock.Send(data);
//            sock.Close();
//        }

//        public void SendKeyup(int key)
//        {
//            byte[] data = new byte[9];
//            data[0] = (byte)MsgType.MT_KEYUP;
//            Array.Copy(BitConverter.GetBytes(key), 0, data, 1, 4);
//            SendData(data);
//        }

//        public void SendMouseDown(MouseButtons mousebuttons)
//        {
//            byte[] data = new byte[9];
//            switch(mousebuttons)
//            {
//                case MouseButtons.Left:
//                    data[0] = (byte)MsgType.MT_M_LEFTDOWN; break;

//                case MouseButtons.Right:
//                    data[0] = (byte)MsgType.MT_M_RIGHTDOWN; break;

//                case MouseButtons.Middle:
//                    data[0] = (byte)MsgType.MT_M_MIDDLEDOWN; break;
//            }
//            SendData(data);
//        }

//        public void SendMouseUp(MouseButtons mousebuttons)
//        {
//            byte[] data = new byte[9];
//            switch (mousebuttons)
//            {
//                case MouseButtons.Left:
//                    data[0] = (byte)MsgType.MT_M_LEFTUP; break;

//                case MouseButtons.Right:
//                    data[0] = (byte)MsgType.MT_M_RIGHTUP; break;

//                case MouseButtons.Middle:
//                    data[0] = (byte)MsgType.MT_M_MIDDLEUP; break;
//            }
//            SendData(data);
//        }
//        public void SendMouseMove(int x, int y)
//        {
//            byte[] data = new byte[9];

//            data[0] = (byte)MsgType.MT_M_MOVE;
//            Array.Copy(BitConverter.GetBytes(x), 0, data, 1,4);
//            Array.Copy(BitConverter.GetBytes(y), 0, data, 1,4);

//            SendData(data);
//        }
//    }
//}
