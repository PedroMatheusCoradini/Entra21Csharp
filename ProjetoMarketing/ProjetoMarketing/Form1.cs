namespace ProjetoMarketing
{
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void btnClickAki_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Show();
        }
    }
}