
namespace Presentation.FormRecepServ
{
    partial class EnsamblesPzasAsig
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
            this.btnAsignarTec = new FontAwesome.Sharp.IconButton();
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btnPzasNoAsig = new FontAwesome.Sharp.IconButton();
            this.btonCancelEnsam = new FontAwesome.Sharp.IconButton();
            this.pnlTecEnsamble = new System.Windows.Forms.Panel();
            this.cmbTecnicos = new System.Windows.Forms.ComboBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.lblTitleTec = new System.Windows.Forms.Label();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            this.panelDatosEnsamble.SuspendLayout();
            this.pnlTecEnsamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarTec
            // 
            this.btnAsignarTec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarTec.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAsignarTec.FlatAppearance.BorderSize = 0;
            this.btnAsignarTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTec.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarTec.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsignarTec.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btnAsignarTec.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAsignarTec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignarTec.IconSize = 25;
            this.btnAsignarTec.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAsignarTec.Location = new System.Drawing.Point(637, 420);
            this.btnAsignarTec.Name = "btnAsignarTec";
            this.btnAsignarTec.Size = new System.Drawing.Size(155, 29);
            this.btnAsignarTec.TabIndex = 23;
            this.btnAsignarTec.Text = "Asignar Tecnico";
            this.btnAsignarTec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarTec.UseVisualStyleBackColor = false;
            this.btnAsignarTec.Click += new System.EventHandler(this.btnAsignarTec_Click);
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btnPzasNoAsig);
            this.panelDatosEnsamble.Controls.Add(this.btonCancelEnsam);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(620, 36);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(236, 190);
            this.panelDatosEnsamble.TabIndex = 22;
            // 
            // btnPzasNoAsig
            // 
            this.btnPzasNoAsig.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPzasNoAsig.FlatAppearance.BorderSize = 0;
            this.btnPzasNoAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPzasNoAsig.ForeColor = System.Drawing.Color.Black;
            this.btnPzasNoAsig.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            this.btnPzasNoAsig.IconColor = System.Drawing.Color.Black;
            this.btnPzasNoAsig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPzasNoAsig.IconSize = 30;
            this.btnPzasNoAsig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPzasNoAsig.Location = new System.Drawing.Point(48, 47);
            this.btnPzasNoAsig.Name = "btnPzasNoAsig";
            this.btnPzasNoAsig.Size = new System.Drawing.Size(157, 40);
            this.btnPzasNoAsig.TabIndex = 1;
            this.btnPzasNoAsig.Text = "Piezas no Asignadas";
            this.btnPzasNoAsig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPzasNoAsig.UseVisualStyleBackColor = false;
            this.btnPzasNoAsig.Click += new System.EventHandler(this.btnPzasNoAsig_Click);
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
            this.btonCancelEnsam.Location = new System.Drawing.Point(48, 113);
            this.btonCancelEnsam.Name = "btonCancelEnsam";
            this.btonCancelEnsam.Size = new System.Drawing.Size(157, 40);
            this.btonCancelEnsam.TabIndex = 0;
            this.btonCancelEnsam.Text = "Cancelar";
            this.btonCancelEnsam.UseVisualStyleBackColor = false;
            this.btonCancelEnsam.Click += new System.EventHandler(this.btonCancelEnsam_Click);
            // 
            // pnlTecEnsamble
            // 
            this.pnlTecEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTecEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlTecEnsamble.Controls.Add(this.cmbTecnicos);
            this.pnlTecEnsamble.Controls.Add(this.btnSave);
            this.pnlTecEnsamble.Controls.Add(this.btnCancel);
            this.pnlTecEnsamble.Controls.Add(this.lblTitleTec);
            this.pnlTecEnsamble.Location = new System.Drawing.Point(551, 249);
            this.pnlTecEnsamble.Name = "pnlTecEnsamble";
            this.pnlTecEnsamble.Size = new System.Drawing.Size(305, 154);
            this.pnlTecEnsamble.TabIndex = 21;
            // 
            // cmbTecnicos
            // 
            this.cmbTecnicos.FormattingEnabled = true;
            this.cmbTecnicos.Location = new System.Drawing.Point(50, 58);
            this.cmbTecnicos.Name = "cmbTecnicos";
            this.cmbTecnicos.Size = new System.Drawing.Size(224, 23);
            this.cmbTecnicos.TabIndex = 18;
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
            // lblTitleTec
            // 
            this.lblTitleTec.AutoSize = true;
            this.lblTitleTec.BackColor = System.Drawing.Color.Black;
            this.lblTitleTec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleTec.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleTec.Location = new System.Drawing.Point(50, 19);
            this.lblTitleTec.Name = "lblTitleTec";
            this.lblTitleTec.Size = new System.Drawing.Size(231, 21);
            this.lblTitleTec.TabIndex = 8;
            this.lblTitleTec.Text = "Asignar Tecnico al Ensamble";
            // 
            // dGVEnsambles
            // 
            this.dGVEnsambles.AllowUserToAddRows = false;
            this.dGVEnsambles.AllowUserToDeleteRows = false;
            this.dGVEnsambles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEnsambles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVEnsambles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.dGVEnsambles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEnsambles.Location = new System.Drawing.Point(6, 36);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowTemplate.Height = 25;
            this.dGVEnsambles.Size = new System.Drawing.Size(599, 190);
            this.dGVEnsambles.TabIndex = 19;
            this.dGVEnsambles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEnsambles_CellClick);
            // 
            // dGVDetalleEnsamble
            // 
            this.dGVDetalleEnsamble.AllowUserToAddRows = false;
            this.dGVDetalleEnsamble.AllowUserToDeleteRows = false;
            this.dGVDetalleEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVDetalleEnsamble.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDetalleEnsamble.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.dGVDetalleEnsamble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(6, 249);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowTemplate.Height = 25;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(522, 200);
            this.dGVDetalleEnsamble.TabIndex = 20;
            // 
            // EnsamblesPzasAsig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.btnAsignarTec);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.pnlTecEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Name = "EnsamblesPzasAsig";
            this.Text = "EnsamblesPzasAsig";
            this.Load += new System.EventHandler(this.EnsamblesPzasAsig_Load);
            this.panelDatosEnsamble.ResumeLayout(false);
            this.pnlTecEnsamble.ResumeLayout(false);
            this.pnlTecEnsamble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAsignarTec;
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btnPzasNoAsig;
        private FontAwesome.Sharp.IconButton btonCancelEnsam;
        private System.Windows.Forms.Panel pnlTecEnsamble;
        private System.Windows.Forms.ComboBox cmbTecnicos;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label lblTitleTec;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
    }
}