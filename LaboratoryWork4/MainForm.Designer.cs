namespace LaboratoryWork4
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
            this.components = new System.ComponentModel.Container();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DottedLineStepTextBox = new System.Windows.Forms.TextBox();
            this.SolidLineRadioButton = new System.Windows.Forms.RadioButton();
            this.DottedLineRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ColorsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ThinLineRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ThickLineRadioButton = new System.Windows.Forms.RadioButton();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DrawFigureButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OYUpButton = new System.Windows.Forms.Button();
            this.OYDownButton = new System.Windows.Forms.Button();
            this.OXLeftButton = new System.Windows.Forms.Button();
            this.OXRightButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DrawAxisButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(368, 363);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ColorsComboBox);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(784, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 363);
            this.panel2.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(3, 256);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 56);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сдвиг по оси OY вправо";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DottedLineStepTextBox);
            this.groupBox5.Controls.Add(this.SolidLineRadioButton);
            this.groupBox5.Controls.Add(this.DottedLineRadioButton);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(3, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 105);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройка стиля линии";
            // 
            // DottedLineStepTextBox
            // 
            this.DottedLineStepTextBox.Location = new System.Drawing.Point(91, 77);
            this.DottedLineStepTextBox.Name = "DottedLineStepTextBox";
            this.DottedLineStepTextBox.Size = new System.Drawing.Size(88, 20);
            this.DottedLineStepTextBox.TabIndex = 10;
            this.DottedLineStepTextBox.TextChanged += new System.EventHandler(this.DottedLineStepTextBox_TextChanged);
            // 
            // SolidLineRadioButton
            // 
            this.SolidLineRadioButton.AutoSize = true;
            this.SolidLineRadioButton.Location = new System.Drawing.Point(6, 29);
            this.SolidLineRadioButton.Name = "SolidLineRadioButton";
            this.SolidLineRadioButton.Size = new System.Drawing.Size(109, 17);
            this.SolidLineRadioButton.TabIndex = 7;
            this.SolidLineRadioButton.TabStop = true;
            this.SolidLineRadioButton.Text = "Сплошная линия";
            this.SolidLineRadioButton.UseVisualStyleBackColor = true;
            this.SolidLineRadioButton.CheckedChanged += new System.EventHandler(this.SolidLineRadioButton_CheckedChanged);
            // 
            // DottedLineRadioButton
            // 
            this.DottedLineRadioButton.AutoSize = true;
            this.DottedLineRadioButton.Location = new System.Drawing.Point(6, 54);
            this.DottedLineRadioButton.Name = "DottedLineRadioButton";
            this.DottedLineRadioButton.Size = new System.Drawing.Size(118, 17);
            this.DottedLineRadioButton.TabIndex = 8;
            this.DottedLineRadioButton.TabStop = true;
            this.DottedLineRadioButton.Text = "Пунктирная линия";
            this.DottedLineRadioButton.UseVisualStyleBackColor = true;
            this.DottedLineRadioButton.CheckedChanged += new System.EventHandler(this.DottedLineRadioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Шаг пунктира:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Цвет:";
            // 
            // ColorsComboBox
            // 
            this.ColorsComboBox.FormattingEnabled = true;
            this.ColorsComboBox.Location = new System.Drawing.Point(44, 12);
            this.ColorsComboBox.Name = "ColorsComboBox";
            this.ColorsComboBox.Size = new System.Drawing.Size(138, 21);
            this.ColorsComboBox.TabIndex = 4;
            this.ColorsComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorsComboBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ThinLineRadioButton);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.ThickLineRadioButton);
            this.groupBox4.Controls.Add(this.WidthTextBox);
            this.groupBox4.Location = new System.Drawing.Point(3, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройка стиля линии";
            // 
            // ThinLineRadioButton
            // 
            this.ThinLineRadioButton.AutoSize = true;
            this.ThinLineRadioButton.Location = new System.Drawing.Point(6, 75);
            this.ThinLineRadioButton.Name = "ThinLineRadioButton";
            this.ThinLineRadioButton.Size = new System.Drawing.Size(95, 17);
            this.ThinLineRadioButton.TabIndex = 6;
            this.ThinLineRadioButton.TabStop = true;
            this.ThinLineRadioButton.Text = "Тонкая линия";
            this.ThinLineRadioButton.UseVisualStyleBackColor = true;
            this.ThinLineRadioButton.CheckedChanged += new System.EventHandler(this.ThinLineRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Толщина:";
            // 
            // ThickLineRadioButton
            // 
            this.ThickLineRadioButton.AutoSize = true;
            this.ThickLineRadioButton.Location = new System.Drawing.Point(6, 22);
            this.ThickLineRadioButton.Name = "ThickLineRadioButton";
            this.ThickLineRadioButton.Size = new System.Drawing.Size(100, 17);
            this.ThickLineRadioButton.TabIndex = 4;
            this.ThickLineRadioButton.TabStop = true;
            this.ThickLineRadioButton.Text = "Толстая линия";
            this.ThickLineRadioButton.UseVisualStyleBackColor = true;
            this.ThickLineRadioButton.CheckedChanged += new System.EventHandler(this.ThickLineRadioButton_CheckedChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(68, 46);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(111, 20);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // DrawFigureButton
            // 
            this.DrawFigureButton.Location = new System.Drawing.Point(3, 39);
            this.DrawFigureButton.Name = "DrawFigureButton";
            this.DrawFigureButton.Size = new System.Drawing.Size(185, 23);
            this.DrawFigureButton.TabIndex = 8;
            this.DrawFigureButton.Text = "Нарисовать фигуру";
            this.DrawFigureButton.UseVisualStyleBackColor = true;
            this.DrawFigureButton.Click += new System.EventHandler(this.DrawFigureButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DrawFigureButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.DrawAxisButton);
            this.panel1.Location = new System.Drawing.Point(386, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 363);
            this.panel1.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(3, 244);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(70, 23);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OYUpButton);
            this.groupBox1.Controls.Add(this.OYDownButton);
            this.groupBox1.Controls.Add(this.OXLeftButton);
            this.groupBox1.Controls.Add(this.OXRightButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 141);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сдвиг";
            // 
            // OYUpButton
            // 
            this.OYUpButton.Location = new System.Drawing.Point(6, 106);
            this.OYUpButton.Name = "OYUpButton";
            this.OYUpButton.Size = new System.Drawing.Size(173, 23);
            this.OYUpButton.TabIndex = 14;
            this.OYUpButton.Text = "Сдвиг по оси OY вверх";
            this.OYUpButton.UseVisualStyleBackColor = true;
            this.OYUpButton.Click += new System.EventHandler(this.OYUpButton_Click);
            // 
            // OYDownButton
            // 
            this.OYDownButton.Location = new System.Drawing.Point(6, 77);
            this.OYDownButton.Name = "OYDownButton";
            this.OYDownButton.Size = new System.Drawing.Size(173, 23);
            this.OYDownButton.TabIndex = 13;
            this.OYDownButton.Text = "Сдвиг по оси OY вниз";
            this.OYDownButton.UseVisualStyleBackColor = true;
            this.OYDownButton.Click += new System.EventHandler(this.OYDownButton_Click);
            // 
            // OXLeftButton
            // 
            this.OXLeftButton.Location = new System.Drawing.Point(6, 48);
            this.OXLeftButton.Name = "OXLeftButton";
            this.OXLeftButton.Size = new System.Drawing.Size(173, 23);
            this.OXLeftButton.TabIndex = 12;
            this.OXLeftButton.Text = "Сдвиг по оси ОХ влево";
            this.OXLeftButton.UseVisualStyleBackColor = true;
            this.OXLeftButton.Click += new System.EventHandler(this.OXLeftButton_Click);
            // 
            // OXRightButton
            // 
            this.OXRightButton.Location = new System.Drawing.Point(6, 19);
            this.OXRightButton.Name = "OXRightButton";
            this.OXRightButton.Size = new System.Drawing.Size(173, 23);
            this.OXRightButton.TabIndex = 11;
            this.OXRightButton.Text = "Сдвиг по оси ОХ вправо";
            this.OXRightButton.UseVisualStyleBackColor = true;
            this.OXRightButton.Click += new System.EventHandler(this.OXRightButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(3, 68);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(185, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DrawAxisButton
            // 
            this.DrawAxisButton.Location = new System.Drawing.Point(3, 12);
            this.DrawAxisButton.Name = "DrawAxisButton";
            this.DrawAxisButton.Size = new System.Drawing.Size(185, 23);
            this.DrawAxisButton.TabIndex = 8;
            this.DrawAxisButton.Text = "Нарисовать ось";
            this.DrawAxisButton.UseVisualStyleBackColor = true;
            this.DrawAxisButton.Click += new System.EventHandler(this.DrawAxisButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(585, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 363);
            this.panel3.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 141);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Преобразования над фигурой";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 387);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PictureBox);
            this.Name = "MainForm";
            this.Text = "Генерация отрезков";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ColorsComboBox;
        private System.Windows.Forms.TextBox DottedLineStepTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton DottedLineRadioButton;
        private System.Windows.Forms.RadioButton SolidLineRadioButton;
        private System.Windows.Forms.RadioButton ThinLineRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton ThickLineRadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button DrawFigureButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DrawAxisButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OYUpButton;
        private System.Windows.Forms.Button OYDownButton;
        private System.Windows.Forms.Button OXLeftButton;
        private System.Windows.Forms.Button OXRightButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

