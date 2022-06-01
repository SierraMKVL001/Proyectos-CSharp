using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Dominio.Servicios
{
    public class ProcEmpleados
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarEmpleados()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarPuestos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarPuestos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarEmpleadosT()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListOrdenUser(int idEmplea)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ListOrdenUser";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idUser", SqlDbType.Int).Value = idEmplea;
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
        public DataTable LisTecnicos(int idEmplea)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ListTecnicos";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idTec", SqlDbType.Int).Value = idEmplea;
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
