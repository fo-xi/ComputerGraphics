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

namespace ZAPOLNENIE
{
	public partial class MainForm : Form
	{
		public int xn, yn, xk, yk;

        public Bitmap bitmap;

        public Color colorLine = Color.Black;

        public Color colorFill = Color.Gray;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            DialogResult d = ColorLineDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                colorLine = ColorLineDialog.Color;
            }
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            DialogResult d = ColorFillDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                colorFill = ColorFillDialog.Color;

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (CDARadioButton.Checked || FillRadioButton.Checked)
            {
                xn = e.X;
                yn = e.Y;
            }
            else
            {
                MessageBox.Show("Вы не выбрали алгоритм вывода фигуры!");
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            xk = e.X;
            yk = e.Y;
            using (Graphics g = Graphics.FromHwnd(PictureBox.Handle))
            {
                if (CDARadioButton.Checked)
                {
                    CDA(xn, yn, xk, yk);
                }

                if (FillRadioButton.Checked)
                {
                    Zaliv(xk, yk);
                }
            }

            PictureBox.Image = bitmap;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
        }

        private void FigureButton_Click(object sender, EventArgs e)
        {
            LineColorButton.Enabled = false;
            FigureButton.Enabled = false;
            Point[] points = new Point[]
            {
                new Point(15, 20), //0
                new Point(45, 30), //1
                new Point(75, 20), //2
                new Point(75, 74), //3
                new Point(45, 60), //4
                new Point(15, 74), //5
            };

            using (Graphics g = Graphics.FromHwnd(PictureBox.Handle))
            {
                if (CDARadioButton.Checked)
                {
                    CDA(points[0].X, points[0].Y, points[1].X, points[1].Y);
                    CDA(points[1].X, points[1].Y, points[2].X, points[2].Y);
                    CDA(points[2].X, points[2].Y, points[3].X, points[3].Y);
                    CDA(points[3].X, points[3].Y, points[4].X, points[4].Y);
                    CDA(points[4].X, points[4].Y, points[5].X, points[5].Y);
                    CDA(points[5].X, points[5].Y, points[0].X, points[0].Y);
                }
                PictureBox.Image = bitmap;
            }
            LineColorButton.Enabled = true;
            FigureButton.Enabled = true;
        }

        private void CDA(int x1, int y1, int x2, int y2)
        {
            xn = x1;
            yn = y1;
            xk = x2;
            yk = y2;
            double dx = xk - xn;
            double dy = yk - yn;
            int n = 1000;
            double xt = xn;
            double yt = yn;
            for (int i = 1; i <= n; i++)
            {
                Pen myPen = new Pen(colorLine, 1);
                bitmap.SetPixel((int)xt, (int)yt, colorLine);
                xt = xt + dx / n;
                yt = yt + dy / n;
            }
        }

        private void Zaliv(int x1, int y1)
        {
            if (x1 >= PictureBox.Width || x1 < 0 || y1 >= PictureBox.Height || y1 < 0)
            {
                return;
            }

            Color oldColor = bitmap.GetPixel(x1, y1);

            if ((oldColor.ToArgb() != colorLine.ToArgb()) &&
                (oldColor.ToArgb() != colorFill.ToArgb()))
            {
                bitmap.SetPixel(x1, y1, colorFill);

                Zaliv(x1 + 1, y1);
                Zaliv(x1 - 1, y1);
                Zaliv(x1, y1 + 1);
                Zaliv(x1, y1 - 1);
            }
            else
            {
                return;
            }
        }

        private void PolygonAlgorithm(int firstPointX, int firstPointY, int secondPointX, int secondPointY)
        {

        }
    }
}
