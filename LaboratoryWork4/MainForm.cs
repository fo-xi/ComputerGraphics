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
		
		public float [,] matrWheel1Spokes = new float[2, 3];

		public float[,] matrWheel2Spokes = new float[2, 3];

		public float[,] matrHousing = new float[10, 3];

		public float[,] matrPedal1 = new float[2, 3];

		public float[,] matrPedal2 = new float[2, 3];

		public float kWheel1 = 0;

		public float lWheel1 = 0;

		public float kWheel2 = 0;

		public float lWheel2 = 0;

		public float kWheel3 = 0;

		public float lWheel3 = 0;

		//Тандем

		public float[,] matrTandem = new float[10, 3];

		public float[,] matrTandemPedal1 = new float[2, 3];

		public float[,] matrTandemPedal2 = new float[2, 3];

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

		private void InitWheelSpokes()
		{

			if (TandemCheckBox.Checked)
			{ 
			
			}
			else 
			{
				matrWheel1Spokes[0, 0] = -25; matrWheel1Spokes[0, 1] = 0; matrWheel1Spokes[0, 2] = 1;
				matrWheel1Spokes[1, 0] = 25; matrWheel1Spokes[1, 1] = 0; matrWheel1Spokes[1, 2] = 1;

				matrWheel2Spokes[0, 0] = -25; matrWheel2Spokes[0, 1] = 0; matrWheel2Spokes[0, 2] = 1;
				matrWheel2Spokes[1, 0] = 25; matrWheel2Spokes[1, 1] = 0; matrWheel2Spokes[1, 2] = 1;

				kWheel1 = k - 60;
				lWheel1 = l + 25;

				kWheel2 = k + 60;
				lWheel2 = l + 25;
			}
		}

		private void InitHousing()
		{
			if (TandemCheckBox.Checked)
			{

			}
			else
			{
				matrHousing[0, 0] = -60; matrHousing[0, 1] = 25; matrHousing[0, 2] = 1;
				matrHousing[1, 0] = -60; matrHousing[1, 1] = -35; matrHousing[1, 2] = 1;
				matrHousing[2, 0] = -60; matrHousing[2, 1] = -15; matrHousing[2, 2] = 1;
				matrHousing[3, 0] = 15; matrHousing[3, 1] = -15; matrHousing[3, 2] = 1;
				matrHousing[4, 0] = 15; matrHousing[4, 1] = -35; matrHousing[4, 2] = 1;
				matrHousing[5, 0] = 15; matrHousing[5, 1] = 25; matrHousing[5, 2] = 1;
				matrHousing[6, 0] = 60; matrHousing[6, 1] = 25; matrHousing[6, 2] = 1;
				matrHousing[7, 0] = -85; matrHousing[7, 1] = 0; matrHousing[7, 2] = 1;
				matrHousing[8, 0] = 35; matrHousing[8, 1] = 0; matrHousing[8, 2] = 1;
				matrHousing[9, 0] = 5; matrHousing[9, 1] = 15; matrHousing[9, 2] = 1;
			}
		}

		private void InitTandem()
		{
			matrTandem[0, 0] = 90;   matrTandem[0, 1] = -15;  matrTandem[0, 2] = 1;
			matrTandem[1, 0] = 90;   matrTandem[1, 1] = -35;  matrTandem[1, 2] = 1;
			matrTandem[2, 0] = 90;   matrTandem[2, 1] = 25;   matrTandem[2, 2] = 1;
			matrTandem[3, 0] = 165;  matrTandem[3, 1] = 25;   matrTandem[3, 2] = 1;
			matrTandem[4, 0] = 138;  matrTandem[4, 1] = 0;    matrTandem[4, 2] = 1;
			matrTandem[5, 0] = 80;   matrTandem[5, 1] = 15;   matrTandem[5, 2] = 1;
		}

		private void InitPedal()
		{
			matrPedal1[0, 0] = 0; matrPedal1[0, 1] = 0; matrPedal1[0, 2] = 1;
			matrPedal1[1, 0] = 0; matrPedal1[1, 1] = 20; matrPedal1[1, 2] = 1;

			matrPedal2[0, 0] = -5; matrPedal2[0, 1] = 20; matrPedal2[0, 2] = 1;
			matrPedal2[1, 0] = 5; matrPedal2[1, 1] = 20; matrPedal2[1, 2] = 1;

			if (TandemCheckBox.Checked)
			{
				//matrTandemPedal1[0, 0] = 0;  matrTandemPedal1[0, 1] = 0;  matrTandemPedal1[0, 2] = 1;
				//matrTandemPedal1[1, 0] = 0;  matrTandemPedal1[1, 1] = 20; matrTandemPedal1[1, 2] = 1;
												 							  
				//matrTandemPedal2[0, 0] = -80; matrTandemPedal2[0, 1] = 20; matrTandemPedal2[0, 2] = 1;
				//matrTandemPedal2[1, 0] = 80;  matrTandemPedal2[1, 1] = 20; matrTandemPedal2[1, 2] = 1;

			}
			else
			{
				kWheel3 = k + 15;
				lWheel3 = l + 25;
			}
		}

		private void DrawBicycle()
		{
			InitWheelSpokes();
			InitHousing();
			InitPedal();
			InitRotation(angle);
			InitTandem();

			InitMatrSdv(kWheel1, lWheel1);
			float[,] wheel1Spokes = MultiplyMatr(matrWheel1Spokes, rotation);
			wheel1Spokes = MultiplyMatr(wheel1Spokes, matrSdv);

			InitMatrSdv(kWheel2, lWheel2);
			float[,] wheel2Spokes = MultiplyMatr(matrWheel2Spokes, rotation);
			wheel2Spokes = MultiplyMatr(wheel2Spokes, matrSdv);

			InitMatrSdv(kWheel3, lWheel3);
			float[,] pedal1 = MultiplyMatr(matrPedal1, rotation);
			pedal1 = MultiplyMatr(pedal1, matrSdv);

			InitMatrSdv(kWheel3, lWheel3);
			float[,] pedal2 = MultiplyMatr(matrPedal2, rotation);
			pedal2 = MultiplyMatr(pedal2, matrSdv);

			InitMatrSdv(k, l);
			float[,] frame = MultiplyMatr(matrHousing, matrSdv);
			float[,] tandem = MultiplyMatr(matrTandem, matrSdv);

			Graphics g = Graphics.FromImage(bitmap);

			//Рисуем спицы
			g.DrawLine(pen, wheel1Spokes[0, 0], wheel1Spokes[0, 1], wheel1Spokes[1, 0], wheel1Spokes[1, 1]);
			g.DrawLine(pen, wheel2Spokes[0, 0], wheel2Spokes[0, 1], wheel2Spokes[1, 0], wheel2Spokes[1, 1]);

			g.DrawEllipse(pen, frame[7, 0], frame[7, 1], 50, 50);
			g.DrawLine(pen, frame[0, 0], frame[0, 1], frame[1, 0], frame[1, 1]);
			g.DrawLine(pen, frame[2, 0], frame[2, 1], frame[3, 0], frame[3, 1]);
			g.DrawLine(pen, frame[4, 0], frame[4, 1], frame[5, 0], frame[5, 1]);

			g.DrawEllipse(pen, frame[9, 0], frame[9, 1], 20, 20);

			g.DrawLine(pen, pedal1[0, 0], pedal1[0, 1], pedal1[1, 0], pedal1[1, 1]);
			g.DrawLine(pen, pedal2[0, 0], pedal2[0, 1], pedal2[1, 0], pedal2[1, 1]);

			if (TandemCheckBox.Checked)
			{
				g.DrawLine(pen, tandem[0, 0], tandem[0, 1], frame[3, 0], frame[3, 1]);
				g.DrawLine(pen, tandem[1, 0], tandem[1, 1], tandem[2, 0], tandem[2, 1]);
				g.DrawLine(pen, tandem[2, 0], tandem[2, 1], tandem[3, 0], tandem[3, 1]);
				g.DrawLine(pen, tandem[0, 0], tandem[0, 1], tandem[3, 0], tandem[3, 1]);
				g.DrawLine(pen, frame[3, 0], frame[3, 1], tandem[2, 0], tandem[2, 1]);
				g.DrawLine(pen, frame[5, 0], frame[5, 1], tandem[2, 0], tandem[2, 1]);

				g.DrawEllipse(pen, tandem[5, 0], tandem[5, 1], 20, 20);
				g.DrawEllipse(pen, tandem[4, 0], tandem[4, 1], 50, 50);

				//g.DrawLine(pen, pedal1[0, 0], pedal1[0, 1], pedal1[1, 0], pedal1[1, 1]);
				//g.DrawLine(pen, pedal2[0, 0], pedal2[0, 1], pedal2[1, 0], pedal2[1, 1]);
			}
			else
			{
				g.DrawLine(pen, frame[5, 0], frame[5, 1], frame[6, 0], frame[6, 1]);
				g.DrawLine(pen, frame[6, 0], frame[6, 1], frame[3, 0], frame[3, 1]);
				g.DrawEllipse(pen, frame[8, 0], frame[8, 1], 50, 50);
			}

			g.Dispose();

			PictureBox.Image = bitmap;
		}

		private void BicycleButton_Click(object sender, EventArgs e)
		{
			k = PictureBox.Width / 2;
			l = PictureBox.Height / 2;
			DrawBicycle();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			angle -= 10;
			k -= 5;
			if (k < -170)
			{
				k = PictureBox.Width + 170;
			}
			RemovingBicycle();
			Thread.Sleep(100);
		}

		private void RemovingBicycle()
		{
			PictureBox.Image = null;
			bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
			DrawBicycle();
			PictureBox.Image = bitmap;
		}

		private void StartBicycleButton_Click(object sender, EventArgs e)
		{
			timer2.Interval = 100;

			StartBicycleButton.Text = "Стоп";
			if (f == true)
			{
				timer2.Start();
			}
			else
			{
				timer2.Stop();
				StartBicycleButton.Text = "Старт";
			}
			f = !f;
		}
	}
}
