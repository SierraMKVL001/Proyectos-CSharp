using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentation.FormCompartidos;
using System.Runtime.InteropServices;
using Common.Cache;
using Presentation.FormEnsambles;
using FontAwesome.Sharp;



namespace Presentation.FormAdmin
{
    public partial class AdminUI : Form
    {
        private Form FromActive = null;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public AdminUI()
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelLateralMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region (Des)Activar Botones
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
            panelFormSon.Controls.Add(ChildForm);
            panelFormSon.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        #region SubMenus-Menus
        private void customizeDesing()
        {
            pnlSubEnsmble.Visible = false;
            pnlSubProductos.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubEnsmble.Visible == true)
                pnlSubEnsmble.Visible = false;
            if (pnlSubProductos.Visible == true)
                pnlSubProductos.Visible = false;


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
        #region Movilidad
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Informacion Usuario
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Cerrar Sesion?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void LoadUserData()
        {
            lblUserName.Text = UserLoginCache.Nombres+" "+UserLoginCache.Apellidos;
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideSubMenu();
            OpenFormSon(new FormEditProfile());
            lblTitleFormActual.Text = "Editar Perfil";
            iconFormHijoActual.IconChar = IconChar.UserCircle;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            DisableButton();
            leftBorderBtn.Visible = false;
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
            if (FromActive != null)
            {
                FromActive.Close();
                Reset();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        #region BotonesdeVentana

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres Cerrar la Aplicacion?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaxim_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaxim.Visible = false;
            btnRest.Visible = true;
        }

        private void btnRest_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMaxim.Visible = true;
        }
        #endregion

        private void btnFacEnsamble_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleFormActual.Text = "Facturar Ensambles";
            OpenFormSon(new EnsamblesListos());
            hideSubMenu();
        }

        private void btNEsnambles_Click(object sender, EventArgs e)
        {
            subMenu(pnlSubEnsmble);
            ActivateButton(sender, RGBColors.color2);
            lblTitleFormActual.Text = "Ensambles";
        }
        private void btnPendiente_Click(object sender, EventArgs e)
        {
            iconFormHijoActual.IconChar = IconChar.FileAlt;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            lblTitleFormActual.Text = "Ensambles Pendientes";
            OpenFormSon(new ListadeEnsambles());
            hideSubMenu();
        }
        private void btnEnsamFact_Click(object sender, EventArgs e)
        {
            iconFormHijoActual.IconChar = IconChar.FileAlt;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            lblTitleFormActual.Text = "Ensambles Pendientes";
            OpenFormSon(new EnsamblesFacturados());
            hideSubMenu();
        }

        private void btnNewEnsamble_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color3);
            OpenFormSon(new NuevoEnsamble());
            lblTitleFormActual.Text = "Nuevo Esnamble";
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color4);
            lblTitleFormActual.Text = "Usuarios";
            OpenFormSon(new FormEmpleados());

        }
        #region Productos Tools
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            lblTitleFormActual.Text = "Productos";
            subMenu(pnlSubProductos);
        }

        private void btnAllProduct_Click(object sender, EventArgs e)
        {
            lblTitleFormActual.Text = "Todos los Productos";
            iconFormHijoActual.IconChar = btnAllProduct.IconChar;
            OpenFormSon(new FormProductos());
            hideSubMenu();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            lblTitleFormActual.Text = "Marcas";
            iconFormHijoActual.IconChar = btnMarcas.IconChar;
            OpenFormSon(new FormMarcas());
            hideSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            lblTitleFormActual.Text = "Categorias";
            iconFormHijoActual.IconChar = btnCategorias.IconChar;
            OpenFormSon(new FormCategorias());
            hideSubMenu();
        }

        private void btnProve_Click(object sender, EventArgs e)
        {
            lblTitleFormActual.Text = "Provedores";
            iconFormHijoActual.IconChar = btnProve.IconChar;
            OpenFormSon(new FormProvedores());
            hideSubMenu();
        }
        #endregion
        private void btnClientes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color6);
            OpenFormSon(new FormClientes());
            lblTitleFormActual.Text = "Clientes";
        }

        
    }
}
