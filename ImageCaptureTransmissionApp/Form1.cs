using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgSendRecLib;
namespace ImageCaptureTransmissionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ip;
        ImageClient ic;

        private void button1_Click(object sender, EventArgs e)
        {
            ip = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ic == null)
            {
                return;
            }

            int left = trackBar1.Value;
            int right = trackBar3.Value;

            if(left > right)
            {
                int temp = left;
                left = right;
                right = temp;
            }

            int top = trackBar2.Value;
            int bottom = trackBar4.Value;
            if(top>bottom)
            {
                int temp = top;
                top = bottom;
                bottom = temp;
            }

            int width = right - left;
            int height = bottom - top;

            if (width == 0 || height == 0)
            {
                return;
            }

            Bitmap bitmap = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(bitmap);
            Size size = new Size(width, height);
            gr.CopyFromScreen( new Point(left, top), new Point(0, 0), size);

            ic.Connect(ip, 10200);
            ic.SendImage(bitmap);   
            ic.Close();
            pictureBox1.Image = bitmap;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ic = new ImageClient();

            trackBar1.Maximum = trackBar3.Maximum = Screen.PrimaryScreen.Bounds.Width;
            trackBar2.Maximum = trackBar4.Maximum = Screen.PrimaryScreen.Bounds.Height;
        
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
