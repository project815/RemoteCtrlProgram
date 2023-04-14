using ImgSendRecLib;
using KMESendRecvLib;
using Image_Capture_Transmission_Class;
//using remote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ImageSendServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ImageServer ims;
        //RecvEventServer res;
        int imgcnt = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            ims = new ImageServer(DefalutIP, 10200);
            ims.RecvedImage += Ims_RecvedImage;
            //res = new RecvEventServer(DefalutIP, 10200);
            //res.RecvedKMEvent += Res_RecvedKMEvent;
        }

        private void Res_RecvedKMEvent(object sender, RecvKMEEventArgs e)
        {
            string s = e.MT.ToString();
            switch (e.MT)
            {
                case MsgType.MT_KDOWN:
                case MsgType.MT_KEYUP:
                    s += " " + e.Key.ToString(); break;
                case MsgType.MT_M_MOVE:
                    s += " " + e.Now.X.ToString() + ", " + e.Now.Y.ToString(); break;

            }
            lbox_km.Items.Add(s);
            lbox_km.SelectedIndex = lbox_km.Items.Count - 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbox_fno.SelectedIndex == -1)
            {
                return;
            }
            int icnt = (int)lbox_fno.SelectedItem;
            pictureBox1.ImageLocation = string.Format("{0}.bmp", imgcnt);
        }

        private void Ims_RecvedImage(object sender, RecvImageEventArgs e)
        {
            imgcnt++;
            e.Image.Save(string.Format("{0}.bmp", imgcnt));
            lbox_fno.Items.Add(imgcnt);
        }


        static string DefalutIP
        {
            get
            {
                return "127.0.0.1";
                //호스트 이름 구하기
                string host_name = Dns.GetHostName();
                //호스트 엔트리 구하기
                IPHostEntry host_entry = Dns.GetHostEntry(host_name);
                //호스트 주소 목록 반복
                foreach(IPAddress ipaddr in host_entry.AddressList)
                {
                    //주소 체계가 InterNetWork일 때
                    if (ipaddr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        //IP주소 문자열 반환
                        return ipaddr.ToString();
                    }
                }
                //빈문자열 반환
                return string.Empty;
            }
        }
        
    }
}

 

