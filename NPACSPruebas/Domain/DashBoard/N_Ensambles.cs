using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DashBoard;
using DataAccess.DashBoard;

namespace Domain.DashBoard
{
    public class N_Ensambles
    {
        public void DatosEnam(int idEnsamble,E_Ensamble obj)
        {
            D_Ensambles accessDat = new D_Ensambles();
            accessDat.ObtDatos(idEnsamble, obj);
        }
    }
}
