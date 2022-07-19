using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Pedido
    {
        public int NumPedido =0;
        public int CantidadProductos { get; set; }
        public String ListaProductos { get; set; }
        public String MetodoPago { get; set; }

        public Pedido()
        {

        }

        public Pedido(int numPedido, int cantidadProductos, string listaProductos, string metodoPago)
        {
            NumPedido = numPedido;
            CantidadProductos = cantidadProductos;
            ListaProductos = listaProductos;
            MetodoPago = metodoPago;
        }
    }
}
