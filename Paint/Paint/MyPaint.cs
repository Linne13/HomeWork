using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public class MyPaint
    {

         public enum Shape
         {
            LINE,
            RECTANGLE,
            ELLIPSE,
            FREE,
            FILL
        };

        Pen pen = new Pen(Color.Black);
        Brush brush = new SolidBrush(Color.Black);
        public Point prevPoint = new Point(0, 0);
        public bool mouseClicked = false;
        public Shape sh = Shape.LINE;


        public void setPenColor(Color color)
        {
            pen.Color = color;
        }

        public void Draw(Graphics g, Point curPoint)
        {
            if (mouseClicked)
            {
                if (sh == Shape.LINE)
                {
                    g.DrawLine(pen, prevPoint, curPoint);
                    prevPoint = curPoint;
                }
                if (sh == Shape.RECTANGLE)
                {
                   g.DrawRectangle(pen, prevPoint, curPoint, )
                }
            }
        }


    }
}
