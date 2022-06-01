using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Presentation
{
    public partial class FormPrincipal : Form
    {
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; 
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 214);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconHijoFormActual.IconChar = currentBtn.IconChar;
                iconHijoFormActual.IconColor = currentBtn.IconColor;


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
            panelDeskpot.Controls.Add(childForm);
            panelDeskpot.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTituloHijo.Text = childForm.Text;
        }



        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconEstadisticas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTituloHijo.Text = iconEstadisticas.Text;
            OpenChildForm(new Estadisticas());
            
        }

        private void iconEnsambles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            lblTituloHijo.Text = iconEnsambles.Text;
            OpenChildForm(new Ensambles());
            
        }

        private void iconProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            lblTituloHijo.Text = iconProductos.Text;
            OpenChildForm(new Productos());
        }

        private void iconClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            lblTituloHijo.Text = iconClientes.Text;
            OpenChildForm(new Clientes());
           
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Cerrar Seión", "Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            this.Close();

            
        }

        private void iconConfiguracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            lblTituloHijo.Text = iconConfiguracion.Text;
            OpenChildForm(new Configuracion());
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconHijoFormActual.IconChar = IconChar.Home;
            iconHijoFormActual.IconColor =Color.White;
            lblTituloHijo.Text = "Inicio";
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconbtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconbtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconbtnRestore_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            iconbtnMaxim.Visible = true;
            iconbtnRestore.Visible = false;
        }
        private void iconbtnRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            iconbtnMaxim.Visible = false;
            iconbtnRestore.Visible = true;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHour.Text = DateTime.Now.ToLongDateString();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            lblNombre.Text = CacheInicioSes.FirstName + " " + CacheInicioSes.LastName;
            lblPosit.Text = CacheInicioSes.Position;
        }
    }
}
