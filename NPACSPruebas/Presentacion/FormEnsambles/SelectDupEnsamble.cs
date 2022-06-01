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
using System.Runtime.InteropServices;

namespace Presentacion.FormEnsambles
{
    public partial class SelectDupEnsamble : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        int n = 0;
        bool selectensam = false;
        DateTime fromDate = DateTime.Today;
        DateTime toDate = DateTime.Now;
        public SelectDupEnsamble()
        {
            InitializeComponent();
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Restart()
        {
            
            dGVDetalleEnsamble.Columns.Clear();
            ListarEnsambles();
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
                ProcDupEnsambles objPro = new ProcDupEnsambles();
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
        private void SelectDupEnsamble_Load(object sender, EventArgs e)
        {
            ListarEnsambles();
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
        private void btnRechEnsamble_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void btnReporteExcel_Click(object sender, EventArgs e)
        {
            if (dGVEnsambles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro de Duplicar este Ensamble?", "Precaucion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    VarDatosEntreForm var = Owner as VarDatosEntreForm;
                    foreach (DataGridViewRow row in dGVDetalleEnsamble.Rows)
                    {
                        row.Selected = true;
                        DataGridViewRow Fila = dGVDetalleEnsamble.SelectedRows[0] as DataGridViewRow;
                        var.TablaAgregarDatos(Fila);
                    }
                    Restart();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
