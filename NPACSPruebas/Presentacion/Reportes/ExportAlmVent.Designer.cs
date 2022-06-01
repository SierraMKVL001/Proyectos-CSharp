
namespace Presentacion.Reportes
{
    partial class ExportAlmVent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportAlmVent));
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnGen = new FontAwesome.Sharp.IconButton();
            this.btnSelect = new FontAwesome.Sharp.IconButton();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.pnlDatosEnsamb = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEnsamblo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSolicito = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVPzasFacturar = new System.Windows.Forms.DataGridView();
            this.pnlDatosEnsamb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPzasFacturar)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(770, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGen.FlatAppearance.BorderSize = 0;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGen.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnGen.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGen.IconSize = 25;
            this.btnGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGen.Location = new System.Drawing.Point(177, 55);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(137, 27);
            this.btnGen.TabIndex = 13;
            this.btnGen.Text = "Generar";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSelect.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnSelect.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSelect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelect.IconSize = 25;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(20, 55);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(137, 27);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(20, 22);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(561, 20);
            this.txtRuta.TabIndex = 11;
            // 
            // pnlDatosEnsamb
            // 
            this.pnlDatosEnsamb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosEnsamb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlDatosEnsamb.Controls.Add(this.lblId);
            this.pnlDatosEnsamb.Controls.Add(this.label11);
            this.pnlDatosEnsamb.Controls.Add(this.lblIVA);
            this.pnlDatosEnsamb.Controls.Add(this.label9);
            this.pnlDatosEnsamb.Controls.Add(this.lblSubTotal);
            this.pnlDatosEnsamb.Controls.Add(this.label7);
            this.pnlDatosEnsamb.Controls.Add(this.lblTotal);
            this.pnlDatosEnsamb.Controls.Add(this.lblFolio);
            this.pnlDatosEnsamb.Controls.Add(this.label5);
            this.pnlDatosEnsamb.Controls.Add(this.lblEnsamblo);
            this.pnlDatosEnsamb.Controls.Add(this.label4);
            this.pnlDatosEnsamb.Controls.Add(this.lblSolicito);
            this.pnlDatosEnsamb.Controls.Add(this.label3);
            this.pnlDatosEnsamb.Controls.Add(this.lblNombre);
            this.pnlDatosEnsamb.Controls.Add(this.label2);
            this.pnlDatosEnsamb.Controls.Add(this.label1);
            this.pnlDatosEnsamb.Location = new System.Drawing.Point(11, 98);
            this.pnlDatosEnsamb.Name = "pnlDatosEnsamb";
            this.pnlDatosEnsamb.Size = new System.Drawing.Size(261, 237);
            this.pnlDatosEnsamb.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblId.Location = new System.Drawing.Point(36, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(48, 21);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Desc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(6, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "ID:";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIVA.Location = new System.Drawing.Point(99, 185);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(112, 21);
            this.lblIVA.TabIndex = 13;
            this.lblIVA.Text = "Desconocido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(50, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "IVA:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubTotal.Location = new System.Drawing.Point(123, 164);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(112, 21);
            this.lblSubTotal.TabIndex = 11;
            this.lblSubTotal.Text = "Desconocido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(36, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(113, 206);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 21);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Desconocido";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFolio.Location = new System.Drawing.Point(166, 14);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(48, 21);
            this.lblFolio.TabIndex = 8;
            this.lblFolio.Text = "Desc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(58, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total: ";
            // 
            // lblEnsamblo
            // 
            this.lblEnsamblo.AutoSize = true;
            this.lblEnsamblo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnsamblo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnsamblo.Location = new System.Drawing.Point(39, 143);
            this.lblEnsamblo.Name = "lblEnsamblo";
            this.lblEnsamblo.Size = new System.Drawing.Size(112, 21);
            this.lblEnsamblo.TabIndex = 6;
            this.lblEnsamblo.Text = "Desconocido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(85, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ensamblo";
            // 
            // lblSolicito
            // 
            this.lblSolicito.AutoSize = true;
            this.lblSolicito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicito.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSolicito.Location = new System.Drawing.Point(36, 101);
            this.lblSolicito.Name = "lblSolicito";
            this.lblSolicito.Size = new System.Drawing.Size(112, 21);
            this.lblSolicito.TabIndex = 4;
            this.lblSolicito.Text = "Desconocido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(96, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Solicito";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(25, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Desconocido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(43, 38);
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
            this.label1.Location = new System.Drawing.Point(122, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio";
            // 
            // dGVPzasFacturar
            // 
            this.dGVPzasFacturar.AllowUserToAddRows = false;
            this.dGVPzasFacturar.AllowUserToDeleteRows = false;
            this.dGVPzasFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVPzasFacturar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPzasFacturar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.dGVPzasFacturar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPzasFacturar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVPzasFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPzasFacturar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVPzasFacturar.EnableHeadersVisualStyles = false;
            this.dGVPzasFacturar.Location = new System.Drawing.Point(278, 98);
            this.dGVPzasFacturar.Name = "dGVPzasFacturar";
            this.dGVPzasFacturar.ReadOnly = true;
            this.dGVPzasFacturar.RowHeadersVisible = false;
            this.dGVPzasFacturar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPzasFacturar.Size = new System.Drawing.Size(496, 237);
            this.dGVPzasFacturar.TabIndex = 9;
            // 
            // ExportAlmVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.pnlDatosEnsamb);
            this.Controls.Add(this.dGVPzasFacturar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportAlmVent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportAlmVent";
            this.Load += new System.EventHandler(this.ExportAlmVent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExportAlmVent_MouseDown);
            this.pnlDatosEnsamb.ResumeLayout(false);
            this.pnlDatosEnsamb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPzasFacturar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnGen;
        private FontAwesome.Sharp.IconButton btnSelect;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Panel pnlDatosEnsamb;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblEnsamblo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblSolicito;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVPzasFacturar;
    }
}