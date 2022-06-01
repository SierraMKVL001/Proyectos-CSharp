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
    public class ProcAdministrador
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        public DataTable FiltroListAllEnsamb(string buscarProducto, DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "List_FF_AllEnsam_Admin";
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
        public DataTable FiltroFeListAllEnsamb( DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "List_F_AllEnsam_Admin";
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
        public DataTable FiltroFeListEnsambFact(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_fecha_FacturaEnsam_Admin";
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
        public DataTable FiltroListFeEnsambFact(string buscarProducto, DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_F_fecha_FacturaEnsam_Admin";
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
        public DataTable ListEnsamListos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_ListosEnsam_Admin";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public string obtenerTecnico(int idEnsam)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "obt_Tecnico";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Add("@idEnsamble", SqlDbType.Int).Value = idEnsam;
            LeerFilas = Comando.ExecuteReader();
            if (LeerFilas.Read())
            {
                return LeerFilas["Tecnico"].ToString();
            }
            else
            {LeerFilas.Close();
                return "No Asignado";
            }
        }
        public DataTable ListAllEnsam()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "List_AllEnsamb_Admin";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListAllEnsambles()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "List_All_Ensam_Admin";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListaDetallesEnsamble(int IDDetEnsamble)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ListarDetalles_Ensamble_Admin";
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
    }
}
