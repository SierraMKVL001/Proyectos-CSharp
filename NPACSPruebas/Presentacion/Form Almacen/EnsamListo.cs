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

namespace Presentacion.Form_Almacen
{
    public partial class EnsamListo : Form
    {
        int n = 0;
        bool selectensam = false;
        private EstatusModel estatus = new EstatusModel();
        public EnsamListo()
        {
            InitializeComponent();
        }
        private void EnsamListo_Load(object sender, EventArgs e)
        {
            ListarEnsambles();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (lblIDE.Text=="0")
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
            lblEnsam.Text = "Desconocido";
            lblIDE.Text = "0";
            lblIVA.Text = "0";
            lblNFolio.Text = "0";
            lblNomRSoc.Text = "Desconocido";
            lblSolicito.Text = "Desconocido";
            lblSubT.Text = "0";
            lblTotal.Text = "0";
            VerSelectEnsam();
        }

        private void dGVEnsambles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            ProcAdministrador objPro1 = new ProcAdministrador();
            try
            {
                lblEnsam.Text = objPro1.obtenerTecnico(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lblIDE.Text = dGVEnsambles.Rows[n].Cells[0].Value.ToString();
            lblNFolio.Text = dGVEnsambles.Rows[n].Cells[1].Value.ToString();
            lblNomRSoc.Text = dGVEnsambles.Rows[n].Cells[2].Value.ToString();
            lblSolicito.Text = dGVEnsambles.Rows[n].Cells[3].Value.ToString();
            lblSubT.Text = dGVEnsambles.Rows[n].Cells[7].Value.ToString();
            lblIVA.Text = dGVEnsambles.Rows[n].Cells[8].Value.ToString();
            lblTotal.Text = dGVEnsambles.Rows[n].Cells[9].Value.ToString();
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
                    var fimp2 = new ExportAlmVent();
                    fimp2.lblId.Text = lblIDE.Text;
                    fimp2.ShowDialog();
                }
                else
                {
                    MensajeError("Seleccione un Ensamble");
                }
            }
            else
                MensajeError("Seleccione una fila");
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
    }
}
