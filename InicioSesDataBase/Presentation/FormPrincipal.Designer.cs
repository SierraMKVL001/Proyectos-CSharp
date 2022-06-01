
using System;

namespace Presentation
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconConfiguracion = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconClientes = new FontAwesome.Sharp.IconButton();
            this.iconProductos = new FontAwesome.Sharp.IconButton();
            this.iconEnsambles = new FontAwesome.Sharp.IconButton();
            this.iconEstadisticas = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblUserAct = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPosit = new System.Windows.Forms.Label();
            this.iconbtnRestore = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnMaxim = new FontAwesome.Sharp.IconPictureBox();
            this.iconbtnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lblTituloHijo = new System.Windows.Forms.Label();
            this.iconHijoFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDeskpot = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnMaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHijoFormActual)).BeginInit();
            this.panelDeskpot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.iconConfiguracion);
            this.panelMenu.Controls.Add(this.iconButton5);
            this.panelMenu.Controls.Add(this.iconClientes);
            this.panelMenu.Controls.Add(this.iconProductos);
            this.panelMenu.Controls.Add(this.iconEnsambles);
            this.panelMenu.Controls.Add(this.iconEstadisticas);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 552);
            this.panelMenu.TabIndex = 0;
            // 
            // iconConfiguracion
            // 
            this.iconConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconConfiguracion.FlatAppearance.BorderSize = 0;
            this.iconConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconConfiguracion.IconColor = System.Drawing.Color.Gainsboro;
            this.iconConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconConfiguracion.IconSize = 32;
            this.iconConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconConfiguracion.Location = new System.Drawing.Point(0, 380);
            this.iconConfiguracion.Name = "iconConfiguracion";
            this.iconConfiguracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconConfiguracion.Size = new System.Drawing.Size(220, 60);
            this.iconConfiguracion.TabIndex = 6;
            this.iconConfiguracion.Text = "Configuracion";
            this.iconConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconConfiguracion.UseVisualStyleBackColor = true;
            this.iconConfiguracion.Click += new System.EventHandler(this.iconConfiguracion_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 492);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(220, 60);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "Cerrar Sesión";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconClientes
            // 
            this.iconClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconClientes.FlatAppearance.BorderSize = 0;
            this.iconClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconClientes.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClientes.IconSize = 32;
            this.iconClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconClientes.Location = new System.Drawing.Point(0, 320);
            this.iconClientes.Name = "iconClientes";
            this.iconClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconClientes.Size = new System.Drawing.Size(220, 60);
            this.iconClientes.TabIndex = 4;
            this.iconClientes.Text = "Clientes";
            this.iconClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconClientes.UseVisualStyleBackColor = true;
            this.iconClientes.Click += new System.EventHandler(this.iconClientes_Click);
            // 
            // iconProductos
            // 
            this.iconProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconProductos.FlatAppearance.BorderSize = 0;
            this.iconProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconProductos.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.iconProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProductos.IconSize = 32;
            this.iconProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProductos.Location = new System.Drawing.Point(0, 260);
            this.iconProductos.Name = "iconProductos";
            this.iconProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconProductos.Size = new System.Drawing.Size(220, 60);
            this.iconProductos.TabIndex = 3;
            this.iconProductos.Text = "Productos";
            this.iconProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconProductos.UseVisualStyleBackColor = true;
            this.iconProductos.Click += new System.EventHandler(this.iconProductos_Click);
            // 
            // iconEnsambles
            // 
            this.iconEnsambles.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconEnsambles.FlatAppearance.BorderSize = 0;
            this.iconEnsambles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEnsambles.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconEnsambles.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iconEnsambles.IconColor = System.Drawing.Color.Gainsboro;
            this.iconEnsambles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEnsambles.IconSize = 32;
            this.iconEnsambles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEnsambles.Location = new System.Drawing.Point(0, 200);
            this.iconEnsambles.Name = "iconEnsambles";
            this.iconEnsambles.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconEnsambles.Size = new System.Drawing.Size(220, 60);
            this.iconEnsambles.TabIndex = 2;
            this.iconEnsambles.Text = "Ensambles";
            this.iconEnsambles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEnsambles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEnsambles.UseVisualStyleBackColor = true;
            this.iconEnsambles.Click += new System.EventHandler(this.iconEnsambles_Click);
            // 
            // iconEstadisticas
            // 
            this.iconEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconEstadisticas.FlatAppearance.BorderSize = 0;
            this.iconEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEstadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconEstadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconEstadisticas.IconColor = System.Drawing.Color.Gainsboro;
            this.iconEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEstadisticas.IconSize = 32;
            this.iconEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEstadisticas.Location = new System.Drawing.Point(0, 140);
            this.iconEstadisticas.Name = "iconEstadisticas";
            this.iconEstadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconEstadisticas.Size = new System.Drawing.Size(220, 60);
            this.iconEstadisticas.TabIndex = 1;
            this.iconEstadisticas.Text = "Estadisticas";
            this.iconEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEstadisticas.UseVisualStyleBackColor = true;
            this.iconEstadisticas.Click += new System.EventHandler(this.iconEstadisticas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(220, 140);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panelBarraTitulo.Controls.Add(this.lblUserAct);
            this.panelBarraTitulo.Controls.Add(this.lblNombre);
            this.panelBarraTitulo.Controls.Add(this.lblPosit);
            this.panelBarraTitulo.Controls.Add(this.iconbtnRestore);
            this.panelBarraTitulo.Controls.Add(this.iconbtnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.iconbtnMaxim);
            this.panelBarraTitulo.Controls.Add(this.iconbtnCerrar);
            this.panelBarraTitulo.Controls.Add(this.lblTituloHijo);
            this.panelBarraTitulo.Controls.Add(this.iconHijoFormActual);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(867, 65);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // lblUserAct
            // 
            this.lblUserAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserAct.AutoSize = true;
            this.lblUserAct.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserAct.Location = new System.Drawing.Point(342, 6);
            this.lblUserAct.Name = "lblUserAct";
            this.lblUserAct.Size = new System.Drawing.Size(84, 15);
            this.lblUserAct.TabIndex = 8;
            this.lblUserAct.Text = "Usuario Actual";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(355, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPosit
            // 
            this.lblPosit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosit.AutoSize = true;
            this.lblPosit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPosit.Location = new System.Drawing.Point(354, 39);
            this.lblPosit.Name = "lblPosit";
            this.lblPosit.Size = new System.Drawing.Size(52, 15);
            this.lblPosit.TabIndex = 6;
            this.lblPosit.Text = "Posicion";
            // 
            // iconbtnRestore
            // 
            this.iconbtnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.iconbtnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconbtnRestore.IconColor = System.Drawing.Color.White;
            this.iconbtnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnRestore.IconSize = 21;
            this.iconbtnRestore.Location = new System.Drawing.Point(819, 0);
            this.iconbtnRestore.Name = "iconbtnRestore";
            this.iconbtnRestore.Size = new System.Drawing.Size(21, 21);
            this.iconbtnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconbtnRestore.TabIndex = 5;
            this.iconbtnRestore.TabStop = false;
            this.iconbtnRestore.Visible = false;
            this.iconbtnRestore.Click += new System.EventHandler(this.iconbtnRestore_Click_1);
            // 
            // iconbtnMinimizar
            // 
            this.iconbtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.iconbtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.iconbtnMinimizar.IconColor = System.Drawing.Color.White;
            this.iconbtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnMinimizar.IconSize = 21;
            this.iconbtnMinimizar.Location = new System.Drawing.Point(792, 0);
            this.iconbtnMinimizar.Name = "iconbtnMinimizar";
            this.iconbtnMinimizar.Size = new System.Drawing.Size(21, 21);
            this.iconbtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconbtnMinimizar.TabIndex = 4;
            this.iconbtnMinimizar.TabStop = false;
            this.iconbtnMinimizar.Click += new System.EventHandler(this.iconbtnMinimizar_Click);
            // 
            // iconbtnMaxim
            // 
            this.iconbtnMaxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnMaxim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.iconbtnMaxim.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconbtnMaxim.IconColor = System.Drawing.Color.White;
            this.iconbtnMaxim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnMaxim.IconSize = 21;
            this.iconbtnMaxim.Location = new System.Drawing.Point(819, 0);
            this.iconbtnMaxim.Name = "iconbtnMaxim";
            this.iconbtnMaxim.Size = new System.Drawing.Size(21, 21);
            this.iconbtnMaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconbtnMaxim.TabIndex = 3;
            this.iconbtnMaxim.TabStop = false;
            this.iconbtnMaxim.Click += new System.EventHandler(this.iconbtnRestore_Click);
            // 
            // iconbtnCerrar
            // 
            this.iconbtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.iconbtnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconbtnCerrar.IconColor = System.Drawing.Color.White;
            this.iconbtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnCerrar.IconSize = 21;
            this.iconbtnCerrar.Location = new System.Drawing.Point(846, 0);
            this.iconbtnCerrar.Name = "iconbtnCerrar";
            this.iconbtnCerrar.Size = new System.Drawing.Size(21, 21);
            this.iconbtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconbtnCerrar.TabIndex = 2;
            this.iconbtnCerrar.TabStop = false;
            this.iconbtnCerrar.Click += new System.EventHandler(this.iconbtnCerrar_Click);
            // 
            // lblTituloHijo
            // 
            this.lblTituloHijo.AutoSize = true;
            this.lblTituloHijo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloHijo.Location = new System.Drawing.Point(67, 14);
            this.lblTituloHijo.Name = "lblTituloHijo";
            this.lblTituloHijo.Size = new System.Drawing.Size(85, 40);
            this.lblTituloHijo.TabIndex = 1;
            this.lblTituloHijo.Text = "Inicio";
            // 
            // iconHijoFormActual
            // 
            this.iconHijoFormActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.iconHijoFormActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHijoFormActual.IconColor = System.Drawing.Color.White;
            this.iconHijoFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHijoFormActual.IconSize = 65;
            this.iconHijoFormActual.Location = new System.Drawing.Point(0, 0);
            this.iconHijoFormActual.Name = "iconHijoFormActual";
            this.iconHijoFormActual.Size = new System.Drawing.Size(65, 65);
            this.iconHijoFormActual.TabIndex = 0;
            this.iconHijoFormActual.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(85)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 65);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(867, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDeskpot
            // 
            this.panelDeskpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDeskpot.Controls.Add(this.lblTime);
            this.panelDeskpot.Controls.Add(this.lblHour);
            this.panelDeskpot.Controls.Add(this.pictureBox1);
            this.panelDeskpot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskpot.Location = new System.Drawing.Point(220, 73);
            this.panelDeskpot.Name = "panelDeskpot";
            this.panelDeskpot.Size = new System.Drawing.Size(867, 479);
            this.panelDeskpot.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblTime.Location = new System.Drawing.Point(355, 322);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(171, 58);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            // 
            // lblHour
            // 
            this.lblHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHour.ForeColor = System.Drawing.Color.White;
            this.lblHour.Location = new System.Drawing.Point(257, 383);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(96, 33);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 552);
            this.Controls.Add(this.panelDeskpot);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnMaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHijoFormActual)).EndInit();
            this.panelDeskpot.ResumeLayout(false);
            this.panelDeskpot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconEstadisticas;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconConfiguracion;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconClientes;
        private FontAwesome.Sharp.IconButton iconProductos;
        private FontAwesome.Sharp.IconButton iconEnsambles;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblTituloHijo;
        private FontAwesome.Sharp.IconPictureBox iconHijoFormActual;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDeskpot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconbtnCerrar;
        private FontAwesome.Sharp.IconPictureBox iconbtnMaxim;
        private FontAwesome.Sharp.IconPictureBox iconbtnMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconbtnRestore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblUserAct;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPosit;
    }
}