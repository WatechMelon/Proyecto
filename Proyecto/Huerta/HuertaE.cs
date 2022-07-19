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
namespace Vista.Huerta
{
    public partial class HuertaE : Form
    {
        HE he;
        public HuertaE()
        {
            he = new HE();
            InitializeComponent();
            

           
        }

        private void HuertaE_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(comboTam.Text == "" || comboEstado.Text == "" ||comboEspecie1.Text =="" || txtMetas.Text == "")
            {
                MessageBox.Show("Campos incompletos, por favor rellenarlos");
            }else if(comboEspecie4.Text != "" && comboTam.Text != "Mediana") {

                MessageBox.Show("No puedes elegir una cuarta especie con una huerta pequeña");

            }
            else
            {
                he.Tamanio = comboTam.Text;
                he.Especie1 = comboEspecie1.Text;
                he.Especie2 = comboEspecie2.Text;
                he.Especie3 = comboEspecie3.Text;
                he.Especie4 = comboEspecie4.Text;
                he.EstadoCultivo = comboEstado.Text;
                he.MetaCultivo = Convert.ToInt32(txtMetas.Text);
                he.FechaCultivo = Convert.ToDateTime(datePlantas.Text);
                MessageBox.Show("Todos los datos han sido ingresados con exito");


            }

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMetas.Text = "";

        }
    }
}
