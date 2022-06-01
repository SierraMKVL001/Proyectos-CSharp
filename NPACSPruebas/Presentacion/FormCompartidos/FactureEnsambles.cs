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

namespace Presentacion.FormCompartidos
{
    public partial class FactureEnsambles : Form
    {
        int n = 0;
        DateTime fromDate = DateTime.Today;
        DateTime toDate = DateTime.Now;
        public FactureEnsambles()
        {
            InitializeComponent();
            dTimeTo.Enabled = false;
            dTimeFrom.Enabled = false;
        }
        private void ListEnsamFact()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListFactEnsambles(fromDate, toDate);

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
                    dGVDetalleEnsambles.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(dGVEnsambles.Rows[n].Cells[0].Value));
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
            dGVDetalleEnsambles.Columns.Clear();
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.FiltroListEnsambFact(this.txtSearch.Text.Trim(), fromDate, toDate);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FactureEnsambles_Load(object sender, EventArgs e)
        {
            ListEnsamFact();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = DateTime.Today;
            toDate = DateTime.Now;
            txtSearch.Clear();
            dGVDetalleEnsambles.Columns.Clear();
            ListEnsamFact();
        }

        private void btn7Dais_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = DateTime.Today.AddDays(-7);
            toDate = DateTime.Now;
            txtSearch.Clear();
            dGVDetalleEnsambles.Columns.Clear();
            ListEnsamFact();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            toDate = DateTime.Now;
            txtSearch.Clear();
            dGVDetalleEnsambles.Columns.Clear();
            ListEnsamFact();
        }

        private void btn30Dias_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = DateTime.Today.AddDays(-30);
            toDate = DateTime.Now;
            txtSearch.Clear();
            dGVDetalleEnsambles.Columns.Clear();
            ListEnsamFact();
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            toDate = DateTime.Now;
            txtSearch.Clear();
            dGVDetalleEnsambles.Columns.Clear();
            ListEnsamFact();
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
            dGVDetalleEnsambles.Columns.Clear();
            dTimeFrom.Enabled = false;
            dTimeTo.Enabled = false;
            ListEnsamFact();
        }
    }
}
