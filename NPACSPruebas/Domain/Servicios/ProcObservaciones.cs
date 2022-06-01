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
    public class ProcObservaciones
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public string consultaObservaciones()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "select (select MAX(idObs)from Observaciones) as idObs";
            Comando.CommandType = CommandType.Text;
            LeerFilas = Comando.ExecuteReader();
            if (LeerFilas.Read())
            {
                return LeerFilas["idObs"].ToString();

            }
            else
            {
                return "No. Observacion";
            }
        }
        public string obtenerObservacion(int idEnsam)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "obt_Obs";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Add("@idEnsamble", SqlDbType.Int).Value = idEnsam;
            LeerFilas = Comando.ExecuteReader();
            if (LeerFilas.Read())
            {
                return LeerFilas["Observacion"].ToString();

            }
            else
            {
                return "Ninguna Observacion";
            }
        }
        public DataTable ListObservacionesEnsam(int idObs)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Listar_Observaciones";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idObs", SqlDbType.Int).Value = idObs;
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
