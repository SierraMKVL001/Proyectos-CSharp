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
    public class D_EditObserva
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();

        public void ObtenerObserv(E_EditObserva obj, int idObser)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "obt_LAObservacion";
            Comando.CommandType = CommandType.StoredProcedure;

            SqlParameter observacion = new SqlParameter("@Obsercacion", SqlDbType.VarChar,50); observacion.Direction = ParameterDirection.Output;

            Comando.Parameters.Add("@idObs", SqlDbType.Int).Value = idObser;
            Comando.Parameters.Add(observacion);
            Comando.ExecuteNonQuery();

            obj. Observacion= Comando.Parameters["@Obsercacion"].Value.ToString();

            Conexion.CerrarConexion();
        }
    }
}
