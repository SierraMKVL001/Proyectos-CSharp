using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.DashBoard;

namespace DataAccess.DashBoard
{
    public class D_Ensambles
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();

        public void ObtDatos(int idEnsamble,E_Ensamble obj)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Obtener_Datos";
            Comando.CommandType = CommandType.StoredProcedure;

            SqlParameter numFolio = new SqlParameter("@Numfolio", SqlDbType.VarChar, 20);numFolio.Direction = ParameterDirection.Output;
            SqlParameter nCliente = new SqlParameter("@NCliente", SqlDbType.VarChar, 50); nCliente.Direction = ParameterDirection.Output;
            SqlParameter nEmpleado = new SqlParameter("@NEmpleado", SqlDbType.VarChar, 50); nEmpleado.Direction = ParameterDirection.Output;
            SqlParameter subTotal = new SqlParameter("@SubTotal", SqlDbType.Float); subTotal.Direction = ParameterDirection.Output;
            SqlParameter iva = new SqlParameter("@IVA", SqlDbType.Float); iva.Direction = ParameterDirection.Output;
            SqlParameter total = new SqlParameter("@total", SqlDbType.Float); total.Direction = ParameterDirection.Output;

            Comando.Parameters.Add(numFolio);
            Comando.Parameters.Add(nCliente);
            Comando.Parameters.Add(nEmpleado);
            Comando.Parameters.Add(subTotal);
            Comando.Parameters.Add(iva);
            Comando.Parameters.Add(total);
            Comando.Parameters.Add("@idEnsamble", SqlDbType.Int).Value = idEnsamble;
            Comando.ExecuteNonQuery();

            obj.NumFolio= Comando.Parameters["@Numfolio"].Value.ToString();
            obj.NCliente= Comando.Parameters["@NCliente"].Value.ToString();
            obj.NEmpleado= Comando.Parameters["@NEmpleado"].Value.ToString();
            obj.SubTotal = Comando.Parameters["@SubTotal"].Value.ToString();
            obj.IVA = Comando.Parameters["@IVA"].Value.ToString();
            obj.Total = Comando.Parameters["@total"].Value.ToString();
            Conexion.CerrarConexion();
        }
    }
}
