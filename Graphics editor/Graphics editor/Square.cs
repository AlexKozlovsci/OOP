using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    class Square : Shape
    {
        public override void Draw(Graphics element)
        {
            Pen pen = new Pen(Color.Black, 2);
            element.DrawRectangle(pen, 250, 100, 100, 100);
            pen.Dispose();
        }


    }
}
