
namespace Presentation.FormAdmin
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
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btnRegresarTec = new FontAwesome.Sharp.IconButton();
            this.btnRechEnsamble = new FontAwesome.Sharp.IconButton();
            this.btnEnsamListo = new FontAwesome.Sharp.IconButton();
            this.btonCancelEnsam = new FontAwesome.Sharp.IconButton();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            this.pnlDatosEnsamb = new System.Windows.Forms.Panel();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEnsamblo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSolicito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatosEnsamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            this.pnlDatosEnsamb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btnRegresarTec);
            this.panelDatosEnsamble.Controls.Add(this.btnRechEnsamble);
            this.panelDatosEnsamble.Controls.Add(this.btnEnsamListo);
            this.panelDatosEnsamble.Controls.Add(this.btonCancelEnsam);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(6, 249);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(236, 200);
            this.panelDatosEnsamble.TabIndex = 27;
            // 
            // btnRegresarTec
            // 
            this.btnRegresarTec.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRegresarTec.FlatAppearance.BorderSize = 0;
            this.btnRegresarTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarTec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRegresarTec.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            this.btnRegresarTec.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnRegresarTec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresarTec.IconSize = 30;
            this.btnRegresarTec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarTec.Location = new System.Drawing.Point(17, 90);
            this.btnRegresarTec.Name = "btnRegresarTec";
            this.btnRegresarTec.Size = new System.Drawing.Size(201, 28);
            this.btnRegresarTec.TabIndex = 3;
            this.btnRegresarTec.Text = "Regresar Ensamble";
            this.btnRegresarTec.UseVisualStyleBackColor = false;
            this.btnRegresarTec.Click += new System.EventHandler(this.btnRegresarTec_Click);
            // 
            // btnRechEnsamble
            // 
            this.btnRechEnsamble.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRechEnsamble.FlatAppearance.BorderSize = 0;
            this.btnRechEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechEnsamble.ForeColor = System.Drawing.Color.DimGray;
            this.btnRechEnsamble.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnRechEnsamble.IconColor = System.Drawing.Color.DimGray;
            this.btnRechEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRechEnsamble.IconSize = 30;
            this.btnRechEnsamble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechEnsamble.Location = new System.Drawing.Point(18, 55);
            this.btnRechEnsamble.Name = "btnRechEnsamble";
            this.btnRechEnsamble.Size = new System.Drawing.Size(201, 29);
            this.btnRechEnsamble.TabIndex = 2;
            this.btnRechEnsamble.Text = "Ensamble Facturado";
            this.btnRechEnsamble.UseVisualStyleBackColor = false;
            this.btnRechEnsamble.Click += new System.EventHandler(this.btnRechEnsamble_Click);
            // 
            // btnEnsamListo
            // 
            this.btnEnsamListo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnsamListo.FlatAppearance.BorderSize = 0;
            this.btnEnsamListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsamListo.ForeColor = System.Drawing.Color.Green;
            this.btnEnsamListo.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnEnsamListo.IconColor = System.Drawing.Color.Green;
            this.btnEnsamListo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsamListo.IconSize = 30;
            this.btnEnsamListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsamListo.Location = new System.Drawing.Point(17, 20);
            this.btnEnsamListo.Name = "btnEnsamListo";
            this.btnEnsamListo.Size = new System.Drawing.Size(201, 29);
            this.btnEnsamListo.TabIndex = 1;
            this.btnEnsamListo.Text = "Excel";
            this.btnEnsamListo.UseVisualStyleBackColor = false;
            this.btnEnsamListo.Click += new System.EventHandler(this.btnEnsamListo_Click);
            // 
            // btonCancelEnsam
            // 
            this.btonCancelEnsam.BackColor = System.Drawing.Color.AliceBlue;
            this.btonCancelEnsam.FlatAppearance.BorderSize = 0;
            this.btonCancelEnsam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonCancelEnsam.ForeColor = System.Drawing.Color.DarkRed;
            this.btonCancelEnsam.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.btonCancelEnsam.IconColor = System.Drawing.Color.DarkRed;
            this.btonCancelEnsam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btonCancelEnsam.IconSize = 30;
            this.btonCancelEnsam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btonCancelEnsam.Location = new System.Drawing.Point(17, 124);
            this.btonCancelEnsam.Name = "btonCancelEnsam";
            this.btonCancelEnsam.Size = new System.Drawing.Size(201, 28);
            this.btonCancelEnsam.TabIndex = 0;
            this.btonCancelEnsam.Text = "Cancelar";
            this.btonCancelEnsam.UseVisualStyleBackColor = false;
            this.btonCancelEnsam.Click += new System.EventHandler(this.btonCancelEnsam_Click);
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
            this.dGVEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEnsambles.Location = new System.Drawing.Point(6, 36);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowTemplate.Height = 25;
            this.dGVEnsambles.Size = new System.Drawing.Size(599, 190);
            this.dGVEnsambles.TabIndex = 25;
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
            this.dGVDetalleEnsamble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(252, 249);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowTemplate.Height = 25;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(599, 200);
            this.dGVDetalleEnsamble.TabIndex = 26;
            // 
            // pnlDatosEnsamb
            // 
            this.pnlDatosEnsamb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosEnsamb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlDatosEnsamb.Controls.Add(this.lblFolio);
            this.pnlDatosEnsamb.Controls.Add(this.lblTotal);
            this.pnlDatosEnsamb.Controls.Add(this.label5);
            this.pnlDatosEnsamb.Controls.Add(this.label4);
            this.pnlDatosEnsamb.Controls.Add(this.lblEnsamblo);
            this.pnlDatosEnsamb.Controls.Add(this.label3);
            this.pnlDatosEnsamb.Controls.Add(this.lblSolicito);
            this.pnlDatosEnsamb.Controls.Add(this.label2);
            this.pnlDatosEnsamb.Controls.Add(this.lblNombre);
            this.pnlDatosEnsamb.Controls.Add(this.label1);
            this.pnlDatosEnsamb.Location = new System.Drawing.Point(615, 36);
            this.pnlDatosEnsamb.Name = "pnlDatosEnsamb";
            this.pnlDatosEnsamb.Size = new System.Drawing.Size(236, 190);
            this.pnlDatosEnsamb.TabIndex = 28;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFolio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFolio.Location = new System.Drawing.Point(89, 11);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(108, 20);
            this.lblFolio.TabIndex = 11;
            this.lblFolio.Text = "Desconocido";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(94, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(108, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Desconocido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(36, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(44, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Folio";
            // 
            // lblEnsamblo
            // 
            this.lblEnsamblo.AutoSize = true;
            this.lblEnsamblo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnsamblo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnsamblo.Location = new System.Drawing.Point(65, 140);
            this.lblEnsamblo.Name = "lblEnsamblo";
            this.lblEnsamblo.Size = new System.Drawing.Size(108, 20);
            this.lblEnsamblo.TabIndex = 5;
            this.lblEnsamblo.Text = "Desconocido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(81, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ensamblo";
            // 
            // lblSolicito
            // 
            this.lblSolicito.AutoSize = true;
            this.lblSolicito.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSolicito.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSolicito.Location = new System.Drawing.Point(65, 100);
            this.lblSolicito.Name = "lblSolicito";
            this.lblSolicito.Size = new System.Drawing.Size(108, 20);
            this.lblSolicito.TabIndex = 3;
            this.lblSolicito.Text = "Desconocido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(90, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solicito";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(65, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Desconocido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre/Razon Social";
            // 
            // EnsamblesListos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.pnlDatosEnsamb);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Name = "EnsamblesListos";
            this.Text = "EnsamblesListos";
            this.Load += new System.EventHandler(this.EnsamblesListos_Load);
            this.panelDatosEnsamble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            this.pnlDatosEnsamb.ResumeLayout(false);
            this.pnlDatosEnsamb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btnRegresarTec;
        private FontAwesome.Sharp.IconButton btnRechEnsamble;
        private FontAwesome.Sharp.IconButton btnEnsamListo;
        private FontAwesome.Sharp.IconButton btonCancelEnsam;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
        private System.Windows.Forms.Panel pnlDatosEnsamb;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEnsamblo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSolicito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label label4;
    }
}