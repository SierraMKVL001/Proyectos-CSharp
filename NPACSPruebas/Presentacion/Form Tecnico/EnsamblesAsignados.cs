using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Common.DashBoard;
using Domain.DashBoard;
using Domain.Servicios;
using Domain.Modelos;
using Domain.ValueObjects;

namespace Presentacion.Form_Tecnico
{
    public partial class EnsamblesAsignados : Form
    {
        int n = 0;
        private EstatusModel estatus = new EstatusModel();
        public EnsamblesAsignados()
        {
            InitializeComponent();
            btnEditObserv.Visible = false;
            btnAgrObser.Visible = false;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            }else if (txtObservacion.Text != "Ninguna Observacion")
            {
                btnEditObserv.Visible = true;
                btnAgrObser.Visible = false;
            }else if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                btnEditObserv.Visible = false;
                btnAgrObser.Visible = false;
            }else if (lblNumObser.Text == "0")
            {
                btnEditObserv.Visible = false;
                btnAgrObser.Visible = true;
            }
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
                ObtObservacion(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
                lblIDEns.Text=Convert.ToString(dGVEnsambles.Rows[n].Cells[0].Value);
                ProcEnsambles objPro = new ProcEnsambles();
                try
                {
                    dGVDetalleEnsamble.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
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
        private void EnsamblesAsignados_Load(object sender, EventArgs e)
        {
            ListUserTec();
            ListEnsambles();
        }
        public void Restart()
        {
            ListEnsambles();
            txtObservacion.Clear();
            dGVDetalleEnsamble.Columns.Clear();
            lblNumObser.Text = "0";
            lblIDEns.Text = "0";
            ActivateButtons();
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
                        Restart();
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
                        Restart();
                    }
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
        private void btnEditObserv_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                var fimp = new EditObservaciones();
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
                var fimp1 = new AgreObservacion();
                fimp1.lblID.Text = lblIDEns.Text;
                fimp1.ShowDialog();
                Restart();
            }
            else
                MensajeError("Seleccione una fila");
        }
    }
}
