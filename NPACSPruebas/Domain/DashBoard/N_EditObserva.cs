using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DashBoard;
using DataAccess.DashBoard;

namespace Domain.DashBoard
{
    public class N_EditObserva
    {
        public void EditObservacio(E_EditObserva obj,int idObser)
        {
            D_EditObserva accesDB = new D_EditObserva();
            accesDB.ObtenerObserv(obj, idObser);
        }
    }
}
