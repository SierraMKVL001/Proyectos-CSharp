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
    public class D_Observacion
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();

        public void ObtenerObserv(E_Observacion obj, int idEnsamble)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "datos_obs";
            Comando.CommandType = CommandType.StoredProcedure;

            SqlParameter observacion = new SqlParameter("@idObserva", 0); observacion.Direction = ParameterDirection.Output;
            
            Comando.Parameters.Add("@idEnsamble", SqlDbType.Int).Value = idEnsamble;
            Comando.Parameters.Add(observacion);
            Comando.ExecuteNonQuery();

            obj.IdObserva= Comando.Parameters["@idObserva"].Value.ToString();

            Conexion.CerrarConexion();
        }
    }
}
