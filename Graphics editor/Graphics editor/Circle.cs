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
            Pen pen = new Pen(Color.Red, 2);
            element.DrawEllipse(pen, 100, 100, 100, 100);
            pen.Dispose();
        }

    }
}
