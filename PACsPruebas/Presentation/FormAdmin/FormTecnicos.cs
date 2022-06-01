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
    public partial class FormTecnicos : Form
    {
        private TecnicosModel tecnicos = new TecnicosModel();
        public FormTecnicos()
        {
            InitializeComponent();
            pnlTecni.Enabled = false;

        }
        private void ListEmpleados()
        {
            ProcEmpleados objPro = new ProcEmpleados();
            cmbEmple.DataSource = objPro.ListarEmpleadosT();
            cmbEmple.DisplayMember = "Nombre";
            cmbEmple.ValueMember = "ID";
        }
        private void ListarTecnicos()
        {
            ProcTecnicos objPro = new ProcTecnicos();
            try
            {
                dGVTecnicos.DataSource = objPro.ListarTecnicos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void restart()
        {
            pnlTecni.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGVTecnicos.SelectedRows.Count > 0)
            {
                
                tecnicos.State = EntityState.Deleted;
                tecnicos.IdTec = Convert.ToInt32(dGVTecnicos.CurrentRow.Cells[0].Value);

                string result = tecnicos.SaveChanges();
                MessageBox.Show(result);
                ListarTecnicos();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlTecni.Enabled = true;
            tecnicos.State = EntityState.Added;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tecnicos.IdEmplea = Convert.ToInt32(cmbEmple.SelectedValue);

            bool valid = new Helps.DataValidation(tecnicos).Validate();
            if (valid == true)
            {
                string result = tecnicos.SaveChanges();
                MessageBox.Show(result);
                ListarTecnicos();
                restart();
            }
        }

        private void FormTecnicos_Load(object sender, EventArgs e)
        {
            ListarTecnicos();
            ListEmpleados();
        }
    }
}
