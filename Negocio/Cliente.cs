using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public String Email { get; set; }
        public String Pass { get; set; }
        public String Barrio { get; set; }
        public int Telefono { get; set; }
        public String Calle { get; set; }
        public int Numero { get; set; }
        public String Esquina { get; set; }



        public Cliente()
        {
        }

        public Cliente(int idCliente, string email, string pass, string barrio, int telefono, string calle, int numero, string esquina)
        {
            this.IdCliente = idCliente;
            this.Email = email;
            this.Pass = pass;
            Barrio = barrio;
            this.Telefono = telefono;
            this.Calle = calle;
            this.Numero = numero;
            this.Esquina = esquina;
        }
    }


}
