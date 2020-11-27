using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ZAPOLNENIE
{
	public partial class MainForm : Form
	{
		public int xn, yn, xk, yk;

        public Bitmap bitmap;

        public Color colorLine = Color.Black;

        public Color colorFill = Color.Gray;

        public Color oldColorLine;

        public Point[] pointsFigure1 = new Point[]
        {
            new Point(15, 20), //0
            new Point(45, 30), //1
            new Point(75, 20), //2
            new Point(75, 74), //3
            new Point(45, 60), //4
            new Point(15, 74), //5
        };

        Point[] pointsFigure2 = new Point[]
        {
            //отрезок
            new Point(50,170),//0
            new Point(120, 170),//1
            //квадрат
            new Point(85, 130),//2
            new Point(155, 130),//3
            new Point(155, 200),//4
            new Point(85, 200),//5
            //прямоугольник
            new Point(130, 130),//6
            new Point(230, 130),//7
            new Point(230,200),//8
            new Point(130, 200),//9
            //треугольник
            new Point(200,200),//10
            new Point(255, 130),//11
            new Point(310, 200),//12
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            DialogResult d = ColorLineDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                oldColorLine = colorLine;
                colorLine = ColorLineDialog.Color;
            }
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            DialogResult d = ColorFillDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                colorFill = ColorFillDialog.Color;

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (CDARadioButton.Checked || FillRadioButton.Checked)
            {
                xn = e.X;
                yn = e.Y;
            }
            else
            {
                MessageBox.Show("Вы не выбрали алгоритм вывода фигуры!");
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            xk = e.X;
            yk = e.Y;
            using (Graphics g = Graphics.FromHwnd(PictureBox.Handle))
            {
                if (CDARadioButton.Checked)
                {
                    CDA(xn, yn, xk, yk);
                }

                if (FillRadioButton.Checked)
                {
                    Zaliv(xk, yk);
                }
            }

            PictureBox.Image = bitmap;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
        }

        private void FigureButton_Click(object sender, EventArgs e)
        {
            LineColorButton.Enabled = false;
            FigureButton.Enabled = false;
            
            using (Graphics g = Graphics.FromHwnd(PictureBox.Handle))
            {
                if (CDARadioButton.Checked)
                {
                    CDA(pointsFigure1[0].X, pointsFigure1[0].Y, pointsFigure1[1].X, pointsFigure1[1].Y);
                    CDA(pointsFigure1[1].X, pointsFigure1[1].Y, pointsFigure1[2].X, pointsFigure1[2].Y);
                    CDA(pointsFigure1[2].X, pointsFigure1[2].Y, pointsFigure1[3].X, pointsFigure1[3].Y);
                    CDA(pointsFigure1[3].X, pointsFigure1[3].Y, pointsFigure1[4].X, pointsFigure1[4].Y);
                    CDA(pointsFigure1[4].X, pointsFigure1[4].Y, pointsFigure1[5].X, pointsFigure1[5].Y);
                    CDA(pointsFigure1[5].X, pointsFigure1[5].Y, pointsFigure1[0].X, pointsFigure1[0].Y);
                }

                PictureBox.Image = bitmap;
            }
            LineColorButton.Enabled = true;
            FigureButton.Enabled = true;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            PolygonAlgorithm();
        }

        private void CDA(int x1, int y1, int x2, int y2)
        {
            xn = x1;
            yn = y1;
            xk = x2;
            yk = y2;
            double dx = xk - xn;
            double dy = yk - yn;
            int n = 1000;
            double xt = xn;
            double yt = yn;
            for (int i = 1; i <= n; i++)
            {
                Pen myPen = new Pen(colorLine, 1);
                bitmap.SetPixel((int)xt, (int)yt, colorLine);
                xt = xt + dx / n;
                yt = yt + dy / n;
            }
        }

        private void Zaliv(int x1, int y1)
        {
            if (x1 >= PictureBox.Width || x1 < 0 || y1 >= PictureBox.Height || y1 < 0)
            {
                return;
            }

            Color oldColor = bitmap.GetPixel(x1, y1);

            if ((oldColor.ToArgb() != colorLine.ToArgb()) &&
                (oldColor.ToArgb() != colorFill.ToArgb()))
            {
                bitmap.SetPixel(x1, y1, colorFill);

                Zaliv(x1 + 1, y1);
                Zaliv(x1 - 1, y1);
                Zaliv(x1, y1 + 1);
                Zaliv(x1, y1 - 1);


            }
            else
            {
                return;
            }
        }

        private void PolygonAlgorithm()
        {
            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var point in pointsFigure1)
            {
                if (point.Y > max)
                {
                    max = point.Y;
                }

                if (point.Y < min)
                {
                    min = point.Y;
                }
            }

            
            for (int i = min; i <= max; i++)
            {
                var xlist = new List<int>();
                var x = 0;
                for (int k = 0; k < pointsFigure1.Length - 1; k++)
                {
                    //принадлежит ли точка отрезку
                    if (i > pointsFigure1[k].Y && i < pointsFigure1[k + 1].Y || i < pointsFigure1[k].Y && i > pointsFigure1[k + 1].Y)
                    {
                        x = pointsFigure1[k].X + (i - pointsFigure1[k].Y) * (pointsFigure1[k + 1].X - pointsFigure1[k].X) /
                            (pointsFigure1[k + 1].Y - pointsFigure1[k].Y);
                        if (x >= 0)
                        {
                            xlist.Add(x);
                        }
                    }
                }
                x = pointsFigure1[0].X + (i - pointsFigure1[0].Y) * (pointsFigure1[pointsFigure1.Length - 1].X - pointsFigure1[0].X) /
                    (pointsFigure1[pointsFigure1.Length - 1].Y - pointsFigure1[0].Y);
                xlist.Add(x);
                xlist.Sort();

                Graphics g = Graphics.FromHwnd(PictureBox.Handle);
                Pen pen = new Pen(colorFill);

                for (int j = 0; j < xlist.Count - 1; j += 2)
                {
                    g.DrawLine(pen, new Point(xlist[j] + 1, i), new Point(xlist[j + 1] - 1, i));
                }
            }
        }

        private void BypassingPolygon()
        {
            var point = new Point(-1, -1);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color oldColor = bitmap.GetPixel(x, y);
                    if (oldColor.ToArgb() == colorLine.ToArgb())
                    {
                        point = new Point(x, y);
                        break;
                    }
                }

                if (point.X != -1 && point.Y != -1)
                {
                    break;
                }
            }

            var neighborhoodPoints = new Stack<Point>();
            bool found = false;
            for (int y = point.Y - 1; y <= point.Y + 1; y++)
            {
                for (int x = point.X - 1; x <= point.X + 1; x++)
                {
                    Color currentPixelColor = bitmap.GetPixel(x, y);
                    if (currentPixelColor.ToArgb() == oldColorLine.ToArgb())
                    {
                        neighborhoodPoints.Push(new Point(x, y));
                        found = true;
                    }
                }
            }
            if (!found && neighborhoodPoints.Count == 0)
            {
                return;
            }
        }
    }
}
