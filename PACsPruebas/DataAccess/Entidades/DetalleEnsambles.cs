using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entidades
{
    public class DetalleEnsambles
    {
        public int idDet_Ens { get; set; }
        public int idEnsam { get; set; }
        public int idProduct { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
        public int idObser { get; set; }
        public string NumSerie { get; set; }
    }
}
