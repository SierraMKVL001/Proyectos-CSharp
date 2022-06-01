using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DashBoard;
using DataAccess.DashBoard;

namespace Domain.DashBoard
{
    public class N_Observacion
    {
        public void Observacion(E_Observacion obj, int idEnsamble)
        {
            D_Observacion accesDB = new D_Observacion();
            accesDB.ObtenerObserv(obj, idEnsamble);
        }
    }
}
