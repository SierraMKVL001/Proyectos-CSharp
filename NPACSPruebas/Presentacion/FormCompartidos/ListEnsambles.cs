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
    public partial class ListEnsambles : Form
    {
        int n = 0;
        public ListEnsambles()
        {
            InitializeComponent();
        }
        private void ListEnsamListos()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListEsnamblesListos();

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
            dGVDetalleEnsambles.Columns.Clear();
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.FiltorListEnsamblesListos(this.txtSearch.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ListEnsambles_Load(object sender, EventArgs e)
        {
            ListEnsamListos();
        }
    }
}
