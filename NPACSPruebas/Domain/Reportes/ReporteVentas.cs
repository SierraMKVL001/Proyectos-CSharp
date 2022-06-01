using System;

namespace Domain.Reportes
{
    public class ReporteVentas
    {
        public DateTime reportDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double totalNetVentas { get; set; }
    }
}