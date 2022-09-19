namespace ProjectTeclas
{
    public partial class Form1 : Form
    {
        private int quantidadeKeyPress = 0;
        private int quantidadeKeyDown = 0;
        private int quantidadeKeyUp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            quantidadeKeyPress++;
            MostrarResultado();
            //MessageBox.Show("Evento Key Press");
            lblKeyChar2.Text = e.KeyChar.ToString();
            /*if ((e.KeyChar == 'A'))
                MessageBox.Show("O usuario digitou a letra 'A'.");*/
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Evento Key Down");
            quantidadeKeyDown++;
            MostrarResultado();
        }


        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Evento Key UP");
            quantidadeKeyUp++;
            MostrarResultado();
            lblKeyCode2.Text = e.KeyCode.ToString();
            lblKeyChar2.Text = e.Control.ToString();
            lblAlt2.Text = e.Alt.ToString();
            lblShift2.Text = e.Shift.ToString();
            lblControl2.Text = e.Control.ToString();

            if (e.Control && e.Alt && e.KeyCode.ToString() == "x")
            {
                MessageBox.Show("Presionou Control + Alt + K");
            }
        }


        private void btnInicializar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            txtNome.Clear();
            quantidadeKeyPress = 0;
            quantidadeKeyDown = 0;
            quantidadeKeyUp = 0;

            lblControl2.Text = null;
            lblAlt2.Text = null;
            lblShift2.Text = null;

            lblKeyChar2.Text = "";
            lblKeyCode2.Text = null;
        }

        private void MostrarResultado()
        {
            lblResultado.Text =
                "KeyPress: " + quantidadeKeyPress.ToString() + " | " +
                "KeyDown: " + quantidadeKeyDown.ToString() + " | " +
                "KeyUp: " + quantidadeKeyUp.ToString();
        }
    }
}