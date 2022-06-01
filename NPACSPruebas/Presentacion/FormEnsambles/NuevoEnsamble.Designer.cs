
namespace Presentacion.FormEnsambles
{
    partial class NuevoEnsamble
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDatosEnsamble = new System.Windows.Forms.Panel();
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.btnSearchClient = new FontAwesome.Sharp.IconButton();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRFCClient = new System.Windows.Forms.Label();
            this.lblDireccionClient = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNombreClient = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDatosEmpleado = new System.Windows.Forms.Panel();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblIdEmplea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPreciosEnsamble = new System.Windows.Forms.Panel();
            this.btnEndEnsamble = new FontAwesome.Sharp.IconButton();
            this.dTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dGVPzasEnsamble = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.btnNewProduct = new FontAwesome.Sharp.IconButton();
            this.btnDeleteProd = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.lblObserv = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnObservaciones = new FontAwesome.Sharp.IconButton();
            this.btnEditObservacion = new FontAwesome.Sharp.IconButton();
            this.btnDupEnsamble = new FontAwesome.Sharp.IconButton();
            this.pnlDatosEnsamble.SuspendLayout();
            this.pnlDatosCliente.SuspendLayout();
            this.pnlDatosEmpleado.SuspendLayout();
            this.pnlPreciosEnsamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPzasEnsamble)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosEnsamble
            // 
            this.pnlDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlDatosEnsamble.Controls.Add(this.pnlDatosCliente);
            this.pnlDatosEnsamble.Controls.Add(this.pnlDatosEmpleado);
            this.pnlDatosEnsamble.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosEnsamble.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosEnsamble.Name = "pnlDatosEnsamble";
            this.pnlDatosEnsamble.Size = new System.Drawing.Size(863, 126);
            this.pnlDatosEnsamble.TabIndex = 0;
            // 
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(80)))));
            this.pnlDatosCliente.Controls.Add(this.btnSearchClient);
            this.pnlDatosCliente.Controls.Add(this.lblTelefono);
            this.pnlDatosCliente.Controls.Add(this.lblRFCClient);
            this.pnlDatosCliente.Controls.Add(this.lblDireccionClient);
            this.pnlDatosCliente.Controls.Add(this.lblIdCliente);
            this.pnlDatosCliente.Controls.Add(this.label9);
            this.pnlDatosCliente.Controls.Add(this.label8);
            this.pnlDatosCliente.Controls.Add(this.label7);
            this.pnlDatosCliente.Controls.Add(this.lblNombreClient);
            this.pnlDatosCliente.Controls.Add(this.label5);
            this.pnlDatosCliente.Controls.Add(this.label4);
            this.pnlDatosCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDatosCliente.Location = new System.Drawing.Point(443, 0);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(420, 126);
            this.pnlDatosCliente.TabIndex = 1;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearchClient.FlatAppearance.BorderSize = 0;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchClient.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnSearchClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearchClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchClient.IconSize = 25;
            this.btnSearchClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchClient.Location = new System.Drawing.Point(292, 83);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(117, 32);
            this.btnSearchClient.TabIndex = 11;
            this.btnSearchClient.Text = "Buscar Cliente";
            this.btnSearchClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchClient.UseVisualStyleBackColor = false;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTelefono.Location = new System.Drawing.Point(103, 94);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(94, 17);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Desconocido";
            // 
            // lblRFCClient
            // 
            this.lblRFCClient.AutoSize = true;
            this.lblRFCClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFCClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRFCClient.Location = new System.Drawing.Point(74, 77);
            this.lblRFCClient.Name = "lblRFCClient";
            this.lblRFCClient.Size = new System.Drawing.Size(94, 17);
            this.lblRFCClient.TabIndex = 9;
            this.lblRFCClient.Text = "Desconocido";
            // 
            // lblDireccionClient
            // 
            this.lblDireccionClient.AutoSize = true;
            this.lblDireccionClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDireccionClient.Location = new System.Drawing.Point(110, 60);
            this.lblDireccionClient.Name = "lblDireccionClient";
            this.lblDireccionClient.Size = new System.Drawing.Size(94, 17);
            this.lblDireccionClient.TabIndex = 8;
            this.lblDireccionClient.Text = "Desconocido";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdCliente.Location = new System.Drawing.Point(122, 9);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(103, 17);
            this.lblIdCliente.TabIndex = 7;
            this.lblIdCliente.Text = "Sin Seleccionar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(27, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Telefono: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(27, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "RFC: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(27, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Direccion: ";
            // 
            // lblNombreClient
            // 
            this.lblNombreClient.AutoSize = true;
            this.lblNombreClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreClient.Location = new System.Drawing.Point(27, 43);
            this.lblNombreClient.Name = "lblNombreClient";
            this.lblNombreClient.Size = new System.Drawing.Size(167, 17);
            this.lblNombreClient.TabIndex = 3;
            this.lblNombreClient.Text = "Cliente no Seleccionado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(27, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre/Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "No. Cliente: ";
            // 
            // pnlDatosEmpleado
            // 
            this.pnlDatosEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(80)))));
            this.pnlDatosEmpleado.Controls.Add(this.btnDupEnsamble);
            this.pnlDatosEmpleado.Controls.Add(this.lblPuesto);
            this.pnlDatosEmpleado.Controls.Add(this.lblNombreEmpleado);
            this.pnlDatosEmpleado.Controls.Add(this.lblIdEmplea);
            this.pnlDatosEmpleado.Controls.Add(this.label3);
            this.pnlDatosEmpleado.Controls.Add(this.label2);
            this.pnlDatosEmpleado.Controls.Add(this.label1);
            this.pnlDatosEmpleado.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDatosEmpleado.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosEmpleado.Name = "pnlDatosEmpleado";
            this.pnlDatosEmpleado.Size = new System.Drawing.Size(420, 126);
            this.pnlDatosEmpleado.TabIndex = 0;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPuesto.Location = new System.Drawing.Point(91, 66);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(51, 17);
            this.lblPuesto.TabIndex = 5;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(111, 39);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(61, 17);
            this.lblNombreEmpleado.TabIndex = 4;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // lblIdEmplea
            // 
            this.lblIdEmplea.AutoSize = true;
            this.lblIdEmplea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmplea.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdEmplea.Location = new System.Drawing.Point(138, 13);
            this.lblIdEmplea.Name = "lblIdEmplea";
            this.lblIdEmplea.Size = new System.Drawing.Size(32, 17);
            this.lblIdEmplea.TabIndex = 3;
            this.lblIdEmplea.Text = "ID E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puesto:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Empleado: ";
            // 
            // pnlPreciosEnsamble
            // 
            this.pnlPreciosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlPreciosEnsamble.Controls.Add(this.btnEndEnsamble);
            this.pnlPreciosEnsamble.Controls.Add(this.dTimeFecha);
            this.pnlPreciosEnsamble.Controls.Add(this.cmbTipos);
            this.pnlPreciosEnsamble.Controls.Add(this.label13);
            this.pnlPreciosEnsamble.Controls.Add(this.lblTotal);
            this.pnlPreciosEnsamble.Controls.Add(this.label12);
            this.pnlPreciosEnsamble.Controls.Add(this.lblIVA);
            this.pnlPreciosEnsamble.Controls.Add(this.lblSubTotal);
            this.pnlPreciosEnsamble.Controls.Add(this.label11);
            this.pnlPreciosEnsamble.Controls.Add(this.label10);
            this.pnlPreciosEnsamble.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPreciosEnsamble.Location = new System.Drawing.Point(0, 383);
            this.pnlPreciosEnsamble.Name = "pnlPreciosEnsamble";
            this.pnlPreciosEnsamble.Size = new System.Drawing.Size(863, 89);
            this.pnlPreciosEnsamble.TabIndex = 1;
            // 
            // btnEndEnsamble
            // 
            this.btnEndEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndEnsamble.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEndEnsamble.FlatAppearance.BorderSize = 0;
            this.btnEndEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndEnsamble.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndEnsamble.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEndEnsamble.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnEndEnsamble.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEndEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEndEnsamble.IconSize = 30;
            this.btnEndEnsamble.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEndEnsamble.Location = new System.Drawing.Point(685, 40);
            this.btnEndEnsamble.Name = "btnEndEnsamble";
            this.btnEndEnsamble.Size = new System.Drawing.Size(166, 37);
            this.btnEndEnsamble.TabIndex = 10;
            this.btnEndEnsamble.Text = "Solicitar Ensamble";
            this.btnEndEnsamble.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndEnsamble.UseVisualStyleBackColor = false;
            this.btnEndEnsamble.Click += new System.EventHandler(this.btnEndEnsamble_Click);
            // 
            // dTimeFecha
            // 
            this.dTimeFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeFecha.Location = new System.Drawing.Point(549, 46);
            this.dTimeFecha.Name = "dTimeFecha";
            this.dTimeFecha.Size = new System.Drawing.Size(118, 20);
            this.dTimeFecha.TabIndex = 9;
            // 
            // cmbTipos
            // 
            this.cmbTipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(409, 45);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(118, 21);
            this.cmbTipos.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(438, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 30);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tipos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(245, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 39);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(237, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 30);
            this.label12.TabIndex = 5;
            this.label12.Text = "Total";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIVA.Location = new System.Drawing.Point(122, 50);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(32, 21);
            this.lblIVA.TabIndex = 4;
            this.lblIVA.Text = "0.0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubTotal.Location = new System.Drawing.Point(22, 49);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(32, 21);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(125, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(22, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "SubTotal";
            // 
            // dGVPzasEnsamble
            // 
            this.dGVPzasEnsamble.AllowUserToAddRows = false;
            this.dGVPzasEnsamble.AllowUserToDeleteRows = false;
            this.dGVPzasEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVPzasEnsamble.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPzasEnsamble.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.dGVPzasEnsamble.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPzasEnsamble.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVPzasEnsamble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPzasEnsamble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Stock});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPzasEnsamble.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVPzasEnsamble.EnableHeadersVisualStyles = false;
            this.dGVPzasEnsamble.Location = new System.Drawing.Point(22, 153);
            this.dGVPzasEnsamble.Name = "dGVPzasEnsamble";
            this.dGVPzasEnsamble.ReadOnly = true;
            this.dGVPzasEnsamble.RowHeadersVisible = false;
            this.dGVPzasEnsamble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPzasEnsamble.Size = new System.Drawing.Size(803, 181);
            this.dGVPzasEnsamble.TabIndex = 2;
            this.dGVPzasEnsamble.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPzasEnsamble_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Bruto";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(22, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Folio: ";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFolio.Location = new System.Drawing.Point(80, 129);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(74, 21);
            this.lblFolio.TabIndex = 4;
            this.lblFolio.Text = "No. Folio";
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewProduct.BackColor = System.Drawing.Color.Goldenrod;
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewProduct.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            this.btnNewProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewProduct.IconSize = 30;
            this.btnNewProduct.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewProduct.Location = new System.Drawing.Point(22, 340);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(166, 37);
            this.btnNewProduct.TabIndex = 5;
            this.btnNewProduct.Text = "Agregar Producto";
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteProd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteProd.FlatAppearance.BorderSize = 0;
            this.btnDeleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteProd.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.btnDeleteProd.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteProd.IconSize = 30;
            this.btnDeleteProd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteProd.Location = new System.Drawing.Point(194, 340);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(166, 37);
            this.btnDeleteProd.TabIndex = 6;
            this.btnDeleteProd.Text = "Eliminar Producto";
            this.btnDeleteProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProd.UseVisualStyleBackColor = false;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnClear.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 30;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.Location = new System.Drawing.Point(366, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpiar Ensamble";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblObserv
            // 
            this.lblObserv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObserv.AutoSize = true;
            this.lblObserv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObserv.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblObserv.Location = new System.Drawing.Point(685, 129);
            this.lblObserv.Name = "lblObserv";
            this.lblObserv.Size = new System.Drawing.Size(140, 21);
            this.lblObserv.TabIndex = 9;
            this.lblObserv.Text = "No. Observacion";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(566, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 21);
            this.label15.TabIndex = 8;
            this.label15.Text = "Observacion: ";
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObservaciones.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnObservaciones.FlatAppearance.BorderSize = 0;
            this.btnObservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObservaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnObservaciones.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnObservaciones.IconColor = System.Drawing.Color.Gainsboro;
            this.btnObservaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnObservaciones.IconSize = 30;
            this.btnObservaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnObservaciones.Location = new System.Drawing.Point(640, 340);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(185, 37);
            this.btnObservaciones.TabIndex = 10;
            this.btnObservaciones.Text = "Agregar Observacion";
            this.btnObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObservaciones.UseVisualStyleBackColor = false;
            this.btnObservaciones.Click += new System.EventHandler(this.btnObservaciones_Click);
            // 
            // btnEditObservacion
            // 
            this.btnEditObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditObservacion.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnEditObservacion.FlatAppearance.BorderSize = 0;
            this.btnEditObservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditObservacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditObservacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditObservacion.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditObservacion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEditObservacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditObservacion.IconSize = 30;
            this.btnEditObservacion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditObservacion.Location = new System.Drawing.Point(640, 340);
            this.btnEditObservacion.Name = "btnEditObservacion";
            this.btnEditObservacion.Size = new System.Drawing.Size(185, 37);
            this.btnEditObservacion.TabIndex = 11;
            this.btnEditObservacion.Text = "Editar Observacion";
            this.btnEditObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditObservacion.UseVisualStyleBackColor = false;
            this.btnEditObservacion.Visible = false;
            this.btnEditObservacion.Click += new System.EventHandler(this.btnEditObservacion_Click);
            // 
            // btnDupEnsamble
            // 
            this.btnDupEnsamble.BackColor = System.Drawing.Color.Chocolate;
            this.btnDupEnsamble.FlatAppearance.BorderSize = 0;
            this.btnDupEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDupEnsamble.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDupEnsamble.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDupEnsamble.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnDupEnsamble.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDupEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDupEnsamble.IconSize = 25;
            this.btnDupEnsamble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDupEnsamble.Location = new System.Drawing.Point(269, 83);
            this.btnDupEnsamble.Name = "btnDupEnsamble";
            this.btnDupEnsamble.Size = new System.Drawing.Size(138, 32);
            this.btnDupEnsamble.TabIndex = 13;
            this.btnDupEnsamble.Text = "Duplicar Ensamble";
            this.btnDupEnsamble.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDupEnsamble.UseVisualStyleBackColor = false;
            this.btnDupEnsamble.Click += new System.EventHandler(this.btnDupEnsamble_Click);
            // 
            // NuevoEnsamble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.btnEditObservacion);
            this.Controls.Add(this.btnObservaciones);
            this.Controls.Add(this.lblObserv);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGVPzasEnsamble);
            this.Controls.Add(this.pnlPreciosEnsamble);
            this.Controls.Add(this.pnlDatosEnsamble);
            this.Name = "NuevoEnsamble";
            this.Text = "NuevoEnsamble";
            this.Load += new System.EventHandler(this.NuevoEnsamble_Load);
            this.pnlDatosEnsamble.ResumeLayout(false);
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            this.pnlDatosEmpleado.ResumeLayout(false);
            this.pnlDatosEmpleado.PerformLayout();
            this.pnlPreciosEnsamble.ResumeLayout(false);
            this.pnlPreciosEnsamble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPzasEnsamble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosEnsamble;
        private System.Windows.Forms.Panel pnlDatosCliente;
        private FontAwesome.Sharp.IconButton btnSearchClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDatosEmpleado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblIdEmplea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPreciosEnsamble;
        private FontAwesome.Sharp.IconButton btnEndEnsamble;
        private System.Windows.Forms.DateTimePicker dTimeFecha;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dGVPzasEnsamble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFolio;
        private FontAwesome.Sharp.IconButton btnNewProduct;
        private FontAwesome.Sharp.IconButton btnDeleteProd;
        private FontAwesome.Sharp.IconButton btnClear;
        public System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.Label lblRFCClient;
        public System.Windows.Forms.Label lblDireccionClient;
        public System.Windows.Forms.Label lblIdCliente;
        public System.Windows.Forms.Label lblNombreClient;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblObserv;
        private FontAwesome.Sharp.IconButton btnObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private FontAwesome.Sharp.IconButton btnEditObservacion;
        private FontAwesome.Sharp.IconButton btnDupEnsamble;
    }
}