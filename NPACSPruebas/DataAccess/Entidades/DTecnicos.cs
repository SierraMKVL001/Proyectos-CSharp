using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Entidades
{
    public class DTecnicos
    {
        private int idTec;
        private int idEmplea;

        public int IdTec { get => idTec; set => idTec = value; }
        public int IdEmplea { get => idEmplea; set => idEmplea = value; }


        public DTecnicos()
        {

        }
        public DTecnicos(int idTec, int idEmplea)
        {
            this.IdTec = idTec;
            this.IdEmplea = idEmplea;
        }
        public string Insertar(DTecnicos Tecnicos, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_Tecnicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTecnicos = new SqlParameter();
                ParIdTecnicos.ParameterName = "@idTec";
                ParIdTecnicos.SqlDbType = SqlDbType.Int;
                ParIdTecnicos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdTecnicos);

                SqlParameter ParIdEmplea = new SqlParameter();
                ParIdEmplea.ParameterName = "@idEmplea";
                ParIdEmplea.SqlDbType = SqlDbType.Int;
                ParIdEmplea.Value = Tecnicos.IdEmplea;
                SqlCmd.Parameters.Add(ParIdEmplea);



                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : Convert.ToString(idEmplea);

            }
            catch (Exception ex)
            {
                rpta = ex.Message + "DTecnicos";
            }

            return rpta;

        }
    }
}
