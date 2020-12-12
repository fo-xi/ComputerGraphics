using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace LaboratoryWork5
{
    public partial class MainForm : Form
    {
        public Pen pen = new Pen(Color.Black);

        public Bitmap bitmap;

        public float[,] figure = new float[8, 4];

        public float[,] matrSdv = new float[4, 4];

        public float[,] osi = new float[4, 3];

        public float[,] scaling = new float[4, 4];

        public float[,] rotation = new float[4, 4];

        public float[,] projectionX = new float[4, 4];

        public float[,] projectionY = new float[4, 4];

        public float[,] projectionZ = new float[4, 4];

        public float[,] straight = new float[1, 4];

        public float l;

        public float m;

        public float n;

        public bool f;

        public float angle = 0;

        public float scale = 1;

        public int speed = 100;

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
            List<string> colors = new List<string> {"Red", "Pink", "Blue", "Green"};
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
            figure[0, 0] = -50; figure[0, 1] = -50;  figure[0, 2] = 50;  figure[0, 3] = 1;
            figure[1, 0] = -50; figure[1, 1] = 50;  figure[1, 2] = 50;  figure[1, 3] = 1;
            figure[2, 0] = 50;  figure[2, 1] = 50;  figure[2, 2] = 50;  figure[2, 3] = 1;
            figure[3, 0] = 50;  figure[3, 1] = -50; figure[3, 2] = 50;  figure[3, 3] = 1;

            figure[4, 0] = -50; figure[4, 1] = -50;  figure[4, 2] = -50; figure[4, 3] = 1;
            figure[5, 0] = -50; figure[5, 1] = 50;  figure[5, 2] = -50; figure[5, 3] = 1;
            figure[6, 0] = 50;  figure[6, 1] = 50;  figure[6, 2] = -50; figure[6, 3] = 1;
            figure[7, 0] = 50;  figure[7, 1] = -50; figure[7, 2] = -50; figure[7, 3] = 1;
        }

        private void InitProjection()
        {
            projectionX[0, 0] = 0; projectionX[0, 1] = 0; projectionX[0, 2] = 0; projectionX[0, 3] = 0;
            projectionX[1, 0] = 0; projectionX[1, 1] = 1; projectionX[1, 2] = 0; projectionX[1, 3] = 0;
            projectionX[2, 0] = 0; projectionX[2, 1] = 0; projectionX[2, 2] = 1; projectionX[2, 3] = 0;
            projectionX[3, 0] = 0; projectionX[3, 1] = 0; projectionX[3, 2] = 0; projectionX[3, 3] = 1;

            projectionY[0, 0] = 1; projectionY[0, 1] = 0; projectionY[0, 2] = 0; projectionY[0, 3] = 0;
            projectionY[1, 0] = 0; projectionY[1, 1] = 0; projectionY[1, 2] = 0; projectionY[1, 3] = 0;
            projectionY[2, 0] = 0; projectionY[2, 1] = 0; projectionY[2, 2] = 1; projectionY[2, 3] = 0;
            projectionY[3, 0] = 0; projectionY[3, 1] = 0; projectionY[3, 2] = 0; projectionY[3, 3] = 1;

            projectionZ[0, 0] = 1; projectionZ[0, 1] = 0; projectionZ[0, 2] = 0; projectionZ[0, 3] = 0;
            projectionZ[1, 0] = 0; projectionZ[1, 1] = 1; projectionZ[1, 2] = 0; projectionZ[1, 3] = 0;
            projectionZ[2, 0] = 0; projectionZ[2, 1] = 0; projectionZ[2, 2] = 0; projectionZ[2, 3] = 0;
            projectionZ[3, 0] = 0; projectionZ[3, 1] = 0; projectionZ[3, 2] = 0; projectionZ[3, 3] = 1;
        }

        private void InitMatrSdv(float l1, float m1)
        {
            matrSdv[0, 0] = 1;  matrSdv[0, 1] = 0;  matrSdv[0, 2] = 0;  matrSdv[0, 3] = 0;
            matrSdv[1, 0] = 0;  matrSdv[1, 1] = 1;  matrSdv[1, 2] = 0;  matrSdv[1, 3] = 0;
            matrSdv[2, 0] = 0;  matrSdv[2, 1] = 0;  matrSdv[2, 2] = 1;  matrSdv[2, 3] = 0;
            matrSdv[3, 0] = l1; matrSdv[3, 1] = m1; matrSdv[3, 2] = 0; matrSdv[3, 3] = 1;
        }

        private void InitMatrSdvOsi(float l1, float m1)
        {
            matrSdv[0, 0] = 1;  matrSdv[0, 1] = 0;  matrSdv[0, 2] = 0;
            matrSdv[1, 0] = 0;  matrSdv[1, 1] = 1;  matrSdv[1, 2] = 0;
            matrSdv[2, 0] = l1; matrSdv[2, 1] = m1; matrSdv[2, 2] = 1;
        }

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
            l = PictureBox.Width / 2;
            m = PictureBox.Height / 2;
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
                    result[i, j] = result[i, j] / result[i, m - 1];
                }
            }

            return result;
        }

        private void DrawFigure()
        {
            InitFigure();
            InitProjection();
            InitMatrSdv(l, m);
            InitScaling(scale);
            InitRotation(angle);

            float[,] figure1 = MultiplyMatr(figure, scaling);
            figure1 = MultiplyMatr(figure1, rotation);

            Graphics g = Graphics.FromImage(bitmap);

            figure1 = MultiplyMatr(figure1, projectionZ);
            figure1 = MultiplyMatr(figure1, matrSdv);

            g.DrawLine(pen, figure1[0, 0], figure1[0, 1], figure1[1, 0], figure1[1, 1]);
            g.DrawLine(pen, figure1[1, 0], figure1[1, 1], figure1[2, 0], figure1[2, 1]);
            g.DrawLine(pen, figure1[2, 0], figure1[2, 1], figure1[3, 0], figure1[3, 1]);
            g.DrawLine(pen, figure1[3, 0], figure1[3, 1], figure1[0, 0], figure1[0, 1]);

            g.DrawLine(pen, figure1[4, 0], figure1[4, 1], figure1[5, 0], figure1[5, 1]);
            g.DrawLine(pen, figure1[5, 0], figure1[5, 1], figure1[6, 0], figure1[6, 1]);
            g.DrawLine(pen, figure1[6, 0], figure1[6, 1], figure1[7, 0], figure1[7, 1]);
            g.DrawLine(pen, figure1[7, 0], figure1[7, 1], figure1[4, 0], figure1[4, 1]);

            g.DrawLine(pen, figure1[0, 0], figure1[0, 1], figure1[4, 0], figure1[4, 1]);
            g.DrawLine(pen, figure1[1, 0], figure1[1, 1], figure1[5, 0], figure1[5, 1]);
            g.DrawLine(pen, figure1[2, 0], figure1[2, 1], figure1[6, 0], figure1[6, 1]);
            g.DrawLine(pen, figure1[3, 0], figure1[3, 1], figure1[7, 0], figure1[7, 1]);

            DrawLine();

            g.Dispose();

            PictureBox.Image = bitmap;
        }

        private void DrawOsi()
        {
            InitOsi();
            InitMatrSdvOsi(PictureBox.Width / 2, PictureBox.Height / 2);
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
        }

        private void Update()
        {
            PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            DrawOsi();
            DrawFigure();
            PictureBox.Image = bitmap;
        }

        private void UpdateLine()
        {
            PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            DrawOsi();
            DrawLine();
            PictureBox.Image = bitmap;
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            if (XRightСheckBox.Checked)
            {
                l += 5;
            }

            if (XLeftСheckBox.Checked)
            {
                l -= 5;
            }

            if (YUpRadioButton.Checked)
            {
                m += 5;
            }

            if (YDownRadioButton.Checked)
            {
                m -= 5;
            }

            Update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (XRightСheckBox.Checked)
            {
                l += 5;
            }

            if (XLeftСheckBox.Checked)
            {
                l -= 5;
            }

            if (YUpRadioButton.Checked)
            {
                m += 5;
            }

            if (YDownRadioButton.Checked)
            {
                m -= 5;
            }

            Update();
            Thread.Sleep(100);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            StartButton.Text = "Стоп";
            if (f)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                StartButton.Text = "Старт";
            }
            f = !f;
        }

        private void InitScaling(float scale)
        {
            scaling[0, 0] = 1; scaling[0, 1] = 0; scaling[0, 2] = 0; scaling[0, 3] = 0;
            scaling[1, 0] = 0; scaling[1, 1] = 1; scaling[1, 2] = 0; scaling[1, 3] = 0;
            scaling[2, 0] = 0; scaling[2, 1] = 0; scaling[2, 2] = 1; scaling[2, 3] = 0;
            scaling[3, 0] = 0; scaling[3, 1] = 0; scaling[3, 2] = 0; scaling[3, 3] = scale;
        }

        private void ApplyScalingButton_Click(object sender, EventArgs e)
        {
            scale = float.Parse(ScalingTextBox.Text);
            Update();
        }

        private void DrawLine()
        {
            float l1 = PictureBox.Width / 2;
            float m1 = PictureBox.Height / 2;

            InitProjection();
            InitMatrSdv(l1, m1);

            Graphics g = Graphics.FromImage(bitmap);
            float[,] straight1 = MultiplyMatr(straight, projectionZ);
            straight1 = MultiplyMatr(straight1, matrSdv);
            g.DrawLine(pen, l1, m1, straight1[0, 0], straight1[0, 1]);

            g.Dispose();

            PictureBox.Image = bitmap;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            straight[0, 0] = float.Parse(XTextBox.Text);
            straight[0, 1] = float.Parse(YTextBox.Text); 
            straight[0, 2] = float.Parse(ZTextBox.Text);
            straight[0, 3] = 1;
            Update();
        }

        private void InitRotation(float angle)
        {
            angle = (angle * (float)Math.PI) / 180;
            float cos = (float)Math.Cos(angle); 
            float sin = (float)Math.Sin(angle);

            rotation[0, 0] = straight[0, 0] * straight[0, 0] + (1 - straight[0, 0] * straight[0, 0]) * cos; 
            rotation[0, 1] = straight[0, 0] * straight[0, 1] * (1 - cos) + straight[0, 2] * sin;
            rotation[0, 2] = straight[0, 0] * straight[0, 2] * (1 - cos) - straight[0, 1] * sin;
            rotation[0, 3] = 0;

            rotation[1, 0] = straight[0, 0] * straight[0, 1] * (1 - cos) - straight[0, 2] * sin;
            rotation[1, 1] = straight[0, 1] * straight[0, 1] + (1 - straight[0, 1] * straight[0, 1]) * cos;
            rotation[1, 2] = straight[0, 1] * straight[0, 2] * (1 - cos) + straight[0, 0] * sin;
            rotation[1, 3] = 0;

            rotation[2, 0] = straight[0, 0] * straight[0, 2] * (1 - cos) + straight[0, 1] * sin;
            rotation[2, 1] = straight[0, 1] * straight[0, 2] * (1 - cos) - straight[0, 0] * sin;
            rotation[2, 2] = straight[0, 2] * straight[0, 2] + (1 - straight[0, 2] * straight[0, 2]) * cos;
            rotation[2, 3] = 0;

            rotation[3, 0] = 0;
            rotation[3, 1] = 0;
            rotation[3, 2] = 0;
            rotation[3, 3] = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            angle -= 10;
            Update();
            Thread.Sleep(speed);
        }

        private void StartRotationButton_Click(object sender, EventArgs e)
        {
            timer2.Interval = 100;

            StartRotationButton.Text = "Закончить Вращение";
            if (f)
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
                StartRotationButton.Text = "Начать Вращение";
            }
            f = !f;
        }

        private void ChangeDirectionButton_Click(object sender, EventArgs e)
        {
            angle *= -1;
        }

        private void IncreaseSpeedButton_Click(object sender, EventArgs e)
        {
            speed -= 10;
        }

        private void ReduceSpeedButton_Click(object sender, EventArgs e)
        {
            speed += 10;
        }
    }
}

