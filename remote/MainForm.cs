using RCEventArgsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupServer.Start("127.0.0.1", 10200);
            SetupServer.RecvedRCInfoEventHandler += SetupServer_RecvedRCInfoEventHandler;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            string ip = tbox_ip.Text;
            SetupClient.ConnectedEventHandler += SetupClient_ConnectedEventHandler;
            SetupClient.ConnectFailEventHandler += SetupClient_ConnectFailedEventHandler;
            SetupClient.SetUp(ip, 10200);
        }

        private void SetupClient_ConnectFailedEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("연결 요청이 실패하였습니다.");

        }

        private void SetupClient_ConnectedEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("연결 요청에 대한 처리를 완료하였습니다.");
        }

        private void SetupServer_RecvedRCInfoEventHandler(object sender, RCEventArgsLib.RecvRCInfoEventArgs e)
        {
            tbox_controller_ip.Text = e.IPAddressStr;
            MessageBox.Show(e.IPAddressStr);

        }
    }
}
