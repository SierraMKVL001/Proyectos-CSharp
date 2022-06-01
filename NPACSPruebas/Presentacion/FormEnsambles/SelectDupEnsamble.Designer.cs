
namespace Presentacion.FormEnsambles
{
    partial class SelectDupEnsamble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDupEnsamble));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
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
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btnRechEnsamble = new FontAwesome.Sharp.IconButton();
            this.btnReporteExcel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            this.panelDatosEnsamble.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.btnClose);
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
            this.panel1.Size = new System.Drawing.Size(879, 114);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 28;
            this.btnClose.Location = new System.Drawing.Point(850, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(12, 30);
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
            this.btnAplyCustom.Location = new System.Drawing.Point(764, 59);
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
            this.dTimeTo.Location = new System.Drawing.Point(659, 85);
            this.dTimeTo.Name = "dTimeTo";
            this.dTimeTo.Size = new System.Drawing.Size(99, 20);
            this.dTimeTo.TabIndex = 16;
            // 
            // dTimeFrom
            // 
            this.dTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeFrom.Location = new System.Drawing.Point(659, 59);
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
            this.btnCustom.Location = new System.Drawing.Point(543, 59);
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
            this.btnAño.Location = new System.Drawing.Point(433, 59);
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
            this.btn30Dias.Location = new System.Drawing.Point(332, 59);
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
            this.btnMes.Location = new System.Drawing.Point(222, 59);
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
            this.btn7Dais.Location = new System.Drawing.Point(121, 59);
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
            this.btnToday.Location = new System.Drawing.Point(20, 59);
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
            this.txtSearch.Location = new System.Drawing.Point(87, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(780, 20);
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
            this.dGVEnsambles.Location = new System.Drawing.Point(16, 120);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowHeadersVisible = false;
            this.dGVEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnsambles.Size = new System.Drawing.Size(843, 171);
            this.dGVEnsambles.TabIndex = 13;
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
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(20, 297);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowHeadersVisible = false;
            this.dGVDetalleEnsamble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(839, 152);
            this.dGVDetalleEnsamble.TabIndex = 14;
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btnRechEnsamble);
            this.panelDatosEnsamble.Controls.Add(this.btnReporteExcel);
            this.panelDatosEnsamble.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDatosEnsamble.Location = new System.Drawing.Point(0, 455);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(879, 56);
            this.panelDatosEnsamble.TabIndex = 18;
            // 
            // btnRechEnsamble
            // 
            this.btnRechEnsamble.BackColor = System.Drawing.Color.Gray;
            this.btnRechEnsamble.FlatAppearance.BorderSize = 0;
            this.btnRechEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechEnsamble.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechEnsamble.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRechEnsamble.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnRechEnsamble.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRechEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRechEnsamble.IconSize = 30;
            this.btnRechEnsamble.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRechEnsamble.Location = new System.Drawing.Point(488, 14);
            this.btnRechEnsamble.Name = "btnRechEnsamble";
            this.btnRechEnsamble.Size = new System.Drawing.Size(136, 30);
            this.btnRechEnsamble.TabIndex = 1;
            this.btnRechEnsamble.Text = "Cancelar";
            this.btnRechEnsamble.UseVisualStyleBackColor = false;
            this.btnRechEnsamble.Click += new System.EventHandler(this.btnRechEnsamble_Click);
            // 
            // btnReporteExcel
            // 
            this.btnReporteExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReporteExcel.FlatAppearance.BorderSize = 0;
            this.btnReporteExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteExcel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReporteExcel.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnReporteExcel.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReporteExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteExcel.IconSize = 30;
            this.btnReporteExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReporteExcel.Location = new System.Drawing.Point(255, 14);
            this.btnReporteExcel.Name = "btnReporteExcel";
            this.btnReporteExcel.Size = new System.Drawing.Size(136, 30);
            this.btnReporteExcel.TabIndex = 0;
            this.btnReporteExcel.Text = "Seleccionar";
            this.btnReporteExcel.UseVisualStyleBackColor = false;
            this.btnReporteExcel.Click += new System.EventHandler(this.btnReporteExcel_Click);
            // 
            // SelectDupEnsamble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(879, 511);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectDupEnsamble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectDupEnsamble";
            this.Load += new System.EventHandler(this.SelectDupEnsamble_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
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
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btnRechEnsamble;
        private FontAwesome.Sharp.IconButton btnReporteExcel;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}