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
using Common;
using FontAwesome.Sharp;
using Presentacion.FormCompartidos;
using Presentacion.FormEnsambles;

namespace Presentacion.Form_Ventas
{
    public partial class VentasUI : Form
    {
        private Form FromActive = null;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public VentasUI()
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region Activar Botones
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
            pnlSubEnsamble.Visible = false;
            pnlSubProductos.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubProductos.Visible == true)
                pnlSubProductos.Visible = false;
            if (pnlSubEnsamble.Visible == true)
                pnlSubEnsamble.Visible = false;

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
        #region Botones Windows
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere Cerrar la Aplicacion?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRest.Visible = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMax.Visible = true;
        }
        #endregion
        #region Resetear
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
        #region Datos del Usuario
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Cerrar Sesión?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
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
        private void loadUserData()
        {
            lblUserName.Text = UserLoginCache.Nombres + " " + UserLoginCache.Apellidos;
        }
        private void VentasUI_Load(object sender, EventArgs e)
        {
            loadUserData();
        }
        #endregion
        #region Botones Esnambles
        private void btnEnsambles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            lblTitleFormActual.Text = "Ensambles";
            subMenu(pnlSubEnsamble);
        }
        private void btnNewEnsamble_Click(object sender, EventArgs e)
        {
            OpenFormSon(new NuevoEnsamble());
            lblTitleFormActual.Text = "Nuevo Ensamble";
            iconFormHijoActual.IconChar = btnNewEnsamble.IconChar;
            hideSubMenu();
        }
        private void btnEnsambleSolic_Click(object sender, EventArgs e)
        {
            OpenFormSon(new EnsamblesSolicitados());
            lblTitleFormActual.Text = "Ensambles Solicitados";
            iconFormHijoActual.IconChar = btnEnsambleSolic.IconChar;
            hideSubMenu();
        }
        private void btnEnsamListos_Click(object sender, EventArgs e)
        {
            OpenFormSon(new EnsamSolicListos());
            lblTitleFormActual.Text = "Ensambles Listos";
            iconFormHijoActual.IconChar = btnEnsamListos.IconChar;
            hideSubMenu();
        }
        private void btnAllEnsambles_Click(object sender, EventArgs e)
        {
            OpenFormSon(new AllEnamAlmVent());
            lblTitleFormActual.Text = "Todos los Ensambles";
            iconFormHijoActual.IconChar = btnAllEnsambles.IconChar;
            hideSubMenu();
        }
        #endregion
        #region Botones Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color2);
            lblTitleFormActual.Text = "Productos";
            subMenu(pnlSubProductos);
        }
        private void btnAllProduct_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitleFormActual.Text = "Todos los Productos";
            iconFormHijoActual.IconChar = btnAllProduct.IconChar;
            OpenFormSon(new AllProductos());
        }
        private void btnProdExist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitleFormActual.Text = "Productos con Existencias";
            iconFormHijoActual.IconChar = btnProdExist.IconChar;
            OpenFormSon(new ProductSiExist());
        }
        private void btnProdNExist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitleFormActual.Text = "Productos sin Existencias";
            iconFormHijoActual.IconChar = btnProdExist.IconChar;
            OpenFormSon(new ProductNoExist());
        }
        #endregion
        private void btnClient_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color3);
            OpenFormSon(new FormClientes());
            lblTitleFormActual.Text = "Clientes";
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        
    }
}
