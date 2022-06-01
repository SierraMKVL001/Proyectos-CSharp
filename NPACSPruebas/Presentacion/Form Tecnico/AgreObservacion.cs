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
using Domain.Servicios;
using System.Runtime.InteropServices;

namespace Presentacion.Form_Tecnico
{
    public partial class AgreObservacion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private ObservacionesModel observacion = new ObservacionesModel();
        private AsigObservModel asigObserv = new AsigObservModel();
        public AgreObservacion()
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de que las observaciones estan completas?", "Precaucion",
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

                asigObserv.State = EntityState.Modifed;
                asigObserv.IdEnsamble = Convert.ToInt32(lblID.Text);
                asigObserv.IdObser = Convert.ToInt32(lblObserv.Text);
                bool valid1 = new Helps.DataValidation(asigObserv).Validate();
                if (valid1 == true)
                {
                    string result = asigObserv.SaveChanges();
                    MensajeOk(result);
                }
                Restart();
                this.Close();
            }
        }
        private void AgreObservacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
