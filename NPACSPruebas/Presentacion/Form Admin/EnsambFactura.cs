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
using Presentacion.Reportes;

namespace Presentacion.Form_Admin
{
    public partial class EnsambFactura : Form
    {
        int n = 0;
        bool selectensam = false;
        DateTime fromDate = DateTime.Today;
        DateTime toDate = DateTime.Now;
        public EnsambFactura()
        {
            InitializeComponent();
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
        }
        private void ListarEnsambles()
        {
            ProcAdministrador objPro = new ProcAdministrador();
            try
            {
                dGVEnsambles.DataSource = objPro.FiltroFeListEnsambFact(fromDate, toDate);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void EnsambFactura_Load(object sender, EventArgs e)
        {
            ListarEnsambles();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            Reset();
            ProcAdministrador objPro = new ProcAdministrador();
            try
            {
                dGVEnsambles.DataSource = objPro.FiltroListAllEnsamb(this.txtSearch.Text.Trim(), fromDate, toDate);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = DateTime.Today;
            toDate = DateTime.Now;
            txtSearch.Clear();
            Reset();
            ListarEnsambles();
        }

        private void btn7Dais_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = DateTime.Today.AddDays(-7);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Reset();
            ListarEnsambles();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Reset();
            ListarEnsambles();
        }

        private void btn30Dias_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = DateTime.Today.AddDays(-30);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Reset();
            ListarEnsambles();
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Reset();
            ListarEnsambles();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = true;
            dTimeTo.Enabled = true;
        }

        private void btnAplyCustom_Click(object sender, EventArgs e)
        {
            fromDate = dTimeFrom.Value;
            toDate = dTimeTo.Value;
            txtSearch.Clear();
            Reset();
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            ListarEnsambles();
        }

        private void btnEnsamExcel_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (selectensam==true)
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
    }
}
