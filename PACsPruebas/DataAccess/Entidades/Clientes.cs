using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entidades
{
    public class Clientes
    {
     

        public int idClient { get; set; }
        public string nombre_RazonSocial { get; set; }
        public string telefono { get; set; }
        public string correoEL { get; set; }
        public string direccion { get; set; }
        public string rFC { get; set; }

    }
}
