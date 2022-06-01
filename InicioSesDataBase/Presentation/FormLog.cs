using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Common.Cache;     

namespace Presentation
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void FormLog_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    ModeloUser user = new ModeloUser();
                    var validLogin = user.LoginUser(txtUser.Text,txtPass.Text);
                    if (validLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        MessageBox.Show("Bienvenido " + CacheInicioSes.FirstName+" "+CacheInicioSes.LastName);
                        mainMenu.Show();
                        mainMenu.FormClosing += Logout;
                        this.Hide();
                    } else
                    {
                        msgError("Ususario o Contraseña errona.\n   Por favor intente de nuevo");
                        txtPass.Text="CONTRASEÑA";
                        txtUser.Focus();
                    }
                }
                else msgError("Favor de Ingresar la Contraseña");
            }
            else msgError("Favor de Ingresar el Ususario");
        }
        private void msgError(string msg)
        {
            lblErrorMessagge.Text = "   " + msg;
            lblErrorMessagge.Visible = true;
        }
        private void Logout(object sender, FormClosingEventArgs e)
        {

            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;

            txtUser.Text = "USUARIO";
            lblErrorMessagge.Visible = false;

            this.Show();
            //txtUser.Focus();
        }

       
    }
}
