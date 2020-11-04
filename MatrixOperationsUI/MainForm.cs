using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixOperations;

namespace MatrixOperationsUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private Matrix _firstMatrix = new Matrix(1, 1);
		private Matrix _secondMatrix = new Matrix(1, 1);
		private Matrix _resultMatrix = new Matrix(1, 1);

		private void UpdateDataGridView()
		{
			FirstMatrixDataGridView.RowCount = _firstMatrix.RowСount;
			FirstMatrixDataGridView.ColumnCount = _firstMatrix.СolumnsСount;
			SecondMatrixDataGridView.RowCount = _secondMatrix.RowСount;
			SecondMatrixDataGridView.ColumnCount = _secondMatrix.СolumnsСount;

			for (int i = 0; i < _firstMatrix.RowСount; i++)
			{
				for (int j = 0; j < _firstMatrix.СolumnsСount; j++)
				{
					FirstMatrixDataGridView.Rows[i].Cells[j].Value = _firstMatrix.MatrixElements[i, j];
				}
			}

			for (int i = 0; i < _secondMatrix.RowСount; i++)
			{
				for (int j = 0; j < _secondMatrix.СolumnsСount; j++)
				{
					SecondMatrixDataGridView.Rows[i].Cells[j].Value = _secondMatrix.MatrixElements[i, j];
				}
			}
		}

		private void InputFirstMatrix()
		{
			Random random = new Random();
			for (int i = 0; i < _firstMatrix.RowСount; i++)
			{
				for (int j = 0; j < _firstMatrix.СolumnsСount; j++)
				{
					_firstMatrix.MatrixElements[i, j] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
				}
			}
		}

		private void InputSecondMatrix()
		{
			Random random = new Random();
			for (int i = 0; i < _secondMatrix.RowСount; i++)
			{
				for (int j = 0; j < _secondMatrix.СolumnsСount; j++)
				{
					_secondMatrix.MatrixElements[i, j] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
				}
			}
		}

		private void OutputMatrix()
		{
			for (int i = 0; i < _resultMatrix.RowСount; i++)
			{
				for (int j = 0; j < _resultMatrix.СolumnsСount; j++)
				{
					Console.Write($"{_resultMatrix.MatrixElements[i, j]}\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateDataGridView();
		}

		private void OKButtonFirst_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(RowСountFirstMatrixTextBox.Text, out var row))
			{
				MessageBox.Show("Wrong length", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(ColumsСountFirstMatrixTextBox.Text, out var columns))
			{
				MessageBox.Show("Wrong columns", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_firstMatrix = new Matrix(row, columns);
			InputFirstMatrix();
			UpdateDataGridView();
		}

		private void OKButtonSecond_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(RowСountSecondMatrixTextBox.Text, out var row))
			{
				MessageBox.Show("Wrong length", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(ColumsСountSecondMatrixTextBox.Text, out var columns))
			{
				MessageBox.Show("Wrong columns", "Warning",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_secondMatrix = new Matrix(row, columns);
			InputSecondMatrix();
			UpdateDataGridView();
		}
	}
}
