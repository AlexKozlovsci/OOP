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
            this.shapeCorner = 5;
            int i = 0;
            Point[] shapePoints = new Point[5];
            foreach (Point onePoint in base.points)
            {
                shapePoints[i] = new Point(onePoint.X, onePoint.Y);
                i++;
            }

            Pen pen = new Pen(base.currColor, 2);
            element.DrawPolygon(pen, shapePoints);
            pen.Dispose();
        }
    }
}
