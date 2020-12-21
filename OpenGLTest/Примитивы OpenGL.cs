using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace OpenGLTest
{
    public partial class Form1 : Form
    {
        public bool f;

        public float angle = 0;

        public int number = 0;

        public float[] mtClr = { 0, 1, 0, 0 };

        public float[] light_position = { 10, 10, -30, 0 };

        public bool isSelected = true;

        public Form1()
        {
            InitializeComponent();

            Pr.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gl.glClearColor(0, 0, 0, 1);
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE |
                                     Glut.GLUT_DEPTH);
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            List<string> colors = new List<string> { "Yellow", "Pink", "Red", "Blue" };
            ColorComboBox.DataSource = colors;
        }

        private void ShowSolid(int obj)
        {
            switch (obj)
            {
                // Конус
                case 1:
                {
                    Glut.glutSolidCone(0.2, 0.75, 16, 8); 
                    break; 
                }

                // Куб
                case 2:
                {
                    Glut.glutSolidCube(0.75);
                    break;
                }

                //Цилиндр
                case 3:
                {
                    Glut.glutSolidCylinder(0.2, 0.75, 16, 16);
                    break;
                }

                // Додекаэдр
                case 4:
                {
                    Gl.glScaled(0.5, 0.5, 0.5);
                    Glut.glutSolidDodecahedron();
                    break;
                }

                // Икосаэдр
                case 5:
                {
                    Glut.glutSolidIcosahedron();
                    break;
                }

                // Октаэдр
                case 6:
                {
                    Glut.glutSolidOctahedron();
                    break;
                }

                // Ромбический додекаэдр
                case 7:
                {
                    Glut.glutSolidRhombicDodecahedron();
                    break;
                }

                //Фрактал Губка Серпиского
                case 8:
                {
                    double[] offset = {0.0};
                    Glut.glutSolidSierpinskiSponge(7, offset, 1);
                    break;
                }

                // Сфера
                case 9:
                {
                    Glut.glutSolidSphere(0.75, 16, 16);
                    break;
                }

                // Чайник
                case 10:
                {
                    Glut.glutSolidTeapot(0.5);
                    break;
                }

                // Тетраэдр
                case 11:
                {
                    Gl.glRotated(180, 0, 1, 0);
                    Glut.glutSolidTetrahedron();
                    break;
                }

                // Тор
                case 12:
                {
                    Glut.glutSolidTorus(0.15, 0.65, 16, 16);
                    break;
                } 
            }
        }

        private void Draw(int obj, float angle = 30)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_ACCUM_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glRotated(angle, 0, 1, 0);
            Gl.glRotated(0, 1, 0, 0);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            if (WireRadioButton.Checked)
            {
                Gl.glColor3f(1, 1, 1);

                switch (obj)
                {
                    // Конус
                    case 1:
                    {
                        Glut.glutWireCone(0.2, 0.75, 16, 8);
                        break;
                    }

                    // Куб
                    case 2:
                    {
                        Glut.glutWireCube(0.75);
                        break;
                    }

                    //Цилиндр
                    case 3:
                    {
                        Glut.glutWireCylinder(0.2, 0.75, 16, 16);
                        break;
                    }

                    // Додекаэдр
                    case 4:
                    {
                        Gl.glScaled(0.5, 0.5, 0.5);
                        Glut.glutWireDodecahedron();
                        break;
                    }

                    // Икосаэдр
                    case 5:
                    {
                        Glut.glutWireIcosahedron();
                        break;
                    }

                    // Октаэдр
                    case 6:
                    {
                        Glut.glutWireOctahedron();
                        break;
                    }

                    //Ромбический додекаэдр
                    case 7:
                    {
                        Glut.glutWireRhombicDodecahedron();
                        break;
                    }

                    //Фрактал Губка Серпиского
                    case 8:
                    {
                        double[] offset = {0, 0, 0};
                        Glut.glutWireSierpinskiSponge(7, offset, 1);
                        break;
                    }

                    // Сфера
                    case 9:
                    {
                        Glut.glutWireSphere(0.75, 16, 16);
                        break;
                    }

                    // Чайник
                    case 10:
                    {
                        Glut.glutWireTeapot(0.5);
                        break;
                    }

                    // Тетраэдр
                    case 11:
                    {
                        Gl.glRotated(180, 0, 1, 0);
                        Glut.glutWireTetrahedron();
                        break;
                    }

                    // Тор
                    case 12:
                    {
                        Glut.glutWireTorus(0.15, 0.65, 16, 16);
                        break;
                    } 
                }
            }
            else if (SolidRadioButton.Checked)
            {
                float[] lghtClr = { 1, 1, 1, 0 };
                
                Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL);
                Gl.glShadeModel(Gl.GL_SMOOTH);
                Gl.glEnable(Gl.GL_LIGHTING);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, lghtClr); 
                Gl.glEnable(Gl.GL_LIGHT0);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, mtClr);
                ShowSolid(obj);
                Gl.glDisable(Gl.GL_LIGHTING);
            }
            Pr.Invalidate();
        }

        private void ConeButton_Click(object sender, EventArgs e)
        {
            Draw(1);
            number = 1;
        }

        private void CubeButton_Click(object sender, EventArgs e)
        {
            Draw(2);
            number = 2;
        }

        private void CylinderButton_Click(object sender, EventArgs e)
        {
            Draw(3);
            number = 3;
        }

        private void DodecahedronButton_Click(object sender, EventArgs e)
        {
            Draw(4);
            number = 4;
        }

        private void IcosahedronButton_Click(object sender, EventArgs e)
        {
            Draw(5);
            number = 5;
        }

        private void OctahedronButton_Click(object sender, EventArgs e)
        {
            Draw(6);
            number = 6;
        }

        private void RhombicButton_Click(object sender, EventArgs e)
        {
            Draw(7);
            number = 7;
        }

        private void SierpinskiButton_Click(object sender, EventArgs e)
        {
            Draw(8);
            number = 8;
        }

        private void SphereButton_Click(object sender, EventArgs e)
        {
            Draw(9);
            number = 9;
        }

        private void TeapotButton_Click(object sender, EventArgs e)
        {
            Draw(10);
            number = 10;
        }

        private void TetrahedronButton_Click(object sender, EventArgs e)
        {
            Draw(11);
            number = 11;
        }

        private void TorusButton_Click(object sender, EventArgs e)
        {
            Draw(12);
            number = 12;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            StartButton.Text = "Stop";
            if (f)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                StartButton.Text = "Start";
            }
            f = !f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 10;
            Draw(number, angle);
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColorComboBox.SelectedIndex)
            {
                case 0:
                {
                    mtClr = new float[] { 1, 1, 0, 0 };
                    break;
                }
                case 1:
                {
                    mtClr = new float[] { 1, 0, 1, 0 };
                    break;
                }
                case 2:
                {
                    mtClr = new float[] { 1, 0, 0, 0 };
                    break;
                }
                case 3:
                {
                    mtClr = new float[] { 0, 0, 1, 0 };
                    break;
                }
            }

            Draw(number);
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                light_position = new float[] { -10, -10, 30, 0 };
            }
            else
            {
                light_position = new float[] { 10, 10, -30, 0 };
            }

            isSelected = !isSelected;
            Draw(number);
        }
    }
}
