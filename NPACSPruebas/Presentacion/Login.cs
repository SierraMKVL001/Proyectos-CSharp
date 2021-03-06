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
using Domain.Modelos;
using Presentacion.Form_Admin;
using Presentacion.Form_Ventas;
using Presentacion.Form_Almacen;
using Presentacion.Form_RecServ;
using Presentacion.Form_Tecnico;
using Common;

namespace Presentacion
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();

                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        if (UserLoginCache.idPuesto == Puesto.Administrador)
                        {
                            this.Hide();
                            BienvnidaAdmin welcome = new BienvnidaAdmin();
                            welcome.ShowDialog();
                            AdminUI mainMenu = new AdminUI();
                            mainMenu.Show();
                            mainMenu.FormClosed += LogOut;

                        }
                        if (UserLoginCache.idPuesto == Puesto.Almacen)
                        {
                            this.Hide();
                            BienvenidaAlmacen welcome = new BienvenidaAlmacen();
                            welcome.ShowDialog();
                            AlmacenUI mainMenu = new AlmacenUI();
                            mainMenu.Show();
                            mainMenu.FormClosed += LogOut;
                        }
                        if (UserLoginCache.idPuesto == Puesto.Ejecutivo)
                        {
                            this.Hide();
                            BienvenidoAsesorV welcome = new BienvenidoAsesorV();
                            welcome.ShowDialog();
                            VentasUI mainMenu = new VentasUI();
                            mainMenu.Show();
                            mainMenu.FormClosed += LogOut;

                        }
                        if (UserLoginCache.idPuesto == Puesto.Recepcion)
                        {
                            this.Hide();
                            BienvenidaRecServ welcome = new BienvenidaRecServ();
                            welcome.ShowDialog();
                            RecepcionUI mainMenu = new RecepcionUI();
                            mainMenu.Show();
                            mainMenu.FormClosed += LogOut;
                            
                        }
                        if (UserLoginCache.idPuesto == Puesto.Tecnico)
                        {
                            this.Hide();
                            BienvenidaTecnico welcome = new BienvenidaTecnico();
                            welcome.ShowDialog();
                            TecnicoUI mainMenu = new TecnicoUI();
                            mainMenu.Show();
                            mainMenu.FormClosed += LogOut;

                        }

                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrestos  \n  Por favor intente de nuevo");
                        txtPass.Text = "CONTRASEÑA";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }

                }
                else
                    msgError("Favor de ingresar su CONTRASEÑA");
            }
            else
                msgError("Favor de ingresar su Ususario");
        }
        private void msgError(string msg)
        {
            lblErrorMsg.Text = "" + msg;
            lblErrorMsg.Visible = true;
        }
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            txtUser.Text = "USUARIO";
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            lblErrorMsg.Visible = false;
            this.Show();
        }
        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoveryPass = new RecoveryPassword();
            recoveryPass.ShowDialog();
        }
    }
}
