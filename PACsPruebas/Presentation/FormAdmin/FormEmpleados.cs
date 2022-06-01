using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio.Modelos;
using Dominio.ValueObjects;
using Dominio.Servicios;

namespace Presentation.FormAdmin
{
    public partial class FormEmpleados : Form
    {
        private EmpleadosModel empleados = new EmpleadosModel();

        private int TcN = 0;
        public FormEmpleados()
        {
            InitializeComponent();
            panel1.Enabled = false;
            txtPass.Enabled = false;

        }
        private void ListEmpleados()
        {
            ProcEmpleados objPro = new ProcEmpleados();
            try
            {
                dGVEmpleados.DataSource = objPro.ListarEmpleados();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ListarPuestos()
        {
            ProcEmpleados objPro = new ProcEmpleados();
            cmbPuesto.DataSource = objPro.ListarPuestos();
            cmbPuesto.DisplayMember = "Puesto";
            cmbPuesto.ValueMember = "idPu";
        }
        private void Restart()
        {
            ListEmpleados();
            ListarPuestos();
            TcN = 0;
            panel1.Enabled = false;
            txtPass.Enabled = false;
            txtNombre.Clear();
            txtApellidos.Clear();
            txtUser.Clear();
            txtPass.Clear();
            txtCorreo.Clear();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dGVEmpleados.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seguro que desea Eliminar este Usuario?", "Atencion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    empleados.State = EntityState.Deleted;
                    empleados.IdEmp = Convert.ToInt32(dGVEmpleados.CurrentRow.Cells[0].Value);

                    string result = empleados.SaveChanges();
                    MessageBox.Show(result);
                    ListEmpleados();
                }     
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dGVEmpleados.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                empleados.State = EntityState.Modifed;
                empleados.IdEmp = Convert.ToInt32(dGVEmpleados.CurrentRow.Cells[0].Value);
                txtNombre.Text = dGVEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = dGVEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtUser.Text = dGVEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = dGVEmpleados.CurrentRow.Cells[4].Value.ToString();
                cmbPuesto.Text = dGVEmpleados.CurrentRow.Cells[5].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtPass.Enabled = true;
            empleados.State = EntityState.Added;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ensambles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            TcN = Convert.ToInt32(cmbPuesto.SelectedValue);
            if (TcN == 5)
            {
                try
                { 
                    Rpta = NEmpleado.InsertarTec(txtNombre.Text, txtApellidos.Text, txtUser.Text, txtPass.Text, txtCorreo.Text, TcN);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("El Tecnico se Registro con exito");
                    }
                    else
                    {
                        
                        this.MensajeError(Rpta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            if (TcN == 2)
                {
                try
                    {
                        Rpta = NEmpleado.InsertarOrdn(txtNombre.Text, txtApellidos.Text, txtUser.Text, txtPass.Text, txtCorreo.Text, TcN);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("El Encargado de Almacen se Registro con exito");
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
            }
            if (TcN != 5 && TcN != 2)
             {
                    empleados.Nombres = txtNombre.Text;
                    empleados.Apellidos = txtApellidos.Text;
                    empleados.LogName = txtUser.Text;
                    empleados.Pass = txtPass.Text;
                    empleados.Email = txtCorreo.Text;
                    empleados.IdPuesto = Convert.ToInt32(cmbPuesto.SelectedValue);
                    bool valid = new Helps.DataValidation(empleados).Validate();
                    if (valid == true)
                    {
                        string result = empleados.SaveChanges();
                        MessageBox.Show(result);
                        ListEmpleados();
                        Restart();
                    }
            }
            Restart();
         }
         private void FormEmpleados_Load(object sender, EventArgs e)
         {
            ListEmpleados();
            ListarPuestos();
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
