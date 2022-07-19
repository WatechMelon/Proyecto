using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Huerta;

namespace Vista
{
    public partial class LoginHuerta : Form
    {
        ElegirHuerta huerta;
        public LoginHuerta()
        {
            InitializeComponent();
            huerta = new ElegirHuerta();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "admin@gmail.com" && txtPass.Text == "admin")
                {
                    MessageBox.Show("Te has logueado exitosamente");
                    this.Hide();
                    huerta.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Error, Contraseña o Email incorrectos");
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Hubo un error" + s, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
