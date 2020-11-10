namespace Form1
{
	partial class Form1
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
			this.N = new System.Windows.Forms.Label();
			this.SizeTextBox = new System.Windows.Forms.TextBox();
			this.EnteringFirstMatrixButton = new System.Windows.Forms.Button();
			this.EnteringSecondMatrixButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ResultButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// N
			// 
			this.N.AutoSize = true;
			this.N.Location = new System.Drawing.Point(25, 9);
			this.N.Name = "N";
			this.N.Size = new System.Drawing.Size(25, 13);
			this.N.TabIndex = 0;
			this.N.Text = "n = ";
			// 
			// SizeTextBox
			// 
			this.SizeTextBox.Location = new System.Drawing.Point(56, 6);
			this.SizeTextBox.Name = "SizeTextBox";
			this.SizeTextBox.Size = new System.Drawing.Size(100, 20);
			this.SizeTextBox.TabIndex = 1;
			this.SizeTextBox.Leave += new System.EventHandler(this.SizeTextBox_Leave);
			// 
			// EnteringFirstMatrixButton
			// 
			this.EnteringFirstMatrixButton.Location = new System.Drawing.Point(28, 32);
			this.EnteringFirstMatrixButton.Name = "EnteringFirstMatrixButton";
			this.EnteringFirstMatrixButton.Size = new System.Drawing.Size(128, 23);
			this.EnteringFirstMatrixButton.TabIndex = 2;
			this.EnteringFirstMatrixButton.Text = "Ввод матрицы 1 ... ";
			this.EnteringFirstMatrixButton.UseVisualStyleBackColor = true;
			this.EnteringFirstMatrixButton.Click += new System.EventHandler(this.EnteringFirstMatrixButton_Click);
			// 
			// EnteringSecondMatrixButton
			// 
			this.EnteringSecondMatrixButton.Location = new System.Drawing.Point(28, 61);
			this.EnteringSecondMatrixButton.Name = "EnteringSecondMatrixButton";
			this.EnteringSecondMatrixButton.Size = new System.Drawing.Size(128, 23);
			this.EnteringSecondMatrixButton.TabIndex = 3;
			this.EnteringSecondMatrixButton.Text = "Ввод матрицы 2 ...";
			this.EnteringSecondMatrixButton.UseVisualStyleBackColor = true;
			this.EnteringSecondMatrixButton.Click += new System.EventHandler(this.EnteringSecondMatrixButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(174, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// ResultButton
			// 
			this.ResultButton.Location = new System.Drawing.Point(28, 90);
			this.ResultButton.Name = "ResultButton";
			this.ResultButton.Size = new System.Drawing.Size(265, 23);
			this.ResultButton.TabIndex = 6;
			this.ResultButton.Text = "Результат ...";
			this.ResultButton.UseVisualStyleBackColor = true;
			this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(28, 119);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(265, 23);
			this.SaveButton.TabIndex = 7;
			this.SaveButton.Text = "Сохранить в файле \"Res_Matr.txt\"";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 150);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ResultButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EnteringSecondMatrixButton);
			this.Controls.Add(this.EnteringFirstMatrixButton);
			this.Controls.Add(this.SizeTextBox);
			this.Controls.Add(this.N);
			this.MaximumSize = new System.Drawing.Size(334, 189);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(334, 189);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Произведение матриц";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label N;
		private System.Windows.Forms.TextBox SizeTextBox;
		private System.Windows.Forms.Button EnteringFirstMatrixButton;
		private System.Windows.Forms.Button EnteringSecondMatrixButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ResultButton;
		private System.Windows.Forms.Button SaveButton;
	}
}

