using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstadoPedido
    {
        public int Estadopedido { get; set; }
        public DateTime FechaInicioAprobacion { get; set; }
        public DateTime FechaInicioArmando { get; set; }
        public DateTime FechaFinAprobacion { get; set; }
        public DateTime FechaInicioDespacho { get; set; }
        public DateTime FechaFinArmando { get; set; }
        public DateTime FechaInicioRuta { get; set; }
        public DateTime FechaFinDespacho { get; set; }
        public DateTime FechaInicioRecibo { get; set; }
        public DateTime FechaFinRuta { get; set; }
        public DateTime FechaFinRecibo { get; set; }

        public EstadoPedido()
        {

        }

        public EstadoPedido(int estadopedido, DateTime fechaInicioAprobacion, DateTime fechaInicioArmando, DateTime fechaFinAprobacion, DateTime fechaInicioDespacho, DateTime fechaFinArmando, DateTime fechaInicioRuta, DateTime fechaFinDespacho, DateTime fechaInicioRecibo, DateTime fechaFinRuta, DateTime fechaFinRecibo)
        {
            Estadopedido = estadopedido;
            FechaInicioAprobacion = fechaInicioAprobacion;
            FechaInicioArmando = fechaInicioArmando;
            FechaFinAprobacion = fechaFinAprobacion;
            FechaInicioDespacho = fechaInicioDespacho;
            FechaFinArmando = fechaFinArmando;
            FechaInicioRuta = fechaInicioRuta;
            FechaFinDespacho = fechaFinDespacho;
            FechaInicioRecibo = fechaInicioRecibo;
            FechaFinRuta = fechaFinRuta;
            FechaFinRecibo = fechaFinRecibo;
        }
    }
}
