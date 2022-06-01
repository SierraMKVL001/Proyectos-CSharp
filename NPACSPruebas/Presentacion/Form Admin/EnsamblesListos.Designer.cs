
namespace Presentacion.Form_Admin
{
    partial class EnsamblesListos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btonCancelEnsam = new FontAwesome.Sharp.IconButton();
            this.btnRegresarTec = new FontAwesome.Sharp.IconButton();
            this.btnMarcarFacturado = new FontAwesome.Sharp.IconButton();
            this.btnEnsamExcel = new FontAwesome.Sharp.IconButton();
            this.pnlDatosEnsamb = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnsamblo = new System.Windows.Forms.TextBox();
            this.txtSolicito = new System.Windows.Forms.TextBox();
            this.txtNombreRS = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            this.panelDatosEnsamble.SuspendLayout();
            this.pnlDatosEnsamb.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVEnsambles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVEnsambles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVEnsambles.EnableHeadersVisualStyles = false;
            this.dGVEnsambles.Location = new System.Drawing.Point(6, 36);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowHeadersVisible = false;
            this.dGVEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnsambles.Size = new System.Drawing.Size(555, 190);
            this.dGVEnsambles.TabIndex = 0;
            this.dGVEnsambles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEnsambles_CellClick);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDetalleEnsamble.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVDetalleEnsamble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDetalleEnsamble.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVDetalleEnsamble.EnableHeadersVisualStyles = false;
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(252, 249);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowHeadersVisible = false;
            this.dGVDetalleEnsamble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(599, 200);
            this.dGVDetalleEnsamble.TabIndex = 1;
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
            this.panelDatosEnsamble.TabIndex = 2;
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
            // pnlDatosEnsamb
            // 
            this.pnlDatosEnsamb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosEnsamb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlDatosEnsamb.Controls.Add(this.txtTotal);
            this.pnlDatosEnsamb.Controls.Add(this.label8);
            this.pnlDatosEnsamb.Controls.Add(this.txtIVA);
            this.pnlDatosEnsamb.Controls.Add(this.txtSubtotal);
            this.pnlDatosEnsamb.Controls.Add(this.label7);
            this.pnlDatosEnsamb.Controls.Add(this.txtID);
            this.pnlDatosEnsamb.Controls.Add(this.label6);
            this.pnlDatosEnsamb.Controls.Add(this.txtEnsamblo);
            this.pnlDatosEnsamb.Controls.Add(this.txtSolicito);
            this.pnlDatosEnsamb.Controls.Add(this.txtNombreRS);
            this.pnlDatosEnsamb.Controls.Add(this.txtFolio);
            this.pnlDatosEnsamb.Controls.Add(this.label5);
            this.pnlDatosEnsamb.Controls.Add(this.label4);
            this.pnlDatosEnsamb.Controls.Add(this.label3);
            this.pnlDatosEnsamb.Controls.Add(this.label2);
            this.pnlDatosEnsamb.Controls.Add(this.label1);
            this.pnlDatosEnsamb.Location = new System.Drawing.Point(567, 36);
            this.pnlDatosEnsamb.Name = "pnlDatosEnsamb";
            this.pnlDatosEnsamb.Size = new System.Drawing.Size(284, 190);
            this.pnlDatosEnsamb.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(194, 161);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 20;
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
            // txtIVA
            // 
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(52, 161);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(78, 20);
            this.txtIVA.TabIndex = 18;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(102, 134);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(89, 20);
            this.txtSubtotal.TabIndex = 17;
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
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(52, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(39, 20);
            this.txtID.TabIndex = 15;
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
            // txtEnsamblo
            // 
            this.txtEnsamblo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnsamblo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnsamblo.Location = new System.Drawing.Point(110, 108);
            this.txtEnsamblo.Name = "txtEnsamblo";
            this.txtEnsamblo.Size = new System.Drawing.Size(116, 20);
            this.txtEnsamblo.TabIndex = 13;
            // 
            // txtSolicito
            // 
            this.txtSolicito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolicito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicito.Location = new System.Drawing.Point(89, 82);
            this.txtSolicito.Name = "txtSolicito";
            this.txtSolicito.Size = new System.Drawing.Size(190, 20);
            this.txtSolicito.TabIndex = 12;
            // 
            // txtNombreRS
            // 
            this.txtNombreRS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreRS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRS.Location = new System.Drawing.Point(19, 56);
            this.txtNombreRS.Name = "txtNombreRS";
            this.txtNombreRS.Size = new System.Drawing.Size(248, 20);
            this.txtNombreRS.TabIndex = 11;
            // 
            // txtFolio
            // 
            this.txtFolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(148, 11);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(78, 20);
            this.txtFolio.TabIndex = 10;
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
            this.label1.Location = new System.Drawing.Point(90, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio: ";
            // 
            // EnsamblesListos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.pnlDatosEnsamb);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Name = "EnsamblesListos";
            this.Text = "EnsamblesListos";
            this.Load += new System.EventHandler(this.EnsamblesListos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            this.panelDatosEnsamble.ResumeLayout(false);
            this.pnlDatosEnsamb.ResumeLayout(false);
            this.pnlDatosEnsamb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btonCancelEnsam;
        private FontAwesome.Sharp.IconButton btnRegresarTec;
        private FontAwesome.Sharp.IconButton btnMarcarFacturado;
        private FontAwesome.Sharp.IconButton btnEnsamExcel;
        private System.Windows.Forms.Panel pnlDatosEnsamb;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnsamblo;
        private System.Windows.Forms.TextBox txtSolicito;
        private System.Windows.Forms.TextBox txtNombreRS;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}