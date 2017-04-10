using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        MyPaint mp = new MyPaint();

        Graphics g;
        Bitmap bmp;

        public void colorBtnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            mp.setPenColor(btn.BackColor);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mp.mouseClicked = false;
  
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mp.mouseClicked = true;
            mp.prevPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mp.mouseClicked)
            {
                mp.Draw(pictureBox1.CreateGraphics(), e.Location);
            }
        }

    }

}
