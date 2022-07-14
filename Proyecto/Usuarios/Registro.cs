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
using System.IO;
namespace Vista
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            txtCi.Enabled = false;
            txtPrimerNom.Enabled = false;
            txtSegundoNom.Enabled = false;
            txtPrimerApe.Enabled = false;
            txtSegundoApe.Enabled = false;
            txtRut.Enabled = false;
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBarrio.Text = "";
            txtCalle.Text = "";
            txtCi.Text = "";
            txtContra.Text = "";
            txtEmail.Text = "";
            txtEsquina.Text = "";
            txtIdCliente.Text = "";
            txtNumero.Text = "";
            txtPrimerApe.Text = "";
            txtPrimerNom.Text = "";
            txtRut.Text = "";
            txtSegundoApe.Text = "";
            txtSegundoNom.Text = "";
            txtTelefono.Text = "";


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
            
            if (rdbEmpresa.Checked || rdbTerminal.Checked)
            {
                if (rdbTerminal.Checked && (txtBarrio.Text == "" || txtIdCliente.Text == "" || txtEsquina.Text == "" || txtCalle.Text == "" || txtEmail.Text == "" || txtTelefono.Text == "" ||
                txtContra.Text == "" || txtNumero.Text == "" || txtPrimerNom.Text == "" || txtCi.Text == "" || txtPrimerApe.Text == ""))
                {

                    MessageBox.Show("Hay campos obligatorios sin rellenarT");

                }
                else if (rdbTerminal.Checked)
                {
                    ClienteTerminal clienteTerminal = new ClienteTerminal();

                    clienteTerminal.email = txtEmail.Text;
                    clienteTerminal.pass = txtContra.Text;
                    clienteTerminal.telefono = Convert.ToInt32(txtTelefono.Text);
                    clienteTerminal.Barrio = txtBarrio.Text;
                    clienteTerminal.numero = Convert.ToInt32(txtNumero.Text);
                    clienteTerminal.esquina = txtEsquina.Text;
                    clienteTerminal.Ci = Convert.ToInt32(txtCi.Text);
                    clienteTerminal.PrimerApe = txtPrimerApe.Text;
                    clienteTerminal.PrimerNom = txtPrimerNom.Text;
                    clienteTerminal.SegundoApe = txtSegundoApe.Text;
                    clienteTerminal.SegundoNom = txtSegundoNom.Text;

                    MessageBox.Show("Te has registrado en el sistema exitosamente");
                    Dispose();


                }
                else if (rdbEmpresa.Checked && (txtBarrio.Text == "" || txtIdCliente.Text == "" || txtEsquina.Text == "" || txtCalle.Text == "" || txtEmail.Text == "" || txtTelefono.Text == "" ||
                txtContra.Text == "" || txtNumero.Text == "" || txtRut.Text == ""))
                {


                    MessageBox.Show("Hay campos obligatorios sin rellenarE");



                }
                else if (rdbEmpresa.Checked)
                {
                    try
                    {
                        TextWriter RegistroUsuario = new StreamWriter(@"F:\repos\Proyecto\Proyecto\bin\Debug\" + txtEmail.Text + ".txt", true);
                        RegistroUsuario.WriteLine(txtContra.Text);
                        RegistroUsuario.WriteLine(txtEmail.Text);
                        RegistroUsuario.Close();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Hubo un error" + x, "Error");
                    }
                    ClienteEmpresa clienteEmpresa = new ClienteEmpresa();

                    clienteEmpresa.Rut = Convert.ToInt32(txtRut.Text);
                    clienteEmpresa.idCliente = Convert.ToInt32(txtIdCliente.Text);
                    clienteEmpresa.email = txtEmail.Text;
                    clienteEmpresa.pass = txtContra.Text;
                    clienteEmpresa.telefono = Convert.ToInt32(txtTelefono.Text);
                    clienteEmpresa.Barrio = txtBarrio.Text;
                    clienteEmpresa.numero = Convert.ToInt32(txtNumero.Text);
                    clienteEmpresa.esquina = txtEsquina.Text;
                    clienteEmpresa.calle = txtCalle.Text;

                    MessageBox.Show("Te has registrado en el sistema exitosamente");
                    Dispose();

                }
                else
                {

                    MessageBox.Show("No seleccionaste ningún cliente");

                }
                
            }


        }

    }
}
 