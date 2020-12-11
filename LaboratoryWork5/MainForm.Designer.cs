namespace LaboratoryWork5
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SolidLineRadioButton = new System.Windows.Forms.RadioButton();
            this.DottedLineRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ColorsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ThinLineRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ThickLineRadioButton = new System.Windows.Forms.RadioButton();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DrawFigureButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.XOZRadioButton = new System.Windows.Forms.RadioButton();
            this.YOZRadioButton = new System.Windows.Forms.RadioButton();
            this.XOYRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DrawAxisButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XRightСheckBox = new System.Windows.Forms.CheckBox();
            this.XLeftСheckBox = new System.Windows.Forms.CheckBox();
            this.YUpRadioButton = new System.Windows.Forms.CheckBox();
            this.YDownRadioButton = new System.Windows.Forms.CheckBox();
            this.ZForwardRadioButton = new System.Windows.Forms.CheckBox();
            this.ZBackRadioButton = new System.Windows.Forms.CheckBox();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ScalingTextBox = new System.Windows.Forms.TextBox();
            this.ApplyScalingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(16, 15);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(491, 447);
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
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ColorsComboBox);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(1045, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 446);
            this.panel2.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SolidLineRadioButton);
            this.groupBox5.Controls.Add(this.DottedLineRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(4, 178);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(247, 98);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройка стиля линии";
            // 
            // SolidLineRadioButton
            // 
            this.SolidLineRadioButton.AutoSize = true;
            this.SolidLineRadioButton.Location = new System.Drawing.Point(8, 36);
            this.SolidLineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SolidLineRadioButton.Name = "SolidLineRadioButton";
            this.SolidLineRadioButton.Size = new System.Drawing.Size(141, 21);
            this.SolidLineRadioButton.TabIndex = 7;
            this.SolidLineRadioButton.TabStop = true;
            this.SolidLineRadioButton.Text = "Сплошная линия";
            this.SolidLineRadioButton.UseVisualStyleBackColor = true;
            this.SolidLineRadioButton.CheckedChanged += new System.EventHandler(this.SolidLineRadioButton_CheckedChanged);
            // 
            // DottedLineRadioButton
            // 
            this.DottedLineRadioButton.AutoSize = true;
            this.DottedLineRadioButton.Location = new System.Drawing.Point(8, 66);
            this.DottedLineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DottedLineRadioButton.Name = "DottedLineRadioButton";
            this.DottedLineRadioButton.Size = new System.Drawing.Size(152, 21);
            this.DottedLineRadioButton.TabIndex = 8;
            this.DottedLineRadioButton.TabStop = true;
            this.DottedLineRadioButton.Text = "Пунктирная линия";
            this.DottedLineRadioButton.UseVisualStyleBackColor = true;
            this.DottedLineRadioButton.CheckedChanged += new System.EventHandler(this.DottedLineRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Цвет:";
            // 
            // ColorsComboBox
            // 
            this.ColorsComboBox.FormattingEnabled = true;
            this.ColorsComboBox.Location = new System.Drawing.Point(59, 15);
            this.ColorsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColorsComboBox.Name = "ColorsComboBox";
            this.ColorsComboBox.Size = new System.Drawing.Size(183, 24);
            this.ColorsComboBox.TabIndex = 4;
            this.ColorsComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorsComboBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ThinLineRadioButton);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.ThickLineRadioButton);
            this.groupBox4.Controls.Add(this.WidthTextBox);
            this.groupBox4.Location = new System.Drawing.Point(4, 48);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(247, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройка стиля линии";
            // 
            // ThinLineRadioButton
            // 
            this.ThinLineRadioButton.AutoSize = true;
            this.ThinLineRadioButton.Location = new System.Drawing.Point(8, 92);
            this.ThinLineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ThinLineRadioButton.Name = "ThinLineRadioButton";
            this.ThinLineRadioButton.Size = new System.Drawing.Size(121, 21);
            this.ThinLineRadioButton.TabIndex = 6;
            this.ThinLineRadioButton.TabStop = true;
            this.ThinLineRadioButton.Text = "Тонкая линия";
            this.ThinLineRadioButton.UseVisualStyleBackColor = true;
            this.ThinLineRadioButton.CheckedChanged += new System.EventHandler(this.ThinLineRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Толщина:";
            // 
            // ThickLineRadioButton
            // 
            this.ThickLineRadioButton.AutoSize = true;
            this.ThickLineRadioButton.Location = new System.Drawing.Point(8, 27);
            this.ThickLineRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ThickLineRadioButton.Name = "ThickLineRadioButton";
            this.ThickLineRadioButton.Size = new System.Drawing.Size(128, 21);
            this.ThickLineRadioButton.TabIndex = 4;
            this.ThickLineRadioButton.TabStop = true;
            this.ThickLineRadioButton.Text = "Толстая линия";
            this.ThickLineRadioButton.UseVisualStyleBackColor = true;
            this.ThickLineRadioButton.CheckedChanged += new System.EventHandler(this.ThickLineRadioButton_CheckedChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(91, 57);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(147, 22);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // DrawFigureButton
            // 
            this.DrawFigureButton.Location = new System.Drawing.Point(4, 48);
            this.DrawFigureButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawFigureButton.Name = "DrawFigureButton";
            this.DrawFigureButton.Size = new System.Drawing.Size(247, 28);
            this.DrawFigureButton.TabIndex = 8;
            this.DrawFigureButton.Text = "Нарисовать фигуру";
            this.DrawFigureButton.UseVisualStyleBackColor = true;
            this.DrawFigureButton.Click += new System.EventHandler(this.DrawFigureButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.DrawFigureButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.DrawAxisButton);
            this.panel1.Location = new System.Drawing.Point(515, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 446);
            this.panel1.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.XOZRadioButton);
            this.groupBox6.Controls.Add(this.YOZRadioButton);
            this.groupBox6.Controls.Add(this.XOYRadioButton);
            this.groupBox6.Location = new System.Drawing.Point(4, 120);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(247, 102);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Оси";
            // 
            // XOZRadioButton
            // 
            this.XOZRadioButton.AutoSize = true;
            this.XOZRadioButton.Location = new System.Drawing.Point(7, 76);
            this.XOZRadioButton.Name = "XOZRadioButton";
            this.XOZRadioButton.Size = new System.Drawing.Size(91, 21);
            this.XOZRadioButton.TabIndex = 2;
            this.XOZRadioButton.TabStop = true;
            this.XOZRadioButton.Text = "Ось XOZ ";
            this.XOZRadioButton.UseVisualStyleBackColor = true;
            // 
            // YOZRadioButton
            // 
            this.YOZRadioButton.AutoSize = true;
            this.YOZRadioButton.Location = new System.Drawing.Point(7, 49);
            this.YOZRadioButton.Name = "YOZRadioButton";
            this.YOZRadioButton.Size = new System.Drawing.Size(87, 21);
            this.YOZRadioButton.TabIndex = 1;
            this.YOZRadioButton.TabStop = true;
            this.YOZRadioButton.Text = "Ось YOZ";
            this.YOZRadioButton.UseVisualStyleBackColor = true;
            // 
            // XOYRadioButton
            // 
            this.XOYRadioButton.AutoSize = true;
            this.XOYRadioButton.Location = new System.Drawing.Point(7, 22);
            this.XOYRadioButton.Name = "XOYRadioButton";
            this.XOYRadioButton.Size = new System.Drawing.Size(87, 21);
            this.XOYRadioButton.TabIndex = 0;
            this.XOYRadioButton.TabStop = true;
            this.XOYRadioButton.Text = "Ось XOY";
            this.XOYRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.ShiftButton);
            this.groupBox1.Controls.Add(this.ZBackRadioButton);
            this.groupBox1.Controls.Add(this.ZForwardRadioButton);
            this.groupBox1.Controls.Add(this.YDownRadioButton);
            this.groupBox1.Controls.Add(this.YUpRadioButton);
            this.groupBox1.Controls.Add(this.XLeftСheckBox);
            this.groupBox1.Controls.Add(this.XRightСheckBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(247, 218);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сдвиг";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(4, 84);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(247, 28);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DrawAxisButton
            // 
            this.DrawAxisButton.Location = new System.Drawing.Point(4, 15);
            this.DrawAxisButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawAxisButton.Name = "DrawAxisButton";
            this.DrawAxisButton.Size = new System.Drawing.Size(247, 28);
            this.DrawAxisButton.TabIndex = 8;
            this.DrawAxisButton.Text = "Нарисовать ось";
            this.DrawAxisButton.UseVisualStyleBackColor = true;
            this.DrawAxisButton.Click += new System.EventHandler(this.DrawAxisButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(780, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 446);
            this.panel3.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(4, 230);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(247, 92);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поворот";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ApplyScalingButton);
            this.groupBox3.Controls.Add(this.ScalingTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(4, 226);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(247, 96);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштабирование";
            // 
            // XRightСheckBox
            // 
            this.XRightСheckBox.AutoSize = true;
            this.XRightСheckBox.Location = new System.Drawing.Point(7, 22);
            this.XRightСheckBox.Name = "XRightСheckBox";
            this.XRightСheckBox.Size = new System.Drawing.Size(177, 21);
            this.XRightСheckBox.TabIndex = 0;
            this.XRightСheckBox.Text = "Сдвиг по оси X вправо";
            this.XRightСheckBox.UseVisualStyleBackColor = true;
            // 
            // XLeftСheckBox
            // 
            this.XLeftСheckBox.AutoSize = true;
            this.XLeftСheckBox.Location = new System.Drawing.Point(7, 49);
            this.XLeftСheckBox.Name = "XLeftСheckBox";
            this.XLeftСheckBox.Size = new System.Drawing.Size(169, 21);
            this.XLeftСheckBox.TabIndex = 1;
            this.XLeftСheckBox.Text = "Сдвиг по оси X влево";
            this.XLeftСheckBox.UseVisualStyleBackColor = true;
            // 
            // YUpRadioButton
            // 
            this.YUpRadioButton.AutoSize = true;
            this.YUpRadioButton.Location = new System.Drawing.Point(7, 76);
            this.YUpRadioButton.Name = "YUpRadioButton";
            this.YUpRadioButton.Size = new System.Drawing.Size(167, 21);
            this.YUpRadioButton.TabIndex = 2;
            this.YUpRadioButton.Text = "Сдвиг по оси Y вверх";
            this.YUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // YDownRadioButton
            // 
            this.YDownRadioButton.AutoSize = true;
            this.YDownRadioButton.Location = new System.Drawing.Point(7, 103);
            this.YDownRadioButton.Name = "YDownRadioButton";
            this.YDownRadioButton.Size = new System.Drawing.Size(161, 21);
            this.YDownRadioButton.TabIndex = 3;
            this.YDownRadioButton.Text = "Сдвиг по оси Y вниз";
            this.YDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // ZForwardRadioButton
            // 
            this.ZForwardRadioButton.AutoSize = true;
            this.ZForwardRadioButton.Location = new System.Drawing.Point(7, 130);
            this.ZForwardRadioButton.Name = "ZForwardRadioButton";
            this.ZForwardRadioButton.Size = new System.Drawing.Size(178, 21);
            this.ZForwardRadioButton.TabIndex = 4;
            this.ZForwardRadioButton.Text = "Сдвиг по оси Z вперед";
            this.ZForwardRadioButton.UseVisualStyleBackColor = true;
            // 
            // ZBackRadioButton
            // 
            this.ZBackRadioButton.AutoSize = true;
            this.ZBackRadioButton.Location = new System.Drawing.Point(7, 157);
            this.ZBackRadioButton.Name = "ZBackRadioButton";
            this.ZBackRadioButton.Size = new System.Drawing.Size(170, 21);
            this.ZBackRadioButton.TabIndex = 5;
            this.ZBackRadioButton.Text = "Сдвиг по оси Z назад";
            this.ZBackRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShiftButton
            // 
            this.ShiftButton.Location = new System.Drawing.Point(8, 182);
            this.ShiftButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(108, 28);
            this.ShiftButton.TabIndex = 14;
            this.ShiftButton.Text = "Сдвиг";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(131, 182);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 28);
            this.StartButton.TabIndex = 15;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Масштаб: ";
            // 
            // ScalingTextBox
            // 
            this.ScalingTextBox.Location = new System.Drawing.Point(92, 30);
            this.ScalingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScalingTextBox.Name = "ScalingTextBox";
            this.ScalingTextBox.Size = new System.Drawing.Size(147, 22);
            this.ScalingTextBox.TabIndex = 2;
            // 
            // ApplyScalingButton
            // 
            this.ApplyScalingButton.Location = new System.Drawing.Point(139, 60);
            this.ApplyScalingButton.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyScalingButton.Name = "ApplyScalingButton";
            this.ApplyScalingButton.Size = new System.Drawing.Size(100, 28);
            this.ApplyScalingButton.TabIndex = 4;
            this.ApplyScalingButton.Text = "Применить";
            this.ApplyScalingButton.UseVisualStyleBackColor = true;
            this.ApplyScalingButton.Click += new System.EventHandler(this.ApplyScalingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 476);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.RadioButton DottedLineRadioButton;
        private System.Windows.Forms.RadioButton SolidLineRadioButton;
        private System.Windows.Forms.RadioButton ThinLineRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton ThickLineRadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button DrawFigureButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DrawAxisButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton XOZRadioButton;
        private System.Windows.Forms.RadioButton YOZRadioButton;
        private System.Windows.Forms.RadioButton XOYRadioButton;
        private System.Windows.Forms.CheckBox ZBackRadioButton;
        private System.Windows.Forms.CheckBox ZForwardRadioButton;
        private System.Windows.Forms.CheckBox YDownRadioButton;
        private System.Windows.Forms.CheckBox YUpRadioButton;
        private System.Windows.Forms.CheckBox XLeftСheckBox;
        private System.Windows.Forms.CheckBox XRightСheckBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScalingTextBox;
        private System.Windows.Forms.Button ApplyScalingButton;
    }
}

