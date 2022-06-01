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
using Presentacion.Reportes;
using Common.DashBoard;
using Domain.DashBoard;

namespace Presentacion.Form_Ventas
{
    public partial class EnsamSolicListos : Form
    {
        int n = 0;
        bool selectensam = false;
        private EstatusModel estatus = new EstatusModel();
        public EnsamSolicListos()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void VerSelectEnsam()
        {
            if (lblIDE.Text == "0")
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
            dGVDetalleEnsambles.Columns.Clear();
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
        private void ObtenerDatos(int idEnsamble)
        {
            N_Ensambles neg = new N_Ensambles();
            E_Ensamble obj = new E_Ensamble();
            neg.DatosEnam(idEnsamble, obj);
            lblNFolio.Text = obj.NumFolio;
            lblNomRSoc.Text = obj.NCliente;
            lblSolicito.Text = obj.NEmpleado;
            lblSubT.Text = obj.SubTotal;
            lblIVA.Text = obj.IVA;
            lblTotal.Text = obj.Total;
        }
        private void ListEnsamVentas()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListaEnsamblesListdeVended(UserLoginCache.idEmp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            ObtenerDatos(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
            VerSelectEnsam();
            if (n >= 0)
            {
                ProcEnsambles objPro = new ProcEnsambles();
                try
                {
                    dGVDetalleEnsambles.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void EnsamSolicListos_Load(object sender, EventArgs e)
        {
            ListEnsamVentas();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dGVDetalleEnsambles.Columns.Clear();
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.FiltroListaEnsamblesListdeVended(UserLoginCache.idEmp, this.txtSearch.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                        ListEnsamVentas();
                        Reset();
                    }
                }
            }
            else
                MensajeError("Seleccione una fila");
        }
    }
}
