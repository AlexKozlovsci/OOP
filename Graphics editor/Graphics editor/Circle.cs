using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public class Circle : Shape
    {
        public override void Draw(Graphics element)
        {

            this.shapeCorner = 2; 
            Pen pen = new Pen(base.currColor, 2);
            if (base.points[1].X < base.points[0].X)
            {
                if (base.points[1].Y < base.points[0].Y)
                {
                    element.DrawEllipse(pen, base.points[1].X, base.points[1].Y, base.points[0].X - base.points[1].X, base.points[0].X - base.points[1].X);
                }
                else
                {
                    element.DrawEllipse(pen, base.points[1].X, base.points[0].Y, base.points[0].X - base.points[1].X, base.points[0].X - base.points[1].X);
                }
            }
            else
            {
                if (base.points[1].Y < base.points[0].Y)
                {
                    element.DrawEllipse(pen, base.points[0].X, base.points[1].Y, base.points[1].X - base.points[0].X, base.points[1].X - base.points[0].X);
                }
                else
                {
                    element.DrawEllipse(pen, base.points[0].X, base.points[0].Y, base.points[1].X - base.points[0].X, base.points[1].X - base.points[0].X);
                }
                
            }
            pen.Dispose();
        }

    }
}
