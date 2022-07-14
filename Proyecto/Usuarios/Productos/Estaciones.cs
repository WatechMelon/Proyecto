using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Usuarios.Productos
{
    public partial class Estaciones : Form
    {
        Verano verano;
        Invierno invierno;
        Otoño otonio;
        Primavera primavera;


        public Estaciones()
        {
            InitializeComponent();

            verano = new Verano();
            invierno = new Invierno();
            otonio = new Otoño();
            primavera = new Primavera();
        }

        private void btnVerano_Click(object sender, EventArgs e)
        {

            this.Hide();
            verano.ShowDialog();
            this.Show();

        }

        private void btnOtonio_Click(object sender, EventArgs e)
        {
            this.Hide();
            otonio.ShowDialog();
            this.Show();
        }

        private void btnInvierno_Click(object sender, EventArgs e)
        {
            this.Hide();
            invierno.ShowDialog();
            this.Show();
        }

        private void btnPrimavera_Click(object sender, EventArgs e)
        {
            this.Hide();
            primavera.ShowDialog();
            this.Show();
        }

        private void Estaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
