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
    public class D_DashBoard
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public void ProdPorCategoria(E_DashBoard obj)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ProdPorCategoria";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            while (LeerFilas.Read())
            {
                obj.Categoria.Add(LeerFilas.GetString(0));
                obj.CantProd.Add(LeerFilas.GetInt32(1));
            }
            LeerFilas.Close();
            Conexion.CerrarConexion();
        }
        public void ProdPreferidos(E_DashBoard obj)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ProdPreferidos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            while (LeerFilas.Read())
            {
                obj.Producto.Add(LeerFilas.GetString(0));
                obj.Cant.Add(LeerFilas.GetInt32(1));
            }
            LeerFilas.Close();
            Conexion.CerrarConexion();
        }
        public void SumDatos(E_DashBoard obj)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "DashBoardDatos";
            Comando.CommandType = CommandType.StoredProcedure;

            SqlParameter total = new SqlParameter("@totalVentas", SqlDbType.Float);total.Direction = ParameterDirection.Output;
            SqlParameter nProd = new SqlParameter("@nProd", 0);nProd.Direction = ParameterDirection.Output;
            SqlParameter nMarc = new SqlParameter("@nMarc", 0);nMarc.Direction = ParameterDirection.Output;
            SqlParameter nCateg = new SqlParameter("@nCateg", 0);nCateg.Direction = ParameterDirection.Output;
            SqlParameter nClient = new SqlParameter("@nClient", 0);nClient.Direction = ParameterDirection.Output;
            SqlParameter nProve = new SqlParameter("@nProve", 0);nProve.Direction = ParameterDirection.Output;
            SqlParameter nEmplea = new SqlParameter("@nEmplea", 0);nEmplea.Direction = ParameterDirection.Output;
            SqlParameter nEnsam = new SqlParameter("@nEnsambles",0);nEnsam.Direction = ParameterDirection.Output;
            SqlParameter nTec = new SqlParameter("@nTecnicos",0);nTec.Direction = ParameterDirection.Output;
            SqlParameter nOrden = new SqlParameter("@nOrdenUser", 0);nOrden.Direction = ParameterDirection.Output;

            Comando.Parameters.Add(total);
            Comando.Parameters.Add(nProd);
            Comando.Parameters.Add(nMarc);
            Comando.Parameters.Add(nCateg);
            Comando.Parameters.Add(nClient);
            Comando.Parameters.Add(nProve);
            Comando.Parameters.Add(nEmplea);
            Comando.Parameters.Add(nEnsam);
            Comando.Parameters.Add(nTec);
            Comando.Parameters.Add(nOrden);
            Comando.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
            Comando.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
            Comando.ExecuteNonQuery();

            obj.TotalVentas = Comando.Parameters["@totalVentas"].Value.ToString();
            obj.CantCategorias = Comando.Parameters["@nCateg"].Value.ToString();
            obj.CantProductos= Comando.Parameters["@nProd"].Value.ToString();
            obj.CantMarcas = Comando.Parameters["@nMarc"].Value.ToString();
            obj.CantClientes= Comando.Parameters["@nClient"].Value.ToString();
            obj.CantProvedores= Comando.Parameters["@nProve"].Value.ToString();
            obj.CantEmpleados= Comando.Parameters["@nEmplea"].Value.ToString();
            obj.CantEnsambles= Comando.Parameters["@nEnsambles"].Value.ToString();
            obj.CantTecnicos = Comando.Parameters["@nTecnicos"].Value.ToString();
            obj.CantOrdenUsers = Comando.Parameters["@nOrdenUser"].Value.ToString();

            Conexion.CerrarConexion();
        }
    }
}
