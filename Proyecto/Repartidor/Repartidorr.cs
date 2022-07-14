using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace Vista
{
    public partial class Repartidorr : Form
    {
        public Repartidorr()
        {

            InitializeComponent();
        }

        private void Repartidor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIdRepartidor.Clear();
            txtPass.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtIdRepartidor) == 84321 && txtPass.Text == "Contra")
                {
                    MessageBox.Show("Te has logueado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error, Contraseña o Email incorrectos");
                }
            }
            catch(Exception s)
            {
                MessageBox.Show("Hubo un error" + s, "Error");
            }
        }

        private void txtIdRepartidor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
