
namespace Presentation.FormAlmacen
{
    partial class EnsamblesPendientes
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
            this.btnPzasAsign = new FontAwesome.Sharp.IconButton();
            this.btonCancelEnsam = new FontAwesome.Sharp.IconButton();
            this.pnlDatosDetEnsam = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblTitleSerie = new System.Windows.Forms.Label();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            this.btnAsignarNS = new FontAwesome.Sharp.IconButton();
            this.dGVNumOrdenUs = new System.Windows.Forms.DataGridView();
            this.panelDatosEnsamble.SuspendLayout();
            this.pnlDatosDetEnsam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumOrdenUs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btnPzasAsign);
            this.panelDatosEnsamble.Controls.Add(this.btonCancelEnsam);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(620, 82);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(236, 155);
            this.panelDatosEnsamble.TabIndex = 7;
            // 
            // btnPzasAsign
            // 
            this.btnPzasAsign.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPzasAsign.FlatAppearance.BorderSize = 0;
            this.btnPzasAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPzasAsign.ForeColor = System.Drawing.Color.Green;
            this.btnPzasAsign.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnPzasAsign.IconColor = System.Drawing.Color.Green;
            this.btnPzasAsign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPzasAsign.IconSize = 30;
            this.btnPzasAsign.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPzasAsign.Location = new System.Drawing.Point(65, 18);
            this.btnPzasAsign.Name = "btnPzasAsign";
            this.btnPzasAsign.Size = new System.Drawing.Size(107, 55);
            this.btnPzasAsign.TabIndex = 1;
            this.btnPzasAsign.Text = "Piezas Asignadas";
            this.btnPzasAsign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPzasAsign.UseVisualStyleBackColor = false;
            this.btnPzasAsign.Click += new System.EventHandler(this.btnPzasAsign_Click);
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
            this.btonCancelEnsam.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btonCancelEnsam.Location = new System.Drawing.Point(65, 92);
            this.btonCancelEnsam.Name = "btonCancelEnsam";
            this.btonCancelEnsam.Size = new System.Drawing.Size(107, 55);
            this.btonCancelEnsam.TabIndex = 0;
            this.btonCancelEnsam.Text = "Cancelar";
            this.btonCancelEnsam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btonCancelEnsam.UseVisualStyleBackColor = false;
            this.btonCancelEnsam.Click += new System.EventHandler(this.btonCancelEnsam_Click);
            // 
            // pnlDatosDetEnsam
            // 
            this.pnlDatosDetEnsam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosDetEnsam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlDatosDetEnsam.Controls.Add(this.btnSave);
            this.pnlDatosDetEnsam.Controls.Add(this.btnCancel);
            this.pnlDatosDetEnsam.Controls.Add(this.txtNumSerie);
            this.pnlDatosDetEnsam.Controls.Add(this.lblTitleSerie);
            this.pnlDatosDetEnsam.Location = new System.Drawing.Point(551, 243);
            this.pnlDatosDetEnsam.Name = "pnlDatosDetEnsam";
            this.pnlDatosDetEnsam.Size = new System.Drawing.Size(305, 154);
            this.pnlDatosDetEnsam.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(11, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 29);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancel.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 25;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(161, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 29);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(31, 62);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(243, 23);
            this.txtNumSerie.TabIndex = 9;
            // 
            // lblTitleSerie
            // 
            this.lblTitleSerie.AutoSize = true;
            this.lblTitleSerie.BackColor = System.Drawing.Color.Black;
            this.lblTitleSerie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleSerie.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleSerie.Location = new System.Drawing.Point(60, 19);
            this.lblTitleSerie.Name = "lblTitleSerie";
            this.lblTitleSerie.Size = new System.Drawing.Size(200, 21);
            this.lblTitleSerie.TabIndex = 8;
            this.lblTitleSerie.Text = "Asignar Numero de Serie";
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
            this.dGVEnsambles.Location = new System.Drawing.Point(6, 30);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowTemplate.Height = 25;
            this.dGVEnsambles.Size = new System.Drawing.Size(599, 190);
            this.dGVEnsambles.TabIndex = 4;
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
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(6, 243);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowTemplate.Height = 25;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(522, 200);
            this.dGVDetalleEnsamble.TabIndex = 5;
            // 
            // btnAsignarNS
            // 
            this.btnAsignarNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarNS.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAsignarNS.FlatAppearance.BorderSize = 0;
            this.btnAsignarNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarNS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarNS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsignarNS.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btnAsignarNS.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAsignarNS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignarNS.IconSize = 25;
            this.btnAsignarNS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAsignarNS.Location = new System.Drawing.Point(601, 414);
            this.btnAsignarNS.Name = "btnAsignarNS";
            this.btnAsignarNS.Size = new System.Drawing.Size(224, 29);
            this.btnAsignarNS.TabIndex = 17;
            this.btnAsignarNS.Text = "Asignar Numero de Serie";
            this.btnAsignarNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarNS.UseVisualStyleBackColor = false;
            this.btnAsignarNS.Click += new System.EventHandler(this.btnAsignarNS_Click);
            // 
            // dGVNumOrdenUs
            // 
            this.dGVNumOrdenUs.AllowUserToAddRows = false;
            this.dGVNumOrdenUs.AllowUserToDeleteRows = false;
            this.dGVNumOrdenUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVNumOrdenUs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVNumOrdenUs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.dGVNumOrdenUs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVNumOrdenUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNumOrdenUs.Location = new System.Drawing.Point(620, 17);
            this.dGVNumOrdenUs.Name = "dGVNumOrdenUs";
            this.dGVNumOrdenUs.ReadOnly = true;
            this.dGVNumOrdenUs.RowTemplate.Height = 25;
            this.dGVNumOrdenUs.Size = new System.Drawing.Size(236, 59);
            this.dGVNumOrdenUs.TabIndex = 18;
            // 
            // EnsamblesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.dGVNumOrdenUs);
            this.Controls.Add(this.btnAsignarNS);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.pnlDatosDetEnsam);
            this.Controls.Add(this.dGVEnsambles);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Name = "EnsamblesPendientes";
            this.Text = "EnsamblesPendientes";
            this.Load += new System.EventHandler(this.EnsamblesPendientes_Load);
            this.panelDatosEnsamble.ResumeLayout(false);
            this.pnlDatosDetEnsam.ResumeLayout(false);
            this.pnlDatosDetEnsam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumOrdenUs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatosEnsamble;
        private System.Windows.Forms.Panel pnlDatosDetEnsam;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label lblTitleSerie;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnAsignarNS;
        private FontAwesome.Sharp.IconButton btonCancelEnsam;
        private FontAwesome.Sharp.IconButton btnPzasAsign;
        private System.Windows.Forms.DataGridView dGVNumOrdenUs;
    }
}