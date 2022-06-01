using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentation.FormCompartidos;
using Presentation.FormAdmin;
using Presentation.FormEnsambles;
using System.Runtime.InteropServices;
using Common.Cache;
using FontAwesome.Sharp;

namespace Presentation.FormRecepServ
{
    public partial class RecepcionUI : Form
    {
        private Form FromActive = null;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public RecepcionUI()
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pnlMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region Opciones Boton
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
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 214);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        #endregion
        private void OpenFormSon(Form ChildForm)
        {
            if (FromActive != null)
                FromActive.Close();
            FromActive = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlDeskpot.Controls.Add(ChildForm);
            pnlDeskpot.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
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
        #region Reset
        private void Reset()
        {
            iconFormHijoActual.IconChar = IconChar.Home;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            lblTitleFormActual.Text = "Inicio";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (FromActive != null)
            {
                FromActive.Close();
                Reset();
            }
        }
        #endregion
        #region Movilidad 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region User Data Cache
        private void loadUserData()
        {
            lblNameUser.Text = UserLoginCache.Nombres + " " + UserLoginCache.Apellidos;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Cerrar Session?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnEditperfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideSubMenu();
            OpenFormSon(new FormEditProfile());
            lblTitleFormActual.Text = "Editar Perfil";
            iconFormHijoActual.IconChar = IconChar.UserCircle;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            DisableButton();
            leftBorderBtn.Visible = false;

        }

        private void RecepcionUI_Load(object sender, EventArgs e)
        {
            loadUserData();
        }
        #endregion
        #region Btnes Windows
        private void btnClso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere Cerrar la Aplicacion?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMXA_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMXA.Visible = false;
            btnDrest.Visible = true;
        }

        private void btnMIC_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDrest_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnDrest.Visible = false;
            btnMXA.Visible = true;
        }

        #endregion

        private void btnAsigTec_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color5);
            OpenFormSon(new EnsamblesPzasAsig());
            lblTitleFormActual.Text = "Asignar Tecnicos";
        }

        #region Botones Ensamble
        private void btnEnsambles_Click(object sender, EventArgs e)
        {
            subMenu(pnlSubEnsmble);
            ActivateButton(sender, RGBColors.color3);
            lblTitleFormActual.Text = "Ensambles";
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitleFormActual.Text = "Ensambles Pendientes";
            iconFormHijoActual.IconChar = btnPendiente.IconChar;
            OpenFormSon(new ListadeEnsambles());
        }
        #endregion

        private void btnNewEnsamble_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color5);
            OpenFormSon(new NuevoEnsamble());
            lblTitleFormActual.Text = "Nuevo Esnamble";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color6);
            OpenFormSon(new FormClientes());
            lblTitleFormActual.Text = "Clientes";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            if (FromActive != null)
            {
                FromActive.Close();
                Reset();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
        }
    }
}
