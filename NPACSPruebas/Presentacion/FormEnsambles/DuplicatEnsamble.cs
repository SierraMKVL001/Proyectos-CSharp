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
    public partial class DuplicatEnsamble : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public DuplicatEnsamble()
        {
            InitializeComponent();
        }
        private void ListProductos()
        {
            ProcDupEnsambles objPro = new ProcDupEnsambles();
            try
            {
                dGVProductos.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(lblEnsambleDup.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DuplicatEnsamble_Load(object sender, EventArgs e)
        {
            ListProductos();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            VarDatosEntreForm2 var = Owner as VarDatosEntreForm2;
            foreach (DataGridViewRow row in dGVProductos.Rows)
            {
                row.Selected = true;
                DataGridViewRow Fila = dGVProductos.SelectedRows[0] as DataGridViewRow;
                var.TablaAgregarDatos1(Fila);
                
            }
            var fimp3 = new DuplicaEnsamble();
            fimp3.lblEnsambleDup.Text = lblEnsambleDup.Text;
            this.Close();
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DuplicatEnsamble_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
