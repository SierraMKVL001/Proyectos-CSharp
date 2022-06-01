using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Reportes;
using Microsoft.Reporting.WinForms;
using System.Runtime.InteropServices;

namespace Presentacion.Reportes
{
    public partial class ReportesVentas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public ReportesVentas()
        {
            InitializeComponent();
        }

        private void ReportesVentas_Load(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
        }

        private void getVentasReport(DateTime startDate,DateTime endDate)
        {
            ReportesdeVentas reportModel = new ReportesdeVentas();
            reportModel.crearReporteVentas(startDate,endDate);
            ReportDataSource rds = new ReportDataSource("reporteVentas",reportModel.reportVentas);
            ReportDataSource rds1 = new ReportDataSource("listaVentas", reportModel.listaVentas);
            ReportDataSource rds2 = new ReportDataSource("netVentasReport", reportModel.netVentasReport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds2);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            

            this.reportViewer1.RefreshReport();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            getVentasReport(fromDate, toDate);
        }

        private void btn7Dais_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            getVentasReport(fromDate, toDate);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            var fromDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            var toDate = DateTime.Now;
            getVentasReport(fromDate, toDate);
        }

        private void btn30Dias_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;
            getVentasReport(fromDate, toDate);
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;
            getVentasReport(fromDate, toDate);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = true;
            dTimeTo.Enabled = true;
        }

        private void btnAplyCustom_Click(object sender, EventArgs e)
        {
            var fromDate = dTimeFrom.Value;
            var toDate = dTimeTo.Value;
            getVentasReport(fromDate, new DateTime(toDate.Year,toDate.Month,toDate.Day,23,59,59));
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlDatos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
