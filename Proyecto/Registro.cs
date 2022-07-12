using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTerminal.Checked)
            {
                txtCi.Enabled = true;
                txtPrimerNom.Enabled = true;
                txtSegundoNom.Enabled = true;
                txtPrimerApe.Enabled = true;
                txtSegundoApe.Enabled = true;
                txtRut.Enabled = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEmpresa.Checked)
            {
                txtCi.Enabled = false;
                txtPrimerNom.Enabled = false;
                txtSegundoNom.Enabled = false;
                txtPrimerApe.Enabled = false;
                txtSegundoApe.Enabled = false;
                txtRut.Enabled = true;
            }
        }
    }
}
