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


namespace Presentation.FormAdmin
{
    public partial class FormMarcas : Form
    {
        private MarcasModel marcas = new MarcasModel();
        public FormMarcas()
        {
            InitializeComponent();
            pnlPrin.Enabled = false;
        }
        private void ListarMarcas()
        {
            ClsProductos objPro = new ClsProductos();

            try
            {
                dGVMarcas.DataSource = objPro.ListaMarcas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Restart()
        {
            pnlPrin.Enabled = false;
            txtMarca.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGVMarcas.SelectedRows.Count > 0)
            {
                marcas.State = EntityState.Deleted;
                marcas.IdM = Convert.ToInt32(dGVMarcas.CurrentRow.Cells[0].Value);

                string result = marcas.SaveChanges();
                MessageBox.Show(result);
                ListarMarcas();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dGVMarcas.SelectedRows.Count > 0)
            {
                pnlPrin.Enabled = true;
                marcas.State = EntityState.Modifed;
                marcas.IdM = Convert.ToInt32(dGVMarcas.CurrentRow.Cells[0].Value);
                txtMarca.Text = dGVMarcas.CurrentRow.Cells[1].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlPrin.Enabled = true;
            marcas.State = EntityState.Added;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            marcas.Marca = txtMarca.Text;

            bool valid = new Helps.DataValidation(marcas).Validate();
            if (valid == true)
            {
                string result = marcas.SaveChanges();
                MessageBox.Show(result);
                ListarMarcas();
                Restart();
            }
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            ListarMarcas();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
