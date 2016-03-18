using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public class Ellipse : Circle
    {
        public override void Draw(Graphics element)
        {
            Pen pen = new Pen(Color.Yellow, 2);
            element.DrawEllipse(pen, 100, 200, 200, 100);
            pen.Dispose();
        }

    }
}
