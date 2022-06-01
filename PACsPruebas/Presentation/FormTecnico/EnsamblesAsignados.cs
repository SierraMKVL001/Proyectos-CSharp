using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.Cache;
using Dominio.Servicios;
using Dominio.Modelos;
using Dominio.ValueObjects;

namespace Presentation.FormTecnico
{
    public partial class EnsamblesAsignados : Form
    {
        int n=0;
        private EstatusModel estatus = new EstatusModel();
        public EnsamblesAsignados()
        {
            InitializeComponent();
        }
        private void ListUserTec()
        {
            ProcEmpleados objPro = new ProcEmpleados();
            try
            {
                dGVNumTecnico.DataSource = objPro.LisTecnicos(UserLoginCache.idEmp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ListEnsambles()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListaEnsamblesParaTec(Convert.ToInt32(dGVNumTecnico.CurrentRow.Cells[0].Value));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void EnsamblesAsignados_Load(object sender, EventArgs e)
        {
            ListUserTec();
            ListEnsambles();
        }

        private void btnEnsamListo_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro de Marcar el Ensamble como Listo?", "Sistema de Ensambles",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    estatus.State = EntityState.Modifed;
                    estatus.IdEnsamble = Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value);
                    estatus.IdEstatus = 4;
                    bool valid = new Helps.DataValidation(estatus).Validate();
                    if (valid == true)
                    {
                        string result = estatus.SaveChanges();
                        MessageBox.Show(result);
                        ListEnsambles();
                        dGVDetalleEnsamble.Columns.Clear();
                    }
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnRechEnsamble_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro de Rechazar el Ensamble?", "Sistema de Ensambles",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    estatus.State = EntityState.Modifed;
                    estatus.IdEnsamble = Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value);
                    estatus.IdEstatus = 2;
                    bool valid = new Helps.DataValidation(estatus).Validate();
                    if (valid == true)
                    {
                        string result = estatus.SaveChanges();
                        MessageBox.Show(result);
                        ListEnsambles();
                        dGVDetalleEnsamble.Columns.Clear();
                    }
                }
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
                            ListEnsambles();
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
    }
}
