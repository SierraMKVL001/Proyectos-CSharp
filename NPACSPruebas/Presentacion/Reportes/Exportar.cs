using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Servicios;
using SpreadsheetLight;
using System.Runtime.InteropServices;

namespace Presentacion.Reportes
{
    public partial class Exportar : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        string ruta = "";
        public Exportar()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ListarPzas()
        {
            ProcAdministrador objPro = new ProcAdministrador();
            try
            {
                dGVPzasFacturar.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(lblId.Text));
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
                sl.SetCellValue("J8", hoy.ToString("dd-MM-yy"));
                sl.SetCellValue("C8", lblSolicito.Text);
                sl.SetCellValue("G8", lblEnsamblo.Text);
                sl.SetCellValue("I11", lblTotal.Text);
                sl.SetCellValue("A7", lblNombre.Text);
                sl.SetCellValue("G11", lblSubTotal.Text);
                sl.SetCellValue("H11", lblIVA.Text);
                sl.SetCellValue("E14", lblId.Text);
                sl.SetCellValue("C14", lblFolio.Text);

                int ic = 2;
                foreach (DataGridViewColumn colum in dGVPzasFacturar.Columns)
                {
                    sl.SetCellValue(15, ic, colum.HeaderText.ToString());
                    ic++;
                }
                int ir = 16;
                foreach (DataGridViewRow row in dGVPzasFacturar.Rows)
                {
                    sl.SetCellValue(ir, 2, row.Cells[0].Value.ToString());
                    sl.SetCellValue(ir, 3, row.Cells[1].Value.ToString());
                    sl.SetCellValue(ir, 4, row.Cells[2].Value.ToString());
                    sl.SetCellValue(ir, 5, row.Cells[3].Value.ToString());
                    sl.SetCellValue(ir, 6, row.Cells[4].Value.ToString());
                    sl.SetCellValue(ir, 7, row.Cells[5].Value.ToString());
                    ir++;
                }

                SLStyle estilocont = new SLStyle();
                estilocont.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                estilocont.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                estilocont.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                estilocont.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                estilocont.Border.LeftBorder.Color = Color.Black;

                sl.SetCellStyle("B14","G"+ir,estilocont);
                sl.AutoFitColumn("B","G");

                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Libro de Excel|*.xlsx";
                guardar.Title = "Guardar Reporte";
                guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (guardar.ShowDialog() == DialogResult.OK)
                {

                    sl.SaveAs(guardar.FileName);
                    //MessageBox.Show("Archivo Guardado");
                    MensajeOk("Archivo Guardado con Exito");
                }
                else
                {
                    MensajeError("Ocurrio un Error, revise que el documento no esta habierto o ya exista");
                }
            }
        }
        private void Exportar_Load(object sender, EventArgs e)
        {
            ListarPzas();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Exportar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
