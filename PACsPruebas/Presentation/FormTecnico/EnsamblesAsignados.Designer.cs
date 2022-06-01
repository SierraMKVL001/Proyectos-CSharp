
namespace Presentation.FormTecnico
{
    partial class EnsamblesAsignados
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
            this.dGVNumTecnico = new System.Windows.Forms.DataGridView();
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btnRechEnsamble = new FontAwesome.Sharp.IconButton();
            this.btnEnsamListo = new FontAwesome.Sharp.IconButton();
            this.btonCancelEnsam = new FontAwesome.Sharp.IconButton();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumTecnico)).BeginInit();
            this.panelDatosEnsamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVNumTecnico
            // 
            this.dGVNumTecnico.AllowUserToAddRows = false;
            this.dGVNumTecnico.AllowUserToDeleteRows = false;
            this.dGVNumTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVNumTecnico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVNumTecnico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.dGVNumTecnico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVNumTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNumTecnico.Location = new System.Drawing.Point(620, 23);
            this.dGVNumTecnico.Name = "dGVNumTecnico";
            this.dGVNumTecnico.ReadOnly = true;
            this.dGVNumTecnico.RowTemplate.Height = 25;
            this.dGVNumTecnico.Size = new System.Drawing.Size(236, 59);
            this.dGVNumTecnico.TabIndex = 24;
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btnRechEnsamble);
            this.panelDatosEnsamble.Controls.Add(this.btnEnsamListo);
            this.panelDatosEnsamble.Controls.Add(this.btonCancelEnsam);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(620, 88);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(236, 138);
            this.panelDatosEnsamble.TabIndex = 22;
            // 
            // btnRechEnsamble
            // 
            this.btnRechEnsamble.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRechEnsamble.FlatAppearance.BorderSize = 0;
            this.btnRechEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechEnsamble.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRechEnsamble.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            this.btnRechEnsamble.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnRechEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRechEnsamble.IconSize = 30;
            this.btnRechEnsamble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechEnsamble.Location = new System.Drawing.Point(18, 55);
            this.btnRechEnsamble.Name = "btnRechEnsamble";
            this.btnRechEnsamble.Size = new System.Drawing.Size(201, 29);
            this.btnRechEnsamble.TabIndex = 2;
            this.btnRechEnsamble.Text = "Rechazar Ensamble";
            this.btnRechEnsamble.UseVisualStyleBackColor = false;
            this.btnRechEnsamble.Click += new System.EventHandler(this.btnRechEnsamble_Click);
            // 
            // btnEnsamListo
            // 
            this.btnEnsamListo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnsamListo.FlatAppearance.BorderSize = 0;
            this.btnEnsamListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsamListo.ForeColor = System.Drawing.Color.Green;
            this.btnEnsamListo.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnEnsamListo.IconColor = System.Drawing.Color.Green;
            this.btnEnsamListo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsamListo.IconSize = 30;
            this.btnEnsamListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsamListo.Location = new System.Drawing.Point(17, 20);
            this.btnEnsamListo.Name = "btnEnsamListo";
            this.btnEnsamListo.Size = new System.Drawing.Size(201, 29);
            this.btnEnsamListo.TabIndex = 1;
            this.btnEnsamListo.Text = "Ensamble Listo";
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
            this.btonCancelEnsam.Location = new System.Drawing.Point(17, 90);
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
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(845, 200);
            this.dGVDetalleEnsamble.TabIndex = 20;
            // 
            // EnsamblesAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.dGVNumTecnico);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Name = "EnsamblesAsignados";
            this.Text = "EnsamblesAsignados";
            this.Load += new System.EventHandler(this.EnsamblesAsignados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumTecnico)).EndInit();
            this.panelDatosEnsamble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVNumTecnico;
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btnEnsamListo;
        private FontAwesome.Sharp.IconButton btonCancelEnsam;
        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
        private FontAwesome.Sharp.IconButton btnRechEnsamble;
    }
}