namespace ProjetoCadastro
{
    partial class ltboxInformacoes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.richTextBoxInformacoes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Informe um Código";
            this.textBox1.Size = new System.Drawing.Size(147, 27);
            this.textBox1.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.Location = new System.Drawing.Point(203, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 19);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(403, 372);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 29);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(203, 119);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(203, 142);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Informe seu Nome";
            this.txtNome.Size = new System.Drawing.Size(147, 27);
            this.txtNome.TabIndex = 3;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCargo.Location = new System.Drawing.Point(203, 194);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(51, 19);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(203, 216);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PlaceholderText = "Informe seu cargo";
            this.txtCargo.Size = new System.Drawing.Size(147, 27);
            this.txtCargo.TabIndex = 5;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSalarioBase.Location = new System.Drawing.Point(203, 256);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(94, 19);
            this.lblSalarioBase.TabIndex = 8;
            this.lblSalarioBase.Text = "Salario Base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(203, 279);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.PlaceholderText = "Informe seu Salario Base";
            this.txtSalarioBase.Size = new System.Drawing.Size(173, 27);
            this.txtSalarioBase.TabIndex = 7;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCpfCnpj.Location = new System.Drawing.Point(203, 318);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(84, 19);
            this.lblCpfCnpj.TabIndex = 10;
            this.lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(203, 341);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.PlaceholderText = "CPF/CNPJ";
            this.txtCpfCnpj.Size = new System.Drawing.Size(84, 27);
            this.txtCpfCnpj.TabIndex = 9;
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInformacoes.Location = new System.Drawing.Point(203, 385);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(96, 19);
            this.lblInformacoes.TabIndex = 12;
            this.lblInformacoes.Text = "Informações";
            // 
            // richTextBoxInformacoes
            // 
            this.richTextBoxInformacoes.Location = new System.Drawing.Point(203, 407);
            this.richTextBoxInformacoes.Name = "richTextBoxInformacoes";
            this.richTextBoxInformacoes.Size = new System.Drawing.Size(294, 120);
            this.richTextBoxInformacoes.TabIndex = 13;
            this.richTextBoxInformacoes.Text = "";
            // 
            // ltboxInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.richTextBoxInformacoes);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.textBox1);
            this.Name = "ltboxInformacoes";
            this.Text = "Cadastro Geral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label lblCodigo;
        private Button btnCadastrar;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCargo;
        private TextBox txtCargo;
        private Label lblSalarioBase;
        private TextBox txtSalarioBase;
        private Label lblCpfCnpj;
        private TextBox txtCpfCnpj;
        private Label lblInformacoes;
        private RichTextBox richTextBoxInformacoes;
    }
}