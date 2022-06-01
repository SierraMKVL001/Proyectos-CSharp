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
    public partial class FormProvedores : Form
    {
        private ProvedoresModel provedores = new ProvedoresModel();
        public FormProvedores()
        {
            InitializeComponent();
            pnlPrin.Enabled = false;
        }
        private void ListarProvedores()
        {
            ProcProvedores objPro = new ProcProvedores();

            try
            {
                dGVProvedores.DataSource = objPro.ListarProvedores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Restart()
        {
            pnlPrin.Enabled = false;
            txtProvedores.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGVProvedores.SelectedRows.Count > 0)
            {
                provedores.State = EntityState.Deleted;
                provedores.IdProv = Convert.ToInt32(dGVProvedores.CurrentRow.Cells[0].Value);

                string result = provedores.SaveChanges();
                MessageBox.Show(result);
                ListarProvedores();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dGVProvedores.SelectedRows.Count > 0)
            {
                pnlPrin.Enabled = true;
                provedores.State = EntityState.Modifed;
                provedores.IdProv = Convert.ToInt32(dGVProvedores.CurrentRow.Cells[0].Value);
                txtProvedores.Text = dGVProvedores.CurrentRow.Cells[1].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlPrin.Enabled = true;
            provedores.State = EntityState.Added;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            provedores.Provedor = txtProvedores.Text;

            bool valid = new Helps.DataValidation(provedores).Validate();
            if (valid == true)
            {
                string result = provedores.SaveChanges();
                MessageBox.Show(result);
                ListarProvedores();
                Restart();
            }
        }

        private void FormProvedores_Load(object sender, EventArgs e)
        {
            ListarProvedores();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
