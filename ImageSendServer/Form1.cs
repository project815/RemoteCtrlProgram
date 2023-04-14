using ImgSendRecLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSendServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ImageServer ims;
        int imgcnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            ims = new ImageServer("127.0.0.1", 10200);
            ims.RecvedImage += Ims_RecvedImage;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                return;
            }
            int icnt = (int)listBox1.SelectedItem;
            pictureBox1.ImageLocation = string.Format("{0}.bmp", imgcnt);
        }

        private void Ims_RecvedImage(object sender, RecvImageEventArgs e)
        {
            imgcnt++;
            e.Image.Save(string.Format("{0}.bmp", imgcnt));
            listBox1.Items.Add(imgcnt);
        }

        
    }
}

 

