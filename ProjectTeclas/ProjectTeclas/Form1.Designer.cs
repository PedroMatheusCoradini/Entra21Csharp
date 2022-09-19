namespace ProjectTeclas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.lblControl = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblKeyChar = new System.Windows.Forms.Label();
            this.lblKeyCode = new System.Windows.Forms.Label();
            this.lblControl2 = new System.Windows.Forms.Label();
            this.lblAlt2 = new System.Windows.Forms.Label();
            this.lblShift2 = new System.Windows.Forms.Label();
            this.lblKeyChar2 = new System.Windows.Forms.Label();
            this.lblKeyCode2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(633, 27);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(78, 139);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(633, 24);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(633, 27);
            this.textBox2.TabIndex = 2;
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(325, 227);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(173, 54);
            this.btnInicializar.TabIndex = 3;
            this.btnInicializar.Text = "INICIALIZAR";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // lblControl
            // 
            this.lblControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControl.Location = new System.Drawing.Point(78, 297);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(73, 23);
            this.lblControl.TabIndex = 4;
            this.lblControl.Text = "Control";
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlt
            // 
            this.lblAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlt.Location = new System.Drawing.Point(229, 297);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(63, 23);
            this.lblAlt.TabIndex = 5;
            this.lblAlt.Text = "Alt";
            this.lblAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShift
            // 
            this.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShift.Location = new System.Drawing.Point(385, 297);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(63, 23);
            this.lblShift.TabIndex = 6;
            this.lblShift.Text = "Shift";
            this.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeyChar
            // 
            this.lblKeyChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeyChar.Location = new System.Drawing.Point(526, 297);
            this.lblKeyChar.Name = "lblKeyChar";
            this.lblKeyChar.Size = new System.Drawing.Size(79, 23);
            this.lblKeyChar.TabIndex = 7;
            this.lblKeyChar.Text = "Key Char";
            this.lblKeyChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeyCode
            // 
            this.lblKeyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeyCode.Location = new System.Drawing.Point(661, 297);
            this.lblKeyCode.Name = "lblKeyCode";
            this.lblKeyCode.Size = new System.Drawing.Size(79, 23);
            this.lblKeyCode.TabIndex = 8;
            this.lblKeyCode.Text = "Key Code";
            this.lblKeyCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControl2
            // 
            this.lblControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblControl2.Location = new System.Drawing.Point(58, 338);
            this.lblControl2.Name = "lblControl2";
            this.lblControl2.Size = new System.Drawing.Size(116, 39);
            this.lblControl2.TabIndex = 9;
            this.lblControl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlt2
            // 
            this.lblAlt2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlt2.Location = new System.Drawing.Point(202, 338);
            this.lblAlt2.Name = "lblAlt2";
            this.lblAlt2.Size = new System.Drawing.Size(116, 39);
            this.lblAlt2.TabIndex = 10;
            this.lblAlt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShift2
            // 
            this.lblShift2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShift2.Location = new System.Drawing.Point(360, 338);
            this.lblShift2.Name = "lblShift2";
            this.lblShift2.Size = new System.Drawing.Size(116, 39);
            this.lblShift2.TabIndex = 11;
            this.lblShift2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeyChar2
            // 
            this.lblKeyChar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKeyChar2.Location = new System.Drawing.Point(509, 338);
            this.lblKeyChar2.Name = "lblKeyChar2";
            this.lblKeyChar2.Size = new System.Drawing.Size(116, 39);
            this.lblKeyChar2.TabIndex = 12;
            this.lblKeyChar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeyCode2
            // 
            this.lblKeyCode2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKeyCode2.Location = new System.Drawing.Point(643, 338);
            this.lblKeyCode2.Name = "lblKeyCode2";
            this.lblKeyCode2.Size = new System.Drawing.Size(116, 39);
            this.lblKeyCode2.TabIndex = 13;
            this.lblKeyCode2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKeyCode2);
            this.Controls.Add(this.lblKeyChar2);
            this.Controls.Add(this.lblShift2);
            this.Controls.Add(this.lblAlt2);
            this.Controls.Add(this.lblControl2);
            this.Controls.Add(this.lblKeyCode);
            this.Controls.Add(this.lblKeyChar);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label lblResultado;
        private TextBox textBox2;
        private Button btnInicializar;
        private Label lblControl;
        private Label lblAlt;
        private Label lblShift;
        private Label lblKeyChar;
        private Label lblKeyCode;
        private Label lblControl2;
        private Label lblAlt2;
        private Label lblShift2;
        private Label lblKeyChar2;
        private Label lblKeyCode2;
    }
}