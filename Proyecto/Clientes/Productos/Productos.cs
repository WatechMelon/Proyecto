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

namespace Vista.Usuarios.Productos
{


    public partial class Productos : Form
    {
        Producto producto;
        Pedido pedido;
        
        

        public Productos()
        {

            InitializeComponent();
            producto = new Producto();
            pedido = new Pedido();
            txtArvejas.Enabled = false;
            txtAcelga.Enabled = false;
            txtAjo.Enabled = false;
            txtApio.Enabled = false;
            txtBerenjena.Enabled = false;
            txtBetarraga.Enabled = false;
            txtCebollin.Enabled = false;
            txtCebolla.Enabled = false;
            txtChoclo.Enabled = false;
            txtFrutilla.Enabled = false;
            txtHabas.Enabled = false;
            txtLechuga.Enabled = false;
            txtPapa.Enabled = false;
            txtPimenton.Enabled = false;
            txtPoroto.Enabled = false;
            txtPorotoV.Enabled = false;
            txtRepollo.Enabled = false;
            txtTomate.Enabled = false;
            txtZanahoria.Enabled = false;
            txtPorotoV.Text = "0";
            txtArvejas.Text = "0";
            txtAcelga.Text = "0";
            txtAjo.Text = "0";
            txtApio.Text = "0";
            txtBerenjena.Text = "0";
            txtBetarraga.Text = "0";
            txtCebollin.Text = "0";
            txtCebolla.Text = "0";
            txtChoclo.Text = "0";
            txtFrutilla.Text = "0";
            txtHabas.Text = "0";
            txtLechuga.Text = "0";
            txtPapa.Text = "0";
            txtPimenton.Text = "0";
            txtPoroto.Text = "0";
            txtRepollo.Text = "0";
            txtTomate.Text = "0";
            txtZanahoria.Text = "0";



        }

     

        private void Estaciones_Load(object sender, EventArgs e)
        {

        }


        private void btnAjoO_Click(object sender, EventArgs e)
        {
            txtAjo.Enabled = true;
        }

        private void txtLechuga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLechugaP_Click(object sender, EventArgs e)
        {
            txtLechuga.Enabled = true;
        }

        private void btnPorotoVEV_Click(object sender, EventArgs e)
        {
            txtPorotoV.Enabled = true;
        }

        private void btnApioV_Click(object sender, EventArgs e)
        {
            txtApio.Enabled = true;
        }

        private void btnHabasO_Click(object sender, EventArgs e)
        {
            txtHabas.Enabled = true;
        }

        private void btnArvejasO_Click(object sender, EventArgs e)
        {
            txtArvejas.Enabled = true;
        }

        private void btnTomateI_Click(object sender, EventArgs e)
        {
            txtTomate.Enabled = true;
        }

        private void btnAcelgaV_Click(object sender, EventArgs e)
        {
            txtAcelga.Enabled = true;
        }

        private void btnRepolloV_Click(object sender, EventArgs e)
        {
            txtRepollo.Enabled = true;
        }

        private void btnCebollinV_Click(object sender, EventArgs e)
        {
            txtCebollin.Enabled = true;
        }

        private void btnPapaV_Click(object sender, EventArgs e)
        {
            txtPapa.Enabled = true;
        }

        private void btnZanahoriaV_Click(object sender, EventArgs e)
        {
            txtZanahoria.Enabled = true;
        }

        private void btnCebollaV_Click(object sender, EventArgs e)
        {
            txtCebolla.Enabled = true;
        }

        private void btnChocloP_Click(object sender, EventArgs e)
        {
            txtChoclo.Enabled = true;
        }

        private void btnPimentonI_Click(object sender, EventArgs e)
        {
            txtPimenton.Enabled = true;
        }

        private void btnBetarragaIP_Click(object sender, EventArgs e)
        {
            txtBetarraga.Enabled = true;
        }

        private void btnBerenjenaP_Click(object sender, EventArgs e)
        {
            txtBerenjena.Enabled = true;
        }

        private void btnFrutillaO_Click(object sender, EventArgs e)
        {
            txtFrutilla.Enabled = true;
        }

        private void btnPorotoV_Click(object sender, EventArgs e)
        {
            txtPoroto.Enabled = true;
          
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (comboPago.Text == "Elegir metodo de pago")
            {
                MessageBox.Show("Metodo de pago no seleccionado");
            }
           else { 
            pedido.MetodoPago = comboPago.Text;

            pedido.ListaProductos = "Registro de compra: " + "\n" + producto.Lechuga + "\n" + producto.Porotov + "\n"
                + producto.Apio + "\n" + producto.Habas + "\n" + producto.Arvejas + "\n" + producto.Acelga
           + "\n" + producto.Ajo + "\n" + producto.Berenjena + "\n" + producto.Betarraga + "\n"
           + producto.Cebollin + "\n" + producto.Cebolla + "\n" + producto.Choclo + "\n" + producto.Frutilla + "\n" +
           producto.Papa + "\n" + producto.Pimenton + "\n" + producto.Poroto + "\n" + producto.Repollo + "\n" + producto.Tomate + "\n" + producto.Zanahoria;

            pedido.CantidadProductos = +Convert.ToInt32(txtLechuga.Text) + Convert.ToInt32(txtPorotoV.Text) + Convert.ToInt32(txtApio.Text)
            + Convert.ToInt32(txtHabas.Text) + Convert.ToInt32(txtArvejas.Text) + Convert.ToInt32(txtTomate.Text) + Convert.ToInt32(txtAjo.Text)
            + Convert.ToInt32(txtAcelga.Text) + Convert.ToInt32(txtRepollo.Text) + Convert.ToInt32(txtCebollin.Text) + Convert.ToInt32(txtPapa.Text)
            + Convert.ToInt32(txtZanahoria.Text) + Convert.ToInt32(txtCebolla.Text) + Convert.ToInt32(txtChoclo.Text) + Convert.ToInt32(txtPimenton.Text)
            + Convert.ToInt32(txtBetarraga.Text) + Convert.ToInt32(txtBerenjena.Text) + Convert.ToInt32(txtFrutilla.Text) + Convert.ToInt32(txtPoroto.Text);

            pedido.NumPedido++;
            

            MessageBox.Show(pedido.ListaProductos);

            }
        }
        public void btnLechugaA_Click(object sender, EventArgs e)
        {
                producto.Lechuga = "Lechuga: " +Convert.ToInt32(txtLechuga.Text) + " KG";
            
        }

        private void btnPorotoVA_Click(object sender, EventArgs e)
        {
                producto.Porotov = "Porotos Verdes: "  +Convert.ToInt32(txtPorotoV.Text) + " KG";
        }

        private void btnApioA_Click(object sender, EventArgs e)
        {
                producto.Apio = "Apio: " + Convert.ToInt32(txtApio.Text) + " KG";
        }

        private void btnHabasA_Click(object sender, EventArgs e)
        {
                 producto.Habas = "Habas: " + Convert.ToInt32(txtHabas.Text) + " KG";
        }

        private void btnArvejasA_Click(object sender, EventArgs e)
        {
                producto.Arvejas = "Arveja: "+ Convert.ToInt32(txtArvejas.Text) + " KG";
        }

        private void btnTomateA_Click(object sender, EventArgs e)
        {
                producto.Tomate = "Tomate: " + Convert.ToInt32(txtTomate.Text) + " KG";
        }

        private void btnAjoA_Click(object sender, EventArgs e)
        {
                producto.Ajo = "Ajos: " + Convert.ToInt32(txtAjo.Text) + " KG";
        }

        private void btnAcelgaA_Click(object sender, EventArgs e)
        {
                producto.Acelga ="Acelga: " +Convert.ToInt32(txtAcelga.Text) + " KG";
        }

        private void btnRepolloA_Click(object sender, EventArgs e)
        {
                producto.Repollo = "Repollo: " + Convert.ToInt32(txtRepollo.Text) + " KG";
        }

        private void btnCebollinA_Click(object sender, EventArgs e)
        {
                producto.Cebollin= "Cebollin: " + Convert.ToInt32(txtCebollin.Text) + " KG";
        }

        private void btnPapaA_Click(object sender, EventArgs e)
        {
                producto.Papa = "Papa: " + Convert.ToInt32(txtPapa.Text) + " KG";
        }

        private void btnZanahoriaA_Click(object sender, EventArgs e)
        {
                producto.Zanahoria = "Zanahoria: " + Convert.ToInt32(txtZanahoria.Text) + " KG";
        }

        private void btnCebollaA_Click(object sender, EventArgs e)
        {
                producto.Cebolla = "Cebolla: " + Convert.ToInt32(txtCebolla.Text) + " KG";
        }

        private void btnChocloA_Click(object sender, EventArgs e)
        {
                producto.Choclo = "Choclo: " + Convert.ToInt32(txtChoclo.Text) + " KG";
        }

        private void btnPimentonA_Click(object sender, EventArgs e)
        {
                 producto.Pimenton = "Pimentón: " + Convert.ToInt32(txtPimenton.Text) + " KG";
        }

        private void btnBetarragaA_Click(object sender, EventArgs e)
        {
                producto.Betarraga = "Betarraga: " + Convert.ToInt32(txtBetarraga.Text) + " KG";
        }

        private void btnBerenjenaA_Click(object sender, EventArgs e)
        {
                producto.Berenjena = "Berenjena: " + Convert.ToInt32(txtBerenjena.Text) + " KG";
        }

        private void btnFrutillaA_Click(object sender, EventArgs e)
        {
                producto.Frutilla = "Frutilla: " + Convert.ToInt32(txtFrutilla.Text) + " KG";
        }

        private void btnPorotoA_Click(object sender, EventArgs e)
        {
                producto.Poroto = "Portos: " + Convert.ToInt32(txtPoroto.Text) + " KG";
        }

        private void comboPago_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBerrataga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
