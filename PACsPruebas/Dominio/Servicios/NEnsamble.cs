using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataAccess.Entidades;

namespace Dominio.Servicios
{
    public class NEnsamble
    {
        //Método Insertar que llama al método Insertar de la clase DVenta
        //de la CapaDatos
        public static string Insertar( string NumFolio, int idCliente, int idEmpleado, int idTipo, DateTime Fecha,decimal total, DataTable dtDetalles)
        {
            DEnsamble Obj = new DEnsamble();
            Obj.NumFolio1 = NumFolio;
            Obj.IdCliente = idCliente;
            Obj.IdEmpleado = idEmpleado;
            Obj.IdTipo = idTipo;
            Obj.Fecha1 = Fecha;
            Obj.Total = total;
            List<DDetalle_Ensamble> detalles = new List<DDetalle_Ensamble>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Ensamble detalle = new DDetalle_Ensamble();
                detalle.IdProduct = Convert.ToInt32(row["idProduct"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
                detalles.Add(detalle);

            }


            return Obj.Insertar(Obj, detalles);
        }

        //Método Anular que llama al método Anular de la clase DVenta
        //de la CapaDatos
        public static string Eliminar(int idensamble)
        {
            DEnsamble Obj = new DEnsamble();
            Obj.IdEnsamble = idensamble;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DVenta
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DEnsamble().Mostrar();
        }

        //Método BuscarFechas que llama al método BuscarFechas
        //de la clase DVenta de la CapaDatos
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DEnsamble Obj = new DEnsamble();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DEnsamble Obj = new DEnsamble();
            return Obj.MostrarDetalle(textobuscar);
        }
        //public static DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        //{
        //    DEnsamble Obj = new DEnsamble();
        //    return Obj.MostrarArticulo_Venta_Nombre(textobuscar);
        //}
        //public static DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        //{
        //    DEnsamble Obj = new DEnsamble();
        //    return Obj.MostrarArticulo_Venta_Codigo(textobuscar);
        //}
    }
}
