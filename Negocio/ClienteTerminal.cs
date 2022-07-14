using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteTerminal : Cliente
    {
        public ClienteTerminal()
        {
        }

        public ClienteTerminal(int idCliente, string email, string pass, string barrio, int telefono, string calle, int numero, string esquina, int ci, string primerNom, string segundoNom, string primerApe, string segundoApe) : base(idCliente, email, pass, barrio, telefono, calle, numero, esquina)
        {
            Ci = ci;   
            PrimerNom = primerNom;
            SegundoNom = segundoNom;
            PrimerApe = primerApe;
            SegundoApe = segundoApe;

        }

        public int Ci
        {
            get; set;
        }
        public String PrimerNom
        {
            get; set;
        }

        public String SegundoNom
        {
            get; set;
        }

        public String PrimerApe
        {
            get; set;
        }

        public String SegundoApe
        {
            get; set;
        }





    }
}
