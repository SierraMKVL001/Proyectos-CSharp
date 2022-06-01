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
using Presentation.Reportes;

namespace Presentation.FormAdmin
{
    public partial class EnsamblesListos : Form
    {
        int n = 0;
        private EstatusModel estatus = new EstatusModel();
        public EnsamblesListos()
        {
            InitializeComponent();
        }
        private void ListarEnsambles()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListerEnsamListos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Reset()
        {
            lblEnsamblo.Text = "Desconocido";
            lblNombre.Text = "Desconocido";
            lblSolicito.Text = "Desconocido";
            lblTotal.Text = "Desconocido";
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnsamblesListos_Load(object sender, EventArgs e)
        {
            ListarEnsambles();
        }

        private void btnRechEnsamble_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro de marcar el Ensamble como Facturado?", "Sistema de Ensambles",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    estatus.State = EntityState.Modifed;
                    estatus.IdEnsamble = Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value);
                    estatus.IdEstatus = 5;
                    bool valid = new Helps.DataValidation(estatus).Validate();
                    if (valid == true)
                    {
                        string result = estatus.SaveChanges();
                        MessageBox.Show(result);
                        ListarEnsambles();
                        Reset();
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
        private void btnRegresarTec_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro de regresar el Ensamble al Tecnico?", "Sistema de Ensambles",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    estatus.State = EntityState.Modifed;
                    estatus.IdEnsamble = Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value);
                    estatus.IdEstatus = 3;
                    bool valid = new Helps.DataValidation(estatus).Validate();
                    if (valid == true)
                    {
                        string result = estatus.SaveChanges();
                        MessageBox.Show(result);
                        ListarEnsambles();
                        Reset();
                        dGVDetalleEnsamble.Columns.Clear();
                    }
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void dGVEnsambles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            lblEnsamblo.Text = dGVEnsambles.Rows[n].Cells[5].Value.ToString();
            lblNombre.Text= dGVEnsambles.Rows[n].Cells[2].Value.ToString();
            lblSolicito.Text = dGVEnsambles.Rows[n].Cells[3].Value.ToString();
            lblTotal.Text= dGVEnsambles.Rows[n].Cells[8].Value.ToString();
            lblFolio.Text= dGVEnsambles.Rows[n].Cells[0].Value.ToString();
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

        private void btnEnsamListo_Click(object sender, EventArgs e)
        {
            var fimp = new Importar();
            fimp.lblNombre.Text = lblNombre.Text;
            fimp.lblSolicito.Text = lblSolicito.Text;
            fimp.lblEnsamblo.Text = lblEnsamblo.Text;
            fimp.lblTotal.Text = lblTotal.Text;
            fimp.lblFolio.Text = lblFolio.Text;
            fimp.ShowDialog();


        }
    }
   
}
