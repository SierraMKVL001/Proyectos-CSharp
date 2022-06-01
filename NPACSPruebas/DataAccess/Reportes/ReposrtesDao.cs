using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Reportes
{
    public class ReposrtesDao:ConexionDB
    {
        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection = conection;
                    command.CommandText = "Reportes_Ensambles";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
                    command.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;
                }
            }
        }
    }
}
