
namespace Presentation.Reportes
{
    partial class Importar
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
            this.btnSelect = new FontAwesome.Sharp.IconButton();
            this.btnGen = new FontAwesome.Sharp.IconButton();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEnsamblo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSolicito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.dGVPzasFacturar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPzasFacturar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelect.IconColor = System.Drawing.Color.Black;
            this.btnSelect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelect.Location = new System.Drawing.Point(21, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(126, 27);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGen.IconColor = System.Drawing.Color.Black;
            this.btnGen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGen.Location = new System.Drawing.Point(167, 45);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(126, 27);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generar";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRuta.Location = new System.Drawing.Point(21, 12);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(528, 27);
            this.txtRuta.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.lblFolio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblEnsamblo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSolicito);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 206);
            this.panel1.TabIndex = 29;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(115, 142);
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
            this.label5.Location = new System.Drawing.Point(30, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total: ";
            // 
            // lblEnsamblo
            // 
            this.lblEnsamblo.AutoSize = true;
            this.lblEnsamblo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnsamblo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnsamblo.Location = new System.Drawing.Point(59, 122);
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
            this.label3.Location = new System.Drawing.Point(75, 102);
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
            this.lblSolicito.Location = new System.Drawing.Point(59, 82);
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
            this.label2.Location = new System.Drawing.Point(84, 62);
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
            this.lblNombre.Location = new System.Drawing.Point(59, 42);
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
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre/Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(30, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Folio";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFolio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFolio.Location = new System.Drawing.Point(84, 173);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(108, 20);
            this.lblFolio.TabIndex = 9;
            this.lblFolio.Text = "Desconocido";
            // 
            // dGVPzasFacturar
            // 
            this.dGVPzasFacturar.AllowUserToAddRows = false;
            this.dGVPzasFacturar.AllowUserToDeleteRows = false;
            this.dGVPzasFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPzasFacturar.Location = new System.Drawing.Point(279, 78);
            this.dGVPzasFacturar.Name = "dGVPzasFacturar";
            this.dGVPzasFacturar.ReadOnly = true;
            this.dGVPzasFacturar.RowTemplate.Height = 25;
            this.dGVPzasFacturar.Size = new System.Drawing.Size(496, 206);
            this.dGVPzasFacturar.TabIndex = 30;
            // 
            // Importar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.dGVPzasFacturar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnSelect);
            this.Name = "Importar";
            this.Text = "Importar";
            this.Load += new System.EventHandler(this.Importar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPzasFacturar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSelect;
        private FontAwesome.Sharp.IconButton btnGen;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblEnsamblo;
        public System.Windows.Forms.Label lblSolicito;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVPzasFacturar;
    }
}