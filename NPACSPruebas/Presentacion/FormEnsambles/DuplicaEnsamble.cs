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
using Common.DashBoard;
using Domain.DashBoard;

namespace Presentacion.FormEnsambles
{
    public partial class DuplicaEnsamble : Form, VarDatosEntreForm2
    {
        int n = 0;
        private DataTable dtDetalle;
        double subtotal;
        double Total;
        double iva;
        int count = 0;
        bool SelectClient = false;
        bool ObsSelect = false;
        public DuplicaEnsamble()
        {
            InitializeComponent();
            LoadUserData();
            //DuplicaProduct();
            dTimeFecha.Enabled = false;
        }
        private void DuplicaProduct()
        {
            DuplicatEnsamble duplicaEn = new DuplicatEnsamble();
            AddOwnedForm(duplicaEn);
        }
        private void DuplicaEnsamble_Load(object sender, EventArgs e)
        {
            obtenerICLiente(Convert.ToInt32(lblEnsambleDup.Text));
            ObtenerDatosCliente(Convert.ToInt32(lblIdCliente.Text));
            ListarTipos();
            //llenarDataG();
        }
        public void obtenerICLiente(int idEnsamble)
        {
            N_DupEnsamble neg = new N_DupEnsamble();
            E_DupEnsamble obj = new E_DupEnsamble();
            neg.idCliente(obj, idEnsamble);
            lblIdCliente.Text = obj.IdCliente;
        }
        public void ObtenerDatosCliente(int idCliente)
        {
            N_DupEnsamble neg1 = new N_DupEnsamble();
            E_DupEnsamble obj1 = new E_DupEnsamble();
            neg1.DatosCliente(obj1, idCliente);
            lblDireccionClient.Text = obj1.Direccion;
            lblNombreClient.Text = obj1.NomCliente;
            lblRFCClient.Text = obj1.Rfc;
            lblTelefono.Text = obj1.Telefono;
        }
        public void llenarDataG()
        {
            ProcDupEnsambles objPro = new ProcDupEnsambles();
            try
            {
                dGVPzasEnsamble.DataSource = objPro.ListaDetallesEnsamble(Convert.ToInt32(lblEnsambleDup.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (DataGridViewRow row in dGVPzasEnsamble.Rows)
            {
                
                    subtotal += Convert.ToSingle(row.Cells[4].Value);
            }
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
                userPuesto = "Recepcion de Servicio";
            if (UserLoginCache.idPuesto == Puesto.Tecnico)
                userPuesto = "Tecnico";
            if (UserLoginCache.idPuesto == Puesto.Ejecutivo)
                userPuesto = "Ejecutivo de Ventas";

            lblIdEmplea.Text = UserLoginCache.idEmp.ToString();
            lblNombreEmpleado.Text = UserLoginCache.Nombres + " " + UserLoginCache.Apellidos;
            lblPuesto.Text = userPuesto;
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
        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            SelectDupClient seleccionClient = new SelectDupClient();
            AddOwnedForm(seleccionClient);
            seleccionClient.ShowDialog();
            ClienteSeleccionado();
        }
        private void ListarTipos()
        {
            ProcEnsambles objPro = new ProcEnsambles();
            cmbTipos.DataSource = objPro.ListarTipos();
            cmbTipos.DisplayMember = "Tipo";
            cmbTipos.ValueMember = "ID";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void TablaAgregarDatos1(DataGridViewRow fila1a)
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
            if (lblObserv.Text == "No. Observacion")
            {
                btnObservaciones.Visible = true;
                btnEditObservacion.Visible = false;
            }
            if (lblObserv.Text != "No. Observacion")
            {
                btnObservaciones.Visible = false;
                btnEditObservacion.Visible = true;
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            //SelectDupProduct selectProduct = new SelectDupProduct();
            //AddOwnedForm(selectProduct);
            //selectProduct.ShowDialog();
            DuplicatEnsamble duplicaEn = new DuplicatEnsamble();
            duplicaEn.lblEnsambleDup.Text = lblEnsambleDup.Text;
            AddOwnedForm(duplicaEn);
            duplicaEn.ShowDialog();
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
    }
    internal interface VarDatosEntreForm2
    {
        void TablaAgregarDatos1(DataGridViewRow fila1a);
    }
}
