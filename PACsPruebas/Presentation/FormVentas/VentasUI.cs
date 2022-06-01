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
using Presentation.FormEnsambles;


namespace Presentation.FormVentas
{
    public partial class VentasUI : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public VentasUI()
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        #region Menu-SubMenu
        private void customizeDesing()
        {
            pnlEnsmbles.Visible = false;
            pnlProductos.Visible = false;
            
        }
        private void hideSubMenu()
        {
            if (pnlEnsmbles.Visible == true)
                pnlEnsmbles.Visible = false;
            if (pnlProductos.Visible == true)
                pnlProductos.Visible = false;
            

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
        #region Funcion Btnes
        private void ActivateButton(object senderBtn,Color color)
        {
            DisableButton();
            if (senderBtn !=null)
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
                currentBtn.BackColor = Color.FromArgb(30,0,80);
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
        #region ToolsEnsamble
        private void btnEnsamble_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);

            lblTitleFormHijo.Text = "Ensambles";
            subMenu(pnlEnsmbles);

        }
        private void btnNewEnsamble_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NuevoEnsamble());
            lblTitleFormHijo.Text = "Nuevo Ensamble";
            iconFormHijoActual.IconChar = btnNewEnsamble.IconChar;
            hideSubMenu();
        }
        private void btnEnsambleSolic_Click(object sender, EventArgs e)
        {
            
            lblTitleFormHijo.Text = "Ensambles Solicitados";
            iconFormHijoActual.IconChar = btnEnsambleSolic.IconChar;
            hideSubMenu();
        }
        #endregion

        #region ToolsProductos
        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RGBColors.color2);
            lblTitleFormHijo.Text = "Productos";
            subMenu(pnlProductos);
        }
        private void btnAllProd_Click(object sender, EventArgs e)
        {
            lblTitleFormHijo.Text = "Todos los Productos";
            iconFormHijoActual.IconChar = btnAllProd.IconChar;
            OpenChildForm(new FormProductos());
            hideSubMenu();
        }
        private void btnProdExist_Click(object sender, EventArgs e)
        {
            lblTitleFormHijo.Text = "Productos con Existencias";
            iconFormHijoActual.IconChar = btnProdExist.IconChar;
           
            hideSubMenu();
        }
        private void btnProdNExist_Click(object sender, EventArgs e)
        {
            lblTitleFormHijo.Text = "Productos sin Existencias";
            iconFormHijoActual.IconChar = btnProdNExist.IconChar;
           
            hideSubMenu();
        }
        #endregion

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormClientes());
            lblTitleFormHijo.Text = "Clientes";
        }
        #region Reset
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (currentChildForm != null) 
            {
                currentChildForm.Close();
                Reset();
            }
            
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconFormHijoActual.IconChar = IconChar.Home;
            iconFormHijoActual.IconColor = Color.Gainsboro;
            lblTitleFormHijo.Text = "Inicio";
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
        #region Btnes Windows
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
        #region Datos de Usuario
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Cerrar Session?", "Precaucion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void lnkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormEditProfile());
            lblTitleFormHijo.Text = "Editar Perfil";
        }
        private void loadUserData()
        {
            lblUserName.Text= UserLoginCache.Nombres + " " + UserLoginCache.Apellidos;
        }
        private void VentasUI_Load(object sender, EventArgs e)
        {
            loadUserData();
        }
        #endregion




    }
}
