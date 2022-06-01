using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class ConexionDB
    {
        static private string CadenaConexion = ConfigurationManager.ConnectionStrings["DBCon_Proyecto"].ConnectionString;
                                               //"Server= SIERRAMASTERPC; DataBase= NPACSPruebas; integrated security = true";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(CadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
