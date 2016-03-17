using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    class Triangle : Shape
    {
        public override void Draw(Graphics element)
        {
            Point point1 = new Point(300, 70);
            Point point2 = new Point(350, 20);
            Point point3 = new Point(400, 70);

            Point[] curvePoints = 
            {
                point1, point2, point3
            };

            Pen pen = new Pen(Color.Tomato, 2);
            element.DrawPolygon(pen, curvePoints);
            pen.Dispose();
        }

    }
}
