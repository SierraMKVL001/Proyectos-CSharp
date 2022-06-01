
namespace Presentacion.Form_Almacen
{
    partial class EnsamListo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDatosEnsamb = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btonCancelEnsam = new FontAwesome.Sharp.IconButton();
            this.btnRegresarTec = new FontAwesome.Sharp.IconButton();
            this.btnMarcarFacturado = new FontAwesome.Sharp.IconButton();
            this.btnEnsamExcel = new FontAwesome.Sharp.IconButton();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.lblIDE = new System.Windows.Forms.Label();
            this.lblNFolio = new System.Windows.Forms.Label();
            this.lblNomRSoc = new System.Windows.Forms.Label();
            this.lblSolicito = new System.Windows.Forms.Label();
            this.lblEnsam = new System.Windows.Forms.Label();
            this.lblSubT = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlDatosEnsamb.SuspendLayout();
            this.panelDatosEnsamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosEnsamb
            // 
            this.pnlDatosEnsamb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosEnsamb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlDatosEnsamb.Controls.Add(this.lblTotal);
            this.pnlDatosEnsamb.Controls.Add(this.lblIVA);
            this.pnlDatosEnsamb.Controls.Add(this.lblSubT);
            this.pnlDatosEnsamb.Controls.Add(this.lblEnsam);
            this.pnlDatosEnsamb.Controls.Add(this.lblSolicito);
            this.pnlDatosEnsamb.Controls.Add(this.lblNomRSoc);
            this.pnlDatosEnsamb.Controls.Add(this.lblNFolio);
            this.pnlDatosEnsamb.Controls.Add(this.lblIDE);
            this.pnlDatosEnsamb.Controls.Add(this.label8);
            this.pnlDatosEnsamb.Controls.Add(this.label7);
            this.pnlDatosEnsamb.Controls.Add(this.label6);
            this.pnlDatosEnsamb.Controls.Add(this.label5);
            this.pnlDatosEnsamb.Controls.Add(this.label4);
            this.pnlDatosEnsamb.Controls.Add(this.label3);
            this.pnlDatosEnsamb.Controls.Add(this.label2);
            this.pnlDatosEnsamb.Controls.Add(this.label1);
            this.pnlDatosEnsamb.Location = new System.Drawing.Point(567, 36);
            this.pnlDatosEnsamb.Name = "pnlDatosEnsamb";
            this.pnlDatosEnsamb.Size = new System.Drawing.Size(284, 190);
            this.pnlDatosEnsamb.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(3, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(15, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(131, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ensamblo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Solicito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(53, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre/Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(133, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio: ";
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btonCancelEnsam);
            this.panelDatosEnsamble.Controls.Add(this.btnRegresarTec);
            this.panelDatosEnsamble.Controls.Add(this.btnMarcarFacturado);
            this.panelDatosEnsamble.Controls.Add(this.btnEnsamExcel);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(6, 249);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(236, 200);
            this.panelDatosEnsamble.TabIndex = 11;
            // 
            // btonCancelEnsam
            // 
            this.btonCancelEnsam.BackColor = System.Drawing.Color.AliceBlue;
            this.btonCancelEnsam.FlatAppearance.BorderSize = 0;
            this.btonCancelEnsam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonCancelEnsam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonCancelEnsam.ForeColor = System.Drawing.Color.DarkRed;
            this.btonCancelEnsam.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.btonCancelEnsam.IconColor = System.Drawing.Color.DarkRed;
            this.btonCancelEnsam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btonCancelEnsam.IconSize = 30;
            this.btonCancelEnsam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btonCancelEnsam.Location = new System.Drawing.Point(18, 145);
            this.btonCancelEnsam.Name = "btonCancelEnsam";
            this.btonCancelEnsam.Size = new System.Drawing.Size(201, 36);
            this.btonCancelEnsam.TabIndex = 3;
            this.btonCancelEnsam.Text = "Cancelar Ensamble";
            this.btonCancelEnsam.UseVisualStyleBackColor = false;
            this.btonCancelEnsam.Click += new System.EventHandler(this.btonCancelEnsam_Click);
            // 
            // btnRegresarTec
            // 
            this.btnRegresarTec.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRegresarTec.FlatAppearance.BorderSize = 0;
            this.btnRegresarTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarTec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarTec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRegresarTec.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            this.btnRegresarTec.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnRegresarTec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresarTec.IconSize = 30;
            this.btnRegresarTec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarTec.Location = new System.Drawing.Point(18, 103);
            this.btnRegresarTec.Name = "btnRegresarTec";
            this.btnRegresarTec.Size = new System.Drawing.Size(201, 36);
            this.btnRegresarTec.TabIndex = 2;
            this.btnRegresarTec.Text = "Regresar Ensamble";
            this.btnRegresarTec.UseVisualStyleBackColor = false;
            this.btnRegresarTec.Click += new System.EventHandler(this.btnRegresarTec_Click);
            // 
            // btnMarcarFacturado
            // 
            this.btnMarcarFacturado.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMarcarFacturado.FlatAppearance.BorderSize = 0;
            this.btnMarcarFacturado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarFacturado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarFacturado.ForeColor = System.Drawing.Color.Gray;
            this.btnMarcarFacturado.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnMarcarFacturado.IconColor = System.Drawing.Color.Gray;
            this.btnMarcarFacturado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarcarFacturado.IconSize = 30;
            this.btnMarcarFacturado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarFacturado.Location = new System.Drawing.Point(18, 61);
            this.btnMarcarFacturado.Name = "btnMarcarFacturado";
            this.btnMarcarFacturado.Size = new System.Drawing.Size(201, 36);
            this.btnMarcarFacturado.TabIndex = 1;
            this.btnMarcarFacturado.Text = "Ensamble Facturado";
            this.btnMarcarFacturado.UseVisualStyleBackColor = false;
            this.btnMarcarFacturado.Click += new System.EventHandler(this.btnMarcarFacturado_Click);
            // 
            // btnEnsamExcel
            // 
            this.btnEnsamExcel.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnsamExcel.FlatAppearance.BorderSize = 0;
            this.btnEnsamExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsamExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnsamExcel.ForeColor = System.Drawing.Color.Green;
            this.btnEnsamExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnEnsamExcel.IconColor = System.Drawing.Color.Green;
            this.btnEnsamExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsamExcel.IconSize = 30;
            this.btnEnsamExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsamExcel.Location = new System.Drawing.Point(18, 19);
            this.btnEnsamExcel.Name = "btnEnsamExcel";
            this.btnEnsamExcel.Size = new System.Drawing.Size(201, 36);
            this.btnEnsamExcel.TabIndex = 0;
            this.btnEnsamExcel.Text = "Exportar a Excel";
            this.btnEnsamExcel.UseVisualStyleBackColor = false;
            this.btnEnsamExcel.Click += new System.EventHandler(this.btnEnsamExcel_Click);
            // 
            // dGVDetalleEnsamble
            // 
            this.dGVDetalleEnsamble.AllowUserToAddRows = false;
            this.dGVDetalleEnsamble.AllowUserToDeleteRows = false;
            this.dGVDetalleEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVDetalleEnsamble.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDetalleEnsamble.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.dGVDetalleEnsamble.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDetalleEnsamble.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dGVDetalleEnsamble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDetalleEnsamble.DefaultCellStyle = dataGridViewCellStyle22;
            this.dGVDetalleEnsamble.EnableHeadersVisualStyles = false;
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(252, 249);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowHeadersVisible = false;
            this.dGVDetalleEnsamble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(599, 200);
            this.dGVDetalleEnsamble.TabIndex = 10;
            // 
            // dGVEnsambles
            // 
            this.dGVEnsambles.AllowUserToAddRows = false;
            this.dGVEnsambles.AllowUserToDeleteRows = false;
            this.dGVEnsambles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEnsambles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVEnsambles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.dGVEnsambles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVEnsambles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dGVEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVEnsambles.DefaultCellStyle = dataGridViewCellStyle24;
            this.dGVEnsambles.EnableHeadersVisualStyles = false;
            this.dGVEnsambles.Location = new System.Drawing.Point(6, 36);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowHeadersVisible = false;
            this.dGVEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnsambles.Size = new System.Drawing.Size(555, 190);
            this.dGVEnsambles.TabIndex = 9;
            this.dGVEnsambles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEnsambles_CellClick);
            // 
            // lblIDE
            // 
            this.lblIDE.AutoSize = true;
            this.lblIDE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDE.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIDE.Location = new System.Drawing.Point(52, 11);
            this.lblIDE.Name = "lblIDE";
            this.lblIDE.Size = new System.Drawing.Size(19, 21);
            this.lblIDE.TabIndex = 20;
            this.lblIDE.Text = "0";
            // 
            // lblNFolio
            // 
            this.lblNFolio.AutoSize = true;
            this.lblNFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFolio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNFolio.Location = new System.Drawing.Point(191, 11);
            this.lblNFolio.Name = "lblNFolio";
            this.lblNFolio.Size = new System.Drawing.Size(19, 21);
            this.lblNFolio.TabIndex = 21;
            this.lblNFolio.Text = "0";
            // 
            // lblNomRSoc
            // 
            this.lblNomRSoc.AutoSize = true;
            this.lblNomRSoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRSoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNomRSoc.Location = new System.Drawing.Point(30, 53);
            this.lblNomRSoc.Name = "lblNomRSoc";
            this.lblNomRSoc.Size = new System.Drawing.Size(112, 21);
            this.lblNomRSoc.TabIndex = 22;
            this.lblNomRSoc.Text = "Desconocido";
            // 
            // lblSolicito
            // 
            this.lblSolicito.AutoSize = true;
            this.lblSolicito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicito.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSolicito.Location = new System.Drawing.Point(89, 82);
            this.lblSolicito.Name = "lblSolicito";
            this.lblSolicito.Size = new System.Drawing.Size(112, 21);
            this.lblSolicito.TabIndex = 23;
            this.lblSolicito.Text = "Desconocido";
            // 
            // lblEnsam
            // 
            this.lblEnsam.AutoSize = true;
            this.lblEnsam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnsam.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnsam.Location = new System.Drawing.Point(110, 108);
            this.lblEnsam.Name = "lblEnsam";
            this.lblEnsam.Size = new System.Drawing.Size(112, 21);
            this.lblEnsam.TabIndex = 24;
            this.lblEnsam.Text = "Desconocido";
            // 
            // lblSubT
            // 
            this.lblSubT.AutoSize = true;
            this.lblSubT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubT.Location = new System.Drawing.Point(102, 134);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(19, 21);
            this.lblSubT.TabIndex = 25;
            this.lblSubT.Text = "0";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIVA.Location = new System.Drawing.Point(52, 161);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(19, 21);
            this.lblIVA.TabIndex = 26;
            this.lblIVA.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(194, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 21);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            // 
            // EnsamListo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.pnlDatosEnsamb);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Name = "EnsamListo";
            this.Text = "EnsamListo";
            this.Load += new System.EventHandler(this.EnsamListo_Load);
            this.pnlDatosEnsamb.ResumeLayout(false);
            this.pnlDatosEnsamb.PerformLayout();
            this.panelDatosEnsamble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosEnsamb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btonCancelEnsam;
        private FontAwesome.Sharp.IconButton btnRegresarTec;
        private FontAwesome.Sharp.IconButton btnMarcarFacturado;
        private FontAwesome.Sharp.IconButton btnEnsamExcel;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubT;
        private System.Windows.Forms.Label lblEnsam;
        private System.Windows.Forms.Label lblSolicito;
        private System.Windows.Forms.Label lblNomRSoc;
        private System.Windows.Forms.Label lblNFolio;
        private System.Windows.Forms.Label lblIDE;
    }
}