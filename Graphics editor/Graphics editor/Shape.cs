using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public abstract class Shape
    {
        public int StartPoint;
        public string Background;
        public string BorderColor;
        public abstract void Draw(Graphics element);
    }
}
