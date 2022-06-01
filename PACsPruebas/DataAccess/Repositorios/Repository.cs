using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public abstract class Repository
    {
        private readonly string connectionString;
        public Repository()
        {
            connectionString = "Server= SIERRAMASTERPC; DataBase= NPACSPruebas; integrated security = true";
        }
        protected SqlConnection GetConnection(){
            return new SqlConnection(connectionString);
        }

    }
}
