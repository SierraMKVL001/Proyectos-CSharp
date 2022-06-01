using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DashBoard;
using DataAccess.DashBoard;

namespace Domain.DashBoard
{
    public class N_DupEnsamble
    {
        public void DatosCliente(E_DupEnsamble obj, int idCliente)
        {
            D_DupEnsamble accesDB = new D_DupEnsamble();
            accesDB.ObtenerDatosCliente(obj, idCliente);
        }
        public void idCliente(E_DupEnsamble obj1,int idEnsamble)
        {
            D_DupEnsamble axesDB = new D_DupEnsamble();
            axesDB.ObteneridCliente(obj1, idEnsamble);
        }
    }
}
