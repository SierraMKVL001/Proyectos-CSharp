using System;

namespace Domain.Reportes
{
    public class ListaVentas
    {
        public int idEnsamble { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string solicito { get; set; }
        public string productos { get; set; }
        public double total { get; set; }
    }
}