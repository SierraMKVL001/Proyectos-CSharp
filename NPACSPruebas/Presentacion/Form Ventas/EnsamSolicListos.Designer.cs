
namespace Presentacion.Form_Ventas
{
    partial class EnsamSolicListos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dGVDetalleEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.pnlDatosEnsamb = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubT = new System.Windows.Forms.Label();
            this.lblEnsam = new System.Windows.Forms.Label();
            this.lblSolicito = new System.Windows.Forms.Label();
            this.lblNomRSoc = new System.Windows.Forms.Label();
            this.lblNFolio = new System.Windows.Forms.Label();
            this.lblIDE = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btnMarcarFacturado = new FontAwesome.Sharp.IconButton();
            this.btnEnsamExcel = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            this.pnlDatosEnsamb.SuspendLayout();
            this.panelDatosEnsamble.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(101, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(750, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dGVDetalleEnsambles
            // 
            this.dGVDetalleEnsambles.AllowUserToAddRows = false;
            this.dGVDetalleEnsambles.AllowUserToDeleteRows = false;
            this.dGVDetalleEnsambles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVDetalleEnsambles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDetalleEnsambles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.dGVDetalleEnsambles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVDetalleEnsambles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDetalleEnsambles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dGVDetalleEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDetalleEnsambles.DefaultCellStyle = dataGridViewCellStyle18;
            this.dGVDetalleEnsambles.EnableHeadersVisualStyles = false;
            this.dGVDetalleEnsambles.Location = new System.Drawing.Point(254, 266);
            this.dGVDetalleEnsambles.Name = "dGVDetalleEnsambles";
            this.dGVDetalleEnsambles.ReadOnly = true;
            this.dGVDetalleEnsambles.RowHeadersVisible = false;
            this.dGVDetalleEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetalleEnsambles.Size = new System.Drawing.Size(597, 188);
            this.dGVDetalleEnsambles.TabIndex = 5;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVEnsambles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dGVEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVEnsambles.DefaultCellStyle = dataGridViewCellStyle20;
            this.dGVEnsambles.EnableHeadersVisualStyles = false;
            this.dGVEnsambles.Location = new System.Drawing.Point(12, 51);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowHeadersVisible = false;
            this.dGVEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnsambles.Size = new System.Drawing.Size(539, 209);
            this.dGVEnsambles.TabIndex = 4;
            this.dGVEnsambles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEnsambles_CellClick);
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
            this.pnlDatosEnsamb.Location = new System.Drawing.Point(567, 51);
            this.pnlDatosEnsamb.Name = "pnlDatosEnsamb";
            this.pnlDatosEnsamb.Size = new System.Drawing.Size(284, 190);
            this.pnlDatosEnsamb.TabIndex = 13;
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
            this.panelDatosEnsamble.Controls.Add(this.btnMarcarFacturado);
            this.panelDatosEnsamble.Controls.Add(this.btnEnsamExcel);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(12, 266);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(236, 116);
            this.panelDatosEnsamble.TabIndex = 14;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(26, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Buscar: ";
            // 
            // EnsamSolicListos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.pnlDatosEnsamb);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dGVDetalleEnsambles);
            this.Controls.Add(this.dGVEnsambles);
            this.Name = "EnsamSolicListos";
            this.Text = "EnsamSolicListos";
            this.Load += new System.EventHandler(this.EnsamSolicListos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            this.pnlDatosEnsamb.ResumeLayout(false);
            this.pnlDatosEnsamb.PerformLayout();
            this.panelDatosEnsamble.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dGVDetalleEnsambles;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.Panel pnlDatosEnsamb;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubT;
        private System.Windows.Forms.Label lblEnsam;
        private System.Windows.Forms.Label lblSolicito;
        private System.Windows.Forms.Label lblNomRSoc;
        private System.Windows.Forms.Label lblNFolio;
        private System.Windows.Forms.Label lblIDE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btnMarcarFacturado;
        private FontAwesome.Sharp.IconButton btnEnsamExcel;
        private System.Windows.Forms.Label label9;
    }
}