using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DashBoard
{
    public class E_Ensamble
    {
        string numFolio;
        string nCliente;
        string nEmpleado;
        string subTotal;
        string iVA;
        string total;

        public string NumFolio { get => numFolio; set => numFolio = value; }
        public string NCliente { get => nCliente; set => nCliente = value; }
        public string NEmpleado { get => nEmpleado; set => nEmpleado = value; }
        public string SubTotal { get => subTotal; set => subTotal = value; }
        public string IVA { get => iVA; set => iVA = value; }
        public string Total { get => total; set => total = value; }
    }
}
