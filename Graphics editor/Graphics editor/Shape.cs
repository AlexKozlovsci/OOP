﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_editor
{
    public abstract class Shape
    {
        public Color currColor;
        public int shapeCorner;
        public List<Point> points = new List<Point>();
        public abstract void Draw(Graphics element);
    }
}
