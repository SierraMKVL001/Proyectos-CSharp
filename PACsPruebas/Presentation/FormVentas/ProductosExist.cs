using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio.Servicios;

namespace Presentation.FormVentas
{
    public partial class ProductosExist : Form
    {
        public ProductosExist()
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ClsProductos objPro = new ClsProductos();
            try
            {
                dGVProductos.DataSource = objPro.FiltrarProductosExist(this.txtFiltro.Text.Trim(),cmbCampo.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ProductosExist_Load(object sender, EventArgs e)
        {
            ListProductos();
        }
    }
}
