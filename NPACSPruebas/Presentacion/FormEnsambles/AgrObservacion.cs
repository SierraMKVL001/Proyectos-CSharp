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
using Domain.Modelos;
using Domain.ValueObjects;
using System.Runtime.InteropServices;

namespace Presentacion.FormEnsambles
{
    public partial class AgrObservacion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private ObservacionesModel observacion = new ObservacionesModel();
        public AgrObservacion()
        {
            InitializeComponent();
        }
        public void Restart()
        {
            txtObservacion.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
            this.Close();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere Proceder con el Ensamble?", "Precaucion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                observacion.State = EntityState.Added;
                observacion.Observacion = txtObservacion.Text;
                bool valid = new Helps.DataValidation(observacion).Validate();
                if (valid == true)
                {
                    string result = observacion.SaveChanges();
                    MensajeOk(result);
                }
                ProcObservaciones obj = new ProcObservaciones();
                lblObserv.Text = obj.consultaObservaciones();
                NuevoEnsamble Ensamble = Owner as NuevoEnsamble;
                Ensamble.lblObserv.Text = lblObserv.Text;
                Restart();
                this.Close();
            }
        }
        private void AgrObservacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
