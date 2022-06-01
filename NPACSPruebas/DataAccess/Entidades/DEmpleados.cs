using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Entidades
{
    public class DEmpleados
    {
        private int idEmp;
        private string nombres;
        private string apellidos;
        private string logName;
        private string pass;
        private string email;
        private int idPuesto;

        public int IdEmp { get => idEmp; set => idEmp = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string LogName { get => logName; set => logName = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Email { get => email; set => email = value; }
        public int IdPuesto { get => idPuesto; set => idPuesto = value; }

        public DEmpleados()
        {

        }
        public DEmpleados(int idEmp, string nombres, string apellidos, string logName, string pass, string email, int idPuesto)
        {
            this.IdEmp = idEmp;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.LogName = logName;
            this.Pass = pass;
            this.email = email;
            this.IdPuesto = idPuesto;
        }
        public string InsertTec(DEmpleados Empleados)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                ////Establecer la transacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                ////Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámtros
                SqlParameter ParIdEmp = new SqlParameter();
                ParIdEmp.ParameterName = "@idEmp";
                ParIdEmp.SqlDbType = SqlDbType.Int;
                ParIdEmp.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEmp);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@Nombres";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Value = Empleados.Nombres;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@Apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Value = Empleados.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParLogName = new SqlParameter();
                ParLogName.ParameterName = "@LogName";
                ParLogName.SqlDbType = SqlDbType.VarChar;
                ParLogName.Value = Empleados.LogName;
                SqlCmd.Parameters.Add(ParLogName);

                SqlParameter ParPass = new SqlParameter();
                ParPass.ParameterName = "@Pass";
                ParPass.SqlDbType = SqlDbType.VarChar;
                ParPass.Value = Empleados.Pass;
                SqlCmd.Parameters.Add(ParPass);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Value = Empleados.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParIdPuesto = new SqlParameter();
                ParIdPuesto.ParameterName = "@idPuesto";
                ParIdPuesto.SqlDbType = SqlDbType.Int;
                ParIdPuesto.Value = Empleados.IdPuesto;
                SqlCmd.Parameters.Add(ParIdPuesto);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    //Obtenemos el codigo del ingreso que se genero por la base de datos

                    this.idEmp = Convert.ToInt32(SqlCmd.Parameters["@idEmp"].Value);
                    DTecnicos det = new DTecnicos();

                    det.IdEmplea = this.idEmp;
                    //Llamamos al metodo insertar de la clase DetalleIngreso
                    //y le pasamos la conexion y la transaccion que debe de usar
                    rpta = det.Insertar(det, ref SqlCon, ref SqlTra);

                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message + "DEmpleadoTec";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        public string InsertOrden(DEmpleados Empleados)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmp = new SqlParameter();
                ParIdEmp.ParameterName = "@idEmp";
                ParIdEmp.SqlDbType = SqlDbType.Int;
                ParIdEmp.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEmp);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@Nombres";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Value = Empleados.Nombres;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@Apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Value = Empleados.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParLogName = new SqlParameter();
                ParLogName.ParameterName = "@LogName";
                ParLogName.SqlDbType = SqlDbType.VarChar;
                ParLogName.Value = Empleados.LogName;
                SqlCmd.Parameters.Add(ParLogName);

                SqlParameter ParPass = new SqlParameter();
                ParPass.ParameterName = "@Pass";
                ParPass.SqlDbType = SqlDbType.VarChar;
                ParPass.Value = Empleados.Pass;
                SqlCmd.Parameters.Add(ParPass);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Value = Empleados.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParIdPuesto = new SqlParameter();
                ParIdPuesto.ParameterName = "@idPuesto";
                ParIdPuesto.SqlDbType = SqlDbType.Int;
                ParIdPuesto.Value = Empleados.IdPuesto;
                SqlCmd.Parameters.Add(ParIdPuesto);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {
                    this.idEmp = Convert.ToInt32(SqlCmd.Parameters["@idEmp"].Value);
                    DOrdenUser det = new DOrdenUser();
                    det.IdEMplea = this.idEmp;
                    rpta = det.Insertar(det, ref SqlCon, ref SqlTra);

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message + "DEnsambleOrden";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
    }
}
