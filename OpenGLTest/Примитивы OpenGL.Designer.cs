
namespace OpenGLTest
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
            this.Pr = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.ConeButton = new System.Windows.Forms.Button();
            this.CubeButton = new System.Windows.Forms.Button();
            this.CylinderButton = new System.Windows.Forms.Button();
            this.DodecahedronButton = new System.Windows.Forms.Button();
            this.IcosahedronButton = new System.Windows.Forms.Button();
            this.OctahedronButton = new System.Windows.Forms.Button();
            this.RhombicButton = new System.Windows.Forms.Button();
            this.SierpinskiButton = new System.Windows.Forms.Button();
            this.SphereButton = new System.Windows.Forms.Button();
            this.TeapotButton = new System.Windows.Forms.Button();
            this.TetrahedronButton = new System.Windows.Forms.Button();
            this.TorusButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.WireRadioButton = new System.Windows.Forms.RadioButton();
            this.SolidRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Pr
            // 
            this.Pr.AccumBits = ((byte)(0));
            this.Pr.AutoCheckErrors = false;
            this.Pr.AutoFinish = false;
            this.Pr.AutoMakeCurrent = true;
            this.Pr.AutoSwapBuffers = true;
            this.Pr.BackColor = System.Drawing.Color.Black;
            this.Pr.ColorBits = ((byte)(32));
            this.Pr.DepthBits = ((byte)(16));
            this.Pr.Location = new System.Drawing.Point(12, 12);
            this.Pr.Name = "Pr";
            this.Pr.Size = new System.Drawing.Size(524, 402);
            this.Pr.StencilBits = ((byte)(0));
            this.Pr.TabIndex = 0;
            // 
            // ConeButton
            // 
            this.ConeButton.Location = new System.Drawing.Point(542, 12);
            this.ConeButton.Name = "ConeButton";
            this.ConeButton.Size = new System.Drawing.Size(246, 23);
            this.ConeButton.TabIndex = 1;
            this.ConeButton.Text = "Cone";
            this.ConeButton.UseVisualStyleBackColor = true;
            // 
            // CubeButton
            // 
            this.CubeButton.Location = new System.Drawing.Point(542, 41);
            this.CubeButton.Name = "CubeButton";
            this.CubeButton.Size = new System.Drawing.Size(246, 23);
            this.CubeButton.TabIndex = 2;
            this.CubeButton.Text = "Cube";
            this.CubeButton.UseVisualStyleBackColor = true;
            // 
            // CylinderButton
            // 
            this.CylinderButton.Location = new System.Drawing.Point(542, 70);
            this.CylinderButton.Name = "CylinderButton";
            this.CylinderButton.Size = new System.Drawing.Size(246, 23);
            this.CylinderButton.TabIndex = 3;
            this.CylinderButton.Text = "Cylinder";
            this.CylinderButton.UseVisualStyleBackColor = true;
            // 
            // DodecahedronButton
            // 
            this.DodecahedronButton.Location = new System.Drawing.Point(542, 99);
            this.DodecahedronButton.Name = "DodecahedronButton";
            this.DodecahedronButton.Size = new System.Drawing.Size(246, 23);
            this.DodecahedronButton.TabIndex = 4;
            this.DodecahedronButton.Text = "Dodecahedron";
            this.DodecahedronButton.UseVisualStyleBackColor = true;
            // 
            // IcosahedronButton
            // 
            this.IcosahedronButton.Location = new System.Drawing.Point(542, 128);
            this.IcosahedronButton.Name = "IcosahedronButton";
            this.IcosahedronButton.Size = new System.Drawing.Size(246, 23);
            this.IcosahedronButton.TabIndex = 5;
            this.IcosahedronButton.Text = "Icosahedron";
            this.IcosahedronButton.UseVisualStyleBackColor = true;
            // 
            // OctahedronButton
            // 
            this.OctahedronButton.Location = new System.Drawing.Point(542, 157);
            this.OctahedronButton.Name = "OctahedronButton";
            this.OctahedronButton.Size = new System.Drawing.Size(246, 23);
            this.OctahedronButton.TabIndex = 6;
            this.OctahedronButton.Text = "Octahedron";
            this.OctahedronButton.UseVisualStyleBackColor = true;
            // 
            // RhombicButton
            // 
            this.RhombicButton.Location = new System.Drawing.Point(542, 186);
            this.RhombicButton.Name = "RhombicButton";
            this.RhombicButton.Size = new System.Drawing.Size(246, 23);
            this.RhombicButton.TabIndex = 7;
            this.RhombicButton.Text = "Rhombic";
            this.RhombicButton.UseVisualStyleBackColor = true;
            // 
            // SierpinskiButton
            // 
            this.SierpinskiButton.Location = new System.Drawing.Point(542, 215);
            this.SierpinskiButton.Name = "SierpinskiButton";
            this.SierpinskiButton.Size = new System.Drawing.Size(246, 23);
            this.SierpinskiButton.TabIndex = 8;
            this.SierpinskiButton.Text = "Sierpinski";
            this.SierpinskiButton.UseVisualStyleBackColor = true;
            // 
            // SphereButton
            // 
            this.SphereButton.Location = new System.Drawing.Point(542, 244);
            this.SphereButton.Name = "SphereButton";
            this.SphereButton.Size = new System.Drawing.Size(246, 23);
            this.SphereButton.TabIndex = 9;
            this.SphereButton.Text = "Sphere";
            this.SphereButton.UseVisualStyleBackColor = true;
            // 
            // TeapotButton
            // 
            this.TeapotButton.Location = new System.Drawing.Point(542, 273);
            this.TeapotButton.Name = "TeapotButton";
            this.TeapotButton.Size = new System.Drawing.Size(246, 23);
            this.TeapotButton.TabIndex = 10;
            this.TeapotButton.Text = "Teapot";
            this.TeapotButton.UseVisualStyleBackColor = true;
            // 
            // TetrahedronButton
            // 
            this.TetrahedronButton.Location = new System.Drawing.Point(542, 302);
            this.TetrahedronButton.Name = "TetrahedronButton";
            this.TetrahedronButton.Size = new System.Drawing.Size(246, 23);
            this.TetrahedronButton.TabIndex = 11;
            this.TetrahedronButton.Text = "Tetrahedron";
            this.TetrahedronButton.UseVisualStyleBackColor = true;
            // 
            // TorusButton
            // 
            this.TorusButton.Location = new System.Drawing.Point(542, 331);
            this.TorusButton.Name = "TorusButton";
            this.TorusButton.Size = new System.Drawing.Size(246, 23);
            this.TorusButton.TabIndex = 12;
            this.TorusButton.Text = "Torus";
            this.TorusButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(633, 369);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(155, 23);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // WireRadioButton
            // 
            this.WireRadioButton.AutoSize = true;
            this.WireRadioButton.Location = new System.Drawing.Point(542, 360);
            this.WireRadioButton.Name = "WireRadioButton";
            this.WireRadioButton.Size = new System.Drawing.Size(47, 17);
            this.WireRadioButton.TabIndex = 14;
            this.WireRadioButton.TabStop = true;
            this.WireRadioButton.Text = "Wire";
            this.WireRadioButton.UseVisualStyleBackColor = true;
            // 
            // SolidRadioButton
            // 
            this.SolidRadioButton.AutoSize = true;
            this.SolidRadioButton.Location = new System.Drawing.Point(542, 383);
            this.SolidRadioButton.Name = "SolidRadioButton";
            this.SolidRadioButton.Size = new System.Drawing.Size(48, 17);
            this.SolidRadioButton.TabIndex = 15;
            this.SolidRadioButton.TabStop = true;
            this.SolidRadioButton.Text = "Solid";
            this.SolidRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.SolidRadioButton);
            this.Controls.Add(this.WireRadioButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TorusButton);
            this.Controls.Add(this.TetrahedronButton);
            this.Controls.Add(this.TeapotButton);
            this.Controls.Add(this.SphereButton);
            this.Controls.Add(this.SierpinskiButton);
            this.Controls.Add(this.RhombicButton);
            this.Controls.Add(this.OctahedronButton);
            this.Controls.Add(this.IcosahedronButton);
            this.Controls.Add(this.DodecahedronButton);
            this.Controls.Add(this.CylinderButton);
            this.Controls.Add(this.CubeButton);
            this.Controls.Add(this.ConeButton);
            this.Controls.Add(this.Pr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl Pr;
        private System.Windows.Forms.Button ConeButton;
        private System.Windows.Forms.Button CubeButton;
        private System.Windows.Forms.Button CylinderButton;
        private System.Windows.Forms.Button DodecahedronButton;
        private System.Windows.Forms.Button IcosahedronButton;
        private System.Windows.Forms.Button OctahedronButton;
        private System.Windows.Forms.Button RhombicButton;
        private System.Windows.Forms.Button SierpinskiButton;
        private System.Windows.Forms.Button SphereButton;
        private System.Windows.Forms.Button TeapotButton;
        private System.Windows.Forms.Button TetrahedronButton;
        private System.Windows.Forms.Button TorusButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RadioButton WireRadioButton;
        private System.Windows.Forms.RadioButton SolidRadioButton;
    }
}

