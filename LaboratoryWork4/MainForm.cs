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

        public Bitmap bitmap;

		public int step = 0;

		public int[,] figure = new int[6, 3];

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
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
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

		private void InitFigure()
		{
			figure[0, 0] = -59;   figure[0, 1] = -32;   figure[0, 2] = 1;
			figure[1, 0] = 61;    figure[1, 1] = 16;    figure[1, 2] = 1;
			figure[2, 0] = 181;   figure[2, 1] = -32;   figure[2, 2] = 1;
			figure[3, 0] = 181;   figure[3, 1] = 184;   figure[3, 2] = 1;
            figure[4, 0] = 61;    figure[4, 1] = 136;   figure[4, 2] = 1;
            figure[5, 0] = -59;   figure[5, 1] = 184;   figure[5, 2] = 1;
		}

		private void InitMatrPreob(int k1, int l1)
		{
			matrSdv[0, 0] = 1;  matrSdv[0, 1] = 0;  matrSdv[0, 2] = 0;
			matrSdv[1, 0] = 0;  matrSdv[1, 1] = 1;  matrSdv[1, 2] = 0;
			matrSdv[2, 0] = k1; matrSdv[2, 1] = l1; matrSdv[2, 2] = 1;
		}

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
			k = PictureBox.Width / 2 - 60;
			l = PictureBox.Height / 2 - 70;

			DrawFigure();
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
			if (OXRightRadioButton.Checked)
            {
                k++;
                RemovingOldFigure();
			}

            if (OXLeftRadioButton.Checked)
            {
                k--;
                RemovingOldFigure();
			}

            if (OYDownRadioButton.Checked)
            {
                l++;
                RemovingOldFigure();
			}

            if (OYUpRadioButton.Checked)
            {
                l--;
                RemovingOldFigure();
			}
            RemovingOldFigure();
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

        private void DrawFigure()
        {
            InitFigure();
            InitMatrPreob(k, l);
            int[,] kv1 = MultiplyMatr(figure, matrSdv);

			Graphics g = Graphics.FromImage(bitmap);

			g.DrawLine(pen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            g.DrawLine(pen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            g.DrawLine(pen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            g.DrawLine(pen, kv1[3, 0], kv1[3, 1], kv1[4, 0], kv1[4, 1]);
            g.DrawLine(pen, kv1[4, 0], kv1[4, 1], kv1[5, 0], kv1[5, 1]);
            g.DrawLine(pen, kv1[5, 0], kv1[5, 1], kv1[0, 0], kv1[0, 1]);
			g.Dispose();

            PictureBox.Image = bitmap;
        }

        private void DrawOsi()
		{
			InitOsi();
			InitMatrPreob(PictureBox.Width / 2, PictureBox.Height / 2);
			int[,] osi1 = MultiplyMatr(osi, matrSdv);
			Graphics g = Graphics.FromImage(bitmap);

			g.DrawLine(pen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);
			g.DrawLine(pen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);
            g.Dispose();

            PictureBox.Image = bitmap;
		}

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.Image = bitmap;
		}

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            if (OXRightRadioButton.Checked)
            {
                k += 5;
                RemovingOldFigure();

            }

            if (OXLeftRadioButton.Checked)
            {
                k -= 5;
                RemovingOldFigure();

            }

            if (OYDownRadioButton.Checked)
            {
                l += 5;
                RemovingOldFigure();
			}

            if (OYUpRadioButton.Checked)
            {
                l -= 5;
                RemovingOldFigure();
			}

			RemovingOldFigure();
		}

        private void RemovingOldFigure()
        {
			PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.Image = bitmap;
			DrawOsi();
            DrawFigure();
            PictureBox.Image = bitmap;
		}
    }
}
