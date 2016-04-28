using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public class Rectangle : Square
    {
        public override void Draw(Graphics element)
        {
            this.shapeCorner = 2;
            Pen pen = new Pen(base.currColor, 2);
            if (base.points[1].X < base.points[0].X)
            {
                if (base.points[1].Y < base.points[0].Y)
                {
                    element.DrawRectangle(pen, base.points[1].X, base.points[1].Y, base.points[0].X - base.points[1].X, base.points[0].Y - base.points[1].Y);
                }
                else
                {
                    element.DrawRectangle(pen, base.points[1].X, base.points[0].Y, base.points[0].X - base.points[1].X, base.points[1].Y - base.points[0].Y);
                }
            }
            else
            {
                if (base.points[1].Y < base.points[0].Y)
                {
                    element.DrawRectangle(pen, base.points[0].X, base.points[1].Y, base.points[1].X - base.points[0].X, base.points[0].Y - base.points[1].Y);
                }
                else
                {
                    element.DrawRectangle(pen, base.points[0].X, base.points[0].Y, base.points[1].X - base.points[0].X, base.points[1].Y - base.points[0].Y);
                }
            }
            pen.Dispose();
        }

    }
}
