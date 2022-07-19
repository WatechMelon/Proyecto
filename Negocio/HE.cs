using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class HE
    {
        public int Id_He { get; set; }
        public String Tamanio { get; set; }

        public String EstadoCultivo { get; set; }
        
        public int MetaCultivo { get; set; }

        public DateTime FechaCultivo { get; set; }

        public String Especie1 { get; set; }
        public String Especie2 { get; set; }
        public String Especie3 { get; set; }
        public String Especie4 { get; set; }


        public HE()
        {

        }

        public HE(int id_He, string tamanio, string estadoCultivo, int metaCultivo, DateTime fechaCultivo, string especie1, string especie2, string especie3, string especie4)
        {
            Id_He = id_He;
            Tamanio = tamanio;
            EstadoCultivo = estadoCultivo;
            MetaCultivo = metaCultivo;
            FechaCultivo = fechaCultivo;
            Especie1 = especie1;
            Especie2 = especie2;
            Especie3 = especie3;
            Especie4 = especie4;
        }
    }
}
