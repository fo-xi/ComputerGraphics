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
            this.ShiftButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OYUpRadioButton = new System.Windows.Forms.RadioButton();
            this.OXLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.OYDownRadioButton = new System.Windows.Forms.RadioButton();
            this.OXRightRadioButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DrawAxisButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ApplyAngleButton = new System.Windows.Forms.Button();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.X0ReflectionButton = new System.Windows.Forms.Button();
            this.Y0ReflectionButton = new System.Windows.Forms.Button();
            this.YXReflectionButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ApplyScalingButton = new System.Windows.Forms.Button();
            this.ScalingTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BicycleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(16, 15);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 446);
            this.panel2.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SolidLineRadioButton);
            this.groupBox5.Controls.Add(this.DottedLineRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(4, 178);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(247, 98);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройка стиля линии";
            // 
            // SolidLineRadioButton
            // 
            this.SolidLineRadioButton.AutoSize = true;
            this.SolidLineRadioButton.Location = new System.Drawing.Point(8, 36);
            this.SolidLineRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.DottedLineRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ColorsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(247, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройка стиля линии";
            // 
            // ThinLineRadioButton
            // 
            this.ThinLineRadioButton.AutoSize = true;
            this.ThinLineRadioButton.Location = new System.Drawing.Point(8, 92);
            this.ThinLineRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ThickLineRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(147, 22);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // DrawFigureButton
            // 
            this.DrawFigureButton.Location = new System.Drawing.Point(4, 48);
            this.DrawFigureButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel1.Controls.Add(this.BicycleButton);
            this.panel1.Controls.Add(this.ShiftButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DrawFigureButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.DrawAxisButton);
            this.panel1.Location = new System.Drawing.Point(515, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 446);
            this.panel1.TabIndex = 3;
            // 
            // ShiftButton
            // 
            this.ShiftButton.Location = new System.Drawing.Point(12, 273);
            this.ShiftButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(108, 28);
            this.ShiftButton.TabIndex = 13;
            this.ShiftButton.Text = "Сдвиг";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(128, 273);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 28);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OYUpRadioButton);
            this.groupBox1.Controls.Add(this.OXLeftRadioButton);
            this.groupBox1.Controls.Add(this.OYDownRadioButton);
            this.groupBox1.Controls.Add(this.OXRightRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(4, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(247, 146);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сдвиг";
            // 
            // OYUpRadioButton
            // 
            this.OYUpRadioButton.AutoSize = true;
            this.OYUpRadioButton.Location = new System.Drawing.Point(8, 116);
            this.OYUpRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OYUpRadioButton.Name = "OYUpRadioButton";
            this.OYUpRadioButton.Size = new System.Drawing.Size(177, 21);
            this.OYUpRadioButton.TabIndex = 2;
            this.OYUpRadioButton.TabStop = true;
            this.OYUpRadioButton.Text = "Сдвиг по оси OY вверх";
            this.OYUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // OXLeftRadioButton
            // 
            this.OXLeftRadioButton.AutoSize = true;
            this.OXLeftRadioButton.Location = new System.Drawing.Point(8, 59);
            this.OXLeftRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OXLeftRadioButton.Name = "OXLeftRadioButton";
            this.OXLeftRadioButton.Size = new System.Drawing.Size(179, 21);
            this.OXLeftRadioButton.TabIndex = 1;
            this.OXLeftRadioButton.TabStop = true;
            this.OXLeftRadioButton.Text = "Сдвиг по оси ОХ влево";
            this.OXLeftRadioButton.UseVisualStyleBackColor = true;
            // 
            // OYDownRadioButton
            // 
            this.OYDownRadioButton.AutoSize = true;
            this.OYDownRadioButton.Location = new System.Drawing.Point(8, 87);
            this.OYDownRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OYDownRadioButton.Name = "OYDownRadioButton";
            this.OYDownRadioButton.Size = new System.Drawing.Size(171, 21);
            this.OYDownRadioButton.TabIndex = 1;
            this.OYDownRadioButton.TabStop = true;
            this.OYDownRadioButton.Text = "Сдвиг по оси OY вниз";
            this.OYDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // OXRightRadioButton
            // 
            this.OXRightRadioButton.AutoSize = true;
            this.OXRightRadioButton.Location = new System.Drawing.Point(8, 31);
            this.OXRightRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OXRightRadioButton.Name = "OXRightRadioButton";
            this.OXRightRadioButton.Size = new System.Drawing.Size(187, 21);
            this.OXRightRadioButton.TabIndex = 0;
            this.OXRightRadioButton.TabStop = true;
            this.OXRightRadioButton.Text = "Сдвиг по оси ОХ вправо";
            this.OXRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(4, 84);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.DrawAxisButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawAxisButton.Name = "DrawAxisButton";
            this.DrawAxisButton.Size = new System.Drawing.Size(247, 28);
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
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(780, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 446);
            this.panel3.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ApplyAngleButton);
            this.groupBox7.Controls.Add(this.AngleTextBox);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Location = new System.Drawing.Point(4, 249);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(247, 92);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поворот";
            // 
            // ApplyAngleButton
            // 
            this.ApplyAngleButton.Location = new System.Drawing.Point(139, 55);
            this.ApplyAngleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApplyAngleButton.Name = "ApplyAngleButton";
            this.ApplyAngleButton.Size = new System.Drawing.Size(100, 28);
            this.ApplyAngleButton.TabIndex = 4;
            this.ApplyAngleButton.Text = "Применить";
            this.ApplyAngleButton.UseVisualStyleBackColor = true;
            this.ApplyAngleButton.Click += new System.EventHandler(this.ApplyAngleButton_Click);
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Location = new System.Drawing.Point(67, 23);
            this.AngleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(171, 22);
            this.AngleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угол: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.X0ReflectionButton);
            this.groupBox2.Controls.Add(this.Y0ReflectionButton);
            this.groupBox2.Controls.Add(this.YXReflectionButton);
            this.groupBox2.Location = new System.Drawing.Point(4, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(247, 130);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отражение";
            // 
            // X0ReflectionButton
            // 
            this.X0ReflectionButton.Location = new System.Drawing.Point(8, 94);
            this.X0ReflectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.X0ReflectionButton.Name = "X0ReflectionButton";
            this.X0ReflectionButton.Size = new System.Drawing.Size(231, 28);
            this.X0ReflectionButton.TabIndex = 2;
            this.X0ReflectionButton.Text = "Относительно прямой X = 0";
            this.X0ReflectionButton.UseVisualStyleBackColor = true;
            this.X0ReflectionButton.Click += new System.EventHandler(this.X0ReflectionButton_Click);
            // 
            // Y0ReflectionButton
            // 
            this.Y0ReflectionButton.Location = new System.Drawing.Point(8, 59);
            this.Y0ReflectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Y0ReflectionButton.Name = "Y0ReflectionButton";
            this.Y0ReflectionButton.Size = new System.Drawing.Size(231, 28);
            this.Y0ReflectionButton.TabIndex = 1;
            this.Y0ReflectionButton.Text = "Относительно прямой Y = 0";
            this.Y0ReflectionButton.UseVisualStyleBackColor = true;
            this.Y0ReflectionButton.Click += new System.EventHandler(this.Y0ReflectionButton_Click);
            // 
            // YXReflectionButton
            // 
            this.YXReflectionButton.Location = new System.Drawing.Point(8, 23);
            this.YXReflectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YXReflectionButton.Name = "YXReflectionButton";
            this.YXReflectionButton.Size = new System.Drawing.Size(231, 28);
            this.YXReflectionButton.TabIndex = 0;
            this.YXReflectionButton.Text = "Относительно прямой Y = X";
            this.YXReflectionButton.UseVisualStyleBackColor = true;
            this.YXReflectionButton.Click += new System.EventHandler(this.YXReflectionButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ApplyScalingButton);
            this.groupBox3.Controls.Add(this.ScalingTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(4, 153);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(247, 96);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштабирование";
            // 
            // ApplyScalingButton
            // 
            this.ApplyScalingButton.Location = new System.Drawing.Point(139, 60);
            this.ApplyScalingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApplyScalingButton.Name = "ApplyScalingButton";
            this.ApplyScalingButton.Size = new System.Drawing.Size(100, 28);
            this.ApplyScalingButton.TabIndex = 3;
            this.ApplyScalingButton.Text = "Применить";
            this.ApplyScalingButton.UseVisualStyleBackColor = true;
            this.ApplyScalingButton.Click += new System.EventHandler(this.ApplyScalingButton_Click);
            // 
            // ScalingTextBox
            // 
            this.ScalingTextBox.Location = new System.Drawing.Point(95, 27);
            this.ScalingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScalingTextBox.Name = "ScalingTextBox";
            this.ScalingTextBox.Size = new System.Drawing.Size(143, 22);
            this.ScalingTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Масштаб: ";
            // 
            // BicycleButton
            // 
            this.BicycleButton.Location = new System.Drawing.Point(12, 313);
            this.BicycleButton.Margin = new System.Windows.Forms.Padding(4);
            this.BicycleButton.Name = "BicycleButton";
            this.BicycleButton.Size = new System.Drawing.Size(232, 28);
            this.BicycleButton.TabIndex = 14;
            this.BicycleButton.Text = "Велосипед";
            this.BicycleButton.UseVisualStyleBackColor = true;
            this.BicycleButton.Click += new System.EventHandler(this.BicycleButton_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.RadioButton OYUpRadioButton;
        private System.Windows.Forms.RadioButton OXLeftRadioButton;
        private System.Windows.Forms.RadioButton OYDownRadioButton;
        private System.Windows.Forms.RadioButton OXRightRadioButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button ApplyAngleButton;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button X0ReflectionButton;
        private System.Windows.Forms.Button Y0ReflectionButton;
        private System.Windows.Forms.Button YXReflectionButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ApplyScalingButton;
        private System.Windows.Forms.TextBox ScalingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BicycleButton;
    }
}

