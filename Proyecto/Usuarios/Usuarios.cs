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
    public partial class Usuario : Form 
    {
        RegistroUsuario registroUsuario;
        Login loginUsuario;
        public Usuario()
        {
            InitializeComponent();
            registroUsuario = new RegistroUsuario();
            loginUsuario= new Login();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registroUsuario.ShowDialog();
            this.Show();
            
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginUsuario.ShowDialog();
            this.Show();
        }
    }
}
