
namespace Presentacion.Reportes
{
    partial class ReportesVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesVentas));
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnAplyCustom = new FontAwesome.Sharp.IconButton();
            this.dTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.btnCustom = new FontAwesome.Sharp.IconButton();
            this.btnAño = new FontAwesome.Sharp.IconButton();
            this.btn30Dias = new FontAwesome.Sharp.IconButton();
            this.btnMes = new FontAwesome.Sharp.IconButton();
            this.btn7Dais = new FontAwesome.Sharp.IconButton();
            this.btnToday = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.pnlDatos.Controls.Add(this.btnClose);
            this.pnlDatos.Controls.Add(this.btnAplyCustom);
            this.pnlDatos.Controls.Add(this.dTimeTo);
            this.pnlDatos.Controls.Add(this.dTimeFrom);
            this.pnlDatos.Controls.Add(this.btnCustom);
            this.pnlDatos.Controls.Add(this.btnAño);
            this.pnlDatos.Controls.Add(this.btn30Dias);
            this.pnlDatos.Controls.Add(this.btnMes);
            this.pnlDatos.Controls.Add(this.btn7Dais);
            this.pnlDatos.Controls.Add(this.btnToday);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(863, 107);
            this.pnlDatos.TabIndex = 0;
            this.pnlDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDatos_MouseDown);
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
            this.btnClose.Location = new System.Drawing.Point(835, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnAplyCustom.Location = new System.Drawing.Point(745, 47);
            this.btnAplyCustom.Name = "btnAplyCustom";
            this.btnAplyCustom.Size = new System.Drawing.Size(95, 30);
            this.btnAplyCustom.TabIndex = 21;
            this.btnAplyCustom.Text = "Aplicar";
            this.btnAplyCustom.UseVisualStyleBackColor = false;
            this.btnAplyCustom.Click += new System.EventHandler(this.btnAplyCustom_Click);
            // 
            // dTimeTo
            // 
            this.dTimeTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeTo.Location = new System.Drawing.Point(640, 73);
            this.dTimeTo.Name = "dTimeTo";
            this.dTimeTo.Size = new System.Drawing.Size(99, 20);
            this.dTimeTo.TabIndex = 20;
            // 
            // dTimeFrom
            // 
            this.dTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeFrom.Location = new System.Drawing.Point(640, 47);
            this.dTimeFrom.Name = "dTimeFrom";
            this.dTimeFrom.Size = new System.Drawing.Size(99, 20);
            this.dTimeFrom.TabIndex = 19;
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
            this.btnCustom.Location = new System.Drawing.Point(524, 47);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(95, 30);
            this.btnCustom.TabIndex = 18;
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
            this.btnAño.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAño.IconColor = System.Drawing.Color.Black;
            this.btnAño.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAño.Location = new System.Drawing.Point(416, 47);
            this.btnAño.Name = "btnAño";
            this.btnAño.Size = new System.Drawing.Size(95, 30);
            this.btnAño.TabIndex = 4;
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
            this.btn30Dias.Location = new System.Drawing.Point(315, 47);
            this.btn30Dias.Name = "btn30Dias";
            this.btn30Dias.Size = new System.Drawing.Size(95, 30);
            this.btn30Dias.TabIndex = 3;
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
            this.btnMes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMes.IconColor = System.Drawing.Color.Black;
            this.btnMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMes.Location = new System.Drawing.Point(214, 47);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(95, 30);
            this.btnMes.TabIndex = 2;
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
            this.btn7Dais.Location = new System.Drawing.Point(113, 47);
            this.btn7Dais.Name = "btn7Dais";
            this.btn7Dais.Size = new System.Drawing.Size(95, 30);
            this.btn7Dais.TabIndex = 1;
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
            this.btnToday.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnToday.IconColor = System.Drawing.Color.Black;
            this.btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToday.Location = new System.Drawing.Point(12, 47);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(95, 30);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.ReporteVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(863, 365);
            this.reportViewer1.TabIndex = 1;
            // 
            // ReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportesVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesVentas";
            this.Load += new System.EventHandler(this.ReportesVentas_Load);
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private FontAwesome.Sharp.IconButton btnAño;
        private FontAwesome.Sharp.IconButton btn30Dias;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btn7Dais;
        private FontAwesome.Sharp.IconButton btnToday;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FontAwesome.Sharp.IconButton btnAplyCustom;
        private System.Windows.Forms.DateTimePicker dTimeTo;
        private System.Windows.Forms.DateTimePicker dTimeFrom;
        private FontAwesome.Sharp.IconButton btnCustom;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}