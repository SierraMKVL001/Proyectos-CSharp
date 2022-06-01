using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.Cache;
using Dominio.Servicios;

namespace Presentation.FormEnsambles
{
    public partial class ListadeEnsambles : Form
    {
        int n = 0;
        public ListadeEnsambles()
        {
            InitializeComponent();

        }
        private void ListEnsambles()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVEnsambles.DataSource = objPro.ListarTodosEnsambles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ListadeEnsambles_Load(object sender, EventArgs e)
        {
            ListEnsambles();
            dGVEnsambles.AllowUserToAddRows = false;
            dGVDetalleEnsamble.AllowUserToAddRows = false;
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
