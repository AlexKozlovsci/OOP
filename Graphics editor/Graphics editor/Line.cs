using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public class Line : Square
    {
        public override void Draw(Graphics element)
        {
            this.shapeCorner = 2;
            
            Pen pen = new Pen(base.currColor, 2);
            element.DrawLine(pen, base.points[0].X, base.points[0].Y, base.points[1].X, base.points[1].Y);
            pen.Dispose();
        }
    }
}
