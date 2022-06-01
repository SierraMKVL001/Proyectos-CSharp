using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Presentation.FormCompartidos;
using Common.Cache;

namespace Presentation.FormTecnico
{

    
    public partial class TecnicoUI : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public TecnicoUI()
        {
            InitializeComponent();
            customizeDesing();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pnlPrin.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconFormHijoActual.IconChar = currentBtn.IconChar;
                iconFormHijoActual.IconColor = currentBtn.IconColor;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 0, 80);
                currentBtn.ForeColor = Color.Gainsboro; ;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDeskpot.Controls.Add(childForm);
            pnlDeskpot.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 214);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        #region Menu-SubMenu
        private void customizeDesing()
        {
            pnlSubEnsmble.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubEnsmble.Visible == true)
                pnlSubEnsmble.Visible = false;
        }
        private void subMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion
        #region Btnes Windows

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres Cerrar la Aplicacion?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRest.Visible = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMax.Visible = true;
        }
        #endregion

        #region Informacion de Usuario
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Cerrar Session?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void LoadUserData()
        {
            lblUserName.Text = UserLoginCache.Nombres + " " + UserLoginCache.Apellidos;
        }
        private void TecnicoUI_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideSubMenu();
            DisableButton();
            OpenChildForm(new FormEditProfile());
            leftBorderBtn.Visible = false;
            iconFormHijoActual.IconChar = IconChar.UserCircle;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            lblTitleFormActual.Text = "Editar Perfil";
        }
        #endregion
        private void Reset()
        {
            iconFormHijoActual.IconChar = IconChar.Home;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            lblTitleFormActual.Text = "Inicio";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnEnsamblesAsig_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new EnsamblesAsignados());
            lblTitleFormActual.Text = "Ensambles Asignados";
        }
        #region Botones Ensambles
        private void btnEnsambles_Click(object sender, EventArgs e)
        {

        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnNewEnsamble_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
