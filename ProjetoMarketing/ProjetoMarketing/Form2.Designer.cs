namespace ProjetoMarketing
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTipoDeCafe = new System.Windows.Forms.Label();
            this.comboBoxTipoDeCafe = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.comboBoxQuantidadeDeCafe = new System.Windows.Forms.ComboBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoDeCafe
            // 
            this.lblTipoDeCafe.AutoSize = true;
            this.lblTipoDeCafe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDeCafe.Location = new System.Drawing.Point(249, 24);
            this.lblTipoDeCafe.Name = "lblTipoDeCafe";
            this.lblTipoDeCafe.Size = new System.Drawing.Size(113, 25);
            this.lblTipoDeCafe.TabIndex = 0;
            this.lblTipoDeCafe.Text = "Tipo de café";
            // 
            // comboBoxTipoDeCafe
            // 
            this.comboBoxTipoDeCafe.FormattingEnabled = true;
            this.comboBoxTipoDeCafe.Items.AddRange(new object[] {
            "Café torrado,",
            "Café Expresso,",
            "Café melita"});
            this.comboBoxTipoDeCafe.Location = new System.Drawing.Point(382, 21);
            this.comboBoxTipoDeCafe.Name = "comboBoxTipoDeCafe";
            this.comboBoxTipoDeCafe.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTipoDeCafe.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(249, 85);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(110, 25);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // comboBoxQuantidadeDeCafe
            // 
            this.comboBoxQuantidadeDeCafe.FormattingEnabled = true;
            this.comboBoxQuantidadeDeCafe.Items.AddRange(new object[] {
            "1,",
            "2,",
            "4,",
            "6,",
            "10"});
            this.comboBoxQuantidadeDeCafe.Location = new System.Drawing.Point(382, 85);
            this.comboBoxQuantidadeDeCafe.Name = "comboBoxQuantidadeDeCafe";
            this.comboBoxQuantidadeDeCafe.Size = new System.Drawing.Size(151, 28);
            this.comboBoxQuantidadeDeCafe.TabIndex = 3;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.Location = new System.Drawing.Point(249, 142);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(94, 29);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(439, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.comboBoxQuantidadeDeCafe);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.comboBoxTipoDeCafe);
            this.Controls.Add(this.lblTipoDeCafe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTipoDeCafe;
        private ComboBox comboBoxTipoDeCafe;
        private Label lblQuantidade;
        private ComboBox comboBoxQuantidadeDeCafe;
        private Button btnComprar;
        private Button btnCancelar;
    }
}