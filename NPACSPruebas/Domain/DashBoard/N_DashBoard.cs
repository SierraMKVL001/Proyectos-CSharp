using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DashBoard;
using DataAccess.DashBoard;

namespace Domain.DashBoard
{
    public class N_DashBoard
    {
        public void Dashboard(E_DashBoard obj)
        {
            D_DashBoard accesDB = new D_DashBoard();
            accesDB.ProdPorCategoria(obj);
            accesDB.ProdPreferidos(obj);
            accesDB.SumDatos(obj);
        }
    }
}
