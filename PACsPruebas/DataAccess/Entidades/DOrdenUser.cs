using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Entidades
{
    public class DOrdenUser
    {
        private int idOrden;
        private int idEMplea;

        public int IdOrden { get => idOrden; set => idOrden = value; }
        public int IdEMplea { get => idEMplea; set => idEMplea = value; }

        public DOrdenUser()
        {

        }
        public DOrdenUser(int idOrden,int idEMplea)
        {
            this.IdOrden = idOrden;
            this.IdEMplea = idEMplea;
        }
        public string Insertar(DOrdenUser OrdenUser, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_OrdenUsr";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Ensamble = new SqlParameter();
                ParIddetalle_Ensamble.ParameterName = "@idOrden";
                ParIddetalle_Ensamble.SqlDbType = SqlDbType.Int;
                ParIddetalle_Ensamble.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Ensamble);

                SqlParameter ParIdEMplea = new SqlParameter();
                ParIdEMplea.ParameterName = "@idEMplea";
                ParIdEMplea.SqlDbType = SqlDbType.Int;
                ParIdEMplea.Value = OrdenUser.IdEMplea;
                SqlCmd.Parameters.Add(ParIdEMplea);



                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : Convert.ToString(idEMplea);

            }
            catch (Exception ex)
            {
                rpta = ex.Message + "DOrdenUser";
            }

            return rpta;

        }

    }
}
