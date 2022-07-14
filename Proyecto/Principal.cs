using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;
namespace Proyecto
{
    public partial class Principal : Form
    {
        LoginHuerta loginHuerta;
        Usuario FormularioUsuario;
        Repartidorr loginRepartidor;
        public Principal()
        {
            InitializeComponent();
            FormularioUsuario = new Usuario();
            loginRepartidor = new Repartidorr();
            loginHuerta = new LoginHuerta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginHuerta.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioUsuario.ShowDialog();
            this.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginRepartidor.ShowDialog();
            this.Show();
        }
    }
}
