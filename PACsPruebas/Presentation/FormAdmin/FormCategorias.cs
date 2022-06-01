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
    public partial class FormCategorias : Form
    {
        private CategoriasModel categorias = new CategoriasModel();
        public FormCategorias()
        {
            InitializeComponent();
            pnlPrin.Enabled = false;
        }
        private void ListarCategorias()
        {
            ClsProductos objPro = new  ClsProductos();
            
            try
            {
                dGVCategorias.DataSource = objPro.ListaCategorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Restart()
        {
            pnlPrin.Enabled = false;
            txtCategoria.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGVCategorias.SelectedRows.Count > 0)
            {
                categorias.State = EntityState.Deleted;
                categorias.IdC = Convert.ToInt32(dGVCategorias.CurrentRow.Cells[0].Value);

                string result = categorias.SaveChanges();
                MessageBox.Show(result);
                ListarCategorias();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dGVCategorias.SelectedRows.Count > 0)
            {
                pnlPrin.Enabled = true;
                categorias.State = EntityState.Modifed;
                categorias.IdC = Convert.ToInt32(dGVCategorias.CurrentRow.Cells[0].Value);
                txtCategoria.Text = dGVCategorias.CurrentRow.Cells[1].Value.ToString();
                
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlPrin.Enabled = true;
            categorias.State = EntityState.Added;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            categorias.Categoria = txtCategoria.Text;

            bool valid = new Helps.DataValidation(categorias).Validate();
            if (valid == true)
            {
                string result = categorias.SaveChanges();
                MessageBox.Show(result);
                ListarCategorias();
                Restart();
            }
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }
    }
}
