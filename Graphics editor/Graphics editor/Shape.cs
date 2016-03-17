using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    class Shape
    {
        public int StartPoint;
        public string Background;
        public string BorderColor;

        public virtual void Draw(Graphics element)
        {
           
        }

    }
}
