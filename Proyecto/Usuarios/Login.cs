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
using Vista.Usuarios.Productos;
using System.IO;
namespace Vista
{
    public partial class Login : Form
    {
        Estaciones compras;
        public Login()
        { 
            RegistroUsuario registroUsuario = new RegistroUsuario();
            InitializeComponent();
            compras = new Estaciones();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader InicioS = new StreamReader(txtEmail.Text + ".txt");
                if (InicioS.ReadLine() == txtContra.Text && InicioS.ReadLine() == txtEmail.Text)
                {
                    MessageBox.Show("Bienvenido \n Se ha iniciado sesión correctamente");
                    this.Hide();
                    compras.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión, su contraseña o email es incorrecto");
                }
            }
            catch(Exception y)
            {
                MessageBox.Show("Hubo un error" + y, "Error");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtContra.Text = "";


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
