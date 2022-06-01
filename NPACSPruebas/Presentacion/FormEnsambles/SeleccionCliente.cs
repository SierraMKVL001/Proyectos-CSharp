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
    public partial class SeleccionCliente : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public SeleccionCliente()
        {
            InitializeComponent();
        }
        private void ListarClientes()
        {
            ProcClientes objPro = new ProcClientes();
            try
            {
                dGVClientes.DataSource = objPro.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ProcClientes objPro = new ProcClientes();
            try
            {
                dGVClientes.DataSource = objPro.FiltrarClientes(this.txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Restart()
        {
            txtSearch.Clear();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dGVClientes.SelectedRows.Count > 0)
            {
                NuevoEnsamble Ensamble = Owner as NuevoEnsamble;

                Ensamble.lblIdCliente.Text = dGVClientes.CurrentRow.Cells[0].Value.ToString();
                Ensamble.lblNombreClient.Text = dGVClientes.CurrentRow.Cells[1].Value.ToString();
                Ensamble.lblTelefono.Text = dGVClientes.CurrentRow.Cells[2].Value.ToString();
                Ensamble.lblDireccionClient.Text = dGVClientes.CurrentRow.Cells[4].Value.ToString();
                Ensamble.lblRFCClient.Text = dGVClientes.CurrentRow.Cells[5].Value.ToString();

                Restart();
                this.Close();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void SeleccionCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void SeleccionCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
