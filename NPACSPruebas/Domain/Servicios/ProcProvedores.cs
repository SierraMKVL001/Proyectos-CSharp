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
    public class ProcProvedores
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarProvedores()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListaProvedores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
    }
}
