using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Servicios;

namespace Presentacion.Form_Ventas
{
    public partial class ProductSiExist : Form
    {
        public ProductSiExist()
        {
            InitializeComponent();
        }
        private void ListProductos()
        {
            ClsProductos objPro = new ClsProductos();
            try
            {
                dGVProductos.DataSource = objPro.ListarProdExist();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ProductSiExist_Load(object sender, EventArgs e)
        {
            ListProductos();
        }

        private void txtSearchProduc_TextChanged(object sender, EventArgs e)
        {
            ClsProductos objPro = new ClsProductos();
            try
            {
                dGVProductos.DataSource = objPro.FiltrarSiEProductos(this.txtSearchProduc.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
