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
using Domain.Servicios;
using Domain.Modelos;
using Domain.ValueObjects;

namespace Presentacion.Form_Almacen
{
    public partial class EnsamblesPendientes : Form
    {
        int n = 0;
        private PendientesModel pendiente = new PendientesModel();
        private PzasAsigModel pzasasig = new PzasAsigModel();
        public EnsamblesPendientes()
        {
            InitializeComponent();
            pnlDatosDetEnsam.Enabled = false;
        }
        private void ListEnsambles()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListerEnsamPendientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ListUserOrden()
        {
            ProcEmpleados objPro = new ProcEmpleados();
            try
            {
                dGVNumOrdenUs.DataSource = objPro.ListOrdenUser(UserLoginCache.idEmp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        private void Reset()
        {
            txtNumSerie.Clear();
            pnlDatosDetEnsam.Enabled = false;
        }

        private void EnsamblesPendientes_Load(object sender, EventArgs e)
        {
            ListEnsambles();
            ListUserOrden();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pendiente.NumSerie1 = txtNumSerie.Text;

            bool valid = new Helps.DataValidation(pendiente).Validate();
            if (valid == true)
            {
                string result = pendiente.SaveChanges();
                MessageBox.Show(result);

                ProcEnsambles objPro = new ProcEnsambles();
                try
                {
                    dGVDetalleEnsamble.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Reset();
            }
        }
        private void btnAsignarNS_Click(object sender, EventArgs e)
        {
            if (dGVDetalleEnsamble.SelectedRows.Count > 0)
            {
                pnlDatosDetEnsam.Enabled = true;
                pendiente.State = EntityState.Modifed;
                pendiente.IdDet_Ens = Convert.ToInt32(dGVDetalleEnsamble.CurrentRow.Cells[0].Value);
                txtNumSerie.Text = dGVDetalleEnsamble.CurrentRow.Cells[4].Value.ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnPzasAsign_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro que se han Asignado Todas las Piezas al Ensamble?", "Sistema de Ensambles",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pzasasig.State = EntityState.Modifed;
                    pzasasig.IdEnsamble = Convert.ToInt32(dGVEnsambles.CurrentRow.Cells[0].Value);
                    pzasasig.IdEstatus = 2;
                    pzasasig.IdOrdeno = Convert.ToInt32(dGVNumOrdenUs.CurrentRow.Cells[0].Value);
                    bool valid = new Helps.DataValidation(pzasasig).Validate();
                    if (valid == true)
                    {
                        string result = pzasasig.SaveChanges();
                        MessageBox.Show(result);
                        dGVDetalleEnsamble.Columns.Clear();
                        ListEnsambles();
                    }
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
