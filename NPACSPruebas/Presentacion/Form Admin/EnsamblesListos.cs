using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Servicios;
using Domain.Modelos;
using Domain.ValueObjects;
using Presentacion.Reportes;

namespace Presentacion.Form_Admin
{
    public partial class EnsamblesListos : Form
    {
        int n = 0;
        bool selectensam = false;
        private EstatusModel estatus = new EstatusModel();
        public EnsamblesListos()
        {
            InitializeComponent();
            txtEnsamblo.Enabled = false;
            txtFolio.Enabled = false;
            txtID.Enabled = false;
            txtIVA.Enabled = false;
            txtNombreRS.Enabled = false;
            txtSolicito.Enabled = false;
            txtSubtotal.Enabled = false;
            txtTotal.Enabled = false;
        }
        private void ListarEnsambles()
        {
            ProcAdministrador objPro = new ProcAdministrador();
            try
            {
                dGVEnsambles.DataSource = objPro.ListEnsamListos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void VerSelectEnsam()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                selectensam = false;
            }
            else
            {
                selectensam = true;
            }
        }
        private void Reset()
        {
            dGVDetalleEnsamble.Columns.Clear();
            txtEnsamblo.Clear();
            txtID.Clear();
            txtFolio.Clear();
            txtIVA.Clear();
            txtNombreRS.Clear();
            txtSolicito.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            VerSelectEnsam();
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
        private void btnMarcarFacturado_Click(object sender, EventArgs e)
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
                        MensajeOk(result);
                        ListarEnsambles();
                        Reset();
                        
                    }
                }
            }
            else
                MensajeError("Seleccione una fila");
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
                        MensajeOk(result);
                        ListarEnsambles();
                        Reset();
                    }
                }
            }
            else
                MensajeError("Seleccione una fila");
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
                            Reset();
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
                MensajeError("Seleccione una fila");
        }
        private void dGVEnsambles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            ProcAdministrador objPro1 = new ProcAdministrador();
            try
            {
                txtEnsamblo.Text = objPro1.obtenerTecnico(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtID.Text = dGVEnsambles.Rows[n].Cells[0].Value.ToString();
            txtFolio.Text = dGVEnsambles.Rows[n].Cells[1].Value.ToString();
            txtNombreRS.Text = dGVEnsambles.Rows[n].Cells[2].Value.ToString();
            txtSolicito.Text = dGVEnsambles.Rows[n].Cells[3].Value.ToString();
            txtSubtotal.Text = dGVEnsambles.Rows[n].Cells[7].Value.ToString();
            txtIVA.Text = dGVEnsambles.Rows[n].Cells[8].Value.ToString();
            txtTotal.Text = dGVEnsambles.Rows[n].Cells[9].Value.ToString();
            VerSelectEnsam();
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
        private void btnEnsamExcel_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (selectensam == true)
                {
                    var fimp = new Exportar();
                    fimp.lblId.Text = txtID.Text;
                    fimp.lblNombre.Text = txtNombreRS.Text;
                    fimp.lblSolicito.Text = txtSolicito.Text;
                    fimp.lblEnsamblo.Text = txtEnsamblo.Text;
                    fimp.lblTotal.Text = txtTotal.Text;
                    fimp.lblIVA.Text = txtIVA.Text;
                    fimp.lblSubTotal.Text = txtSubtotal.Text;
                    fimp.lblFolio.Text = txtFolio.Text;
                    fimp.ShowDialog();
                }
                else
                {
                    MensajeError("Seleccione un Ensamble");
                } 
            }
            else
                MensajeError("Seleccione una fila");
        }
    }
}
