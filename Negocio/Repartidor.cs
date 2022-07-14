using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Repartidor
    {
        public int IdRepartidor = 84321;
        public String Contra = "Contra";

        public Repartidor()
        {

        }
        public Repartidor(int idRepartidor, string contra)
        {
            this.IdRepartidor = idRepartidor;
            Contra = contra;
        }
    }
}
