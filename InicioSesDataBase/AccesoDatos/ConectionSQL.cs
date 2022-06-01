using System;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public abstract class ConectionSQL
    {
        private readonly string connectionString;
        public ConectionSQL()
        {
            connectionString = "Server= SIERRAMASTERPC; DataBase= PACSComp; integrated security = true";
        }
        protected SqlConnection GetConection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
