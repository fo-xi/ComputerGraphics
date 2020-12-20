using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace LaboratoryWork6
{
    public partial class MainForm : Form
    {
        public Pen pen = new Pen(Color.Black);

        public Bitmap bitmap;

        public float[,] figure = new float[5, 4];

        public float[,] matrSdv = new float[4, 4];

        public float[,] osi = new float[6, 4];

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

        //Удаление невидимых линий

        public const float angleA = 45;

        public const float angleB = 35.26f;

        public Surface[] surfaces = new Surface[6];

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

            l = PictureBox.Width / 2;
            m = PictureBox.Height / 2;
            n = PictureBox.Height / 2 - 110;
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
                Update();
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
                Update();
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
            Update();
        }

        private void SolidLineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Solid;
            Update();
        }

        private void DottedLineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dash;
            Update();
        }

        private void InitFigure()
        {
            figure[0, 0] = 0;   figure[0, 1] = -50; figure[0, 2] = 0;   figure[0, 3] = 1;
            figure[1, 0] = 0;   figure[1, 1] = 50;  figure[1, 2] = 0;   figure[1, 3] = 1;
            figure[2, 0] = -50; figure[2, 1] = 0;   figure[2, 2] = 0;   figure[2, 3] = 1;
            figure[3, 0] = 50;  figure[3, 1] = 0;   figure[3, 2] = 0;   figure[3, 3] = 1;
            figure[4, 0] = 0;   figure[4, 1] = 0;   figure[4, 2] = -50; figure[4, 3] = 1;
        }

        private void InitProjection()
        {
            var newAngleA = (angleA * (float)Math.PI) / 180;
            float cosA = (float)Math.Cos(newAngleA);
            float sinA = (float)Math.Sin(newAngleA);

            var newAngleB = (angleB * (float)Math.PI) / 180;
            float cosB = (float)Math.Cos(newAngleB);
            float sinB = (float)Math.Sin(newAngleB);

            projectionZ[0, 0] = cosA; projectionZ[0, 1] = sinA * sinB;  projectionZ[0, 2] = 0; projectionZ[0, 3] = 1;
            projectionZ[1, 0] = 0;    projectionZ[1, 1] = cosB;         projectionZ[1, 2] = 0; projectionZ[1, 3] = 1;
            projectionZ[2, 0] = sinA; projectionZ[2, 1] = -cosA * sinB; projectionZ[2, 2] = 0; projectionZ[2, 3] = 1;
            projectionZ[3, 0] = 0;    projectionZ[3, 1] = 0;            projectionZ[3, 2] = 0; projectionZ[3, 3] = 1;
        }

        private void InitMatrSdv(float l1, float m1, float n1)
        {
            matrSdv[0, 0] = 1; matrSdv[0, 1] = 0;   matrSdv[0, 2] = 0; matrSdv[0, 3] = 0;
            matrSdv[1, 0] = 0; matrSdv[1, 1] = 1;   matrSdv[1, 2] = 0; matrSdv[1, 3] = 0;
            matrSdv[2, 0] = 0; matrSdv[2, 1] = 0;   matrSdv[2, 2] = 1; matrSdv[2, 3] = 0;
            matrSdv[3, 0] = l1; matrSdv[3, 1] = m1; matrSdv[3, 2] = n1; matrSdv[3, 3] = 1;
        }

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
            l = PictureBox.Width / 2;
            m = PictureBox.Height / 2;
            n = PictureBox.Height / 2 - 110;
            DrawFigure();
        }

        private void InitSurfaces()
        {
            surfaces[0] = new Surface
            {
                Points = new float[3, 4]
                {
                    {
                        figure[2, 0],
                        figure[2, 1],
                        figure[2, 2],
                        figure[2, 3],
                    },

                    {
                        figure[0, 0],
                        figure[0, 1],
                        figure[0, 2],
                        figure[0, 3],
                    },

                    {
                        figure[3, 0],
                        figure[3, 1],
                        figure[3, 2],
                        figure[3, 3],
                    },
                }
            };

            surfaces[1] = new Surface
            {
                Points = new float[3, 4]
                {
                    {
                        figure[4, 0],
                        figure[4, 1],
                        figure[4, 2],
                        figure[4, 3],
                    },

                    {
                        figure[3, 0],
                        figure[3, 1],
                        figure[3, 2],
                        figure[3, 3],
                    },

                    {
                        figure[0, 0],
                        figure[0, 1],
                        figure[0, 2],
                        figure[0, 3],
                    },
                }
            };

            surfaces[2] = new Surface
            {
                Points = new float[3, 4]
                {
                    {
                        figure[4, 0],
                        figure[4, 1],
                        figure[4, 2],
                        figure[4, 3],
                    },

                    {
                        figure[0, 0],
                        figure[0, 1],
                        figure[0, 2],
                        figure[0, 3],
                    },

                    {
                        figure[2, 0],
                        figure[2, 1],
                        figure[2, 2],
                        figure[2, 3],
                    },
                }
            };

            surfaces[3] = new Surface
            {
                Points = new float[3, 4]
                {
                    {
                        figure[4, 0],
                        figure[4, 1],
                        figure[4, 2],
                        figure[4, 3],
                    },

                    {
                        figure[2, 0],
                        figure[2, 1],
                        figure[2, 2],
                        figure[2, 3],
                    },

                    {
                        figure[1, 0],
                        figure[1, 1],
                        figure[1, 2],
                        figure[1, 3],
                    },
                }
            };

            surfaces[4] = new Surface
            {
                Points = new float[3, 4]
                {
                    {
                        figure[4, 0],
                        figure[4, 1],
                        figure[4, 2],
                        figure[4, 3],
                    },

                    {
                        figure[3, 0],
                        figure[3, 1],
                        figure[3, 2],
                        figure[3, 3],
                    },

                    {
                        figure[1, 0],
                        figure[1, 1],
                        figure[1, 2],
                        figure[1, 3],
                    },
                }
            };

            surfaces[5] = new Surface
            {
                Points = new float[3, 4]
                {
                    {
                        figure[2, 0],
                        figure[2, 1],
                        figure[2, 2],
                        figure[2, 3],
                    },

                    {
                        figure[3, 0],
                        figure[3, 1],
                        figure[3, 2],
                        figure[3, 3],
                    },

                    {
                        figure[1, 0],
                        figure[1, 1],
                        figure[1, 2],
                        figure[1, 3],
                    },
                }
            };
        }

        private void InitOsi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0;    osi[0, 2] = 0;    osi[0, 3] = 1;
            osi[1, 0] = 200;  osi[1, 1] = 0;    osi[1, 2] = 0;    osi[1, 3] = 1;
            osi[2, 0] = 0;    osi[2, 1] = 200;  osi[2, 2] = 0;    osi[2, 3] = 1;
            osi[3, 0] = 0;    osi[3, 1] = -200; osi[3, 2] = 0;    osi[3, 3] = 1;
            osi[4, 0] = 0;    osi[4, 1] = 0;    osi[4, 2] = -200; osi[4, 3] = 1;
            osi[5, 0] = 0;    osi[5, 1] = 0;    osi[5, 2] = 200;  osi[5, 3] = 1;
        }

        private void DrawOsi()
        {
            InitOsi();
            InitMatrSdv(PictureBox.Width / 2, PictureBox.Height / 2, PictureBox.Height / 2 - 110);
            InitProjection();

            //Делает из трехмерного пространства двухмерное изображение так, что мы видим трехмерного пространство
            float[,] osi1 = MultiplyMatr(osi, matrSdv);
            osi1 = MultiplyMatr(osi1, projectionZ);
            Graphics g = Graphics.FromImage(bitmap);
            var pen = new Pen(Color.Black);

            g.DrawLine(pen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);
            g.DrawLine(pen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);
            g.DrawLine(pen, osi1[4, 0], osi1[4, 1], osi1[5, 0], osi1[5, 1]);
            g.Dispose();

            PictureBox.Image = bitmap;
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

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    result[i, j] = 0;

                    for (var k = 0; k < m; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }

        private void DrawFigure()
        {
            InitFigure();
            InitProjection();
            InitMatrSdv(l, m, n);
            InitScaling(scale);
            InitRotation(angle);
            InitSurfaces();

            Graphics g = Graphics.FromImage(bitmap);

            foreach (var surface in surfaces)
            {
                surface.Points = MultiplyMatr(surface.Points, scaling);
                surface.Points = MultiplyMatr(surface.Points, rotation);
                surface.CalculateAngle(angleA, angleB);
                surface.Points = MultiplyMatr(surface.Points, matrSdv);
                surface.Points = MultiplyMatr(surface.Points, projectionZ);
            }

            foreach (var surface in surfaces)
            {
                var rightAngle = 90;
                //Из радиан в градусы
                var angle = (surface.CalculateAngle(angleA, angleB)) * 180 / (float)Math.PI;
                if (angle > rightAngle)
                {
                    pen.DashStyle = DashStyle.Dash;
                }
                else
                {
                    pen.DashStyle = DashStyle.Solid;
                }

                g.DrawLine(pen, surface.Points[0, 0], surface.Points[0, 1], surface.Points[1, 0], surface.Points[1, 1]);
                g.DrawLine(pen, surface.Points[1, 0], surface.Points[1, 1], surface.Points[2, 0], surface.Points[2, 1]);
                g.DrawLine(pen, surface.Points[2, 0], surface.Points[2, 1], surface.Points[0, 0], surface.Points[0, 1]);
            }

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

            if (ZBackRadioButton.Checked)
            {
                n += 5;
            }

            if (ZForwardRadioButton.Checked)
            {
                n -= 5;
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

            if (ZBackRadioButton.Checked)
            {
                n += 5;
            }

            if (ZForwardRadioButton.Checked)
            {
                n -= 5;
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
            scaling[0, 0] = scale; scaling[0, 1] = 0;     scaling[0, 2] = 0;     scaling[0, 3] = 0;
            scaling[1, 0] = 0;     scaling[1, 1] = scale; scaling[1, 2] = 0;     scaling[1, 3] = 0;
            scaling[2, 0] = 0;     scaling[2, 1] = 0;     scaling[2, 2] = scale; scaling[2, 3] = 0;
            scaling[3, 0] = 0;     scaling[3, 1] = 0;     scaling[3, 2] = 0;     scaling[3, 3] = 1;
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
    }
}