using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entidades
{
    public class Productos
    {
        public int idPro { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string Descripcion { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public decimal precioUnid { get; set; }
        public int idProvedor { get; set; }
        public int stock { get; set; }
    }
}
