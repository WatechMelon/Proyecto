using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public String email { get; set; }
        public String pass { get; set; }
        public String Barrio { get; set; }
        public int telefono { get; set; }
        public String calle { get; set; }
        public int numero { get; set; }
        public String esquina { get; set; }



        public Cliente()
        {
        }

        public Cliente(int idCliente, string email, string pass, string barrio, int telefono, string calle, int numero, string esquina)
        {
            this.idCliente = idCliente;
            this.email = email;
            this.pass = pass;
            Barrio = barrio;
            this.telefono = telefono;
            this.calle = calle;
            this.numero = numero;
            this.esquina = esquina;
        }
    }


}
