
namespace Presentacion.FormCompartidos
{
    partial class AllEnamAlmVent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAplyCustom = new FontAwesome.Sharp.IconButton();
            this.dTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.btnCustom = new FontAwesome.Sharp.IconButton();
            this.btnAño = new FontAwesome.Sharp.IconButton();
            this.btn30Dias = new FontAwesome.Sharp.IconButton();
            this.btnMes = new FontAwesome.Sharp.IconButton();
            this.btn7Dais = new FontAwesome.Sharp.IconButton();
            this.btnToday = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            this.btnAgrObser = new FontAwesome.Sharp.IconButton();
            this.btnEditObserv = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumObser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDEns = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btnReporteExcel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDatosEnsamble.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAplyCustom);
            this.panel1.Controls.Add(this.dTimeTo);
            this.panel1.Controls.Add(this.dTimeFrom);
            this.panel1.Controls.Add(this.btnCustom);
            this.panel1.Controls.Add(this.btnAño);
            this.panel1.Controls.Add(this.btn30Dias);
            this.panel1.Controls.Add(this.btnMes);
            this.panel1.Controls.Add(this.btn7Dais);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 101);
            this.panel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buscar: ";
            // 
            // btnAplyCustom
            // 
            this.btnAplyCustom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAplyCustom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAplyCustom.FlatAppearance.BorderSize = 0;
            this.btnAplyCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplyCustom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAplyCustom.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnAplyCustom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAplyCustom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAplyCustom.IconSize = 25;
            this.btnAplyCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplyCustom.Location = new System.Drawing.Point(756, 38);
            this.btnAplyCustom.Name = "btnAplyCustom";
            this.btnAplyCustom.Size = new System.Drawing.Size(95, 30);
            this.btnAplyCustom.TabIndex = 17;
            this.btnAplyCustom.Text = "Aplicar";
            this.btnAplyCustom.UseVisualStyleBackColor = false;
            this.btnAplyCustom.Click += new System.EventHandler(this.btnAplyCustom_Click);
            // 
            // dTimeTo
            // 
            this.dTimeTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeTo.Location = new System.Drawing.Point(651, 64);
            this.dTimeTo.Name = "dTimeTo";
            this.dTimeTo.Size = new System.Drawing.Size(99, 20);
            this.dTimeTo.TabIndex = 16;
            // 
            // dTimeFrom
            // 
            this.dTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeFrom.Location = new System.Drawing.Point(651, 38);
            this.dTimeFrom.Name = "dTimeFrom";
            this.dTimeFrom.Size = new System.Drawing.Size(99, 20);
            this.dTimeFrom.TabIndex = 15;
            // 
            // btnCustom
            // 
            this.btnCustom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustom.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCustom.FlatAppearance.BorderSize = 0;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCustom.IconColor = System.Drawing.Color.Black;
            this.btnCustom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustom.Location = new System.Drawing.Point(535, 38);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(95, 30);
            this.btnCustom.TabIndex = 14;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnAño
            // 
            this.btnAño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAño.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAño.FlatAppearance.BorderSize = 0;
            this.btnAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAño.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAño.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btnAño.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAño.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAño.IconSize = 25;
            this.btnAño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAño.Location = new System.Drawing.Point(425, 38);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(104, 30);
            this.btnAño.TabIndex = 13;
            this.btnAño.Text = "Este Año";
            this.btnAño.UseVisualStyleBackColor = false;
            this.btnAño.Click += new System.EventHandler(this.btnAño_Click);
            // 
            // btn30Dias
            // 
            this.btn30Dias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn30Dias.BackColor = System.Drawing.Color.Chocolate;
            this.btn30Dias.FlatAppearance.BorderSize = 0;
            this.btn30Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30Dias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn30Dias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn30Dias.IconColor = System.Drawing.Color.Black;
            this.btn30Dias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn30Dias.Location = new System.Drawing.Point(324, 38);
            this.btn30Dias.Name = "btn30Dias";
            this.btn30Dias.Size = new System.Drawing.Size(95, 30);
            this.btn30Dias.TabIndex = 12;
            this.btn30Dias.Text = "Ultimos 30 Dias";
            this.btn30Dias.UseVisualStyleBackColor = false;
            this.btn30Dias.Click += new System.EventHandler(this.btn30Dias_Click);
            // 
            // btnMes
            // 
            this.btnMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMes.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMes.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnMes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMes.IconSize = 25;
            this.btnMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMes.Location = new System.Drawing.Point(214, 38);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(104, 30);
            this.btnMes.TabIndex = 11;
            this.btnMes.Text = "Este Mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btn7Dais
            // 
            this.btn7Dais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn7Dais.BackColor = System.Drawing.Color.Brown;
            this.btn7Dais.FlatAppearance.BorderSize = 0;
            this.btn7Dais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7Dais.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn7Dais.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn7Dais.IconColor = System.Drawing.Color.Black;
            this.btn7Dais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn7Dais.Location = new System.Drawing.Point(113, 38);
            this.btn7Dais.Name = "btn7Dais";
            this.btn7Dais.Size = new System.Drawing.Size(95, 30);
            this.btn7Dais.TabIndex = 10;
            this.btn7Dais.Text = "Ultimos 7 Dias";
            this.btn7Dais.UseVisualStyleBackColor = false;
            this.btn7Dais.Click += new System.EventHandler(this.btn7Dais_Click);
            // 
            // btnToday
            // 
            this.btnToday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToday.BackColor = System.Drawing.Color.DimGray;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToday.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnToday.IconColor = System.Drawing.Color.Gainsboro;
            this.btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToday.IconSize = 25;
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(12, 38);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(95, 30);
            this.btnToday.TabIndex = 9;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(87, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(764, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dGVEnsambles.Location = new System.Drawing.Point(12, 107);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowHeadersVisible = false;
            this.dGVEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnsambles.Size = new System.Drawing.Size(596, 207);
            this.dGVEnsambles.TabIndex = 12;
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
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(257, 323);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowHeadersVisible = false;
            this.dGVDetalleEnsamble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(599, 137);
            this.dGVDetalleEnsamble.TabIndex = 13;
            // 
            // btnAgrObser
            // 
            this.btnAgrObser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgrObser.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAgrObser.FlatAppearance.BorderSize = 0;
            this.btnAgrObser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrObser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrObser.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAgrObser.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnAgrObser.IconColor = System.Drawing.Color.DarkMagenta;
            this.btnAgrObser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgrObser.IconSize = 30;
            this.btnAgrObser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgrObser.Location = new System.Drawing.Point(645, 287);
            this.btnAgrObser.Name = "btnAgrObser";
            this.btnAgrObser.Size = new System.Drawing.Size(201, 30);
            this.btnAgrObser.TabIndex = 16;
            this.btnAgrObser.Text = "Agregar Observacion";
            this.btnAgrObser.UseVisualStyleBackColor = false;
            this.btnAgrObser.Click += new System.EventHandler(this.btnAgrObser_Click);
            // 
            // btnEditObserv
            // 
            this.btnEditObserv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditObserv.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEditObserv.FlatAppearance.BorderSize = 0;
            this.btnEditObserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditObserv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditObserv.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnEditObserv.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditObserv.IconColor = System.Drawing.Color.DarkMagenta;
            this.btnEditObserv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditObserv.IconSize = 30;
            this.btnEditObserv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditObserv.Location = new System.Drawing.Point(645, 287);
            this.btnEditObserv.Name = "btnEditObserv";
            this.btnEditObserv.Size = new System.Drawing.Size(201, 30);
            this.btnEditObserv.TabIndex = 15;
            this.btnEditObserv.Text = "Editar Observacion";
            this.btnEditObserv.UseVisualStyleBackColor = false;
            this.btnEditObserv.Click += new System.EventHandler(this.btnEditObserv_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.lblNumObser);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblIDEns);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtObservacion);
            this.panel2.Location = new System.Drawing.Point(616, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 174);
            this.panel2.TabIndex = 14;
            // 
            // lblNumObser
            // 
            this.lblNumObser.AutoSize = true;
            this.lblNumObser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumObser.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNumObser.Location = new System.Drawing.Point(187, 149);
            this.lblNumObser.Name = "lblNumObser";
            this.lblNumObser.Size = new System.Drawing.Size(15, 17);
            this.lblNumObser.TabIndex = 6;
            this.lblNumObser.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(105, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "No. Obser. ";
            // 
            // lblIDEns
            // 
            this.lblIDEns.AutoSize = true;
            this.lblIDEns.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEns.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIDEns.Location = new System.Drawing.Point(42, 149);
            this.lblIDEns.Name = "lblIDEns";
            this.lblIDEns.Size = new System.Drawing.Size(15, 17);
            this.lblIDEns.TabIndex = 4;
            this.lblIDEns.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(9, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(69, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Observaciones";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacion.Location = new System.Drawing.Point(12, 28);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(218, 114);
            this.txtObservacion.TabIndex = 1;
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btnReporteExcel);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(9, 323);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(240, 71);
            this.panelDatosEnsamble.TabIndex = 17;
            // 
            // btnReporteExcel
            // 
            this.btnReporteExcel.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReporteExcel.FlatAppearance.BorderSize = 0;
            this.btnReporteExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteExcel.ForeColor = System.Drawing.Color.Green;
            this.btnReporteExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnReporteExcel.IconColor = System.Drawing.Color.Green;
            this.btnReporteExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteExcel.IconSize = 30;
            this.btnReporteExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteExcel.Location = new System.Drawing.Point(19, 18);
            this.btnReporteExcel.Name = "btnReporteExcel";
            this.btnReporteExcel.Size = new System.Drawing.Size(201, 33);
            this.btnReporteExcel.TabIndex = 0;
            this.btnReporteExcel.Text = "Exportar a Excel";
            this.btnReporteExcel.UseVisualStyleBackColor = false;
            this.btnReporteExcel.Click += new System.EventHandler(this.btnReporteExcel_Click);
            // 
            // AllEnamAlmVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.btnAgrObser);
            this.Controls.Add(this.btnEditObserv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Controls.Add(this.panel1);
            this.Name = "AllEnamAlmVent";
            this.Text = "AllEnamAlmVent";
            this.Load += new System.EventHandler(this.AllEnamAlmVent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDatosEnsamble.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAplyCustom;
        private System.Windows.Forms.DateTimePicker dTimeTo;
        private System.Windows.Forms.DateTimePicker dTimeFrom;
        private FontAwesome.Sharp.IconButton btnCustom;
        private FontAwesome.Sharp.IconButton btnAño;
        private FontAwesome.Sharp.IconButton btn30Dias;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btn7Dais;
        private FontAwesome.Sharp.IconButton btnToday;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
        private FontAwesome.Sharp.IconButton btnAgrObser;
        private FontAwesome.Sharp.IconButton btnEditObserv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumObser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDEns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btnReporteExcel;
    }
}