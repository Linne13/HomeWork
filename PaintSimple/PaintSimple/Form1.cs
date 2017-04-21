using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintSimple
{
    public partial class Form1 : Form
    {
        enum Shape
        {
            LINE,
            RECTANGLE,
            ELLIPSE
        };
        Shape shape = Shape.LINE;
        Bitmap bmp;
        Graphics g;
      
        bool mouseClicked = false;
        Point prevPoint = new Point(0, 0);
        Point currentPoint;
        
        Pen pen = new Pen(Color.Black);
        Graphics gPic;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            gPic = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

           
            mouseClicked = false;
            

            if(shape == Shape.LINE)
            {
                currentPoint = e.Location;
                pictureBox1.Image = bmp;

            }

            if (shape == Shape.ELLIPSE)
            {
                int w = Math.Abs(prevPoint.X - e.Location.X);
                int h = Math.Abs(prevPoint.Y - e.Location.Y);
                Refresh();
                g.DrawEllipse(pen, prevPoint.X, prevPoint.Y, w, h);
                pictureBox1.Image = bmp;

            }

            if (shape == Shape.RECTANGLE)
            {
                int w = Math.Abs(prevPoint.X - e.Location.X);
                int h = Math.Abs(prevPoint.Y - e.Location.Y);
                int minX = Math.Min(prevPoint.X, e.Location.X);
                int minY = Math.Min(prevPoint.Y, e.Location.Y);
                Refresh();
                g.DrawRectangle(pen, minX, minY, w, h);
                pictureBox1.Image = bmp;

            }


        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                pictureBox1.Image = bmp;

                if (shape == Shape.LINE)
                {
                    g.DrawLine(pen, prevPoint.X, prevPoint.Y, e.Location.X, e.Location.Y);
                    prevPoint = e.Location;
                }

                if (shape == Shape.RECTANGLE)
                {
                    int w = Math.Abs(prevPoint.X - e.Location.X);
                    int h = Math.Abs(prevPoint.Y - e.Location.Y);
                    int minX = Math.Min(prevPoint.X, e.Location.X);
                    int minY = Math.Min(prevPoint.Y, e.Location.Y);
                    pictureBox1.Refresh();

                    gPic.DrawRectangle(pen, minX, minY, w, h);

                }

                if (shape == Shape.ELLIPSE)
                {
                    int w = Math.Abs(prevPoint.X - e.Location.X);
                    int h = Math.Abs(prevPoint.Y - e.Location.Y);
                    Refresh();
                    gPic.DrawEllipse(pen, prevPoint.X, prevPoint.Y, w, h);
                   
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shape = Shape.LINE;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shape = Shape.RECTANGLE;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pen.Color = c.Color;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            shape = Shape.ELLIPSE;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }
    }
}
