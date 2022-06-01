using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Common.DashBoard
{
    public class E_DashBoard
    {
        ArrayList categoria = new ArrayList();
        ArrayList cantProd = new ArrayList();
        ArrayList producto = new ArrayList();
        ArrayList cant = new ArrayList();
        string totalVentas;
        string cantCategorias;
        string cantMarcas;
        string cantProductos;
        string cantClientes;
        string cantEmpleados;
        string cantProvedores;
        string cantEnsambles;
        string cantTecnicos;
        string cantOrdenUsers;

        public ArrayList Categoria { get => categoria; set => categoria = value; }
        public ArrayList CantProd { get => cantProd; set => cantProd = value; }
        public ArrayList Producto { get => producto; set => producto = value; }
        public ArrayList Cant { get => cant; set => cant = value; }
        public string TotalVentas { get => totalVentas; set => totalVentas = value; }
        public string CantCategorias { get => cantCategorias; set => cantCategorias = value; }
        public string CantMarcas { get => cantMarcas; set => cantMarcas = value; }
        public string CantProductos { get => cantProductos; set => cantProductos = value; }
        public string CantClientes { get => cantClientes; set => cantClientes = value; }
        public string CantEmpleados { get => cantEmpleados; set => cantEmpleados = value; }
        public string CantProvedores { get => cantProvedores; set => cantProvedores = value; }
        public string CantEnsambles { get => cantEnsambles; set => cantEnsambles = value; }
        public string CantTecnicos { get => cantTecnicos; set => cantTecnicos = value; }
        public string CantOrdenUsers { get => cantOrdenUsers; set => cantOrdenUsers = value; }
    }
}
