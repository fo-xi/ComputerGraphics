using System;
using System.Text;
using System.Windows.Forms;
using MatrixOperations;
using System.IO;

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
			FirstMatrixDataGridView.RowCount = _firstMatrix.RowsСount;
			FirstMatrixDataGridView.ColumnCount = _firstMatrix.СolumnsСount;
			SecondMatrixDataGridView.RowCount = _secondMatrix.RowsСount;
			SecondMatrixDataGridView.ColumnCount = _secondMatrix.СolumnsСount;
			ResultMatrixDataGridView.RowCount = _resultMatrix.RowsСount;
			ResultMatrixDataGridView.ColumnCount = _resultMatrix.СolumnsСount;

			for (int i = 0; i < _firstMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _firstMatrix.СolumnsСount; j++)
				{
					FirstMatrixDataGridView.Rows[i].Cells[j].Value = _firstMatrix.MatrixElements[i, j];
				}
			}

			for (int i = 0; i < _secondMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _secondMatrix.СolumnsСount; j++)
				{
					SecondMatrixDataGridView.Rows[i].Cells[j].Value = _secondMatrix.MatrixElements[i, j];
				}
			}

			for (int i = 0; i < _resultMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _resultMatrix.СolumnsСount; j++)
				{
					ResultMatrixDataGridView.Rows[i].Cells[j].Value = _resultMatrix.MatrixElements[i, j];
				}
			}
		}

		private void AdditionButton_Click(object sender, EventArgs e)
		{
			if ((_firstMatrix.RowsСount != _secondMatrix.RowsСount) ||
			    (_firstMatrix.СolumnsСount != _secondMatrix.СolumnsСount))
			{
				MessageBox.Show("Matrix sizes must be the same", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_resultMatrix = new Matrix(_firstMatrix.RowsСount, _firstMatrix.СolumnsСount);
			for (int i = 0; i < _firstMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _firstMatrix.СolumnsСount; j++)
				{
					_resultMatrix.MatrixElements[i, j] = 
						_firstMatrix.MatrixElements[i, j] + _secondMatrix.MatrixElements[i, j];
				}
			}

			UpdateDataGridView();
		}

		private void SubtractionButton_Click(object sender, EventArgs e)
		{
			if ((_firstMatrix.RowsСount != _secondMatrix.RowsСount) ||
			    (_firstMatrix.СolumnsСount != _secondMatrix.СolumnsСount))
			{
				MessageBox.Show("Matrix sizes must be the same", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_resultMatrix = new Matrix(_firstMatrix.RowsСount, _firstMatrix.СolumnsСount);
			for (int i = 0; i < _firstMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _firstMatrix.СolumnsСount; j++)
				{
					_resultMatrix.MatrixElements[i, j] =
						_firstMatrix.MatrixElements[i, j] - _secondMatrix.MatrixElements[i, j];
				}
			}

			UpdateDataGridView();
		}

		private void MultiplicationButton_Click(object sender, EventArgs e)
		{
			if (_firstMatrix.СolumnsСount != _secondMatrix.RowsСount)
			{
				MessageBox.Show("The number of columns in the " +
				                "first matrix must be equal to the" +
				                " number of rows in the second matrix.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_resultMatrix = new Matrix(_firstMatrix.RowsСount, _secondMatrix.СolumnsСount);

			for (int i = 0; i < _firstMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _secondMatrix.СolumnsСount; j++)
				{
					_resultMatrix.MatrixElements[i, j] = 0;

					for (int k = 0; k < _firstMatrix.СolumnsСount; k++)
					{
						_resultMatrix.MatrixElements[i, j] +=
							_firstMatrix.MatrixElements[i, k] * _secondMatrix.MatrixElements[k, j];
					}
				}
			}

			UpdateDataGridView();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			FileStream fw = null;
			string msg;
			byte[] msgByte = null;

			fw = new FileStream("Res_Matr.txt", FileMode.Create);

			msg = "Rows count = " + _firstMatrix.RowsСount +
				  "\tСolumns count = " + _secondMatrix.СolumnsСount + "\r\n";

			msgByte = Encoding.Default.GetBytes(msg);

			fw.Write(msgByte, 0, msgByte.Length);

			msg = "";
			for (int i = 0; i < _firstMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _secondMatrix.СolumnsСount; j++)
				{
					msg = msg + _resultMatrix.MatrixElements[i, j].ToString() + "  ";
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

		private void InputFirstMatrix()
		{
			Random random = new Random();
			for (int i = 0; i < _firstMatrix.RowsСount; i++)
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
			for (int i = 0; i < _secondMatrix.RowsСount; i++)
			{
				for (int j = 0; j < _secondMatrix.СolumnsСount; j++)
				{
					_secondMatrix.MatrixElements[i, j] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
				}
			}
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
