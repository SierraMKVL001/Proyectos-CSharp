using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Modelos;
using Domain.ValueObjects;
using System.Runtime.InteropServices;

namespace Presentacion.FormCompartidos
{
    public partial class EditeObserva : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private ObservacionesModel observacion = new ObservacionesModel();
        public EditeObserva()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void Restart()
        {
            lblID.Text = "No. ID";
            lblObserv.Text = "No. Observacion";
            txtObservacion.Clear();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de editar la Observacion?", "Precaucion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                observacion.State = EntityState.Modifed;
                observacion.IdObs = Convert.ToInt32(lblObserv.Text);
                observacion.Observacion = txtObservacion.Text;
                bool valid = new Helps.DataValidation(observacion).Validate();
                if (valid == true)
                {
                    string result = observacion.SaveChanges();
                    MensajeOk(result);
                }
                Restart();
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void EditeObserva_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
