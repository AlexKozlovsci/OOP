using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_editor
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            using (Graphics element = this.DrawPanel.CreateGraphics())
            {
                Shape[] figures = InitFigures();
                int i = 0;
                while(figures[i] != null)
                {
                    figures[i].Draw(element);
                    i++;
                }
            }
        }

        private Shape[] InitFigures()
        {
            Shape[] shapes = new Shape[20];
            int i = 0;
            Square square = new Square();
            shapes[i] = square;
            Circle circle = new Circle();
            shapes[++i] = circle;
            Polygon polygon = new Polygon();
            shapes[++i] = polygon;
            Ellipse ellipse = new Ellipse();
            shapes[++i] = ellipse;
            Rectangle rectangle = new Rectangle();
            shapes[++i] = rectangle;
            Triangle triangle = new Triangle();
            shapes[++i] = triangle;
            Rhombus rhombus = new Rhombus();
            shapes[++i] = rhombus;
            shapes[++i] = null;
            return shapes;
        }
    }
}
