using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;


namespace Graphics_editor

    
{
    public partial class Editor : Form
    {
        private int pushCount;
        private List<PreSave> paintedShapes = new List<PreSave>();
        private Shape shape;
        private Color currColor = Color.Black;

        public Editor()
        {
            InitializeComponent();
        }

        private Shape fabricShapes(string shape)
        {
            Type shapeType = Type.GetType("Graphics_editor." + shape, false, true);
            return (Shape)Activator.CreateInstance(shapeType);
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void colorBox_MouseClick(object sender, MouseEventArgs e)
        {
            currColor = ((Bitmap)colorBox.Image).GetPixel(e.X, e.Y);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shape = fabricShapes("Circle");
            pushCount = 2;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            shape = fabricShapes("Triangle");
            pushCount = 3;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            shape = fabricShapes("Square");
            pushCount = 2;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            shape = fabricShapes("Polygon");
            pushCount = 5;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shape = fabricShapes("Ellipse");
            pushCount = 2;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            shape = fabricShapes("Rectangle");
            pushCount = 2;
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (shape == null)
            {
                MessageBox.Show(this, "Выберите тип фигуры!", "Предупреждение", MessageBoxButtons.OK);
                return;
            }
            Point point = new Point();
            point.X = e.X;
            point.Y = e.Y;
            shape.points.Add(point);
            
            pushCount--;
            if (pushCount == 0)
            {
                using (Graphics element = this.DrawPanel.CreateGraphics())
                {
                    shape.currColor = currColor;
                    shape.Draw(element);
                    pushCount = shape.shapeCorner;
                }

                paintedShapes.Add(new PreSave
                {
                    shape = shape.ToString(),
                    currColor = shape.currColor,
                    shapeCorner = shape.shapeCorner,
                    points = shape.points.GetRange(0, shape.shapeCorner)
                });
                shape.points.Clear();                            
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shape = fabricShapes("Line");
            pushCount = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(paintedShapes);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "json| *.json";
            saveFileDialog.Title = "Save your File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                    File.WriteAllText(saveFileDialog.FileName, json);   
            }

        }

        
    }
}
