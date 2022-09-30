namespace ExerciciosLoginComBanco;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Form2 form2 = new Form2();

        form2.TopLevel = false;
        form2.Dock = DockStyle.Fill;
        panel2.Controls.Clear();
        panel2.Controls.Add(form2);

        form2.Show();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2();

        form2.TopLevel = false;
        form2.Dock = DockStyle.Fill;
        panel2.Controls.Clear();
        panel2.Controls.Add(form2);
        
        form2.Show();
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        Form3 form3 = new Form3();

        panel2.Controls.Clear();

        form3.TopLevel = false;
        form3.Dock = DockStyle.Fill;
        panel2.Controls.Add(form3);

        form3.Show();
    }
}
