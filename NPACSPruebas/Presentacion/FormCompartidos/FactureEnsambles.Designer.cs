
namespace Presentacion.FormCompartidos
{
    partial class FactureEnsambles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.dGVDetalleEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
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
            this.panel1.TabIndex = 11;
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
            this.btnCustom.Location = new System.Drawing.Point(537, 38);
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
            this.btnAño.Size = new System.Drawing.Size(106, 30);
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
            this.btn7Dais.IconColor = System.Drawing.Color.Gainsboro;
            this.btn7Dais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn7Dais.IconSize = 25;
            this.btn7Dais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDetalleEnsambles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVDetalleEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDetalleEnsambles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGVDetalleEnsambles.EnableHeadersVisualStyles = false;
            this.dGVDetalleEnsambles.Location = new System.Drawing.Point(12, 308);
            this.dGVDetalleEnsambles.Name = "dGVDetalleEnsambles";
            this.dGVDetalleEnsambles.ReadOnly = true;
            this.dGVDetalleEnsambles.RowHeadersVisible = false;
            this.dGVDetalleEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetalleEnsambles.Size = new System.Drawing.Size(839, 156);
            this.dGVDetalleEnsambles.TabIndex = 10;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVEnsambles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGVEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVEnsambles.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGVEnsambles.EnableHeadersVisualStyles = false;
            this.dGVEnsambles.Location = new System.Drawing.Point(12, 115);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowHeadersVisible = false;
            this.dGVEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnsambles.Size = new System.Drawing.Size(839, 173);
            this.dGVEnsambles.TabIndex = 9;
            this.dGVEnsambles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEnsambles_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Buscar: ";
            // 
            // FactureEnsambles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGVDetalleEnsambles);
            this.Controls.Add(this.dGVEnsambles);
            this.Name = "FactureEnsambles";
            this.Text = "FactureEnsambles";
            this.Load += new System.EventHandler(this.FactureEnsambles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridView dGVDetalleEnsambles;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.Label label1;
    }
}