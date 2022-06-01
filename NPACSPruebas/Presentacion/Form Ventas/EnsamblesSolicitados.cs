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

namespace Presentacion.Form_Ventas
{
    public partial class EnsamblesSolicitados : Form
    {
        int n = 0;
        public EnsamblesSolicitados()
        {
            InitializeComponent();
        }
        private void ListEnsamVentas()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListaEnsamblesdeVended(UserLoginCache.idEmp);

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

        private void EnsamblesSolicitados_Load(object sender, EventArgs e)
        {
            ListEnsamVentas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dGVDetalleEnsambles.Columns.Clear();
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.FiltroListaEnsamblesdeVended(UserLoginCache.idEmp, this.txtSearch.Text.Trim(),dateT1.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {

            }
            else
            {
                txtSearch.Clear();
                dateT1.Value = DateTime.Today;
                dGVDetalleEnsambles.Columns.Clear();
                ListEnsamVentas();
            }
        }
    }
}
