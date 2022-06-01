using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Domain.Servicios
{
    public class ProcEnsambles
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public string consultIdFolio()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "select (select MAX(idEnsamble)from Ensambles) as idEnsamble";
            Comando.CommandType = CommandType.Text;
            LeerFilas = Comando.ExecuteReader();
            if (LeerFilas.Read())
            {
                return LeerFilas["idEnsamble"].ToString();
            }
            else
            {
                LeerFilas.Close();
                return "0";
            }
        }

        public DataTable ListarTipos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListaTipos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarTodosEnsambles()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Todos_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListerEnsamPendientes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Pendientes_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListerEnsamPzasAsig()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_PzasAsig_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListerEnsamTecnicosAsig()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_TecnicoAsig_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListerEnsamListos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Ensamblados_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListerEnsamFacturados()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Facturados_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable FiltroListAllEnsambles(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_Todos_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListAllEnsambFecha( DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_fecha_Todos_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                Comando.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable FiltroListAllEnsambFecha(string buscarProducto, DateTime fromDate,DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_fecha_Todos_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                Comando.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                Comando.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListPendEnsambles()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Pendiente_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable FiltroListPendEnsambles(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_Pendientes_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListEsnamblesListos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Listos_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable FiltorListEnsamblesListos(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_Listos_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListEnsamFact()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Factura_Ensambles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable FiltroListEnsambFact(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_Factura_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListFactEnsambles(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_fecha_Factura_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                Comando.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable FiltroListEnsambFact(string buscarProducto, DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_fecha_Factura_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                Comando.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                Comando.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListaDetallesEnsamble(int IDDetEnsamble)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ListarDetalles_Ensamble";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idDelEnsamble", SqlDbType.Int).Value = IDDetEnsamble;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListaEnsamblesParaTec(int idEmplea)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_PorTecnicoAsig_Ensambles";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idEmplea", SqlDbType.Int).Value = idEmplea;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListaEnsamblesdeVended(int idEmplea)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_Ensambles_Todos";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idDeVentas", SqlDbType.Int).Value = idEmplea;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable FiltroListaEnsamblesdeVended(int idEmplea,string buscarProducto,DateTime lFecha)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_Ensambles_Todos";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idDeVentas", SqlDbType.Int).Value = idEmplea;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                Comando.Parameters.Add("@fFecho", SqlDbType.Date).Value = lFecha;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListaEnsamblesListdeVended(int idEmplea)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_EnsamblesList_Ventas";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idDeVentas", SqlDbType.Int).Value = idEmplea;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable FiltroListaEnsamblesListdeVended(int idEmplea, string filtro)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_EnsamblesList_Ventas";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idDeVentas", SqlDbType.Int).Value = idEmplea;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = filtro;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
    }
}
