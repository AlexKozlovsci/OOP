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
            Pen pen = new Pen(Color.YellowGreen, 2);
            element.DrawRectangle(pen, 350, 250, 200, 100);
            pen.Dispose();
        }

    }
}
