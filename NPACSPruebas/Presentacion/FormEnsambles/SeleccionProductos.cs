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
    public partial class SeleccionProductos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public SeleccionProductos()
        {
            InitializeComponent();
        }
        private void ListProductos()
        {
            ClsProductos objPro = new ClsProductos();
            try
            {
                dGVProductos.DataSource = objPro.ListaProducEnsamble();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtSearchProduc_TextChanged(object sender, EventArgs e)
        {
            ClsProductos objPro = new ClsProductos();
            try
            {
                dGVProductos.DataSource = objPro.FiltrarProductosEnsamble(this.txtSearchProduc.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Reset()
        {
            txtSearchProduc.Clear();
        }
        private void SeleccionProductos_Load(object sender, EventArgs e)
        {
            ListProductos();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dGVProductos.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(dGVProductos.CurrentRow.Cells[5].Value) <= 0)
                {
                    if (MessageBox.Show("Seleccionar este Producto provocara un Negativo en el Sistema. Seguro que quiere Proceder con la seleccion del Producto?", "Precaucion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        VarDatosEntreForm var = Owner as VarDatosEntreForm;
                        DataGridViewRow Fila = dGVProductos.SelectedRows[0] as DataGridViewRow;
                        var.TablaAgregarDatos(Fila);
                        Reset();
                        this.Close();
                    }
                }
                else
                {
                    VarDatosEntreForm var = Owner as VarDatosEntreForm;
                    DataGridViewRow Fila = dGVProductos.SelectedRows[0] as DataGridViewRow;
                    var.TablaAgregarDatos(Fila);
                    Reset();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Reset();
            this.Close();
        }
        private void SeleccionProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
