using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entidades;

namespace Domain.Servicios
{
    public class NObservacion
    {
        public static string Insertar(string observacion)
        {
            DObservaciones obj = new DObservaciones();
            obj.Observacio = observacion;
            return obj.Insertar(obj);
        }
    }
}
