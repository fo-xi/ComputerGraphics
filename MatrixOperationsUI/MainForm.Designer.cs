namespace MatrixOperationsUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.OKButtonFirst = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.RowsCountFirstMatrix = new System.Windows.Forms.Label();
			this.ColumsCountFirstMatrix = new System.Windows.Forms.Label();
			this.RowСountFirstMatrixTextBox = new System.Windows.Forms.TextBox();
			this.ColumsСountFirstMatrixTextBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.FirstMatrixDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ResultMatrixDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.SecondMatrixDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.OKButtonSecond = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.RowsCountSecondMatrix = new System.Windows.Forms.Label();
			this.ColumsCountSecondMatrix = new System.Windows.Forms.Label();
			this.RowСountSecondMatrixTextBox = new System.Windows.Forms.TextBox();
			this.ColumsСountSecondMatrixTextBox = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.MultiplicationButton = new System.Windows.Forms.Button();
			this.SubtractionButton = new System.Windows.Forms.Button();
			this.AdditionButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.MultiplyingConstantButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.ConstantLabel = new System.Windows.Forms.Label();
			this.ConstantTextBox = new System.Windows.Forms.TextBox();
			this.MultiplicationVectorsButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FirstMatrixDataGridView)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResultMatrixDataGridView)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SecondMatrixDataGridView)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.OKButtonFirst);
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(16, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(348, 140);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Размер матрицы";
			// 
			// OKButtonFirst
			// 
			this.OKButtonFirst.Location = new System.Drawing.Point(236, 103);
			this.OKButtonFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.OKButtonFirst.Name = "OKButtonFirst";
			this.OKButtonFirst.Size = new System.Drawing.Size(100, 28);
			this.OKButtonFirst.TabIndex = 2;
			this.OKButtonFirst.Text = "OK";
			this.OKButtonFirst.UseVisualStyleBackColor = true;
			this.OKButtonFirst.Click += new System.EventHandler(this.OKButtonFirst_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.20884F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79116F));
			this.tableLayoutPanel1.Controls.Add(this.RowsCountFirstMatrix, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ColumsCountFirstMatrix, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.RowСountFirstMatrixTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.ColumsСountFirstMatrixTextBox, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 23);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 73);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// RowsCountFirstMatrix
			// 
			this.RowsCountFirstMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RowsCountFirstMatrix.AutoSize = true;
			this.RowsCountFirstMatrix.Location = new System.Drawing.Point(4, 9);
			this.RowsCountFirstMatrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.RowsCountFirstMatrix.Name = "RowsCountFirstMatrix";
			this.RowsCountFirstMatrix.Size = new System.Drawing.Size(165, 17);
			this.RowsCountFirstMatrix.TabIndex = 0;
			this.RowsCountFirstMatrix.Text = "Количество строк:";
			// 
			// ColumsCountFirstMatrix
			// 
			this.ColumsCountFirstMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ColumsCountFirstMatrix.AutoSize = true;
			this.ColumsCountFirstMatrix.Location = new System.Drawing.Point(4, 46);
			this.ColumsCountFirstMatrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ColumsCountFirstMatrix.Name = "ColumsCountFirstMatrix";
			this.ColumsCountFirstMatrix.Size = new System.Drawing.Size(165, 17);
			this.ColumsCountFirstMatrix.TabIndex = 1;
			this.ColumsCountFirstMatrix.Text = "Количтество столбцов:";
			// 
			// RowСountFirstMatrixTextBox
			// 
			this.RowСountFirstMatrixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RowСountFirstMatrixTextBox.Location = new System.Drawing.Point(177, 7);
			this.RowСountFirstMatrixTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.RowСountFirstMatrixTextBox.Name = "RowСountFirstMatrixTextBox";
			this.RowСountFirstMatrixTextBox.Size = new System.Drawing.Size(151, 22);
			this.RowСountFirstMatrixTextBox.TabIndex = 2;
			// 
			// ColumsСountFirstMatrixTextBox
			// 
			this.ColumsСountFirstMatrixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ColumsСountFirstMatrixTextBox.Location = new System.Drawing.Point(177, 43);
			this.ColumsСountFirstMatrixTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ColumsСountFirstMatrixTextBox.Name = "ColumsСountFirstMatrixTextBox";
			this.ColumsСountFirstMatrixTextBox.Size = new System.Drawing.Size(151, 22);
			this.ColumsСountFirstMatrixTextBox.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.FirstMatrixDataGridView);
			this.groupBox2.Location = new System.Drawing.Point(372, 15);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(667, 268);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ввод первой матрицы";
			// 
			// FirstMatrixDataGridView
			// 
			this.FirstMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FirstMatrixDataGridView.Location = new System.Drawing.Point(8, 23);
			this.FirstMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FirstMatrixDataGridView.Name = "FirstMatrixDataGridView";
			this.FirstMatrixDataGridView.RowHeadersWidth = 51;
			this.FirstMatrixDataGridView.Size = new System.Drawing.Size(651, 236);
			this.FirstMatrixDataGridView.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ResultMatrixDataGridView);
			this.groupBox3.Location = new System.Drawing.Point(372, 566);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(667, 268);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Результат";
			// 
			// ResultMatrixDataGridView
			// 
			this.ResultMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ResultMatrixDataGridView.Location = new System.Drawing.Point(8, 23);
			this.ResultMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ResultMatrixDataGridView.Name = "ResultMatrixDataGridView";
			this.ResultMatrixDataGridView.RowHeadersWidth = 51;
			this.ResultMatrixDataGridView.Size = new System.Drawing.Size(651, 238);
			this.ResultMatrixDataGridView.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.SecondMatrixDataGridView);
			this.groupBox4.Location = new System.Drawing.Point(372, 290);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox4.Size = new System.Drawing.Size(667, 268);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ввод второй матрицы";
			// 
			// SecondMatrixDataGridView
			// 
			this.SecondMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SecondMatrixDataGridView.Location = new System.Drawing.Point(8, 23);
			this.SecondMatrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.SecondMatrixDataGridView.Name = "SecondMatrixDataGridView";
			this.SecondMatrixDataGridView.RowHeadersWidth = 51;
			this.SecondMatrixDataGridView.Size = new System.Drawing.Size(651, 236);
			this.SecondMatrixDataGridView.TabIndex = 1;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.OKButtonSecond);
			this.groupBox5.Controls.Add(this.tableLayoutPanel2);
			this.groupBox5.Location = new System.Drawing.Point(16, 290);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox5.Size = new System.Drawing.Size(348, 140);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Размер матрицы";
			// 
			// OKButtonSecond
			// 
			this.OKButtonSecond.Location = new System.Drawing.Point(236, 103);
			this.OKButtonSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.OKButtonSecond.Name = "OKButtonSecond";
			this.OKButtonSecond.Size = new System.Drawing.Size(100, 28);
			this.OKButtonSecond.TabIndex = 2;
			this.OKButtonSecond.Text = "OK";
			this.OKButtonSecond.UseVisualStyleBackColor = true;
			this.OKButtonSecond.Click += new System.EventHandler(this.OKButtonSecond_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.20884F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79116F));
			this.tableLayoutPanel2.Controls.Add(this.RowsCountSecondMatrix, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ColumsCountSecondMatrix, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.RowСountSecondMatrixTextBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.ColumsСountSecondMatrixTextBox, 1, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 23);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 73);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// RowsCountSecondMatrix
			// 
			this.RowsCountSecondMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RowsCountSecondMatrix.AutoSize = true;
			this.RowsCountSecondMatrix.Location = new System.Drawing.Point(4, 9);
			this.RowsCountSecondMatrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.RowsCountSecondMatrix.Name = "RowsCountSecondMatrix";
			this.RowsCountSecondMatrix.Size = new System.Drawing.Size(165, 17);
			this.RowsCountSecondMatrix.TabIndex = 0;
			this.RowsCountSecondMatrix.Text = "Количество строк:";
			// 
			// ColumsCountSecondMatrix
			// 
			this.ColumsCountSecondMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ColumsCountSecondMatrix.AutoSize = true;
			this.ColumsCountSecondMatrix.Location = new System.Drawing.Point(4, 46);
			this.ColumsCountSecondMatrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ColumsCountSecondMatrix.Name = "ColumsCountSecondMatrix";
			this.ColumsCountSecondMatrix.Size = new System.Drawing.Size(165, 17);
			this.ColumsCountSecondMatrix.TabIndex = 1;
			this.ColumsCountSecondMatrix.Text = "Количтество столбцов:";
			// 
			// RowСountSecondMatrixTextBox
			// 
			this.RowСountSecondMatrixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.RowСountSecondMatrixTextBox.Location = new System.Drawing.Point(177, 7);
			this.RowСountSecondMatrixTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.RowСountSecondMatrixTextBox.Name = "RowСountSecondMatrixTextBox";
			this.RowСountSecondMatrixTextBox.Size = new System.Drawing.Size(151, 22);
			this.RowСountSecondMatrixTextBox.TabIndex = 2;
			// 
			// ColumsСountSecondMatrixTextBox
			// 
			this.ColumsСountSecondMatrixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ColumsСountSecondMatrixTextBox.Location = new System.Drawing.Point(177, 43);
			this.ColumsСountSecondMatrixTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ColumsСountSecondMatrixTextBox.Name = "ColumsСountSecondMatrixTextBox";
			this.ColumsСountSecondMatrixTextBox.Size = new System.Drawing.Size(151, 22);
			this.ColumsСountSecondMatrixTextBox.TabIndex = 3;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.MultiplicationVectorsButton);
			this.groupBox6.Controls.Add(this.tableLayoutPanel3);
			this.groupBox6.Controls.Add(this.MultiplyingConstantButton);
			this.groupBox6.Controls.Add(this.SaveButton);
			this.groupBox6.Controls.Add(this.MultiplicationButton);
			this.groupBox6.Controls.Add(this.SubtractionButton);
			this.groupBox6.Controls.Add(this.AdditionButton);
			this.groupBox6.Location = new System.Drawing.Point(16, 540);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox6.Size = new System.Drawing.Size(348, 287);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Операции";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(16, 130);
			this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(324, 28);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Сохранить результат";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// MultiplicationButton
			// 
			this.MultiplicationButton.Location = new System.Drawing.Point(16, 95);
			this.MultiplicationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MultiplicationButton.Name = "MultiplicationButton";
			this.MultiplicationButton.Size = new System.Drawing.Size(324, 28);
			this.MultiplicationButton.TabIndex = 2;
			this.MultiplicationButton.Text = "Умножение";
			this.MultiplicationButton.UseVisualStyleBackColor = true;
			this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
			// 
			// SubtractionButton
			// 
			this.SubtractionButton.Location = new System.Drawing.Point(16, 59);
			this.SubtractionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.SubtractionButton.Name = "SubtractionButton";
			this.SubtractionButton.Size = new System.Drawing.Size(324, 28);
			this.SubtractionButton.TabIndex = 1;
			this.SubtractionButton.Text = "Вычитание";
			this.SubtractionButton.UseVisualStyleBackColor = true;
			this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
			// 
			// AdditionButton
			// 
			this.AdditionButton.Location = new System.Drawing.Point(16, 23);
			this.AdditionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.AdditionButton.Name = "AdditionButton";
			this.AdditionButton.Size = new System.Drawing.Size(324, 28);
			this.AdditionButton.TabIndex = 0;
			this.AdditionButton.Text = "Сложение";
			this.AdditionButton.UseVisualStyleBackColor = true;
			this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(252, 504);
			this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(100, 28);
			this.ClearButton.TabIndex = 6;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// MultiplyingConstantButton
			// 
			this.MultiplyingConstantButton.Location = new System.Drawing.Point(16, 166);
			this.MultiplyingConstantButton.Margin = new System.Windows.Forms.Padding(4);
			this.MultiplyingConstantButton.Name = "MultiplyingConstantButton";
			this.MultiplyingConstantButton.Size = new System.Drawing.Size(324, 28);
			this.MultiplyingConstantButton.TabIndex = 4;
			this.MultiplyingConstantButton.Text = "Умножение первой матрицы на константу";
			this.MultiplyingConstantButton.UseVisualStyleBackColor = true;
			this.MultiplyingConstantButton.Click += new System.EventHandler(this.MultiplyingConstantButton_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.20884F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79116F));
			this.tableLayoutPanel3.Controls.Add(this.ConstantLabel, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.ConstantTextBox, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 202);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 35);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// ConstantLabel
			// 
			this.ConstantLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ConstantLabel.AutoSize = true;
			this.ConstantLabel.Location = new System.Drawing.Point(83, 9);
			this.ConstantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ConstantLabel.Name = "ConstantLabel";
			this.ConstantLabel.Size = new System.Drawing.Size(82, 17);
			this.ConstantLabel.TabIndex = 0;
			this.ConstantLabel.Text = "Константа:";
			// 
			// ConstantTextBox
			// 
			this.ConstantTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ConstantTextBox.Location = new System.Drawing.Point(173, 6);
			this.ConstantTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.ConstantTextBox.Name = "ConstantTextBox";
			this.ConstantTextBox.Size = new System.Drawing.Size(147, 22);
			this.ConstantTextBox.TabIndex = 2;
			// 
			// MultiplicationVectorsButton
			// 
			this.MultiplicationVectorsButton.Location = new System.Drawing.Point(16, 245);
			this.MultiplicationVectorsButton.Margin = new System.Windows.Forms.Padding(4);
			this.MultiplicationVectorsButton.Name = "MultiplicationVectorsButton";
			this.MultiplicationVectorsButton.Size = new System.Drawing.Size(324, 28);
			this.MultiplicationVectorsButton.TabIndex = 6;
			this.MultiplicationVectorsButton.Text = "Векторное произведение векторов";
			this.MultiplicationVectorsButton.UseVisualStyleBackColor = true;
			this.MultiplicationVectorsButton.Click += new System.EventHandler(this.MultiplicationVectorsButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 843);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "MatrixOperations";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FirstMatrixDataGridView)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ResultMatrixDataGridView)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SecondMatrixDataGridView)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button OKButtonFirst;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label RowsCountFirstMatrix;
		private System.Windows.Forms.Label ColumsCountFirstMatrix;
		private System.Windows.Forms.TextBox RowСountFirstMatrixTextBox;
		private System.Windows.Forms.TextBox ColumsСountFirstMatrixTextBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView FirstMatrixDataGridView;
		private System.Windows.Forms.DataGridView ResultMatrixDataGridView;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView SecondMatrixDataGridView;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button OKButtonSecond;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label RowsCountSecondMatrix;
		private System.Windows.Forms.Label ColumsCountSecondMatrix;
		private System.Windows.Forms.TextBox RowСountSecondMatrixTextBox;
		private System.Windows.Forms.TextBox ColumsСountSecondMatrixTextBox;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button MultiplicationButton;
		private System.Windows.Forms.Button SubtractionButton;
		private System.Windows.Forms.Button AdditionButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button MultiplicationVectorsButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label ConstantLabel;
		private System.Windows.Forms.TextBox ConstantTextBox;
		private System.Windows.Forms.Button MultiplyingConstantButton;
	}
}

