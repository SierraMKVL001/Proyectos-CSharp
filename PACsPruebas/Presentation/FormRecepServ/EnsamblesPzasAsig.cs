using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio.Servicios;
using Dominio.Modelos;
using Dominio.ValueObjects;

namespace Presentation.FormRecepServ
{
    public partial class EnsamblesPzasAsig : Form
    {
        int n = 0;
        private EstatusModel estatus = new EstatusModel();
        private AsigTecEnsamblesModel tecnico = new AsigTecEnsamblesModel();
        public EnsamblesPzasAsig()
        {
            InitializeComponent();
            pnlTecEnsamble.Enabled = false;
        }

        private void ListarEnsambles()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListerEnsamPzasAsig();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ListarTecnicos()
        {
            ProcTecnicos objProd = new ProcTecnicos();
            cmbTecnicos.DataSource = objProd.ListarTecnicos();
            cmbTecnicos.DisplayMember = "Nombre";
            cmbTecnicos.ValueMember = "ID";
        }
        private void Reset()
        {
            ListarTecnicos();
            pnlTecEnsamble.Enabled = false;

        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void EnsamblesPzasAsig_Load(object sender, EventArgs e)
        {
            ListarEnsambles();
            ListarTecnicos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Asignar este Tecnico al Ensamble?", "Sistema de Ensambles",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tecnico.IdEnsamble = Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value);
                tecnico.IdEstatus = 3;
                tecnico.IdTecnico = Convert.ToInt32(cmbTecnicos.SelectedValue);
                bool valid = new Helps.DataValidation(tecnico).Validate();
                if (valid == true)
                {
                    string result = tecnico.SaveChanges();
                    MessageBox.Show(result);
                    ListarEnsambles();
                    dGVDetalleEnsamble.Columns.Clear();
                    Reset();
                }
            }
        }

        private void btnAsignarTec_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                pnlTecEnsamble.Enabled = true;
                tecnico.State = EntityState.Modifed;
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btonCancelEnsam_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro de Cancelar el Ensamble?", "Sistema de Ensambles",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Rpta = NEnsamble.Eliminar(Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value));
                        if (Rpta.Equals("OK"))
                        {
                            ListarEnsambles();
                            dGVDetalleEnsamble.Columns.Clear();
                            this.MensajeOk("El Ensamble se Cancelo de Forma Correcta");
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }

            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnPzasNoAsig_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro de volver a Asignar Piezas al Ensamble?", "Sistema de Ensambles",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    estatus.State = EntityState.Modifed;
                    estatus.IdEnsamble = Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value);
                    estatus.IdEstatus = 1;
                    bool valid = new Helps.DataValidation(estatus).Validate();
                    if (valid == true)
                    {
                        string result = estatus.SaveChanges();
                        MessageBox.Show(result);
                        ListarEnsambles();
                        dGVDetalleEnsamble.Columns.Clear();
                        Reset();
                    }
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void dGVEnsambles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n >= 0)
            {
                ProcEnsambles objPro = new ProcEnsambles();
                try
                {
                    dGVDetalleEnsamble.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
