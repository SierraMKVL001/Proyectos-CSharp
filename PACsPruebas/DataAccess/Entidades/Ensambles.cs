using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entidades
{
    public class Ensambles
    {
        public int idEnsamble { get; set; }
        public string NumFolio { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }
        public int idOrdeno { get; set; }
        public int idTecnico { get; set; }
        public int idEstatus { get; set; }
        public int idTipo { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }
    }
}
