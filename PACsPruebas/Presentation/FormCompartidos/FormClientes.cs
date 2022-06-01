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
    public partial class FormClientes : Form
    {
        private ClientesModel clientes = new ClientesModel();

        public FormClientes()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }
        private void ListClientes()
        {
            ProcClientes objPro = new ProcClientes();
            try
            {
                dGVClientes.DataSource = objPro.ListarClientes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ListClientes();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            ProcClientes objPro = new ProcClientes();
            try
            {
                dGVClientes.DataSource = objPro.FiltrarClientes(this.txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }
        private void Restart()
        {
            panel1.Enabled = false;
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtRFC.Clear();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            clientes.State = EntityState.Added;
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dGVClientes.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                clientes.State = EntityState.Modifed;
                clientes.IdClient = Convert.ToInt32(dGVClientes.CurrentRow.Cells[0].Value);
                txtNombre.Text = dGVClientes.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = dGVClientes.CurrentRow.Cells[2].Value.ToString();
                txtCorreo.Text = dGVClientes.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dGVClientes.CurrentRow.Cells[4].Value.ToString();
                txtRFC.Text = dGVClientes.CurrentRow.Cells[5].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGVClientes.SelectedRows.Count > 0)
            {

                clientes.State = EntityState.Deleted;
                clientes.IdClient = Convert.ToInt32(dGVClientes.CurrentRow.Cells[0].Value);
                string result = clientes.SaveChanges();
                MessageBox.Show(result);
                ListClientes();

            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnSaver_Click(object sender, EventArgs e)
        {
            clientes.Nombre_RazonSocial = txtNombre.Text;
            clientes.Telefono = txtTelefono.Text;
            clientes.CorreoEL = txtCorreo.Text;
            clientes.Direccion = txtDireccion.Text;
            clientes.RFC = txtRFC.Text;

            bool valid = new Helps.DataValidation(clientes).Validate();
            if (valid == true)
            {
                string result = clientes.SaveChanges();
                MessageBox.Show(result);
                ListClientes();
                Restart();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
