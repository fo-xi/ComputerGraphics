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
			WidthTextBox.Enabled = true;
			if (WidthTextBox.Text != "")
			{
				int width = Int32.Parse(WidthTextBox.Text);
				pen = new Pen(pen.Color, width);
			}
		}

		private void WidthTextBox_TextChanged(object sender, EventArgs e)
		{
			int width = Int32.Parse(WidthTextBox.Text);
			pen = new Pen(pen.Color, width);
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
			for (int i = 1; i <= n; i++)
			{
				Graphics g = Graphics.FromHwnd(PictureBox.Handle);
				g.DrawRectangle(pen, (int)xt, (int)yt, 2, 2);
				xt = xt + dx / n;
				yt = yt + dy / n;
			}
		}
	}
}
