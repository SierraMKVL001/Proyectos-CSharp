using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Entidades
{
    public class DEnsamble
    {
        private int idEnsamble;
        private string NumFolio;
        private int idCliente;
        private int idEmpleado;
        private int idTecnico;
        private int idOrdeno;
        private int idEstatus;
        private int idTipo;
        private DateTime Fecha;
        private decimal subTotal;
        private decimal iVA;
        private decimal total;
        private int idObser;

        public int IdEnsamble { get => idEnsamble; set => idEnsamble = value; }
        public string NumFolio1 { get => NumFolio; set => NumFolio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdTecnico { get => idTecnico; set => idTecnico = value; }
        public int IdOrdeno { get => idOrdeno; set => idOrdeno = value; }
        public int IdEstatus { get => idEstatus; set => idEstatus = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public decimal Total { get => total; set => total = value; }
        public int IdObser { get => idObser; set => idObser = value; }
        public decimal SubTotal { get => subTotal; set => subTotal = value; }
        public decimal IVA { get => iVA; set => iVA = value; }

        public DEnsamble()
        {

        }
        public DEnsamble(int idEnsamble, string NumFolio, int idCliente, int idEmpleado, int idTipo, DateTime Fecha, decimal total,decimal subTotal,decimal iVA)
        {
            this.IdEnsamble = idEnsamble;
            this.NumFolio1 = NumFolio;
            this.IdCliente = idCliente;
            this.IdEmpleado = idEmpleado;
            this.IdTipo = idTipo;
            this.Fecha1 = Fecha;
            this.SubTotal = subTotal;
            this.iVA = iVA;
            this.Total = total;
        }
        public DEnsamble(int idEnsamble, string NumFolio, int idCliente, int idEmpleado, int idTipo, DateTime Fecha, decimal total, decimal subTotal, decimal iVA, int idObser)
        {
            this.IdEnsamble = idEnsamble;
            this.NumFolio1 = NumFolio;
            this.IdCliente = idCliente;
            this.IdEmpleado = idEmpleado;
            this.IdTipo = idTipo;
            this.Fecha1 = Fecha;
            this.SubTotal = subTotal;
            this.iVA = iVA;
            this.Total = total;
            this.IdObser = idObser;
        }
        //Métodos
        public string Insertar(DEnsamble Ensamble, List<DDetalle_Ensamble> Detalles)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                ////Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                ////Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_EnsamblePend";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámtros
                SqlParameter ParIdEnsamble = new SqlParameter();
                ParIdEnsamble.ParameterName = "@idEnsamble";
                ParIdEnsamble.SqlDbType = SqlDbType.Int;
                ParIdEnsamble.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEnsamble);

                SqlParameter ParNumFolio = new SqlParameter();
                ParNumFolio.ParameterName = "@NumFolio";
                ParNumFolio.SqlDbType = SqlDbType.VarChar;
                ParNumFolio.Value = Ensamble.NumFolio1;
                SqlCmd.Parameters.Add(ParNumFolio);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Ensamble.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idEmpleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Ensamble.IdEmpleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParTipo_Comprobante = new SqlParameter();
                ParTipo_Comprobante.ParameterName = "@idTipo";
                ParTipo_Comprobante.SqlDbType = SqlDbType.Int;
                ParTipo_Comprobante.Value = Ensamble.IdTipo;
                SqlCmd.Parameters.Add(ParTipo_Comprobante);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Ensamble.Fecha1;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParSubTotal = new SqlParameter();
                ParSubTotal.ParameterName = "@SubTotal";
                ParSubTotal.SqlDbType = SqlDbType.Decimal;
                ParSubTotal.Value = Ensamble.SubTotal;
                SqlCmd.Parameters.Add(ParSubTotal);

                SqlParameter ParIVA = new SqlParameter();
                ParIVA.ParameterName = "@IVA";
                ParIVA.SqlDbType = SqlDbType.Decimal;
                ParIVA.Value = Ensamble.IVA;
                SqlCmd.Parameters.Add(ParIVA);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@Total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Value = Ensamble.Total;
                SqlCmd.Parameters.Add(ParTotal);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.idEnsamble = Convert.ToInt32(SqlCmd.Parameters["@idEnsamble"].Value);
                    foreach (DDetalle_Ensamble det in Detalles)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        det.IdEnsam = this.IdEnsamble;
                        //Llamamos al metodo insertar de la clase DetalleIngreso
                        //y le pasamos la conexion y la transaccion que debe de usar
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            //Si ocurre un error al insertar un detalle de ingreso salimos del for
                            break;
                        }
                        else
                        {
                            //Actualizamos el Stock

                            rpta = DisminuirStock(det.IdProduct, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message + "DEnsamble";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
        public string InsertarObser(DEnsamble Ensamble, List<DDetalle_Ensamble> Detalles)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                ////Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                ////Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_EnsamblePend_Obs";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámtros
                SqlParameter ParIdEnsamble = new SqlParameter();
                ParIdEnsamble.ParameterName = "@idEnsamble";
                ParIdEnsamble.SqlDbType = SqlDbType.Int;
                ParIdEnsamble.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEnsamble);

                SqlParameter ParNumFolio = new SqlParameter();
                ParNumFolio.ParameterName = "@NumFolio";
                ParNumFolio.SqlDbType = SqlDbType.VarChar;
                ParNumFolio.Value = Ensamble.NumFolio1;
                SqlCmd.Parameters.Add(ParNumFolio);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Ensamble.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idEmpleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Ensamble.IdEmpleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParTipo_Comprobante = new SqlParameter();
                ParTipo_Comprobante.ParameterName = "@idTipo";
                ParTipo_Comprobante.SqlDbType = SqlDbType.Int;
                ParTipo_Comprobante.Value = Ensamble.IdTipo;
                SqlCmd.Parameters.Add(ParTipo_Comprobante);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Ensamble.Fecha1;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParSubTotal = new SqlParameter();
                ParSubTotal.ParameterName = "@SubTotal";
                ParSubTotal.SqlDbType = SqlDbType.Decimal;
                ParSubTotal.Value = Ensamble.SubTotal;
                SqlCmd.Parameters.Add(ParSubTotal);

                SqlParameter ParIVA = new SqlParameter();
                ParIVA.ParameterName = "@IVA";
                ParIVA.SqlDbType = SqlDbType.Decimal;
                ParIVA.Value = Ensamble.IVA;
                SqlCmd.Parameters.Add(ParIVA);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@Total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Value = Ensamble.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParIdObser = new SqlParameter();
                ParIdObser.ParameterName = "@idObser";
                ParIdObser.SqlDbType = SqlDbType.Int;
                ParIdObser.Value = Ensamble.IdObser;
                SqlCmd.Parameters.Add(ParIdObser);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.idEnsamble = Convert.ToInt32(SqlCmd.Parameters["@idEnsamble"].Value);
                    foreach (DDetalle_Ensamble det in Detalles)
                    {
                        //Establecemos el codigo del ingreso que se autogenero
                        det.IdEnsam = this.IdEnsamble;
                        //Llamamos al metodo insertar de la clase DetalleIngreso
                        //y le pasamos la conexion y la transaccion que debe de usar
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            //Si ocurre un error al insertar un detalle de ingreso salimos del for
                            break;
                        }
                        else
                        {
                            //Actualizamos el Stock

                            rpta = DisminuirStock(det.IdProduct, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message + "DEnsamble";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
        public string Eliminar(DEnsamble Ensamble)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_Ensamble";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idEnsamble";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Ensamble.idEnsamble;
                SqlCmd.Parameters.Add(ParIdventa);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        //Disminuir Stock
        public string DisminuirStock(int iddetalle_ingreso, int cantidad)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdisminuirel_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProduct = new SqlParameter();
                ParIdProduct.ParameterName = "@idProduct";
                ParIdProduct.SqlDbType = SqlDbType.Int;
                ParIdProduct.Value = iddetalle_ingreso;
                SqlCmd.Parameters.Add(ParIdProduct);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Se actualizó el Stock";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Ensamble");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_Ensamble";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método BuscarFechas
        public DataTable BuscarFechas(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Ensamble");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_Ensamble_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Método BuscarFechas
        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_Ensamble");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_Ensamble";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        //public DataTable MostrarArticulo_Venta_Nombre(String TextoBuscar)
        //{
        //    DataTable DtResultado = new DataTable("articulo");
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon.ConnectionString = ConexionDB.cn;
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "spbuscararticulo_venta_nombre";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParTextoBuscar = new SqlParameter();
        //        ParTextoBuscar.ParameterName = "@textobuscar";
        //        ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
        //        ParTextoBuscar.Size = 50;
        //        ParTextoBuscar.Value = TextoBuscar;
        //        SqlCmd.Parameters.Add(ParTextoBuscar);

        //        SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
        //        SqlDat.Fill(DtResultado);

        //    }
        //    catch (Exception ex)
        //    {
        //        DtResultado = null;
        //    }
        //    return DtResultado;

        //}
        //public DataTable MostrarArticulo_Venta_Codigo(String TextoBuscar)
        //{
        //    DataTable DtResultado = new DataTable("Producto");
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon.ConnectionString = ConexionDB.cn;
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "spbuscararticulo_venta_codigo";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParTextoBuscar = new SqlParameter();
        //        ParTextoBuscar.ParameterName = "@textobuscar";
        //        ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
        //        ParTextoBuscar.Size = 50;
        //        ParTextoBuscar.Value = TextoBuscar;
        //        SqlCmd.Parameters.Add(ParTextoBuscar);

        //        SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
        //        SqlDat.Fill(DtResultado);

        //    }
        //    catch (Exception ex)
        //    {
        //        DtResultado = null;
        //    }
        //    return DtResultado;

        //}
    }
}
