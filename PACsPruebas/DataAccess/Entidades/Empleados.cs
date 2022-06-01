using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entidades
{
    public class Empleados
    {
        public int idEmp { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string logName { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public int idPuesto { get; set; }
    }
}
