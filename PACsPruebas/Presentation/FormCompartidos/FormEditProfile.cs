using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common.Cache;
using Dominio.Modelos;

namespace Presentation.FormCompartidos
{
    public partial class FormEditProfile : Form
    {
        public FormEditProfile()
        {
            InitializeComponent();
        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
        }
        private void loadUserData()
        {
            lblLogName.Text = UserLoginCache.LoginName;
            lblNombres.Text = UserLoginCache.Nombres;
            lblApellidos.Text = UserLoginCache.Apellidos;
            lblEmail.Text = UserLoginCache.Email;

            txtUserName.Text = UserLoginCache.LoginName;
            txtNombres.Text = UserLoginCache.Nombres;
            txtApellidos.Text = UserLoginCache.Apellidos;
            txtEmail.Text = UserLoginCache.Email;
            txtPass.Text = UserLoginCache.Pass;
            txtConfirmPass.Text = UserLoginCache.Pass;
            txtActualPass.Text = "";
        }
        private void initializePassEditControls()
        {
            lnkLblEditPass.Text = "Editar";
            txtPass.Enabled = false;
            txtPass.UseSystemPasswordChar = true;
            txtConfirmPass.Enabled = false;
            txtConfirmPass.UseSystemPasswordChar = true;
        }
        private void reset()
        {
            loadUserData();
            initializePassEditControls();

        }

        private void lblEditPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDatosUser.Visible = true;
            loadUserData();

        }

        private void lnkLblEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lnkLblEditPass.Text == "Editar")
            {
                lnkLblEditPass.Text = "Cancelar";
                txtPass.Enabled = true;
                txtPass.Text = "";
                txtConfirmPass.Enabled = true;
                txtConfirmPass.Text = "";
            }
            else if (lnkLblEditPass.Text=="Cancelar")
            {
                reset();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length >= 5)
            {
                if (txtPass.Text == txtConfirmPass.Text)
                {
                    if (txtActualPass.Text == UserLoginCache.Pass)
                    {
                        var userModel = new UserModel(idEmp: UserLoginCache.idEmp,
                            nombres: txtNombres.Text,
                            apellidos: txtApellidos.Text,
                            logName: txtUserName.Text,
                            pass: txtPass.Text,
                            email: txtEmail.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        pnlDatosUser.Visible = false;
                    }
                    else
                        MessageBox.Show("La Contraseña actual es Incorrecta, intente de nuevo");
                }
                else
                    MessageBox.Show("Las Contraseñas no coinciden, por favor intente de nuevo");
            }
            else
                MessageBox.Show("La Contraseña debe contar con almenos 5 caracteres");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatosUser.Visible = false;
            reset();
        }
    }
}
