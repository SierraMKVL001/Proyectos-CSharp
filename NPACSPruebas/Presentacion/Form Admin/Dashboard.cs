using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.DashBoard;
using Domain.DashBoard;
using Presentacion.Reportes;

namespace Presentacion.Form_Admin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void DashBoard()
        {
            N_DashBoard neg = new N_DashBoard();
            E_DashBoard obj = new E_DashBoard();
            neg.Dashboard(obj);
            crtProductPrefe.Series[0].Points.DataBindXY(obj.Producto, obj.Cant);
            crtProductCateg.Series[0].Points.DataBindXY(obj.Categoria,obj.CantProd);
            lbltotalVentas.Text = obj.TotalVentas;
            lblProvedores.Text = obj.CantProvedores;
            lblProductos.Text = obj.CantProductos;
            lblMarcas.Text = obj.CantMarcas;
            lblEmpleados.Text = obj.CantEmpleados;
            lblClientes.Text = obj.CantClientes;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DashBoard();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            var fimp = new ReportesVentas();
            fimp.ShowDialog();
        }
    }
}
