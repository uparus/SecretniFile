using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Form1 : Form
    {
        Point A, B, C;

        PointF currentPoint;

        bool startPointSet = false;

        bool triangleDrawn = false;

        Random rand = new Random();

        Graphics Graph;
        SolidBrush drawBrush;
        Pen trianglePen;
        Pen pointPen;
        Font MyFont;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            Graph = CreateGraphics();
            drawBrush = new SolidBrush(Color.Black);
            trianglePen = new Pen(Color.Black, 2);
            pointPen = new Pen(Color.Red, 1);
            MyFont = new Font("Arial", 12, FontStyle.Bold);

            GenerateNewTriangle(); 
        }

        private void GenerateNewTriangle()
        {
            Graph.Clear(BackColor);

            startPointSet = false;
            StartButton.Enabled = false;
            InfoLabel.Text = "";

            int margin = 80;

            float minArea = this.ClientSize.Width * this.ClientSize.Height * 0.10f;

            do
            {
                A = new Point(
                    rand.Next(margin, this.ClientSize.Width - margin),
                    rand.Next(margin, this.ClientSize.Height / 2));

                B = new Point(
                    rand.Next(margin, this.ClientSize.Width / 2),
                    rand.Next(this.ClientSize.Height / 2, this.ClientSize.Height - margin));

                C = new Point(
                    rand.Next(this.ClientSize.Width / 2, this.ClientSize.Width - margin),
                    rand.Next(this.ClientSize.Height / 2, this.ClientSize.Height - margin));
            }
            while (TriangleArea(A,B,C)< minArea);

            Graph.DrawLine(trianglePen, A, B);
            Graph.DrawLine(trianglePen, B, C);
            Graph.DrawLine(trianglePen, C, A);

            Graph.DrawString("A", MyFont, Brushes.Black, A.X - 20, A.Y - 20);
            Graph.DrawString("B", MyFont, Brushes.Black, B.X - 20, B.Y + 10);
            Graph.DrawString("C", MyFont, Brushes.Black, C.X + 10, C.Y + 10);

            triangleDrawn = true;
        }

        private float TriangleArea(Point a, Point b, Point c)
        {
            return Math.Abs(
                (a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y)) / 2.0f);
        }


        private bool IsPointInTriangle(Point p, Point a, Point b, Point c)
        {
            float totalArea = Math.Abs(
                (a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y)) / 2.0f);

            float area1 = Math.Abs(
                (p.X * (b.Y - c.Y) + b.X * (c.Y - p.Y) + c.X * (p.Y - b.Y)) / 2.0f);
            float area2 = Math.Abs(
                (a.X * (p.Y - c.Y) + p.X * (c.Y - a.Y) + c.X * (a.Y - p.Y)) / 2.0f);
            float area3 = Math.Abs(
                (a.X * (b.Y - p.Y) + b.X * (p.Y - a.Y) + p.X * (a.Y - b.Y)) / 2.0f);

            return Math.Abs(totalArea - (area1 + area2 + area3)) < 0.01f;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!triangleDrawn) return;

            if (startPointSet) return;

            Point pNew = new Point(e.X, e.Y);
            if (!IsPointInTriangle(pNew, A, B, C)) return; 

            currentPoint = new PointF(e.X, e.Y);
            startPointSet = true;

            Graph.FillEllipse(drawBrush, e.X - 3, e.Y - 3, 6, 6);

            StartButton.Enabled = true;

            InfoLabel.Text = "Точка задана";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!startPointSet)
            {
                MessageBox.Show(
                    "Сначала задайте стартовую точку кликом внутри треугольника!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int steps;
            if (!int.TryParse(StepsTextBox.Text, out steps) || steps <= 0)
            {
                MessageBox.Show(
                    "Введите корректное количество шагов (целое положительное число)!",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            PerformSteps(steps);

            InfoLabel.Text = "Шагов: " + steps;
        }

        private void PerformSteps(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                int vertexIndex = rand.Next(1, 4);  

                PointF targetVertex;
                if (vertexIndex == 1) targetVertex = new PointF(A.X, A.Y);
                else if (vertexIndex == 2) targetVertex = new PointF(B.X, B.Y);
                else targetVertex = new PointF(C.X, C.Y);

                currentPoint = new PointF(
                    (currentPoint.X + targetVertex.X) / 2,
                    (currentPoint.Y + targetVertex.Y) / 2);

                Graph.FillEllipse(drawBrush, currentPoint.X - 1, currentPoint.Y - 1, 3, 3);
            }
        }

        private void NewTriangleButton_Click(object sender, EventArgs e)
        {
            GenerateNewTriangle();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            drawBrush.Dispose();
            trianglePen.Dispose();
            pointPen.Dispose();
            MyFont.Dispose();
            Graph.Dispose();
        }
    }
}
