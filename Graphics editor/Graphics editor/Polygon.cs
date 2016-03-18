using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public class Polygon : Triangle
    {

        public override void Draw(Graphics element)
        {
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 20);
            Point point3 = new Point(150, 50);
            Point point4 = new Point(130, 100);
            Point point5 = new Point(70, 100);
            Point[] curvePoints = 
            {
                point1, point2, point3, point4, point5
            };

            Pen pen = new Pen(Color.Green, 2);
            element.DrawPolygon(pen, curvePoints);
            pen.Dispose();
        }
    }
}
