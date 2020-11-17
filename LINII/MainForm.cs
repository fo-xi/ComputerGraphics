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

namespace LINII
{
	public partial class MainForm : Form
	{
		public int xn, yn, xk, yk;

		public Pen pen = new Pen(Color.Black);

		public int step = 0;

		private void ClearButton_Click(object sender, EventArgs e)
		{
			PictureBox.Image = null;
		}

		private void ColorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (ColorsComboBox.SelectedIndex)
			{
				case 0:
				{
					pen = new Pen(Color.DarkRed);
					break;
				}
				case 1:
				{
					pen = new Pen(Color.PaleVioletRed);
					break;
				}
				case 2:
				{
					pen = new Pen(Color.CornflowerBlue);
					break;
				}
				case 3:
				{
					pen = new Pen(Color.DarkGreen);
					break;
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<string> colors = new List<string>{"Red","Pink","Blue","Green"};
			ColorsComboBox.DataSource = colors;
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			xn = Int32.Parse(FirstXTextBox.Text);
			yn = Int32.Parse(FirstYTextBox.Text);

			xk = Int32.Parse(SecondXTextBox.Text);
			yk = Int32.Parse(SecondYTextBox.Text);

			DrawByCoordinates(xn, yn, xk, yk);
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void ThickLineRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				WidthTextBox.Enabled = true;
				if (WidthTextBox.Text != "")
				{
					int width = Int32.Parse(WidthTextBox.Text);
					pen = new Pen(pen.Color, width);
				}
			}
			catch (Exception exception)
			{
				// ignored
			}
		}

		private void WidthTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int width = Int32.Parse(WidthTextBox.Text);
				pen = new Pen(pen.Color, width);
			}
			catch (Exception exception)
			{
				// ignored
			}
		}

		private void ThinLineRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			WidthTextBox.Enabled = false;
			pen = new Pen(pen.Color, 2);
		}

		private void SolidLineRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			DottedLineStepTextBox.Enabled = false;
		}

		private void DottedLineRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				DottedLineStepTextBox.Enabled = true;
				if (DottedLineStepTextBox.Text != "")
				{
					step = Int32.Parse(DottedLineStepTextBox.Text);
				}
			}
			catch (Exception exception)
			{
				// ignored
			}
		}

		private void DottedLineStepTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				step = Int32.Parse(DottedLineStepTextBox.Text);
			}
			catch (Exception exception)
			{
				// ignored
			}
		}

		private void FisrtFigureButton_Click(object sender, EventArgs e)
		{
			Point[] points = new Point[]
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

			DrawByCoordinates(points[0].X, points[0].Y, points[1].X, points[1].Y);
			DrawByCoordinates(points[2].X, points[2].Y, points[3].X, points[3].Y);
			DrawByCoordinates(points[3].X, points[3].Y, points[4].X, points[4].Y);
			DrawByCoordinates(points[4].X, points[4].Y, points[5].X, points[5].Y);
			DrawByCoordinates(points[5].X, points[5].Y, points[2].X, points[2].Y);
			DrawByCoordinates(points[6].X, points[6].Y, points[7].X, points[7].Y);
			DrawByCoordinates(points[7].X, points[7].Y, points[8].X, points[8].Y);
			DrawByCoordinates(points[8].X, points[8].Y, points[9].X, points[9].Y);
			DrawByCoordinates(points[9].X, points[9].Y, points[6].X, points[6].Y);
			DrawByCoordinates(points[10].X, points[10].Y, points[11].X, points[11].Y);
			DrawByCoordinates(points[11].X, points[11].Y, points[12].X, points[12].Y);
			DrawByCoordinates(points[12].X, points[12].Y, points[10].X, points[10].Y);
		}

		private void SecondFigureButton_Click(object sender, EventArgs e)
		{
			Point[] points = new Point[]
			{
				new Point(61,76),//0
				new Point(181, 124),//1
				new Point(301, 76),//2
				new Point(301, 292),//3
				new Point(181, 244),//4
				new Point(61, 292),//5
			};

			DrawByCoordinates(points[0].X, points[0].Y, points[1].X, points[1].Y);
			DrawByCoordinates(points[1].X, points[1].Y, points[2].X, points[2].Y);
			DrawByCoordinates(points[2].X, points[2].Y, points[3].X, points[3].Y);
			DrawByCoordinates(points[3].X, points[3].Y, points[4].X, points[4].Y);
			DrawByCoordinates(points[4].X, points[4].Y, points[5].X, points[5].Y);
			DrawByCoordinates(points[5].X, points[5].Y, points[0].X, points[0].Y);
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (DDARadioButton.Checked == true)
			{
				xn = e.X;
				yn = e.Y;
			}
			else
			{
				MessageBox.Show("Вы не выбрали алгоритм вывода фигуры!");
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{

			xk = e.X;
			yk = e.Y;

			DrawByCoordinates(xn, yn, xk, yk);

		}

		private void DrawByCoordinates(int firstPointX, int firstPointY, int secondPointX, int secondPointY)
		{
			xk = secondPointX;
			yk = secondPointY;

			double dx = xk - firstPointX;
			double dy = yk - firstPointY;
			//количетсво точек между первый и конечной точкой отрезка
			int n = 1000;
			//координаты точек, которые находятся между начальной и конечной точкой
			double xt = firstPointX;
			double yt = firstPointY;
			int count = 0;
			bool isDrawing = true;
			for (int i = 1; i <= n; i++)
			{
				if (DottedLineRadioButton.Checked)
				{
					if(count == step)
					{
						count = 0;
						isDrawing = !isDrawing;
					}

					if (isDrawing)
					{
						Graphics g = Graphics.FromHwnd(PictureBox.Handle);
						g.DrawRectangle(pen, (int)xt, (int)yt, 2, 2);
					}
					count++;
				}
				else
				{
					Graphics g = Graphics.FromHwnd(PictureBox.Handle);
					g.DrawRectangle(pen, (int)xt, (int)yt, 2, 2);
				}
				xt = xt + dx / n;
				yt = yt + dy / n;
			}
		}
	}
}
