namespace Graphics_editor
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnRhombus = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(2, 89);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(946, 452);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnTriangle.Location = new System.Drawing.Point(137, 21);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(95, 26);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Text = "Треугольник";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCircle.Location = new System.Drawing.Point(36, 21);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(95, 26);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSquare.Location = new System.Drawing.Point(238, 21);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(95, 26);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Квадрат";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnPolygon.Location = new System.Drawing.Point(339, 21);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(95, 26);
            this.btnPolygon.TabIndex = 4;
            this.btnPolygon.Text = "Многоугольник";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEllipse.Location = new System.Drawing.Point(440, 21);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(95, 26);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRectangle.Location = new System.Drawing.Point(541, 21);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(95, 26);
            this.btnRectangle.TabIndex = 6;
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnRhombus
            // 
            this.btnRhombus.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRhombus.Location = new System.Drawing.Point(642, 21);
            this.btnRhombus.Name = "btnRhombus";
            this.btnRhombus.Size = new System.Drawing.Size(95, 26);
            this.btnRhombus.TabIndex = 7;
            this.btnRhombus.Text = "Линия";
            this.btnRhombus.UseVisualStyleBackColor = false;
            this.btnRhombus.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // colorBox
            // 
            this.colorBox.Image = global::Graphics_editor.Properties.Resources.colors;
            this.colorBox.Location = new System.Drawing.Point(784, -1);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(149, 91);
            this.colorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorBox.TabIndex = 8;
            this.colorBox.TabStop = false;
            this.colorBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(596, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(677, 58);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 543);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.btnRhombus);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Editor";
            this.Text = "Graphics Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnRhombus;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

    }
}

