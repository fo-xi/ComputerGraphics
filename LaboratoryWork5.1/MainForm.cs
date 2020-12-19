using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace LaboratoryWork5._1
{
    public partial class MainForm : Form
    {
        public Pen pen = new Pen(Color.Black);

        public Bitmap bitmap;

        public float[,] matrPreob = new float[4, 4];

        public float[,] matrSdv = new float[4, 4];

        public float[,] osi = new float[4, 3];

        public float[,] scaling = new float[4, 4];

        public float[,] projectionZ = new float[4, 4];

        public float l;

        public float m;

        public float n;

        public bool f;

        public float scale = 1;

        // График поверхности

        public float angleX = 0;

        public float angleY = 0;

        public float angleZ = 0;

        public float[,] rotationX = new float[4, 4];

        public float[,] rotationY = new float[4, 4];

        public float[,] rotationZ = new float[4, 4];

        public const int countPoints = 60;

        public GraphPoint[,] surface = new GraphPoint[countPoints, countPoints];

        public GraphPoint[,] drawSurface = new GraphPoint[countPoints, countPoints];

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

        private void InitMatrPreob(float l1, float m1)
        {
            matrPreob[0, 0] = 1;  matrPreob[0, 1] = 0;  matrPreob[0, 2] = 0; matrPreob[0, 3] = 0;
            matrPreob[1, 0] = 0;  matrPreob[1, 1] = 1;  matrPreob[1, 2] = 0; matrPreob[1, 3] = 0;
            matrPreob[2, 0] = 0;  matrPreob[2, 1] = 0;  matrPreob[2, 2] = 1; matrPreob[2, 3] = 0;
            matrPreob[3, 0] = l1; matrPreob[3, 1] = m1; matrPreob[3, 2] = 0; matrPreob[3, 3] = 1;
        }

        private void InitMatrSdv(float l1, float m1, float n1)
        {
            matrSdv[0, 0] = 1; matrSdv[0, 1] = 0; matrSdv[0, 2] = 0;  matrSdv[0, 3] = 0;
            matrSdv[1, 0] = 0; matrSdv[1, 1] = 1; matrSdv[1, 2] = 0;  matrSdv[1, 3] = 0;
            matrSdv[2, 0] = 0; matrSdv[2, 1] = 0; matrSdv[2, 2] = 1;  matrSdv[2, 3] = 0;
            matrSdv[3, 0] = l1; matrSdv[3, 1] = m1; matrSdv[3, 2] = n1; matrSdv[3, 3] = 1;
        }

        private void InitMatrSdvOsi(float l1, float m1)
        {
            matrSdv[0, 0] = 1; matrSdv[0, 1] = 0; matrSdv[0, 2] = 0;
            matrSdv[1, 0] = 0; matrSdv[1, 1] = 1; matrSdv[1, 2] = 0;
            matrSdv[2, 0] = l1; matrSdv[2, 1] = m1; matrSdv[2, 2] = 1;
        }

        private void InitScaling(float scale)
        {
            scaling[0, 0] = scale; scaling[0, 1] = 0;     scaling[0, 2] = 0;     scaling[0, 3] = 0;
            scaling[1, 0] = 0;     scaling[1, 1] = scale; scaling[1, 2] = 0;     scaling[1, 3] = 0;
            scaling[2, 0] = 0;     scaling[2, 1] = 0;     scaling[2, 2] = scale; scaling[2, 3] = 0;
            scaling[3, 0] = 0;     scaling[3, 1] = 0;     scaling[3, 2] = 0;     scaling[3, 3] = 1;
        }

        private void InitRotation(float angleX, float angleY, float angleZ)
        {
            var newAngleX = (angleX * (float)Math.PI) / 180;
            float cosX = (float)Math.Cos(newAngleX);
            float sinX = (float)Math.Sin(newAngleX);

            var newAngleY = (angleY * (float)Math.PI) / 180;
            float cosY = (float)Math.Cos(newAngleY);
            float sinY = (float)Math.Sin(newAngleY);

            var newAngleZ = (angleZ * (float)Math.PI) / 180;
            float cosZ = (float)Math.Cos(newAngleZ);
            float sinZ = (float)Math.Sin(newAngleZ);

            rotationX[0, 0] = 1; rotationX[0, 1] = 0;     rotationX[0, 2] = 0;    rotationX[0, 3] = 0;
            rotationX[1, 0] = 0; rotationX[1, 1] = cosX;  rotationX[1, 2] = sinX; rotationX[1, 3] = 0;
            rotationX[2, 0] = 0; rotationX[2, 1] = -sinX; rotationX[2, 2] = cosX; rotationX[2, 3] = 0;
            rotationX[3, 0] = 0; rotationX[3, 1] = 0;     rotationX[3, 2] = 0;    rotationX[3, 3] = 1;

            rotationY[0, 0] = cosY; rotationY[0, 1] = 0; rotationY[0, 2] = -sinY; rotationY[0, 3] = 0;
            rotationY[1, 0] = 0;    rotationY[1, 1] = 1; rotationY[1, 2] = 0;     rotationY[1, 3] = 0;
            rotationY[2, 0] = sinY; rotationY[2, 1] = 0; rotationY[2, 2] = cosY;  rotationY[2, 3] = 0;
            rotationY[3, 0] = 0;    rotationY[3, 1] = 0; rotationY[3, 2] = 0;     rotationY[3, 3] = 1;

            rotationZ[0, 0] = cosZ;  rotationZ[0, 1] = sinZ; rotationZ[0, 2] = 0; rotationZ[0, 3] = 0;
            rotationZ[1, 0] = -sinZ; rotationZ[1, 1] = cosZ; rotationZ[1, 2] = 0; rotationZ[1, 3] = 0;
            rotationZ[2, 0] = 0;     rotationZ[2, 1] = 0;    rotationZ[2, 2] = 1; rotationZ[2, 3] = 0;
            rotationZ[3, 0] = 0;     rotationZ[3, 1] = 0;    rotationZ[3, 2] = 0; rotationZ[3, 3] = 1;
        }

        private void InitSurface()
        {
            float x = -3;
            float y = -3;
            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints; j++)
                {
                    surface[i, j] = new GraphPoint(x, y, (float)((x * x) - (y * y)), 1);
                    x += (float)0.1;
                }
                y += (float)0.1;
                x = -3;
            }
        }

        private GraphPoint[,] MultiplyMatr(GraphPoint[,] a, float[,] b)
        {
            int n = countPoints;
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

        private void InitOsi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0;    osi[0, 2] = 1;
            osi[1, 0] = 200;  osi[1, 1] = 0;    osi[1, 2] = 1;
            osi[2, 0] = 0;    osi[2, 1] = 200;  osi[2, 2] = 1;
            osi[3, 0] = 0;    osi[3, 1] = -200; osi[3, 2] = 1;
        }

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
            l = 0;
            m = 0;
            DrawFigure();
        }

        private void DrawAxisButton_Click(object sender, EventArgs e)
        {
            DrawOsi();
        }

        private void DrawFigure()
        {
            InitSurface();

            drawSurface = new GraphPoint[countPoints, countPoints];
            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints; j++)
                {
                    drawSurface[i, j] = new GraphPoint(surface[i, j].X, surface[i, j].Y, surface[i, j].Z, surface[i, j].H);
                }
            }

            InitScaling(scale);
            InitMatrPreob(PictureBox.Width / 2, PictureBox.Height / 2);
            InitMatrSdv(l, m, 0);
            InitRotation(angleX, angleY, angleZ);
            
            GraphPoint[,] surface1 = MultiplyMatr(drawSurface, scaling);
            surface1 = MultiplyMatr(surface1, rotationX);
            surface1 = MultiplyMatr(surface1, rotationY);
            surface1 = MultiplyMatr(surface1, rotationZ);
            surface1 = MultiplyMatr(surface1, matrSdv);
            surface1 = MultiplyMatr(surface1, matrPreob);

            Graphics g = Graphics.FromImage(bitmap);

            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints - 1; j++)
                {
                    g.DrawLine(pen, surface1[i, j].X, surface1[i, j].Y, surface1[i, j + 1].Y, surface1[i, j + 1].Y);
                }
            }
            for (int i = 0; i < countPoints; i++)
            {
                for (int j = 0; j < countPoints - 1; j++)
                {
                    g.DrawLine(pen, surface1[j, i].X, surface1[j, i].Y, surface1[j + 1, i].X, surface1[j + 1, i].Y);
                }
            } 
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

        private void RotationX_Click(object sender, EventArgs e)
        {
            angleX += float.Parse(AngleTextBox.Text);
            Update();
        }

        private void RotationY_Click(object sender, EventArgs e)
        {
            angleY += float.Parse(AngleTextBox.Text);
            Update();
        }

        private void RotationZ_Click(object sender, EventArgs e)
        {
            angleY += float.Parse(AngleTextBox.Text);
            Update();
        }

        private void ScalingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(ScalingTextBox.Text, out scale))
            {
                scale = 1;
            }

            Update();
        }
    }
}
