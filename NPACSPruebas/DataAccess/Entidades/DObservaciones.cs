using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Entidades
{
    public class DObservaciones
    {
        private int idObs;
        private string observacion;

        public int IdObs { get => idObs; set => idObs = value; }
        public string Observacio { get => observacion; set => observacion = value; }

        public DObservaciones()
        {

        }
        public DObservaciones(int idObs,string observacion)
        {
            this.idObs = idObs;
            this.observacion = observacion;
        }
        public string Insertar(DObservaciones Observacion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                ////Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                ////Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_Obser";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParObserva = new SqlParameter();
                ParObserva.ParameterName = "@Observacion";
                ParObserva.SqlDbType = SqlDbType.VarChar;
                ParObserva.Value = Observacion.Observacio;
                SqlCmd.Parameters.Add(ParObserva);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : Convert.ToString(Observacio);

            }
            catch (Exception ex)
            {
                rpta = ex.Message + "DObservaciones";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
    }
}
