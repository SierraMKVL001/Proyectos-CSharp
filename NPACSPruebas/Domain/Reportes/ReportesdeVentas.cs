using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Reportes;

namespace Domain.Reportes
{
    public class ReportesdeVentas
    {
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<ListaVentas> listaVentas { get; private set; }
        public List<NetVentasReport> netVentasReport { get; private set; }
        public List<ReporteVentas> reportVentas { get; private set; }
        public double totalNetVentas { get; private set; }
        



        public void crearReporteVentas(DateTime fromDate,DateTime toDate)
        {
            //
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;

            //Crear Lista
            var reposterDao = new ReposrtesDao();
            var result = reposterDao.getSalesOrder(fromDate,toDate);

            listaVentas = new List<ListaVentas>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ventasModel = new ListaVentas()
                {
                    idEnsamble = Convert.ToInt32(rows[0]),
                    fecha = Convert.ToDateTime(rows[1]),
                    cliente = Convert.ToString(rows[2]),
                    productos = Convert.ToString(rows[4]),
                    solicito = Convert.ToString(rows[3]),
                    total = Convert.ToDouble(rows[5])
                };
                listaVentas.Add(ventasModel);
                //Ventas Total
                totalNetVentas += Convert.ToDouble(rows[5]);
            }
            
            //Ventas por periodo
            var listVentasAgrupadas = (from ventas in listaVentas
                                       group ventas by ventas.fecha
                                      into listVentas
                                       select new
                                       {
                                           date = listVentas.Key,
                                           amount = listVentas.Sum(item => item.total)
                                       }).AsEnumerable();
            //Dias entre ventas
            int totalDias = Convert.ToInt32((toDate-fromDate).Days);

            //Grupo dias 7
            if (totalDias <= 7)
            {
                netVentasReport = (from ventas in listVentasAgrupadas
                                   group ventas by ventas.date.ToString("dd-MM-yyyy")
                                 into listVentas
                                   select new NetVentasReport
                                   {
                                       periodo = listVentas.Key,
                                       netSale = listVentas.Sum(item => item.amount)
                                   }
                                     ).ToList();
            }
            //Semanas
            else if(totalDias<=30)
            {
                netVentasReport = (from ventas in listVentasAgrupadas
                                   group ventas by System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                       ventas.date,System.Globalization.CalendarWeekRule.FirstDay,DayOfWeek.Monday)
                                 into listVentas
                                   select new NetVentasReport
                                   {
                                       periodo = "Semana "+listVentas.Key.ToString(),
                                       netSale = listVentas.Sum(item => item.amount)
                                   }
                                     ).ToList();

            }
            //Meses
            else if (totalDias <= 365)
            {
                netVentasReport = (from ventas in listVentasAgrupadas
                                   group ventas by ventas.date.ToString("MM-yyyy")
                                 into listVentas
                                   select new NetVentasReport
                                   {
                                       periodo = listVentas.Key,
                                       netSale = listVentas.Sum(item => item.amount)
                                   }
                                     ).ToList();
            }
            //Años
            else
            {
                netVentasReport = (from ventas in listVentasAgrupadas
                                   group ventas by ventas.date.ToString("yyyy")
                                                 into listVentas
                                   select new NetVentasReport
                                   {
                                       periodo = listVentas.Key,
                                       netSale = listVentas.Sum(item => item.amount)
                                   }
                                      ).ToList();
            }
            reportVentas = new List<ReporteVentas>();
            var reportModel = new ReporteVentas()
            {
                reportDate = reportDate,
                startDate = startDate,
                endDate = endDate,
                totalNetVentas = totalNetVentas
            };
            reportVentas.Add(reportModel);
        }
    }
}
