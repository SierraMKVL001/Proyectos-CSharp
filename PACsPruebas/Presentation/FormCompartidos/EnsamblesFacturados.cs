using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio.Servicios;
using Dominio.Modelos;
using Dominio.ValueObjects;

namespace Presentation.FormCompartidos
{
    public partial class EnsamblesFacturados : Form
    {
        int n = 0;
        public EnsamblesFacturados()
        {
            InitializeComponent();
        }
        private void ListarEnsambles()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListerEnsamFacturados();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EnsamblesFacturados_Load(object sender, EventArgs e)
        {
            ListarEnsambles();
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
    }
}
