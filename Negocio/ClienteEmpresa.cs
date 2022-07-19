using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteEmpresa : Cliente
    {
        private object rut;
        private object idCliente1;
        private object value;

        public ClienteEmpresa()
        {
        }

        public ClienteEmpresa(object rut)
        {
            this.rut = rut;
        }

        public ClienteEmpresa(int idCliente, string email, string pass, string barrio, int telefono, string calle, int numero, string esquina, int rut) : base(idCliente, email, pass, barrio, telefono, calle, numero, esquina)
        {
            Rut = rut;
        }

        public int Rut
        {
            get; set;
        }


    }
}
