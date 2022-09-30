using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosLoginComBanco
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SQN2K91\\SQLEXPRESS;Initial Catalog=loginCadastroBanco;Integrated Security=True");

            string sql = "INSERT INTO clientes(nome, email, senha) VALUES (@nome, @email, @senha)";

            try
            {
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                command.Parameters.Add(new SqlParameter("@email", txtEmailCadastro.Text));
                command.Parameters.Add(new SqlParameter("@senha", txtSenhaCadastro.Text));

                conn.Open();

                command.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Cadastro feito com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
