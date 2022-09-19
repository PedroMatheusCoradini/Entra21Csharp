using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMarketing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmEntrada form2 = new frmEntrada();
            comboBoxQuantidadeDeCafe.Controls.Clear();
            comboBoxTipoDeCafe.Controls.Clear();
            //form2.panel1.Controls.Clear();
            
        }
    }
}
