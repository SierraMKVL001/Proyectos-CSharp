using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    class Conexion
    {
        public static string Cn = ConfigurationManager.ConnectionStrings["DBCon_Proyecto"].ConnectionString;
            
            //"Server= SIERRAMASTERPC; DataBase= NPACSPruebas; integrated security = true";
    }
}
