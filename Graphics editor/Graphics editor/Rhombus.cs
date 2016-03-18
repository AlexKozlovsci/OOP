using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public class Rhombus : Square
    {
        public override void Draw(Graphics element)
        {
            Point point1 = new Point(500, 80);
            Point point2 = new Point(550, 10);
            Point point3 = new Point(600, 80);
            Point point4 = new Point(550, 150);

            Point[] curvePoints = 
            {
                point1, point2, point3, point4
            };

            Pen pen = new Pen(Color.SteelBlue, 2);
            element.DrawPolygon(pen, curvePoints);
            pen.Dispose();
        }
    }
}
