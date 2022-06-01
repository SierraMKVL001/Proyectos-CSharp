using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataAccess.Entidades;

namespace Dominio.Servicios
{
    public class NEmpleado
    {
        public static string InsertarTec(string nombres, string apellidos, string logName, string pass, string email, int idPuesto)
        {
            DEmpleados Obj = new DEmpleados();
            Obj.Nombres = nombres;
            Obj.Apellidos = apellidos;
            Obj.LogName = logName;
            Obj.Pass = pass;
            Obj.Email = email;
            Obj.IdPuesto = idPuesto;
            return Obj.InsertTec(Obj);
        }
        public static string InsertarOrdn(string nombres, string apellidos, string logName, string pass, string email, int idPuesto)
        {
            DEmpleados Obj = new DEmpleados();
            Obj.Nombres = nombres;
            Obj.Apellidos = apellidos;
            Obj.LogName = logName;
            Obj.Pass = pass;
            Obj.Email = email;
            Obj.IdPuesto = idPuesto;
            return Obj.InsertOrden(Obj);
        }
    }
}
