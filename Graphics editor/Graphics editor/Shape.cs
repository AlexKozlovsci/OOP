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

    class Square : Shape
    {
        public override void Draw(Graphics element)
        {
            Pen pen = new Pen(Color.Black, 2);
            element.DrawRectangle(pen, 250, 100, 100, 100);
            pen.Dispose();
        }


    }

    class Circle : Shape
    {
        public override void Draw(Graphics element)
        {
            Pen pen = new Pen(Color.Red, 2);
            element.DrawEllipse(pen, 100, 100, 100, 100);
            pen.Dispose();
        }

    }

    class Triangle : Shape
    {
        public override void Draw(Graphics element)
        {
            Point point1 = new Point(300, 70);
            Point point2 = new Point(350, 20);
            Point point3 = new Point(400, 70);

            Point[] curvePoints = 
            {
                point1, point2, point3
            };

            Pen pen = new Pen(Color.Tomato, 2);
            element.DrawPolygon(pen, curvePoints);
            pen.Dispose();
        }        

    }

    class Rectangle : Square
    {
        public override void Draw(Graphics element)
        {
            Pen pen = new Pen(Color.YellowGreen, 2);
            element.DrawRectangle(pen, 350, 250, 200, 100);
            pen.Dispose();
        }

    }

    class Rhombus : Square
    {
        public override void Draw(Graphics element)
        {
            Point point1 = new Point(500, 80);
            Point point2 = new Point(550, 10);
            Point point3 = new Point(600, 80);
            Point point4 = new Point(550, 150);

            Point[] curvePoints = 
            {
                point1, point2, point3, point4
            };

            Pen pen = new Pen(Color.SteelBlue, 2);
            element.DrawPolygon(pen, curvePoints);
            pen.Dispose();
        }
    }

    class Polygon : Triangle
    {

        public override void Draw(Graphics element)
        {
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100,20);
            Point point3 = new Point(150,50);
            Point point4 = new Point(130,100);
            Point point5 = new Point(70,100);
            Point[] curvePoints = 
            {
                point1, point2, point3, point4, point5
            };
            
            Pen pen = new Pen(Color.Green, 2);
            element.DrawPolygon(pen, curvePoints);
            pen.Dispose();
        }
    }

    class Ellipse : Circle
    {
        public override void Draw(Graphics element)
        {
            Pen pen = new Pen(Color.Yellow, 2);
            element.DrawEllipse(pen, 100, 200, 200, 100);
            pen.Dispose();
        }      

    }
}
