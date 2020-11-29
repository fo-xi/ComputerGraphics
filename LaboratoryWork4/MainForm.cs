using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LaboratoryWork4
{
	public partial class MainForm : Form
	{
		public Pen pen = new Pen(Color.Black);

		public int step = 0;

		public int[,] kv = new int[4, 3];

		public int[,] figure = new int[4, 3];

		public int[,] matrSdv = new int[3, 3];

		public int[,] osi = new int[4, 3];

		public int k;

		public int l;

		public bool f;

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
			List<string> colors = new List<string> { "Red", "Pink", "Blue", "Green" };
			ColorsComboBox.DataSource = colors;
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

		private void InitKvadrat()
		{
			kv[0, 0] = -50; kv[0, 1] = 0;   kv[0, 2] = 1;
			kv[1, 0] = 0;   kv[1, 1] = 50;  kv[1, 2] = 1;
			kv[2, 0] = 50;  kv[2, 1] = 0;   kv[2, 2] = 1;
			kv[3, 0] = 0;   kv[3, 1] = -50; kv[3, 2] = 1;
		}

		private void InitMatrPreob(int k1, int l1)
		{
			matrSdv[0, 0] = 1;  matrSdv[0, 1] = 0;  matrSdv[0, 2] = 0;
			matrSdv[1, 0] = 0;  matrSdv[1, 1] = 1;  matrSdv[1, 2] = 0;
			matrSdv[2, 0] = k1; matrSdv[2, 1] = l1; matrSdv[2, 2] = 1;
		}

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
			k = PictureBox.Width / 2;
			l = PictureBox.Height / 2;

			DrawKvadrat();
		}

        private void InitOsi()
		{
			osi[0, 0] = -200; osi[0, 1] = 0;    osi[0, 2] = 1;
			osi[1, 0] = 200;  osi[1, 1] = 0;    osi[1, 2] = 1;
			osi[2, 0] = 0;    osi[2, 1] = 200;  osi[2, 2] = 1;
			osi[3, 0] = 0;    osi[3, 1] = -200; osi[3, 2] = 1;
		}

        private void DrawAxisButton_Click(object sender, EventArgs e)
        {
			k = PictureBox.Width / 2;
			l = PictureBox.Height / 2;
			DrawOsi();
		}

        private void StartButton_Click(object sender, EventArgs e)
        {
			timer1.Interval = 100;

			StartButton.Text = "Стоп";
			if (f == true)
				timer1.Start();
			else
			{
				timer1.Stop();
				StartButton.Text = "Старт";
			}
			f = !f;
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			k++;
			DrawKvadrat();
			Thread.Sleep(100);
		}

        private int[,] MultiplyMatr(int[,] a, int[,] b)
		{
			int n = a.GetLength(0);
			int m = a.GetLength(1);

			int[,] r = new int[n, m];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					r[i, j] = 0;

					for (int ii = 0; ii < m; ii++)
					{
						r[i, j] += a[i, ii] * b[ii, j];
					}
				}
			}
			return r;
		}

		private void DrawKvadrat()
		{
			InitKvadrat(); 
			InitMatrPreob(k, l); 
			int[,] kv1 = MultiplyMatr(kv, matrSdv); 

			Graphics g = Graphics.FromHwnd(PictureBox.Handle);
			g.DrawLine(pen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
			g.DrawLine(pen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
			g.DrawLine(pen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
			g.DrawLine(pen, kv1[3, 0], kv1[3, 1], kv1[0, 0], kv1[0, 1]);
			g.Dispose();
			pen.Dispose();
		}

		private void DrawOsi()
		{
			InitOsi();
			InitMatrPreob(k, l);
			int[,] osi1 = MultiplyMatr(osi, matrSdv);
			Graphics g = Graphics.FromHwnd(PictureBox.Handle);

			g.DrawLine(pen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);
			g.DrawLine(pen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);
			g.Dispose();
			pen.Dispose();
		}

        private void OXRightButton_Click(object sender, EventArgs e)
        {
			k += 5;
			DrawKvadrat();
		}

        private void OXLeftButton_Click(object sender, EventArgs e)
        {
			k -= 5;
			DrawKvadrat();
		}

        private void OYDownButton_Click(object sender, EventArgs e)
        {
			l += 5;
			DrawKvadrat();
		}

        private void OYUpButton_Click(object sender, EventArgs e)
        {
			l -= 5;
			DrawKvadrat();
		}

        private void ClearButton_Click(object sender, EventArgs e)
        {
			PictureBox.Image = null;
		}
    }
}
