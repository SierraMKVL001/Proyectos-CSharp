using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio.Modelos;
using Dominio.ValueObjects;
using Dominio.Servicios;

namespace Presentation.FormCompartidos
{
    public partial class FormProductos : Form
    {
        private ProductosModel productos = new ProductosModel();

        public FormProductos()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }
        private void ListProductos()
        {
            ClsProductos objPro = new ClsProductos();
            try
            {
                dGVProductos.DataSource = objPro.ListarProductos();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ListProductos();
            ListarCategorias();
            ListarProvedores();
            ListarMarcas();
        }

        private void ListarCategorias()
        {
            ClsProductos objProd = new ClsProductos();
            cmbCategoria.DataSource = objProd.ListarCategorias();
            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.ValueMember = "idC";
        }
        private void ListarMarcas()
        {
            ClsProductos objProd = new ClsProductos();
            cmbMarca.DataSource = objProd.ListarMarcas();
            cmbMarca.DisplayMember = "Marca";
            cmbMarca.ValueMember = "idM";

        }
        private void ListarProvedores()
        {
            ClsProductos objPre = new ClsProductos();
            cmbProvedor.DataSource = objPre.ListarProvedores();
            cmbProvedor.DisplayMember = "Provedor";
            cmbProvedor.ValueMember = "idProv";
        }
        private void Restart()
        {
            panel1.Enabled = false;
            txtNombre.Clear();
            txtNumSerie.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            ListarCategorias();
            ListarMarcas();
            ListarProvedores();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSearchP_TextChanged(object sender, EventArgs e)
        {
            ClsProductos objPro = new ClsProductos();
            try
            {
                dGVProductos.DataSource = objPro.FiltrarProductosAdmin(this.txtSearchP.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleter_Click(object sender, EventArgs e)
        {
            if (dGVProductos.SelectedRows.Count > 0)
            {

                productos.State = EntityState.Deleted;
                productos.IdPro = Convert.ToInt32(dGVProductos.CurrentRow.Cells[0].Value);
                string result = productos.SaveCanges();
                MessageBox.Show(result);
                ListProductos();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dGVProductos.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                productos.State = EntityState.Modifed;
                productos.IdPro = Convert.ToInt32(dGVProductos.CurrentRow.Cells[0].Value);
                txtNumSerie.Text = dGVProductos.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dGVProductos.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = dGVProductos.CurrentRow.Cells[3].Value.ToString();
                cmbCategoria.Text = dGVProductos.CurrentRow.Cells[4].Value.ToString();
                cmbMarca.Text = dGVProductos.CurrentRow.Cells[5].Value.ToString();
                txtPrecio.Text = dGVProductos.CurrentRow.Cells[6].Value.ToString();
                cmbProvedor.Text = dGVProductos.CurrentRow.Cells[7].Value.ToString();
                txtStock.Text = dGVProductos.CurrentRow.Cells[8].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnNewer_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            productos.State = EntityState.Added;
        }

        private void btnSaver_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCategoria.SelectedValue) == 1)
            {
                MensajeError("El campo Categoria no puede estar vacia");
            }
            else
            {
                if (Convert.ToInt32(cmbMarca.SelectedValue) == 1)
                {
                    MensajeError("El campo Marca no puede estar vacia");
                }
                else
                {
                    productos.Nombre = txtNombre.Text;
                    productos.Codigo = txtNumSerie.Text;
                    productos.Descripcion1 = txtDescripcion.Text;
                    productos.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                    productos.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue);
                    productos.PrecioUnid = Convert.ToDecimal(txtPrecio.Text);
                    productos.IdProvedor = Convert.ToInt32(cmbProvedor.SelectedValue);
                    productos.Stock = Convert.ToInt32(txtStock.Text);

                    bool valid = new Helps.DataValidation(productos).Validate();
                    if (valid == true)
                    {
                        string result = productos.SaveCanges();
                        MessageBox.Show(result);
                        ListProductos();
                        Restart();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
