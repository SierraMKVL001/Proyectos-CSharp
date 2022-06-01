using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.DashBoard;
using Domain.DashBoard;
using Domain.Servicios;
using Presentacion.Reportes;
using Presentacion.FormEnsambles;

namespace Presentacion.FormCompartidos
{
    public partial class AllEnamAlmVent : Form
    {
        int n = 0;
        bool selectensam = false;
        DateTime fromDate = DateTime.Today;
        DateTime toDate = DateTime.Now;
        public AllEnamAlmVent()
        {
            InitializeComponent();
            btnEditObserv.Visible = false;
            btnAgrObser.Visible = false;
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ObtObservacion(int idEnsamble)
        {
            N_Observacion neg = new N_Observacion();
            E_Observacion objP = new E_Observacion();
            neg.Observacion(objP, idEnsamble);
            lblNumObser.Text = objP.IdObserva;
        }
        private void ActivateButtons()
        {
            if (txtObservacion.Text == "Ninguna Observacion")
            {
                btnEditObserv.Visible = false;
                btnAgrObser.Visible = true;
            }
            else if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                btnEditObserv.Visible = false;
                btnAgrObser.Visible = false;
            }
            else if (lblNumObser.Text == "0")
            {
                btnEditObserv.Visible = false;
                btnAgrObser.Visible = false;
            }
            else if (txtObservacion.Text != "Ninguna Observacion")
            {
                btnEditObserv.Visible = true;
                btnAgrObser.Visible = false;
            }
        }
        public void Restart()
        {
            txtObservacion.Clear();
            dGVDetalleEnsamble.Columns.Clear();
            lblNumObser.Text = "0";
            lblIDEns.Text = "0";
            ActivateButtons();
            ListarEnsambles();
            VerSelectEnsam();
        }
        private void ListarEnsambles()
        {
            ProcAdministrador objPro = new ProcAdministrador();
            try
            {
                dGVEnsambles.DataSource = objPro.FiltroFeListAllEnsamb(fromDate, toDate);

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
                ObtObservacion(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
                lblIDEns.Text = Convert.ToString(dGVEnsambles.Rows[n].Cells[0].Value);
                VerSelectEnsam();
                ProcObservaciones objPro1 = new ProcObservaciones();
                try
                {
                    txtObservacion.Text = objPro1.obtenerObservacion(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                ActivateButtons();
            }
        }

        private void AllEnamAlmVent_Load(object sender, EventArgs e)
        {
            ListarEnsambles();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            Restart();
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
        public void DesacFechas()
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
        }
        public void ActiveFechas()
        {
            dTimeFrom.Enabled = true;
            dTimeTo.Enabled = true;
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            DesacFechas();
            fromDate = DateTime.Today;
            toDate = DateTime.Now;
            txtSearch.Clear();
            Restart();
            ListarEnsambles();
        }

        private void btn7Dais_Click(object sender, EventArgs e)
        {
            DesacFechas();
            fromDate = DateTime.Today.AddDays(-7);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Restart();
            ListarEnsambles();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            DesacFechas();
            fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Restart();
            ListarEnsambles();
        }

        private void btn30Dias_Click(object sender, EventArgs e)
        {
            DesacFechas();
            fromDate = DateTime.Today.AddDays(-30);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Restart();
            ListarEnsambles();
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            DesacFechas();
            fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            toDate = DateTime.Now;
            txtSearch.Clear();
            Restart();
            ListarEnsambles();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            ActiveFechas();
        }

        private void btnAplyCustom_Click(object sender, EventArgs e)
        {
            fromDate = dTimeFrom.Value;
            toDate = dTimeTo.Value;
            txtSearch.Clear();
            Restart();
            DesacFechas();
            ListarEnsambles();
        }

        private void btnEditObserv_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                var fimp = new EditeObserva();
                fimp.lblID.Text = lblIDEns.Text;
                fimp.lblObserv.Text = lblNumObser.Text;
                fimp.txtObservacion.Text = txtObservacion.Text;
                fimp.ShowDialog();
                Restart();
            }
            else
                MensajeError("Seleccione una fila");
        }
        private void btnAgrObser_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                var fimp1 = new AgrObserva();
                fimp1.lblID.Text = lblIDEns.Text;
                fimp1.ShowDialog();
                Restart();
            }
            else
                MensajeError("Seleccione una fila");
        }
        private void VerSelectEnsam()
        {
            if (lblIDEns.Text=="0")
            {
                selectensam = false;
            }
            else
            {
                selectensam = true;
            }
        }
        private void btnReporteExcel_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (selectensam == true)
                {
                    var fimp2 = new ExportAlmVent();
                    fimp2.lblId.Text = lblIDEns.Text;
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
        //private void btnRechEnsamble_Click(object sender, EventArgs e)
        //{
        //    if (dGVEnsambles.SelectedRows.Count > 0)
        //    {
        //        if (selectensam == true)
        //        {
        //            var fimp3 = new DuplicaEnsamble();
        //            fimp3.lblEnsambleDup.Text = lblIDEns.Text;
        //            fimp3.ShowDialog();
        //        }
        //        else
        //        {
        //            MensajeError("Seleccione un Ensamble");
        //        }
        //    }
        //    else
        //        MensajeError("Seleccione una fila");
        //}
    } 
}
