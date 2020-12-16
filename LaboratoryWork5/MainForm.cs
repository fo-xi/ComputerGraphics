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

        public float[,] projectionZ = new float[4, 4];

        public float[,] straight = new float[1, 4];

        public float l;

        public float m;

        public float n;

        public bool f;

        public float angle = 0;

        public float scale = 1;

        public int speed = 100;

        public const int countPoints = 20;

        public Point[,] graf = new Point[countPoints, countPoints];

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

        private Point[,] MultiplyMatr(Point[,] a, float[,] b)
        {
            int n = a.GetLength(0);
            int m = b.GetLength(1);

            float[,,] temp = new float[n, n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        temp[i, j, k] = 0;

                        temp[i, j, k] += (float)(a[i, j].X * b[0, k]);
                        temp[i, j, k] += (float)(a[i, j].Y * b[1, k]);
                        temp[i, j, k] += (float)(a[i, j].Z * b[2, k]);
                        temp[i, j, k] += (float)(a[i, j].H * b[3, k]);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j].X = temp[i, j, 0];
                    a[i, j].Y = temp[i, j, 1];
                    a[i, j].Z = temp[i, j, 2];
                    a[i, j].H = temp[i, j, 3];
                }
            }

            return a;
        }

        private void DrawFigure()
        {
            InitFigure();
            InitProjection();
            InitMatrSdv(l, m);
            InitScaling(scale);
            InitRotation(angle);
            InitGraf();

            Point[,] figure1 = MultiplyMatr(graf, scaling);
            figure1 = MultiplyMatr(figure1, rotation);

            Graphics g = Graphics.FromImage(bitmap);

            figure1 = MultiplyMatr(figure1, projectionZ);
            figure1 = MultiplyMatr(figure1, matrSdv);

            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints - 1; j++)
                {
                    g.DrawLine(pen, figure1[i, j].X, figure1[i, j].Y, figure1[i, j + 1].Y, figure1[i, j + 1].Y);
                }
            }
            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints - 1; j++)
                {
                    g.DrawLine(pen, figure1[j, i].X, figure1[j, i].Y, figure1[j + 1, i].X, figure1[j + 1, i].Y);
                }
            }

            //g.DrawLine(pen, figure1[0, 0], figure1[0, 1], figure1[1, 0], figure1[1, 1]);
            //g.DrawLine(pen, figure1[1, 0], figure1[1, 1], figure1[2, 0], figure1[2, 1]);
            //g.DrawLine(pen, figure1[2, 0], figure1[2, 1], figure1[3, 0], figure1[3, 1]);
            //g.DrawLine(pen, figure1[3, 0], figure1[3, 1], figure1[0, 0], figure1[0, 1]);

            //g.DrawLine(pen, figure1[4, 0], figure1[4, 1], figure1[5, 0], figure1[5, 1]);
            //g.DrawLine(pen, figure1[5, 0], figure1[5, 1], figure1[6, 0], figure1[6, 1]);
            //g.DrawLine(pen, figure1[6, 0], figure1[6, 1], figure1[7, 0], figure1[7, 1]);
            //g.DrawLine(pen, figure1[7, 0], figure1[7, 1], figure1[4, 0], figure1[4, 1]);

            //g.DrawLine(pen, figure1[0, 0], figure1[0, 1], figure1[4, 0], figure1[4, 1]);
            //g.DrawLine(pen, figure1[1, 0], figure1[1, 1], figure1[5, 0], figure1[5, 1]);
            //g.DrawLine(pen, figure1[2, 0], figure1[2, 1], figure1[6, 0], figure1[6, 1]);
            //g.DrawLine(pen, figure1[3, 0], figure1[3, 1], figure1[7, 0], figure1[7, 1]);

            g.Dispose();

            PictureBox.Image = bitmap;
        }

        private void DrawOsi()
        {
            InitOsi();
            InitMatrSdvOsi(PictureBox.Width / 2, PictureBox.Height / 2);
            //float[,] osi1 = MultiplyMatr(osi, matrSdv);
            Graphics g = Graphics.FromImage(bitmap);

            //g.DrawLine(pen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);
            //g.DrawLine(pen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);
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
            scaling[0, 0] = scale; scaling[0, 1] = 0; scaling[0, 2] = 0; scaling[0, 3] = 0;
            scaling[1, 0] = 0; scaling[1, 1] = scale; scaling[1, 2] = 0; scaling[1, 3] = 0;
            scaling[2, 0] = 0; scaling[2, 1] = 0; scaling[2, 2] = scale; scaling[2, 3] = 0;
            scaling[3, 0] = 0; scaling[3, 1] = 0; scaling[3, 2] = 0; scaling[3, 3] = 1;
        }

        private void ApplyScalingButton_Click(object sender, EventArgs e)
        {
            scale = float.Parse(ScalingTextBox.Text);
            Update();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            straight[0, 0] = float.Parse(XTextBox.Text);
            straight[0, 1] = float.Parse(YTextBox.Text); 
            straight[0, 2] = float.Parse(ZTextBox.Text);
            straight[0, 3] = 1;
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

        private void InitGraf()
        {
            float x = -3;
            float y = -3;
            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints; j++)
                {
                    graf[i, j] = new Point(x, y, (float)((x * x)*(y * y) - 100), 1);
                    x += (float)0.5;
                }
                y += (float)0.5;
                x = -3;
            }
        }
    }
}

