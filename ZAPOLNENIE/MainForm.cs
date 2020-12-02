using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

		Point[] rectangle = new Point[]
		{
			new Point(100, 100),//0
			new Point(300, 100),//1
			new Point(300, 200),//2
			new Point(100, 200),//3
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
            PictureBox.Image = bitmap;
			lines = new List<List<Point>>();
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
			lines.Add(new List<Point>
            {
				new Point(xn, yn),
                new Point(xk, yk),
			});

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

		private void BypassButton_Click(object sender, EventArgs e)
		{
			BypassingPolygon();
		}

		private void SceneButton_Click(object sender, EventArgs e)
		{
			CDA(pointsFigure2[0].X, pointsFigure2[0].Y, pointsFigure2[1].X, pointsFigure2[1].Y);
			CDA(pointsFigure2[2].X, pointsFigure2[2].Y, pointsFigure2[3].X, pointsFigure2[3].Y);
			CDA(pointsFigure2[3].X, pointsFigure2[3].Y, pointsFigure2[4].X, pointsFigure2[4].Y);
			CDA(pointsFigure2[4].X, pointsFigure2[4].Y, pointsFigure2[5].X, pointsFigure2[5].Y);
			CDA(pointsFigure2[5].X, pointsFigure2[5].Y, pointsFigure2[2].X, pointsFigure2[2].Y);
			CDA(pointsFigure2[6].X, pointsFigure2[6].Y, pointsFigure2[7].X, pointsFigure2[7].Y);
			CDA(pointsFigure2[7].X, pointsFigure2[7].Y, pointsFigure2[8].X, pointsFigure2[8].Y);
			CDA(pointsFigure2[8].X, pointsFigure2[8].Y, pointsFigure2[9].X, pointsFigure2[9].Y);
			CDA(pointsFigure2[9].X, pointsFigure2[9].Y, pointsFigure2[6].X, pointsFigure2[6].Y);
			CDA(pointsFigure2[10].X, pointsFigure2[10].Y, pointsFigure2[11].X, pointsFigure2[11].Y);
			CDA(pointsFigure2[11].X, pointsFigure2[11].Y, pointsFigure2[12].X, pointsFigure2[12].Y);
			CDA(pointsFigure2[12].X, pointsFigure2[12].Y, pointsFigure2[10].X, pointsFigure2[10].Y);

			PictureBox.Image = bitmap;
		}

		private void RectangleButton_Click(object sender, EventArgs e)
		{
			Rectangle();
		}

		private void Rectangle()
		{
			Graphics g = Graphics.FromHwnd(PictureBox.Handle);
			Pen pen = new Pen(colorFill);
			CDA(rectangle[0].X, rectangle[0].Y, rectangle[1].X, rectangle[1].Y);
			CDA(rectangle[1].X, rectangle[1].Y, rectangle[2].X, rectangle[2].Y);
			CDA(rectangle[2].X, rectangle[2].Y, rectangle[3].X, rectangle[3].Y);
			CDA(rectangle[3].X, rectangle[3].Y, rectangle[0].X, rectangle[0].Y);

			PictureBox.Image = bitmap;
		}

		private void Zaliv(int x1, int y1)
		{
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

						xlist.Add(x);

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
					g.DrawLine(pen, new Point(xlist[j], i), new Point(xlist[j + 1], i));
				}
			}
		}

		private void BypassingPolygon()
		{
			var neighborhoodPoints = new Stack<Point>();
			var point = new Point(-100, -100);
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					Color currentColor = bitmap.GetPixel(x, y);
					if (currentColor.ToArgb() == oldColorLine.ToArgb())
					{
						point = new Point(x, y);
						neighborhoodPoints.Push(point);
						break;
					}
				}

				if (point.X != -100 && point.Y != -100)
				{
					break;
				}
			}

			while (neighborhoodPoints.Count != 0)
			{
				//текущая проверяемая точка
				Point currentPixel = neighborhoodPoints.Pop();
				while (true)
				{
					//список точек окрестности
					List<Point> listPoints = new List<Point>();
					for (int y = currentPixel.Y - 1; y <= currentPixel.Y + 1; y++)
					{
						for (int x = currentPixel.X - 1; x <= currentPixel.X + 1; x++)
						{
							if (currentPixel.X == x && currentPixel.Y == y)
							{
								continue;
							}
							Color currentPixelColor = bitmap.GetPixel(x, y);
							if (currentPixelColor.ToArgb() == oldColorLine.ToArgb())
							{
								listPoints.Add(new Point(x, y));
							}
						}
					}
					if (listPoints.Count > 1)
					{
						foreach (var points in listPoints)
						{
							neighborhoodPoints.Push(points);
						}
					}
					if (listPoints.Count == 0)
					{
						break;
					}
					bitmap.SetPixel(currentPixel.X, currentPixel.Y, colorLine);
					PictureBox.Image = bitmap;

					currentPixel = listPoints[0];
				}
			}
		}

		private  List<List<Point>> lines = new List<List<Point>>();

        private void ClippingButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < lines.Count; index++)
            {
                var line = lines[index];
                try
                {
                    Clipping(line);
                    PictureBox.Image = bitmap;
                }
                catch
                {
                    lines.Remove(line);
                    index = -1;
                }
            }

            PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);

            Rectangle();

            Graphics g = Graphics.FromHwnd(PictureBox.Handle);


			foreach (var line in lines)
            {
                CDA(line[0].X, line[0].Y, line[1].X, line[1].Y);
            }

            PictureBox.Image = bitmap;
        }

        private void Clipping(List<Point> line)
		{
			//если точки находятся вне окна
			if (line[0].X < rectangle[0].X || line[0].X > rectangle[1].X)
			{
				GOTO1(line, 0);
			}

            if (line[0].Y < rectangle[0].Y || line[0].Y > rectangle[2].Y)
            {
                GOTO1(line, 0);
            }

			if (line[1].X < rectangle[0].X || line[1].X > rectangle[1].X)
			{
				GOTO1(line, 1);
			}

			if (line[1].Y < rectangle[0].Y || line[1].Y > rectangle[2].Y)
			{
				GOTO1(line, 1);
			}
        }

		//проверка отрезка на видимость
        private void GOTO1(List<Point> line, int index)
		{
			if (line[0].X < rectangle[0].X && line[1].X < rectangle[0].X)
			{
                throw new Exception();
			}

			if (line[0].X > rectangle[1].X && line[1].X > rectangle[1].X)
			{
                throw new Exception();
			}

			if (line[0].Y > rectangle[2].Y && line[1].Y > rectangle[2].Y)
			{
                throw new Exception();
			}

			if (line[0].Y < rectangle[0].Y && line[1].Y < rectangle[0].Y)
			{
                throw new Exception();
			}

            //первая или вторая точка
            line[index] = (GOTO4(line[index].X, line[index].Y, Incline(line[0].X, line[0].Y, line[1].X, line[1].Y)));
		}

        private double Incline(double x1, double y1, double x2, double y2)
        {
			return (y1 - y2) / (x1 - x2);
		}

        private Point GOTO4(double x, double y, double m)
		{
            if (x < rectangle[0].X)
			{
                double tempY1 = y;
                x = rectangle[0].X;
				y = m * (rectangle[0].X - x) + tempY1;
			}
			if (x > rectangle[1].X)
			{
                double tempY1 = y;
                x = rectangle[1].X;
				y = m * (rectangle[1].X - x) + tempY1;
			}
			if (y > rectangle[2].Y && m != 0)
			{
                double tempX1 = x;
                y = rectangle[2].Y;
				x = tempX1 + (1 / m) * (rectangle[2].Y - y);
			}
			if (y < rectangle[0].Y && m != 0)
			{
                double tempX1 = x;
                y = rectangle[0].Y;
                x = tempX1 + (1 / m) * (rectangle[0].Y - y);
			}
			return new Point((int)x, (int)y);
		}
	}
}

