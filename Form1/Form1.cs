using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
	public partial class Form1 : Form
	{
		const int MaxN = 10;
		int n = 3;
		TextBox[,] MatrText = null;
		double[,] Matr1 = new double[MaxN, MaxN];
		double[,] Matr2 = new double[MaxN, MaxN];
		double[,] Matr3 = new double[MaxN, MaxN];
		bool f1;
		bool f2;
		int dx = 40, dy = 20;
		Form2 form2 = null;

		private void Form1_Load(object sender, EventArgs e)
		{
			SizeTextBox.Text = "";
			f1 = f2 = false;
			label1.Text = "false";
			label2.Text = "false";

			int i, j;

			form2 = new Form2();
			MatrText = new TextBox[MaxN, MaxN];

			for (i = 0; i < MaxN; i++)
			{
				for (j = 0; j < MaxN; j++)
				{
					MatrText[i, j] = new TextBox();

					MatrText[i, j].Text = "0";

					MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);

					MatrText[i, j].Size = new System.Drawing.Size(dx, dy);

					MatrText[i, j].Visible = false;

					form2.Controls.Add(MatrText[i, j]);
				}
			}
		}

		private void Clear_MatrText()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					MatrText[i, j].Text = "0";
				}
			}
		}

		private void EnteringFirstMatrixButton_Click(object sender, EventArgs e)
		{
			if (SizeTextBox.Text == "")
			{
				return;
			}
			n = int.Parse(SizeTextBox.Text);

			Clear_MatrText();

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					MatrText[i, j].TabIndex = i * n + j + 1;

					MatrText[i, j].Visible = true;
				}
			}

			form2.Width = 10 + n * dx + 20;
			form2.Height = 10 + n * dy + form2.OKButton.Height + 50;

			form2.OKButton.Left = 10;
			form2.OKButton.Top = 10 + n * dy + 10;
			form2.OKButton.Width = form2.Width - 30;

			if (form2.ShowDialog() == DialogResult.OK)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (MatrText[i, j].Text != "")
						{
							Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
						}
						else
						{
							Matr1[i, j] = 0;
						}
					}

					f1 = true;
					label1.Text = "true";
				}
			}
		}

		private void EnteringSecondMatrixButton_Click(object sender, EventArgs e)
		{
			if (SizeTextBox.Text == "") return;
			n = int.Parse(SizeTextBox.Text);

			Clear_MatrText();

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					MatrText[i, j].TabIndex = i * n + j + 1;

					MatrText[i, j].Visible = true;
				}
			}

			form2.Width = 10 + n * dx + 20;
			form2.Height = 10 + n * dy + form2.OKButton.Height + 50;

			form2.OKButton.Left = 10;
			form2.OKButton.Top = 10 + n * dy + 10;
			form2.OKButton.Width = form2.Width - 30;

			if (form2.ShowDialog() == DialogResult.OK)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						Matr2[i, j] = Double.Parse(MatrText[i, j].Text);
					}
					f2 = true;
					label2.Text = "true";
				}
			}
		}

		private void SizeTextBox_Leave(object sender, EventArgs e)
		{
			int nn;
			nn = Int16.Parse(SizeTextBox.Text);
			if (nn != n)
			{
				f1 = f2 = false;
				label1.Text = "false";
				label2.Text = "false";
			}
		}

		private void ResultButton_Click(object sender, EventArgs e)
		{
			if (!((f1 == true) && (f2 == true)))
			{
				return;
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Matr3[j, i] = 0;
					for (int k = 0; k < n; k++)
					{
						Matr3[j, i] = Matr3[j, i] + Matr1[k, i] * Matr2[j, k];
					}
				}
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					MatrText[i, j].TabIndex = i * n + j + 1;

					MatrText[i, j].Text = Matr3[i, j].ToString();
				}
			}

			form2.ShowDialog();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			FileStream fw = null;
			string msg;
			byte[] msgByte = null; 

			fw = new FileStream("Res_Matr.txt", FileMode.Create);

			msg = n.ToString() + "\r\n";

			msgByte = Encoding.Default.GetBytes(msg);

			fw.Write(msgByte, 0, msgByte.Length);

			msg = "";
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					msg = msg + Matr3[i, j].ToString() + "  ";
				}

				msg = msg + "\r\n";
			}

			msgByte = Encoding.Default.GetBytes(msg);

			fw.Write(msgByte, 0, msgByte.Length);

			if (fw != null)
			{
				fw.Close();
			}
		}

		public Form1()
		{
			InitializeComponent();
		}
	}
}
