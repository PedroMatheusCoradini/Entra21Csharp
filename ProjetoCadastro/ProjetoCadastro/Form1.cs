namespace ProjetoCadastro
{
    public partial class ltboxInformacoes : Form
    {
        public ltboxInformacoes()
        {
            InitializeComponent();


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario cadastrado com sucesso!");
            txtCodigo.Text = " ";
            txtNome.Text = " ";
            lblSalarioBase.Text = " ";
            lblCpfCnpj.Text = " ";
            lblInformacoes.Text = " ";
            richTextBoxInformacoes.Text = " ";
        }
    }
}