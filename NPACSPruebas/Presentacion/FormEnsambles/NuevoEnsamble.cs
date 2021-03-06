using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Domain.Servicios;

namespace Presentacion.FormEnsambles
{
    public partial class NuevoEnsamble  : Form,VarDatosEntreForm 
    {
        int n = 0;
        private DataTable dtDetalle;
        double subtotal = 0;
        double Total = 0;
        double iva = 0;
        int count = 0;
        bool SelectClient = false;
        bool ObsSelect = false;
        public NuevoEnsamble()
        {
            InitializeComponent();
            LoadUserData();
            dTimeFecha.Enabled = false;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LoadUserData()
        {
            string userPuesto = "puesto";
            if (UserLoginCache.idPuesto == Puesto.Administrador)
                userPuesto = "Administrador";
            if (UserLoginCache.idPuesto == Puesto.Almacen)
                userPuesto = "Almacen";
            if (UserLoginCache.idPuesto == Puesto.Recepcion)
            {
                userPuesto = "Recepcion de Servicio";
                btnDupEnsamble.Visible = false;
            }
            if (UserLoginCache.idPuesto == Puesto.Tecnico)
            {
                userPuesto = "Tecnico";
                btnDupEnsamble.Visible = false;
            }
            if (UserLoginCache.idPuesto == Puesto.Ejecutivo)
                userPuesto = "Ejecutivo de Ventas";

            lblIdEmplea.Text = UserLoginCache.idEmp.ToString();
            lblNombreEmpleado.Text = UserLoginCache.Nombres + " " + UserLoginCache.Apellidos;
            lblPuesto.Text = userPuesto;
        }
        private void NuevoEnsamble_Load(object sender, EventArgs e)
        {
            ListarTipos();
            this.crearTabla();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            SeleccionCliente seleccionClient = new SeleccionCliente();
            AddOwnedForm(seleccionClient);
            seleccionClient.ShowDialog();
            ClienteSeleccionado();
        }
        private void Reset()
        {
            SelectClient = false;
            ObsSelect = false;
            lblFolio.Text = "No. Folio";
            lblObserv.Text = "No. Observacion";
            lblIdCliente.Text = "Sin Seleccionar";
            lblNombreClient.Text = "Cliente no Seleccionado";
            lblDireccionClient.Text = "Desconocido";
            lblTelefono.Text = "Desconocido";
            lblRFCClient.Text = "Desconocido";
            subtotal = 0;
            iva = 0;
            lblIVA.Text = iva.ToString("#0.00#");
            lblSubTotal.Text = subtotal.ToString("#0.00#");
            Total = subtotal * 1.16;
            lblTotal.Text = Total.ToString("#0.00#");
            ActivateButtons();
        }
        private void ClienteSeleccionado()
        {
            if (lblIdCliente.Text != "Sin Seleccionar")
            {
                SelectClient = true;
            }
        }
        private void ObservacionSelect()
        {
            if (lblObserv.Text != "No. Observacion")
            {
                ObsSelect = true;
            }
        }
        private void ListarTipos()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            cmbTipos.DataSource = objPro.ListarTipos();
            cmbTipos.DisplayMember = "Tipo";
            cmbTipos.ValueMember = "ID";
        }
        public void TablaAgregarDatos(DataGridViewRow fila1a)
        {
            string id = fila1a.Cells["ID"].Value.ToString();
            string cod = fila1a.Cells["Codigo"].Value.ToString();
            string nom = fila1a.Cells["Nombre"].Value.ToString();
            string desc = fila1a.Cells["Descripcion"].Value.ToString();
            string price = fila1a.Cells["Precio Bruto"].Value.ToString();
            string stock = fila1a.Cells["Stock"].Value.ToString();

            this.dGVPzasEnsamble.Rows.Add(new[] { id, cod, nom, desc, price, stock });
            subtotal = subtotal + Convert.ToSingle(fila1a.Cells[4].Value);
            lblSubTotal.Text = subtotal.ToString("#0.00#");
            iva = (subtotal * .16);
            lblIVA.Text = iva.ToString("#0.00#");
            Total = subtotal * 1.16;
            lblTotal.Text = Total.ToString("#0.00#");
        }
        private void ActivateButtons()
        {
            if(lblObserv.Text== "No. Observacion")
            {
                btnObservaciones.Visible = true;
                btnEditObservacion.Visible = false;
            }
            if(lblObserv.Text!="No. Observacion")
            {
                btnObservaciones.Visible = false;
                btnEditObservacion.Visible = true;
            }
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            SeleccionProductos selectProduct = new SeleccionProductos();
            AddOwnedForm(selectProduct);
            selectProduct.ShowDialog();
        }

        private void dGVPzasEnsamble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (dGVPzasEnsamble.Rows.Count > 0)
            {
                subtotal = subtotal - Convert.ToSingle(dGVPzasEnsamble.Rows[n].Cells[4].Value);
                lblSubTotal.Text = subtotal.ToString("#0.00#");
                iva = (subtotal * .16);
                lblIVA.Text = iva.ToString("#0.00#");
                Total = subtotal * 1.16;
                lblTotal.Text = Total.ToString("#0.00#");
                dGVPzasEnsamble.Rows.RemoveAt(n);
            }
            else
            {
                this.MensajeError("No hay Piezas en el Ensamble");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dGVPzasEnsamble.Rows.Clear();
            Reset();
        }
        private void crearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("idProduct", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Nombre", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Single"));
            this.dtDetalle.Columns.Add("descuento", System.Type.GetType("System.Single"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Single"));
            //Relacionamos nuestro datagridview con nuestro datatable
            //this.dGVPzasEnsamble.DataSource = this.dtDetalle;
        }
        private void GuardarDatos()
        {
            foreach (DataGridViewRow rowGrid in dGVPzasEnsamble.Rows)
            {

                DataRow row = dtDetalle.NewRow();
                row["idProduct"] = Convert.ToInt32(rowGrid.Cells[0].Value);
                row["Nombre"] = rowGrid.Cells[2].Value.ToString();
                row["cantidad"] = 1;
                row["precio_venta"] = Convert.ToSingle(rowGrid.Cells[4].Value);
                row["descuento"] = 0;
                row["subtotal"] = subtotal;
                dtDetalle.Rows.Add(row);
            }
        }
        private void ClearTabla(DataTable table)
        {
            table.Clear();
        }
        private void AsignarFolio()
        {
            ProcEnsambles obj = new ProcEnsambles();
            string folio1 = obj.consultIdFolio();
            count = Convert.ToInt32(folio1) + 1;
            string fecha = dTimeFecha.Value.ToString("MMyy");
            string folio = count.ToString("#0000#") + fecha;
            lblFolio.Text = folio;
        }
        private void btnEndEnsamble_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            if (dGVPzasEnsamble.Rows.Count > 0)
            {
                if (SelectClient == true)
                {
                    if (MessageBox.Show("Seguro que quiere Proceder con el Ensamble?", "Precaucion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            if (ObsSelect == false)
                            {
                                GuardarDatos();
                                AsignarFolio();
                                //Vamos a insertar un Ingreso 
                                Rpta = NEnsamble.Insertar(lblFolio.Text,
                                    Convert.ToInt32(lblIdCliente.Text), Convert.ToInt32(lblIdEmplea.Text), Convert.ToInt32(cmbTipos.SelectedValue),
                                dTimeFecha.Value, Convert.ToDecimal(lblTotal.Text),Convert.ToDecimal(lblSubTotal.Text),Convert.ToDecimal(lblIVA.Text), dtDetalle);
                                if (Rpta.Equals("OK"))
                                {
                                    dGVPzasEnsamble.Rows.Clear();
                                    Reset();
                                    ClearTabla(dtDetalle);
                                    this.MensajeOk("El Ensamble se registro de Forma correcta");
                                }
                                else
                                {
                                    //Mostramos el mensaje de error
                                    this.MensajeError(Rpta);
                                    ClearTabla(dtDetalle);
                                }
                            }
                            if (ObsSelect==true)
                            {
                                GuardarDatos();
                                AsignarFolio();
                                //Vamos a insertar un Ingreso 
                                Rpta = NEnsamble.InsertarObser(lblFolio.Text,
                                    Convert.ToInt32(lblIdCliente.Text), Convert.ToInt32(lblIdEmplea.Text), Convert.ToInt32(cmbTipos.SelectedValue),
                                dTimeFecha.Value, Convert.ToDecimal(lblTotal.Text), Convert.ToDecimal(lblSubTotal.Text), Convert.ToDecimal(lblIVA.Text), Convert.ToInt32(lblObserv.Text),  dtDetalle);
                                if (Rpta.Equals("OK"))
                                {
                                    dGVPzasEnsamble.Rows.Clear();
                                    Reset();
                                    ClearTabla(dtDetalle);
                                    this.MensajeOk("El Ensamble se registro de Forma correcta");
                                }
                                else
                                {
                                    //Mostramos el mensaje de error
                                    this.MensajeError(Rpta);
                                    ClearTabla(dtDetalle);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ex.StackTrace);
                        }
                    }
                }
                else
                {
                    this.MensajeError("Se debe Seleccionar un Cliente para efectuar el Ensamble");
                }
            }
            else
            {
                this.MensajeError("Se debe seleccionar Piezas para el Ensamble");
            }
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            AgrObservacion agrObservacion = new AgrObservacion();
            AddOwnedForm(agrObservacion);
            agrObservacion.ShowDialog();
            ObservacionSelect();
            ActivateButtons();
        }

        private void btnEditObservacion_Click(object sender, EventArgs e)
        {
            var fimp = new EditeObserv();
            fimp.lblObserv.Text = lblObserv.Text;
            fimp.ShowDialog();
        }
        private void btnDupEnsamble_Click(object sender, EventArgs e)
        {
            SelectDupEnsamble selectDEnsam = new SelectDupEnsamble();
            AddOwnedForm(selectDEnsam);
            selectDEnsam.ShowDialog();
        }
    }
    internal interface VarDatosEntreForm
    {
    void TablaAgregarDatos(DataGridViewRow fila1a);
    }
}
