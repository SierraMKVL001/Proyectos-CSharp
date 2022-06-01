
namespace Presentacion.Form_Ventas
{
    partial class VentasUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasUI));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnClient = new FontAwesome.Sharp.IconButton();
            this.pnlSubProductos = new System.Windows.Forms.Panel();
            this.btnProdNExist = new FontAwesome.Sharp.IconButton();
            this.btnProdExist = new FontAwesome.Sharp.IconButton();
            this.btnAllProduct = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.pnlSubEnsamble = new System.Windows.Forms.Panel();
            this.btnAllEnsambles = new FontAwesome.Sharp.IconButton();
            this.btnEnsamListos = new FontAwesome.Sharp.IconButton();
            this.btnEnsambleSolic = new FontAwesome.Sharp.IconButton();
            this.btnNewEnsamble = new FontAwesome.Sharp.IconButton();
            this.btnEnsambles = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.btnRest = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblEdit = new System.Windows.Forms.LinkLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconFormHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleFormActual = new System.Windows.Forms.Label();
            this.barraShadow = new System.Windows.Forms.Panel();
            this.pnlDeskpot = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tmrFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlSubProductos.SuspendLayout();
            this.pnlSubEnsamble.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoActual)).BeginInit();
            this.pnlDeskpot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.pnlMenu.Controls.Add(this.btnClient);
            this.pnlMenu.Controls.Add(this.pnlSubProductos);
            this.pnlMenu.Controls.Add(this.btnProductos);
            this.pnlMenu.Controls.Add(this.pnlSubEnsamble);
            this.pnlMenu.Controls.Add(this.btnEnsambles);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.pnlImage);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 591);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnClient
            // 
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClient.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClient.IconSize = 35;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(0, 505);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(220, 60);
            this.btnClient.TabIndex = 12;
            this.btnClient.Text = "Clientes";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // pnlSubProductos
            // 
            this.pnlSubProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.pnlSubProductos.Controls.Add(this.btnProdNExist);
            this.pnlSubProductos.Controls.Add(this.btnProdExist);
            this.pnlSubProductos.Controls.Add(this.btnAllProduct);
            this.pnlSubProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubProductos.Location = new System.Drawing.Point(0, 400);
            this.pnlSubProductos.Name = "pnlSubProductos";
            this.pnlSubProductos.Size = new System.Drawing.Size(220, 105);
            this.pnlSubProductos.TabIndex = 11;
            // 
            // btnProdNExist
            // 
            this.btnProdNExist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdNExist.FlatAppearance.BorderSize = 0;
            this.btnProdNExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdNExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdNExist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProdNExist.IconChar = FontAwesome.Sharp.IconChar.StoreAltSlash;
            this.btnProdNExist.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProdNExist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdNExist.IconSize = 30;
            this.btnProdNExist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdNExist.Location = new System.Drawing.Point(0, 70);
            this.btnProdNExist.Name = "btnProdNExist";
            this.btnProdNExist.Size = new System.Drawing.Size(220, 35);
            this.btnProdNExist.TabIndex = 4;
            this.btnProdNExist.Text = "Productos sin Existencias";
            this.btnProdNExist.UseVisualStyleBackColor = true;
            this.btnProdNExist.Click += new System.EventHandler(this.btnProdNExist_Click);
            // 
            // btnProdExist
            // 
            this.btnProdExist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdExist.FlatAppearance.BorderSize = 0;
            this.btnProdExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdExist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProdExist.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnProdExist.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProdExist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProdExist.IconSize = 30;
            this.btnProdExist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdExist.Location = new System.Drawing.Point(0, 35);
            this.btnProdExist.Name = "btnProdExist";
            this.btnProdExist.Size = new System.Drawing.Size(220, 35);
            this.btnProdExist.TabIndex = 3;
            this.btnProdExist.Text = "Produstos con Existencias";
            this.btnProdExist.UseVisualStyleBackColor = true;
            this.btnProdExist.Click += new System.EventHandler(this.btnProdExist_Click);
            // 
            // btnAllProduct
            // 
            this.btnAllProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllProduct.FlatAppearance.BorderSize = 0;
            this.btnAllProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllProduct.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnAllProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAllProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllProduct.IconSize = 30;
            this.btnAllProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAllProduct.Name = "btnAllProduct";
            this.btnAllProduct.Size = new System.Drawing.Size(220, 35);
            this.btnAllProduct.TabIndex = 2;
            this.btnAllProduct.Text = "Todos losProductos";
            this.btnAllProduct.UseVisualStyleBackColor = true;
            this.btnAllProduct.Click += new System.EventHandler(this.btnAllProduct_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 35;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 340);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(220, 60);
            this.btnProductos.TabIndex = 10;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pnlSubEnsamble
            // 
            this.pnlSubEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.pnlSubEnsamble.Controls.Add(this.btnAllEnsambles);
            this.pnlSubEnsamble.Controls.Add(this.btnEnsamListos);
            this.pnlSubEnsamble.Controls.Add(this.btnEnsambleSolic);
            this.pnlSubEnsamble.Controls.Add(this.btnNewEnsamble);
            this.pnlSubEnsamble.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubEnsamble.Location = new System.Drawing.Point(0, 200);
            this.pnlSubEnsamble.Name = "pnlSubEnsamble";
            this.pnlSubEnsamble.Size = new System.Drawing.Size(220, 140);
            this.pnlSubEnsamble.TabIndex = 9;
            // 
            // btnAllEnsambles
            // 
            this.btnAllEnsambles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllEnsambles.FlatAppearance.BorderSize = 0;
            this.btnAllEnsambles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllEnsambles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllEnsambles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllEnsambles.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnAllEnsambles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAllEnsambles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllEnsambles.IconSize = 30;
            this.btnAllEnsambles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllEnsambles.Location = new System.Drawing.Point(0, 105);
            this.btnAllEnsambles.Name = "btnAllEnsambles";
            this.btnAllEnsambles.Size = new System.Drawing.Size(220, 35);
            this.btnAllEnsambles.TabIndex = 9;
            this.btnAllEnsambles.Text = "Todos los Ensambles";
            this.btnAllEnsambles.UseVisualStyleBackColor = true;
            this.btnAllEnsambles.Click += new System.EventHandler(this.btnAllEnsambles_Click);
            // 
            // btnEnsamListos
            // 
            this.btnEnsamListos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnsamListos.FlatAppearance.BorderSize = 0;
            this.btnEnsamListos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsamListos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnsamListos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnsamListos.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.btnEnsamListos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEnsamListos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsamListos.IconSize = 30;
            this.btnEnsamListos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsamListos.Location = new System.Drawing.Point(0, 70);
            this.btnEnsamListos.Name = "btnEnsamListos";
            this.btnEnsamListos.Size = new System.Drawing.Size(220, 35);
            this.btnEnsamListos.TabIndex = 8;
            this.btnEnsamListos.Text = "Ensambles Listos";
            this.btnEnsamListos.UseVisualStyleBackColor = true;
            this.btnEnsamListos.Click += new System.EventHandler(this.btnEnsamListos_Click);
            // 
            // btnEnsambleSolic
            // 
            this.btnEnsambleSolic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnsambleSolic.FlatAppearance.BorderSize = 0;
            this.btnEnsambleSolic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsambleSolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnsambleSolic.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnsambleSolic.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btnEnsambleSolic.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEnsambleSolic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsambleSolic.IconSize = 30;
            this.btnEnsambleSolic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsambleSolic.Location = new System.Drawing.Point(0, 35);
            this.btnEnsambleSolic.Name = "btnEnsambleSolic";
            this.btnEnsambleSolic.Size = new System.Drawing.Size(220, 35);
            this.btnEnsambleSolic.TabIndex = 7;
            this.btnEnsambleSolic.Text = "Ensambles Solicitados";
            this.btnEnsambleSolic.UseVisualStyleBackColor = true;
            this.btnEnsambleSolic.Click += new System.EventHandler(this.btnEnsambleSolic_Click);
            // 
            // btnNewEnsamble
            // 
            this.btnNewEnsamble.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEnsamble.FlatAppearance.BorderSize = 0;
            this.btnNewEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEnsamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEnsamble.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewEnsamble.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNewEnsamble.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNewEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewEnsamble.IconSize = 30;
            this.btnNewEnsamble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEnsamble.Location = new System.Drawing.Point(0, 0);
            this.btnNewEnsamble.Name = "btnNewEnsamble";
            this.btnNewEnsamble.Size = new System.Drawing.Size(220, 35);
            this.btnNewEnsamble.TabIndex = 6;
            this.btnNewEnsamble.Text = "Nuevo Ensamble";
            this.btnNewEnsamble.UseVisualStyleBackColor = true;
            this.btnNewEnsamble.Click += new System.EventHandler(this.btnNewEnsamble_Click);
            // 
            // btnEnsambles
            // 
            this.btnEnsambles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnsambles.FlatAppearance.BorderSize = 0;
            this.btnEnsambles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsambles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnsambles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnsambles.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnEnsambles.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEnsambles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsambles.IconSize = 35;
            this.btnEnsambles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsambles.Location = new System.Drawing.Point(0, 140);
            this.btnEnsambles.Name = "btnEnsambles";
            this.btnEnsambles.Size = new System.Drawing.Size(220, 60);
            this.btnEnsambles.TabIndex = 8;
            this.btnEnsambles.Text = "Ensambles";
            this.btnEnsambles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnsambles.UseVisualStyleBackColor = true;
            this.btnEnsambles.Click += new System.EventHandler(this.btnEnsambles_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 35;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 546);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 45);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pictureBox1);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(220, 140);
            this.pnlImage.TabIndex = 0;
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
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.BarraTitulo.Controls.Add(this.btnMinus);
            this.BarraTitulo.Controls.Add(this.btnRest);
            this.BarraTitulo.Controls.Add(this.btnMax);
            this.BarraTitulo.Controls.Add(this.btnClose);
            this.BarraTitulo.Controls.Add(this.lblEdit);
            this.BarraTitulo.Controls.Add(this.lblUserName);
            this.BarraTitulo.Controls.Add(this.lblPosition);
            this.BarraTitulo.Controls.Add(this.iconUser);
            this.BarraTitulo.Controls.Add(this.iconFormHijoActual);
            this.BarraTitulo.Controls.Add(this.lblTitleFormActual);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(879, 75);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
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
            this.btnMinus.Location = new System.Drawing.Point(781, 1);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(28, 28);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
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
            this.btnRest.Location = new System.Drawing.Point(815, 0);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(28, 28);
            this.btnRest.TabIndex = 8;
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
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
            this.btnMax.Location = new System.Drawing.Point(815, 1);
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
            this.btnClose.Location = new System.Drawing.Point(849, 1);
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
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.LinkColor = System.Drawing.Color.Gainsboro;
            this.lblEdit.Location = new System.Drawing.Point(632, 48);
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
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(632, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 17);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPosition.Location = new System.Drawing.Point(632, 12);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(120, 17);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Ejecutivo de Ventas";
            // 
            // iconUser
            // 
            this.iconUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.iconUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconUser.IconColor = System.Drawing.Color.Gainsboro;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 69;
            this.iconUser.Location = new System.Drawing.Point(557, 12);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(69, 69);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
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
            this.iconFormHijoActual.TabIndex = 1;
            this.iconFormHijoActual.TabStop = false;
            // 
            // lblTitleFormActual
            // 
            this.lblTitleFormActual.AutoSize = true;
            this.lblTitleFormActual.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFormActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleFormActual.Location = new System.Drawing.Point(77, 19);
            this.lblTitleFormActual.Name = "lblTitleFormActual";
            this.lblTitleFormActual.Size = new System.Drawing.Size(78, 30);
            this.lblTitleFormActual.TabIndex = 0;
            this.lblTitleFormActual.Text = "Inicio";
            // 
            // barraShadow
            // 
            this.barraShadow.BackColor = System.Drawing.Color.Black;
            this.barraShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraShadow.Location = new System.Drawing.Point(220, 75);
            this.barraShadow.Name = "barraShadow";
            this.barraShadow.Size = new System.Drawing.Size(879, 5);
            this.barraShadow.TabIndex = 3;
            // 
            // pnlDeskpot
            // 
            this.pnlDeskpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.pnlDeskpot.Controls.Add(this.lblFecha);
            this.pnlDeskpot.Controls.Add(this.lblHora);
            this.pnlDeskpot.Controls.Add(this.pictureBox2);
            this.pnlDeskpot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeskpot.Location = new System.Drawing.Point(220, 80);
            this.pnlDeskpot.Name = "pnlDeskpot";
            this.pnlDeskpot.Size = new System.Drawing.Size(879, 511);
            this.pnlDeskpot.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFecha.Location = new System.Drawing.Point(253, 421);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(112, 39);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHora.Location = new System.Drawing.Point(343, 363);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(171, 58);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(283, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // tmrFecha
            // 
            this.tmrFecha.Enabled = true;
            this.tmrFecha.Tick += new System.EventHandler(this.tmrFecha_Tick);
            // 
            // VentasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 591);
            this.Controls.Add(this.pnlDeskpot);
            this.Controls.Add(this.barraShadow);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(1115, 630);
            this.Name = "VentasUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasUI";
            this.Load += new System.EventHandler(this.VentasUI_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubProductos.ResumeLayout(false);
            this.pnlSubEnsamble.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoActual)).EndInit();
            this.pnlDeskpot.ResumeLayout(false);
            this.pnlDeskpot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnRest;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.LinkLabel lblEdit;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPosition;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconFormHijoActual;
        private System.Windows.Forms.Label lblTitleFormActual;
        private System.Windows.Forms.Panel barraShadow;
        private System.Windows.Forms.Panel pnlDeskpot;
        private FontAwesome.Sharp.IconButton btnClient;
        private System.Windows.Forms.Panel pnlSubProductos;
        private FontAwesome.Sharp.IconButton btnProdNExist;
        private FontAwesome.Sharp.IconButton btnProdExist;
        private FontAwesome.Sharp.IconButton btnAllProduct;
        private FontAwesome.Sharp.IconButton btnProductos;
        private System.Windows.Forms.Panel pnlSubEnsamble;
        private FontAwesome.Sharp.IconButton btnEnsambleSolic;
        private FontAwesome.Sharp.IconButton btnNewEnsamble;
        private FontAwesome.Sharp.IconButton btnEnsambles;
        private FontAwesome.Sharp.IconButton btnEnsamListos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrFecha;
        private FontAwesome.Sharp.IconButton btnAllEnsambles;
    }
}