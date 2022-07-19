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

namespace Vista.Repartidor
{
    public partial class Pedidos : Form
    {
        Pedido pedido;
        EstadoPedido estadopedido;

        public Pedidos()
        {
            estadopedido = new EstadoPedido();
            pedido = new Pedido();
            InitializeComponent();
            txtPedidos.Text = pedido.MetodoPago +"\n" + pedido.ListaProductos + "\n" + pedido.NumPedido + "\n" + pedido.CantidadProductos;
            dateFin.Enabled = false;



        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
           

        }

        private void gvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }



        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String expr = comboEstado.Text;

            switch (expr)
            {
                case "Esperando aprobación":
                     estadopedido.FechaInicioAprobacion = Convert.ToDateTime(dateInicio.Text);
                    break;
                case "Armando el pedido":
                     estadopedido.FechaInicioArmando = Convert.ToDateTime(dateInicio.Text);
                     estadopedido.FechaFinAprobacion = estadopedido.FechaInicioArmando;
                    break;
                case "Pedido despachado":
                     estadopedido.FechaInicioDespacho = Convert.ToDateTime(dateInicio.Text);
                    estadopedido.FechaFinArmando = estadopedido.FechaInicioDespacho;
                    break;
                case "En ruta":
                     estadopedido.FechaInicioRuta = Convert.ToDateTime(dateInicio.Text);
                    estadopedido.FechaFinDespacho = estadopedido.FechaInicioRuta;
                    break;
                case "Recibido":
                     estadopedido.FechaInicioRecibo = Convert.ToDateTime(dateInicio.Text);
                    estadopedido.FechaFinRuta = estadopedido.FechaInicioRecibo;
                    dateFin.Enabled = true;
                    estadopedido.FechaFinRecibo = Convert.ToDateTime(dateFin.Text);
                    break;
                case "Cancelado":
                    MessageBox.Show("Pedido cancelado");
                    break;
    default: MessageBox.Show("No has elegido ninguna opcion");
                    break;
            }

        }
    }
}
