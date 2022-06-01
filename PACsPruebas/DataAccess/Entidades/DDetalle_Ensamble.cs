using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Entidades
{
    public class DDetalle_Ensamble
    {
        private int idDet_Ens;
        private int idEnsam;
        private int idProduct;
        private int cantidad;
        private decimal precio_Venta;
        private decimal descuento;
        private int idObser;

        public int IdDet_Ens { get => idDet_Ens; set => idDet_Ens = value; }
        public int IdEnsam { get => idEnsam; set => idEnsam = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio_Venta { get => precio_Venta; set => precio_Venta = value; }
        public decimal Descuento { get => descuento; set => descuento = value; }
        public int IdObser { get => idObser; set => idObser = value; }

        public DDetalle_Ensamble()
        {

        }
        public DDetalle_Ensamble(int idDet_Ens,int idEnsam,int idPzasEn,int cantidad,decimal precio_Venta,decimal descuento,int idObser)
        {
            this.IdDet_Ens = idDet_Ens;
            this.IdEnsam = idEnsam;
            this.IdProduct = idPzasEn;
            this.Cantidad = cantidad;
            this.Precio_Venta = precio_Venta;
            this.Descuento = descuento;
            this.IdObser = idObser;
                
        }
        public DDetalle_Ensamble(int idDet_Ens, int idEnsam, int idPzasEn, int cantidad, decimal precio_Venta, decimal descuento)
        {
            this.IdDet_Ens = idDet_Ens;
            this.IdEnsam = idEnsam;
            this.IdProduct = idPzasEn;
            this.Cantidad = cantidad;
            this.Precio_Venta = precio_Venta;
            this.Descuento = descuento;
        }
        public string Insertar(DDetalle_Ensamble Detalle_Ensamble, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle_Ensambles";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Ensamble = new SqlParameter();
                ParIddetalle_Ensamble.ParameterName = "@iddetalle_Ensamble";
                ParIddetalle_Ensamble.SqlDbType = SqlDbType.Int;
                ParIddetalle_Ensamble.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Ensamble);

                SqlParameter ParIdEnsambles = new SqlParameter();
                ParIdEnsambles.ParameterName = "@idEnsamble";
                ParIdEnsambles.SqlDbType = SqlDbType.Int;
                ParIdEnsambles.Value = Detalle_Ensamble.IdEnsam;
                SqlCmd.Parameters.Add(ParIdEnsambles);

                SqlParameter ParIdProduct = new SqlParameter();
                ParIdProduct.ParameterName = "@idProduct";
                ParIdProduct.SqlDbType = SqlDbType.Int;
                ParIdProduct.Value = Detalle_Ensamble.IdProduct;
                SqlCmd.Parameters.Add(ParIdProduct);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalle_Ensamble.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@Precio_Venta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Venta.Value = Detalle_Ensamble.Precio_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Money;
                ParDescuento.Value = Detalle_Ensamble.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : Convert.ToString(IdEnsam) + Convert.ToString(IdProduct) + Convert.ToString(Cantidad) + Convert.ToString(Precio_Venta) 
                    + Convert.ToString(Descuento);

            }
            catch (Exception ex)
            {
                rpta = ex.Message+"DDetalle_Ensamble";
            }

            return rpta;

        }

    }
}

