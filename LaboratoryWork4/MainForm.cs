using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace LaboratoryWork4
{
	public partial class MainForm : Form
	{
		public Pen pen = new Pen(Color.Black);

        public Bitmap bitmap;

		public float step = 0;

		public float[,] figure = new float[6, 3];

		public float[,] matrSdv = new float[3, 3];

		public float[,] osi = new float[4, 3];

        public float [,] otobr = new float[3, 3];

		public float [,] rotation = new float[3, 3];

		public float [,] scaling = new float[3, 3];

		public float k;

		public float l;

		public bool f;

        public float angle = 0;

        public float scale = 1;

        /// Велосипед
        
        public float [,] wheels = new float[3, 3];

        public float[,] housing = new float[7, 3];

        public float[,] pedal = new float[4, 3];

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
            StandardDisplay();
        }

		private void ThickLineRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				WidthTextBox.Enabled = true;
				if (WidthTextBox.Text != "")
				{
					float width = Int32.Parse(WidthTextBox.Text);
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
				float width = float.Parse(WidthTextBox.Text);
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
			pen = new Pen(pen.Color, 1);
		}

		private void SolidLineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Solid;
        }

		private void DottedLineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dash;
        }

        private void InitFigure()
		{
			figure[0, 0] = -60;   figure[0, 1] = 60;   figure[0, 2] = 1;
			figure[1, 0] = 0;    figure[1, 1] = 20;    figure[1, 2] = 1;
			figure[2, 0] = 60;   figure[2, 1] = 60;   figure[2, 2] = 1;
			figure[3, 0] = 60;   figure[3, 1] = -60;   figure[3, 2] = 1;
            figure[4, 0] = 0;    figure[4, 1] = -20;   figure[4, 2] = 1;
            figure[5, 0] = -60;   figure[5, 1] = -60;   figure[5, 2] = 1;
		}

		private void InitMatrSdv(float k1, float l1)
		{
			matrSdv[0, 0] = 1;  matrSdv[0, 1] = 0;  matrSdv[0, 2] = 0;
			matrSdv[1, 0] = 0;  matrSdv[1, 1] = 1;  matrSdv[1, 2] = 0;
			matrSdv[2, 0] = k1; matrSdv[2, 1] = l1; matrSdv[2, 2] = 1;
		}

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
			k = PictureBox.Width / 2;
			l = PictureBox.Height / 2;

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
                k += 5;
            }

            if (OXLeftRadioButton.Checked)
            {
                k -= 5;
            }

            if (OYDownRadioButton.Checked)
            {
                l += 5;
            }

            if (OYUpRadioButton.Checked)
            {
                l -= 5;
			}
            RemovingOldFigure();
			Thread.Sleep(100);
		}

        private float[,] MultiplyMatr(float[,] a, float[,] b)
		{
			int n = a.GetLength(0);
            int m = a.GetLength(1);

			float[,] result = new float[n, m];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					result[i, j] = 0;

					for (int ii = 0; ii < m; ii++)
					{
						result[i, j] += a[i, ii] * b[ii, j];
					}
				}
			}

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = result[i, j] / result[i, 2];
                }
            }

			return result;
		}

        private void DrawFigure()
        {
            InitFigure();
            InitMatrSdv(k, l);
            InitRotation(angle);
			InitScaling(scale);

            float[,] figure1 = MultiplyMatr(figure, scaling);
			figure1 = MultiplyMatr(figure1, rotation);
            figure1 = MultiplyMatr(figure1, otobr);
			figure1 = MultiplyMatr(figure1, matrSdv);

			Graphics g = Graphics.FromImage(bitmap);

			g.DrawLine(pen, figure1[0, 0], figure1[0, 1], figure1[1, 0], figure1[1, 1]);
            g.DrawLine(pen, figure1[1, 0], figure1[1, 1], figure1[2, 0], figure1[2, 1]);
            g.DrawLine(pen, figure1[2, 0], figure1[2, 1], figure1[3, 0], figure1[3, 1]);
            g.DrawLine(pen, figure1[3, 0], figure1[3, 1], figure1[4, 0], figure1[4, 1]);
            g.DrawLine(pen, figure1[4, 0], figure1[4, 1], figure1[5, 0], figure1[5, 1]);
            g.DrawLine(pen, figure1[5, 0], figure1[5, 1], figure1[0, 0], figure1[0, 1]);
			g.Dispose();

            PictureBox.Image = bitmap;
        }

        private void DrawOsi()
		{
			InitOsi();
			InitMatrSdv(PictureBox.Width / 2, PictureBox.Height / 2);
			float[,] osi1 = MultiplyMatr(osi, matrSdv);
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
            StandardDisplay();
		}

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            if (OXRightRadioButton.Checked)
            {
                k += 5;
            }

            if (OXLeftRadioButton.Checked)
            {
                k -= 5;
            }

            if (OYDownRadioButton.Checked)
            {
                l += 5;
            }

            if (OYUpRadioButton.Checked)
            {
                l -= 5;
            }

			RemovingOldFigure();
		}

        private void RemovingOldFigure()
        {
			PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            DrawOsi();
            DrawFigure();
            PictureBox.Image = bitmap;
		}

        private void StandardDisplay()
        {
            otobr[0, 0] = 1; otobr[0, 1] = 0; otobr[0, 2] = 0;
            otobr[1, 0] = 0; otobr[1, 1] = 1; otobr[1, 2] = 0;
            otobr[2, 0] = 0; otobr[2, 1] = 0; otobr[2, 2] = 1;
        }

        private void YX()
        {
            otobr[0, 0] = 0; otobr[0, 1] = 1; otobr[0, 2] = 0;
            otobr[1, 0] = 1; otobr[1, 1] = 0; otobr[1, 2] = 0;
            otobr[2, 0] = 0; otobr[2, 1] = 0; otobr[2, 2] = 1;

            var temp = k;
            k = l;
            l = temp;
        }

        private void Y0()
        {
            otobr[0, 0] = 1; otobr[0, 1] = 0;  otobr[0, 2] = 0;
            otobr[1, 0] = 0; otobr[1, 1] = -1; otobr[1, 2] = 0;
            otobr[2, 0] = 0; otobr[2, 1] = 0;  otobr[2, 2] = 1;

            l = PictureBox.Height - l;
		}

        private void X0()
        {
            otobr[0, 0] = -1; otobr[0, 1] = 0; otobr[0, 2] = 0;
            otobr[1, 0] = 0;  otobr[1, 1] = 1; otobr[1, 2] = 0;
            otobr[2, 0] = 0;  otobr[2, 1] = 0; otobr[2, 2] = 1;

            k = PictureBox.Width - k;
		}

		private void YXReflectionButton_Click(object sender, EventArgs e)
        {
            YX();
            RemovingOldFigure();

        }

        private void Y0ReflectionButton_Click(object sender, EventArgs e)
        {
            Y0();
            RemovingOldFigure();
        }

        private void X0ReflectionButton_Click(object sender, EventArgs e)
        {
            X0();
            RemovingOldFigure();
        }

        private void InitScaling(float scale)
        {
            scaling[0, 0] = 1; scaling[0, 1] = 0; scaling[0, 2] = 0;
            scaling[1, 0] = 0; scaling[1, 1] = 1; scaling[1, 2] = 0;
            scaling[2, 0] = 0; scaling[2, 1] = 0; scaling[2, 2] = scale;
		}

        private void ApplyScalingButton_Click(object sender, EventArgs e)
        {
            scale = float.Parse(ScalingTextBox.Text);
            RemovingOldFigure();
		}

        private void InitRotation(float angle)
        {
            angle = (angle * (float)Math.PI) / 180;
			rotation[0, 0] = (float)Math.Cos(angle); rotation[0, 1] = (float)Math.Sin(angle); rotation[0, 2] = 0;
            rotation[1, 0] = -(float)Math.Sin(angle); rotation[1, 1] = (float)Math.Cos(angle); rotation[1, 2] = 0;
            rotation[2, 0] = -((float)Math.Cos(angle) - 1) + ((float)Math.Sin(angle)); rotation[2, 1] = -((float)Math.Sin(angle)) - ((float)Math.Cos(angle) - 1); rotation[2, 2] = 1;
		}

        private void ApplyAngleButton_Click(object sender, EventArgs e)
        {
            angle = float.Parse(AngleTextBox.Text);
            RemovingOldFigure();
        }

        ///Велосипед

        private void InitWheel()
        {
            wheels[0, 0] = 60; wheels[0, 1] = 300; wheels[0, 2] = 50;
            wheels[1, 0] = 180; wheels[1, 1] = 300; wheels[1, 2] = 50;
            wheels[2, 0] = 150; wheels[2, 1] = 315; wheels[2, 2] = 20;
        }

        private void InitHousing()
        {
            housing[0, 0] = 85; housing[0, 1] = 325; housing[0, 2] = 1;
            housing[1, 0] = 85; housing[1, 1] = 260; housing[1, 2] = 1;
            housing[2, 0] = 85; housing[2, 1] = 280; housing[2, 2] = 1;
            housing[3, 0] = 160; housing[3, 1] = 280; housing[3, 2] = 1;
            housing[4, 0] = 160; housing[4, 1] = 260; housing[4, 2] = 1;
            housing[5, 0] = 160; housing[5, 1] = 325; housing[5, 2] = 1;
            housing[6, 0] = 205; housing[6, 1] = 325; housing[6, 2] = 1;
        }

        private void InitPedal()
        {
            pedal[0, 0] = 160; pedal[0, 1] = 335; pedal[0, 2] = 1;
            pedal[1, 0] = 160; pedal[1, 1] = 345; pedal[1, 2] = 1;
            pedal[2, 0] = 155; pedal[2, 1] = 345; pedal[2, 2] = 1;
            pedal[3, 0] = 165; pedal[3, 1] = 345; pedal[3, 2] = 1;
        }

        private void DrawBicycle()
        {
            InitWheel();
            InitHousing();
            InitPedal();

            Graphics g = Graphics.FromImage(bitmap);

            g.DrawEllipse(pen, wheels[0, 0], wheels[0, 1], wheels[0, 2], wheels[0, 2]);
            g.DrawEllipse(pen, wheels[1, 0], wheels[1, 1], wheels[1, 2], wheels[1, 2]);
            g.DrawEllipse(pen, wheels[2, 0], wheels[2, 1], wheels[2, 2], wheels[2, 2]);

            g.DrawLine(pen, housing[0, 0], housing[0, 1], housing[1, 0], housing[1, 1]);
            g.DrawLine(pen, housing[2, 0], housing[2, 1], housing[3, 0], housing[3, 1]);
            g.DrawLine(pen, housing[4, 0], housing[4, 1], housing[5, 0], housing[5, 1]);
            g.DrawLine(pen, housing[5, 0], housing[5, 1], housing[6, 0], housing[6, 1]);
            g.DrawLine(pen, housing[6, 0], housing[6, 1], housing[3, 0], housing[3, 1]);

            g.DrawLine(pen, pedal[0, 0], pedal[0, 1], pedal[1, 0], pedal[1, 1]);
            g.DrawLine(pen, pedal[2, 0], pedal[2, 1], pedal[3, 0], pedal[3, 1]);


            g.Dispose();

            PictureBox.Image = bitmap;
        }

        private void BicycleButton_Click(object sender, EventArgs e)
        {
            DrawBicycle();
        }
    }
}
