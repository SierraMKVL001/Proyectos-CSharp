
namespace Presentacion.Form_Tecnico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVEnsambles = new System.Windows.Forms.DataGridView();
            this.dGVDetalleEnsamble = new System.Windows.Forms.DataGridView();
            this.dGVNumTecnico = new System.Windows.Forms.DataGridView();
            this.panelDatosEnsamble = new System.Windows.Forms.Panel();
            this.btnRechEnsamble = new FontAwesome.Sharp.IconButton();
            this.btnEnsamListo = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumObser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDEns = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnEditObserv = new FontAwesome.Sharp.IconButton();
            this.btnAgrObser = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumTecnico)).BeginInit();
            this.panelDatosEnsamble.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dGVEnsambles.Location = new System.Drawing.Point(6, 36);
            this.dGVEnsambles.Name = "dGVEnsambles";
            this.dGVEnsambles.ReadOnly = true;
            this.dGVEnsambles.RowHeadersVisible = false;
            this.dGVEnsambles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEnsambles.Size = new System.Drawing.Size(599, 190);
            this.dGVEnsambles.TabIndex = 0;
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
            this.dGVDetalleEnsamble.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dGVDetalleEnsamble.Location = new System.Drawing.Point(6, 249);
            this.dGVDetalleEnsamble.Name = "dGVDetalleEnsamble";
            this.dGVDetalleEnsamble.ReadOnly = true;
            this.dGVDetalleEnsamble.RowHeadersVisible = false;
            this.dGVDetalleEnsamble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDetalleEnsamble.Size = new System.Drawing.Size(599, 200);
            this.dGVDetalleEnsamble.TabIndex = 1;
            // 
            // dGVNumTecnico
            // 
            this.dGVNumTecnico.AllowUserToAddRows = false;
            this.dGVNumTecnico.AllowUserToDeleteRows = false;
            this.dGVNumTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVNumTecnico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVNumTecnico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.dGVNumTecnico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVNumTecnico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVNumTecnico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVNumTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVNumTecnico.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGVNumTecnico.EnableHeadersVisualStyles = false;
            this.dGVNumTecnico.Location = new System.Drawing.Point(620, 23);
            this.dGVNumTecnico.Name = "dGVNumTecnico";
            this.dGVNumTecnico.ReadOnly = true;
            this.dGVNumTecnico.RowHeadersVisible = false;
            this.dGVNumTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVNumTecnico.Size = new System.Drawing.Size(236, 59);
            this.dGVNumTecnico.TabIndex = 2;
            // 
            // panelDatosEnsamble
            // 
            this.panelDatosEnsamble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatosEnsamble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelDatosEnsamble.Controls.Add(this.btnRechEnsamble);
            this.panelDatosEnsamble.Controls.Add(this.btnEnsamListo);
            this.panelDatosEnsamble.Location = new System.Drawing.Point(620, 123);
            this.panelDatosEnsamble.Name = "panelDatosEnsamble";
            this.panelDatosEnsamble.Size = new System.Drawing.Size(236, 103);
            this.panelDatosEnsamble.TabIndex = 3;
            // 
            // btnRechEnsamble
            // 
            this.btnRechEnsamble.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRechEnsamble.FlatAppearance.BorderSize = 0;
            this.btnRechEnsamble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechEnsamble.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechEnsamble.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRechEnsamble.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            this.btnRechEnsamble.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnRechEnsamble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRechEnsamble.IconSize = 30;
            this.btnRechEnsamble.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechEnsamble.Location = new System.Drawing.Point(18, 55);
            this.btnRechEnsamble.Name = "btnRechEnsamble";
            this.btnRechEnsamble.Size = new System.Drawing.Size(201, 29);
            this.btnRechEnsamble.TabIndex = 1;
            this.btnRechEnsamble.Text = "Rechazar Ensamble";
            this.btnRechEnsamble.UseVisualStyleBackColor = false;
            this.btnRechEnsamble.Click += new System.EventHandler(this.btnRechEnsamble_Click);
            // 
            // btnEnsamListo
            // 
            this.btnEnsamListo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnsamListo.FlatAppearance.BorderSize = 0;
            this.btnEnsamListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnsamListo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnsamListo.ForeColor = System.Drawing.Color.Green;
            this.btnEnsamListo.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnEnsamListo.IconColor = System.Drawing.Color.Green;
            this.btnEnsamListo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnsamListo.IconSize = 30;
            this.btnEnsamListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnsamListo.Location = new System.Drawing.Point(17, 20);
            this.btnEnsamListo.Name = "btnEnsamListo";
            this.btnEnsamListo.Size = new System.Drawing.Size(201, 29);
            this.btnEnsamListo.TabIndex = 0;
            this.btnEnsamListo.Text = "Ensamble Listo";
            this.btnEnsamListo.UseVisualStyleBackColor = false;
            this.btnEnsamListo.Click += new System.EventHandler(this.btnEnsamListo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.lblNumObser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIDEns);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Location = new System.Drawing.Point(611, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 174);
            this.panel1.TabIndex = 4;
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
            // btnEditObserv
            // 
            this.btnEditObserv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnEditObserv.Location = new System.Drawing.Point(640, 429);
            this.btnEditObserv.Name = "btnEditObserv";
            this.btnEditObserv.Size = new System.Drawing.Size(201, 30);
            this.btnEditObserv.TabIndex = 5;
            this.btnEditObserv.Text = "Editar Observacion";
            this.btnEditObserv.UseVisualStyleBackColor = false;
            this.btnEditObserv.Click += new System.EventHandler(this.btnEditObserv_Click);
            // 
            // btnAgrObser
            // 
            this.btnAgrObser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAgrObser.Location = new System.Drawing.Point(640, 429);
            this.btnAgrObser.Name = "btnAgrObser";
            this.btnAgrObser.Size = new System.Drawing.Size(201, 30);
            this.btnAgrObser.TabIndex = 6;
            this.btnAgrObser.Text = "Agregar Observacion";
            this.btnAgrObser.UseVisualStyleBackColor = false;
            this.btnAgrObser.Click += new System.EventHandler(this.btnAgrObser_Click);
            // 
            // EnsamblesAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(863, 472);
            this.Controls.Add(this.btnAgrObser);
            this.Controls.Add(this.btnEditObserv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatosEnsamble);
            this.Controls.Add(this.dGVNumTecnico);
            this.Controls.Add(this.dGVDetalleEnsamble);
            this.Controls.Add(this.dGVEnsambles);
            this.Name = "EnsamblesAsignados";
            this.Text = "EnsamblesAsignados";
            this.Load += new System.EventHandler(this.EnsamblesAsignados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEnsambles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDetalleEnsamble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumTecnico)).EndInit();
            this.panelDatosEnsamble.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVEnsambles;
        private System.Windows.Forms.DataGridView dGVDetalleEnsamble;
        private System.Windows.Forms.DataGridView dGVNumTecnico;
        private System.Windows.Forms.Panel panelDatosEnsamble;
        private FontAwesome.Sharp.IconButton btnRechEnsamble;
        private FontAwesome.Sharp.IconButton btnEnsamListo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEditObserv;
        private System.Windows.Forms.Label lblNumObser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDEns;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtObservacion;
        private FontAwesome.Sharp.IconButton btnAgrObser;
    }
}