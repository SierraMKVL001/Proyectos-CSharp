using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.DashBoard;

namespace DataAccess.DashBoard
{
    public class D_DupEnsamble
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();

        public void ObtenerDatosCliente(E_DupEnsamble obj, int idCliente)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "obt_DatosCliente";
            Comando.CommandType = CommandType.StoredProcedure;

            SqlParameter nombre = new SqlParameter("@NomCliente", SqlDbType.VarChar, 20); nombre.Direction = ParameterDirection.Output;
            SqlParameter telefono = new SqlParameter("@Telefono", SqlDbType.VarChar, 20); telefono.Direction = ParameterDirection.Output;
            SqlParameter direccion = new SqlParameter("@Direccion", SqlDbType.VarChar, 30); direccion.Direction = ParameterDirection.Output;
            SqlParameter rfc = new SqlParameter("@RFC", SqlDbType.VarChar, 20); rfc.Direction = ParameterDirection.Output;

            Comando.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
            Comando.Parameters.Add(nombre);
            Comando.Parameters.Add(telefono);
            Comando.Parameters.Add(direccion);
            Comando.Parameters.Add(rfc);
            Comando.ExecuteNonQuery();

            obj.NomCliente = Comando.Parameters["@NomCliente"].Value.ToString();
            obj.Telefono = Comando.Parameters["@Telefono"].Value.ToString();
            obj.Direccion = Comando.Parameters["@Direccion"].Value.ToString();
            obj.Rfc = Comando.Parameters["@RFC"].Value.ToString();

            Conexion.CerrarConexion();
        }
        public void ObteneridCliente(E_DupEnsamble obj1,int idEnsamble)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "obt_idCliente";
            Comando.CommandType = CommandType.StoredProcedure;

            SqlParameter nombre = new SqlParameter("@idCliente", SqlDbType.Int); nombre.Direction = ParameterDirection.Output;
            

            Comando.Parameters.Add("@idEnsamble", SqlDbType.Int).Value = idEnsamble;
            Comando.Parameters.Add(nombre);
            Comando.ExecuteNonQuery();

            obj1.IdCliente = Comando.Parameters["@idCliente"].Value.ToString();
            Conexion.CerrarConexion();
        }
    }
}
