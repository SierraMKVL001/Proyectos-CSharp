using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentation.FormAdmin;
using Dominio.Servicios;
using Dominio.Modelos;
using Dominio.ValueObjects;

namespace Presentation.Reportes
{
    public partial class Importar : Form
    {
        string ruta = "";
        public Importar()
        {
            InitializeComponent();
        }
        private void ListarPzas()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            try
            {
                dGVPzasFacturar.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(lblFolio.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccion = new OpenFileDialog();
            seleccion.Filter = "Libro de Excel|*.xlsx";
            seleccion.Title = "Seleccionar plantilla";
            seleccion.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            if (seleccion.ShowDialog() == DialogResult.OK)
            {

                ruta = seleccion.FileName;

                txtRuta.Text = ruta;
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (ruta != "")
            {
                SLDocument sl = new SLDocument(ruta);
                
                DateTime hoy = DateTime.Today;
                sl.SetCellValue("J8",hoy.ToString("dd-MM-yy"));
                sl.SetCellValue("C8",lblSolicito.Text);
                sl.SetCellValue("G8", lblEnsamblo.Text);
                sl.SetCellValue("I11", lblTotal.Text);

                int ic = 1;
                foreach (DataGridViewColumn colum in dGVPzasFacturar.Columns)
                {
                    sl.SetCellValue(15,ic,colum.HeaderText.ToString());
                    ic++; 
                }
            int ir = 16;
            foreach (DataGridViewRow row in dGVPzasFacturar.Rows)
            {
                sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                ir++;
            }
            SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Libro de Excel|*.xlsx";
                guardar.Title = "Guardar Reporte";
                guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                   
                    sl.SaveAs(guardar.FileName);
                    MessageBox.Show("Archivo Guardado");
                }

            }
        }

        private void Importar_Load(object sender, EventArgs e)
        {
            ListarPzas();
        }
    }
}
