
namespace Presentation.FormTecnico
{
    partial class TecnicoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TecnicoUI));
            this.pnlPrin = new System.Windows.Forms.Panel();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnMisEnsambles = new FontAwesome.Sharp.IconButton();
            this.btnNewEnsamble = new FontAwesome.Sharp.IconButton();
            this.pnlSubEnsmble = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnenProceso = new FontAwesome.Sharp.IconButton();
            this.btnPendiente = new FontAwesome.Sharp.IconButton();
            this.btnEnsambles = new FontAwesome.Sharp.IconButton();
            this.btnEnsamblesAsig = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRest = new FontAwesome.Sharp.IconButton();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblEdit = new System.Windows.Forms.LinkLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleFormActual = new System.Windows.Forms.Label();
            this.iconFormHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDeskpot = new System.Windows.Forms.Panel();
            this.pnlPrin.SuspendLayout();
            this.pnlSubEnsmble.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoActual)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrin
            // 
            this.pnlPrin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.pnlPrin.Controls.Add(this.btnClientes);
            this.pnlPrin.Controls.Add(this.btnMisEnsambles);
            this.pnlPrin.Controls.Add(this.btnNewEnsamble);
            this.pnlPrin.Controls.Add(this.pnlSubEnsmble);
            this.pnlPrin.Controls.Add(this.btnEnsambles);
            this.pnlPrin.Controls.Add(this.btnEnsamblesAsig);
            this.pnlPrin.Controls.Add(this.btnLogOut);
            this.pnlPrin.Controls.Add(this.panel3);
            this.pnlPrin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrin.Location = new System.Drawing.Point(0, 0);
            this.pnlPrin.Name = "pnlPrin";
            this.pnlPrin.Size = new System.Drawing.Size(220, 591);
            this.pnlPrin.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 35;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 460);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(220, 45);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMisEnsambles
            // 
            this.btnMisEnsambles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisEnsambles.FlatAppearance.BorderSize = 0;
            this.btnMisEnsambles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisEnsambles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMisEnsambles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMisEnsambles.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnMisEnsambles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMisEnsambles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisEnsambles.IconSize = 35;
            this.btnMisEnsambles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisEnsambles.Location = new System.Drawing.Point(0, 415);
            this.btnMisEnsambles.Name = "btnMisEnsambles";
            this.btnMisEnsambles.Size = new System.Drawing.Size(220, 45);
            this.btnMisEnsambles.TabIndex = 8;
            this.btnMisEnsambles.Text = "Ensambles Terminados";
            this.btnMisEnsambles.UseVisualStyleBackColor = true;
            // 
            // btnNewEnsamble
            // 
            this.btnNewEnsamble.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEnsamble.FlatAppearance.BorderSize = 0;
            this.btnNewEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEnsamble.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewEnsamble.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewEnsamble.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNewEnsamble.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNewEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewEnsamble.IconSize = 35;
            this.btnNewEnsamble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEnsamble.Location = new System.Drawing.Point(0, 370);
            this.btnNewEnsamble.Name = "btnNewEnsamble";
            this.btnNewEnsamble.Size = new System.Drawing.Size(220, 45);
            this.btnNewEnsamble.TabIndex = 7;
            this.btnNewEnsamble.Text = "Nuevo Ensamble";
            this.btnNewEnsamble.UseVisualStyleBackColor = true;
            this.btnNewEnsamble.Click += new System.EventHandler(this.btnNewEnsamble_Click);
            // 
            // pnlSubEnsmble
            // 
            this.pnlSubEnsmble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(80)))));
            this.pnlSubEnsmble.Controls.Add(this.iconButton1);
            this.pnlSubEnsmble.Controls.Add(this.btnenProceso);
            this.pnlSubEnsmble.Controls.Add(this.btnPendiente);
            this.pnlSubEnsmble.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubEnsmble.Location = new System.Drawing.Point(0, 230);
            this.pnlSubEnsmble.Name = "pnlSubEnsmble";
            this.pnlSubEnsmble.Size = new System.Drawing.Size(220, 140);
            this.pnlSubEnsmble.TabIndex = 6;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 70);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(220, 35);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Ensamblados";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnenProceso
            // 
            this.btnenProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnenProceso.FlatAppearance.BorderSize = 0;
            this.btnenProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenProceso.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnenProceso.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnenProceso.IconColor = System.Drawing.Color.Gainsboro;
            this.btnenProceso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnenProceso.IconSize = 30;
            this.btnenProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenProceso.Location = new System.Drawing.Point(0, 35);
            this.btnenProceso.Name = "btnenProceso";
            this.btnenProceso.Size = new System.Drawing.Size(220, 35);
            this.btnenProceso.TabIndex = 2;
            this.btnenProceso.Text = "Listos para Ensamblar";
            this.btnenProceso.UseVisualStyleBackColor = true;
            // 
            // btnPendiente
            // 
            this.btnPendiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendiente.FlatAppearance.BorderSize = 0;
            this.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendiente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPendiente.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnPendiente.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPendiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPendiente.IconSize = 30;
            this.btnPendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendiente.Location = new System.Drawing.Point(0, 0);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(220, 35);
            this.btnPendiente.TabIndex = 1;
            this.btnPendiente.Text = "Pendientes";
            this.btnPendiente.UseVisualStyleBackColor = true;
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
            // 
            // btnEnsambles
            // 
            this.btnEnsambles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnsambles.FlatAppearance.BorderSize = 0;
            this.btnEnsambles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsambles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnsambles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnsambles.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnEnsambles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEnsambles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsambles.IconSize = 35;
            this.btnEnsambles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsambles.Location = new System.Drawing.Point(0, 185);
            this.btnEnsambles.Name = "btnEnsambles";
            this.btnEnsambles.Size = new System.Drawing.Size(220, 45);
            this.btnEnsambles.TabIndex = 5;
            this.btnEnsambles.Text = "Ensambles";
            this.btnEnsambles.UseVisualStyleBackColor = true;
            this.btnEnsambles.Click += new System.EventHandler(this.btnEnsambles_Click);
            // 
            // btnEnsamblesAsig
            // 
            this.btnEnsamblesAsig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnsamblesAsig.FlatAppearance.BorderSize = 0;
            this.btnEnsamblesAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsamblesAsig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnsamblesAsig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnsamblesAsig.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnEnsamblesAsig.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEnsamblesAsig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsamblesAsig.IconSize = 35;
            this.btnEnsamblesAsig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsamblesAsig.Location = new System.Drawing.Point(0, 140);
            this.btnEnsamblesAsig.Name = "btnEnsamblesAsig";
            this.btnEnsamblesAsig.Size = new System.Drawing.Size(220, 45);
            this.btnEnsamblesAsig.TabIndex = 3;
            this.btnEnsamblesAsig.Text = "Ensambles Asignados";
            this.btnEnsamblesAsig.UseVisualStyleBackColor = true;
            this.btnEnsamblesAsig.Click += new System.EventHandler(this.btnEnsamblesAsig_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 35;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 552);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 39);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Cerrar Sesion";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 140);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnRest);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblEdit);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblPuesto);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.lblTitleFormActual);
            this.panel1.Controls.Add(this.iconFormHijoActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.FlatAppearance.BorderSize = 0;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRest.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRest.IconSize = 28;
            this.btnRest.Location = new System.Drawing.Point(817, 0);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(28, 28);
            this.btnRest.TabIndex = 9;
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.btnMinus.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 28;
            this.btnMinus.Location = new System.Drawing.Point(783, 0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(28, 28);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 28;
            this.btnMax.Location = new System.Drawing.Point(817, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(28, 28);
            this.btnMax.TabIndex = 7;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 28;
            this.btnClose.Location = new System.Drawing.Point(851, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdit.LinkColor = System.Drawing.Color.Gainsboro;
            this.lblEdit.Location = new System.Drawing.Point(655, 48);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(75, 17);
            this.lblEdit.TabIndex = 5;
            this.lblEdit.TabStop = true;
            this.lblEdit.Text = "Editar Perfil";
            this.lblEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEdit_LinkClicked);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(655, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(73, 17);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuesto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPuesto.Location = new System.Drawing.Point(655, 12);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(51, 17);
            this.lblPuesto.TabIndex = 3;
            this.lblPuesto.Text = "Tecnico";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 69;
            this.iconPictureBox1.Location = new System.Drawing.Point(580, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(69, 69);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblTitleFormActual
            // 
            this.lblTitleFormActual.AutoSize = true;
            this.lblTitleFormActual.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleFormActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleFormActual.Location = new System.Drawing.Point(77, 19);
            this.lblTitleFormActual.Name = "lblTitleFormActual";
            this.lblTitleFormActual.Size = new System.Drawing.Size(78, 30);
            this.lblTitleFormActual.TabIndex = 1;
            this.lblTitleFormActual.Text = "Inicio";
            // 
            // iconFormHijoActual
            // 
            this.iconFormHijoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.iconFormHijoActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconFormHijoActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormHijoActual.IconColor = System.Drawing.Color.Gainsboro;
            this.iconFormHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormHijoActual.IconSize = 65;
            this.iconFormHijoActual.Location = new System.Drawing.Point(6, 10);
            this.iconFormHijoActual.Name = "iconFormHijoActual";
            this.iconFormHijoActual.Size = new System.Drawing.Size(65, 65);
            this.iconFormHijoActual.TabIndex = 0;
            this.iconFormHijoActual.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 5);
            this.panel2.TabIndex = 2;
            // 
            // pnlDeskpot
            // 
            this.pnlDeskpot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeskpot.Location = new System.Drawing.Point(220, 80);
            this.pnlDeskpot.Name = "pnlDeskpot";
            this.pnlDeskpot.Size = new System.Drawing.Size(879, 511);
            this.pnlDeskpot.TabIndex = 3;
            // 
            // TecnicoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 591);
            this.Controls.Add(this.pnlDeskpot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPrin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1115, 630);
            this.Name = "TecnicoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecnicoUI";
            this.Load += new System.EventHandler(this.TecnicoUI_Load);
            this.pnlPrin.ResumeLayout(false);
            this.pnlSubEnsmble.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDeskpot;
        private FontAwesome.Sharp.IconPictureBox iconFormHijoActual;
        private System.Windows.Forms.Label lblTitleFormActual;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel lblEdit;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnRest;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnEnsamblesAsig;
        private FontAwesome.Sharp.IconButton btnEnsambles;
        private System.Windows.Forms.Panel pnlSubEnsmble;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnenProceso;
        private FontAwesome.Sharp.IconButton btnPendiente;
        private FontAwesome.Sharp.IconButton btnNewEnsamble;
        private FontAwesome.Sharp.IconButton btnMisEnsambles;
        private FontAwesome.Sharp.IconButton btnClientes;
    }
}