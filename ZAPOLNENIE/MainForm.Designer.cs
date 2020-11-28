
namespace ZAPOLNENIE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClippingButton = new System.Windows.Forms.Button();
            this.SceneButton = new System.Windows.Forms.Button();
            this.BypassButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.FigureButton = new System.Windows.Forms.Button();
            this.FillColorButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FillRadioButton = new System.Windows.Forms.RadioButton();
            this.CDARadioButton = new System.Windows.Forms.RadioButton();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ColorLineDialog = new System.Windows.Forms.ColorDialog();
            this.ColorFillDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ClippingButton);
            this.panel1.Controls.Add(this.SceneButton);
            this.panel1.Controls.Add(this.BypassButton);
            this.panel1.Controls.Add(this.FillButton);
            this.panel1.Controls.Add(this.FigureButton);
            this.panel1.Controls.Add(this.FillColorButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.LineColorButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(386, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 378);
            this.panel1.TabIndex = 0;
            // 
            // ClippingButton
            // 
            this.ClippingButton.Location = new System.Drawing.Point(3, 169);
            this.ClippingButton.Name = "ClippingButton";
            this.ClippingButton.Size = new System.Drawing.Size(185, 23);
            this.ClippingButton.TabIndex = 15;
            this.ClippingButton.Text = "Отсечение";
            this.ClippingButton.UseVisualStyleBackColor = true;
            this.ClippingButton.Click += new System.EventHandler(this.ClippingButton_Click);
            // 
            // SceneButton
            // 
            this.SceneButton.Location = new System.Drawing.Point(3, 141);
            this.SceneButton.Name = "SceneButton";
            this.SceneButton.Size = new System.Drawing.Size(185, 23);
            this.SceneButton.TabIndex = 14;
            this.SceneButton.Text = "Сцена фигур";
            this.SceneButton.UseVisualStyleBackColor = true;
            this.SceneButton.Click += new System.EventHandler(this.SceneButton_Click);
            // 
            // BypassButton
            // 
            this.BypassButton.Location = new System.Drawing.Point(3, 112);
            this.BypassButton.Name = "BypassButton";
            this.BypassButton.Size = new System.Drawing.Size(185, 23);
            this.BypassButton.TabIndex = 13;
            this.BypassButton.Text = "Обход контура";
            this.BypassButton.UseVisualStyleBackColor = true;
            this.BypassButton.Click += new System.EventHandler(this.BypassButton_Click);
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(3, 233);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(185, 23);
            this.FillButton.TabIndex = 12;
            this.FillButton.Text = "Заполнение по алгоритму";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FigureButton
            // 
            this.FigureButton.Location = new System.Drawing.Point(3, 321);
            this.FigureButton.Name = "FigureButton";
            this.FigureButton.Size = new System.Drawing.Size(185, 23);
            this.FigureButton.TabIndex = 11;
            this.FigureButton.Text = "Фигура";
            this.FigureButton.UseVisualStyleBackColor = true;
            this.FigureButton.Click += new System.EventHandler(this.FigureButton_Click);
            // 
            // FillColorButton
            // 
            this.FillColorButton.Location = new System.Drawing.Point(3, 292);
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Size = new System.Drawing.Size(185, 23);
            this.FillColorButton.TabIndex = 10;
            this.FillColorButton.Text = "Цвет заливки";
            this.FillColorButton.UseVisualStyleBackColor = true;
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(3, 350);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(185, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LineColorButton
            // 
            this.LineColorButton.Location = new System.Drawing.Point(3, 262);
            this.LineColorButton.Name = "LineColorButton";
            this.LineColorButton.Size = new System.Drawing.Size(185, 23);
            this.LineColorButton.TabIndex = 8;
            this.LineColorButton.Text = "Цвет линии";
            this.LineColorButton.UseVisualStyleBackColor = true;
            this.LineColorButton.Click += new System.EventHandler(this.LineColorButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FillRadioButton);
            this.groupBox1.Controls.Add(this.CDARadioButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите алгоритм";
            // 
            // FillRadioButton
            // 
            this.FillRadioButton.AutoSize = true;
            this.FillRadioButton.Location = new System.Drawing.Point(6, 68);
            this.FillRadioButton.Name = "FillRadioButton";
            this.FillRadioButton.Size = new System.Drawing.Size(68, 17);
            this.FillRadioButton.TabIndex = 1;
            this.FillRadioButton.TabStop = true;
            this.FillRadioButton.Text = "Заливка";
            this.FillRadioButton.UseVisualStyleBackColor = true;
            // 
            // CDARadioButton
            // 
            this.CDARadioButton.AutoSize = true;
            this.CDARadioButton.Location = new System.Drawing.Point(6, 30);
            this.CDARadioButton.Name = "CDARadioButton";
            this.CDARadioButton.Size = new System.Drawing.Size(99, 17);
            this.CDARadioButton.TabIndex = 0;
            this.CDARadioButton.TabStop = true;
            this.CDARadioButton.Text = "Обычный ЦДА";
            this.CDARadioButton.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(368, 378);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 401);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Генерация отрезков";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RadioButton FillRadioButton;
        private System.Windows.Forms.RadioButton CDARadioButton;
        private System.Windows.Forms.Button LineColorButton;
        private System.Windows.Forms.ColorDialog ColorLineDialog;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button FillColorButton;
        private System.Windows.Forms.ColorDialog ColorFillDialog;
        private System.Windows.Forms.Button FigureButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button BypassButton;
        private System.Windows.Forms.Button SceneButton;
        private System.Windows.Forms.Button ClippingButton;
    }
}

