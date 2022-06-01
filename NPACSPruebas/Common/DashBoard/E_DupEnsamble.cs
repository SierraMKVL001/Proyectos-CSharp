using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DashBoard
{
    public class E_DupEnsamble
    {
        string nomCliente;
        string telefono;
        string direccion;
        string rfc;

        string idCliente;

        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public String IdCliente { get => idCliente; set => idCliente = value; }
    }
}
