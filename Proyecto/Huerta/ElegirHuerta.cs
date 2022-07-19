using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Huerta
{
    public partial class ElegirHuerta : Form
    {
        HuertaE huerta;
        public ElegirHuerta()
        {
            InitializeComponent();
            huerta = new HuertaE();
        }

        private void Huerta_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtId.Text) == 1502)
                {
                    MessageBox.Show("Huerta valida");
                    this.Hide();
                    huerta.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Error, ID de huerta no valido");
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Hubo un error" + s, "Error");
            }
        }
    }
    }

