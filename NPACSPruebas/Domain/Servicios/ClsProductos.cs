using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Domain.Servicios
{
    public class ClsProductos
    {
        private ConexionDB Conexion = new ConexionDB();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCategrias";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListaCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListaCategorias";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarMarcas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarMarcas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListaMarcas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListaMarcas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarProvedores()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProvedores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListaProducEnsamble()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProdEnsamble";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarProdExist()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "listar_Productos_Exist";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable FiltrarNoEProductos(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "filtro_Productos_NoExist";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable FiltrarSiEProductos(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "filtro_Productos_SiExist";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable ListarProdNoExist()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "listar_Productos_Noexist";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable FiltrarProductos(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "filtro_Productos";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable FiltrarProductosAdmin(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "filtro_Productos_Admin";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }


        }
        public DataTable FiltrarProductosExist(string buscarProducto, string campoProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "filtro_Productos_Exist";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                Comando.Parameters.Add("@campo", SqlDbType.VarChar, 60).Value = campoProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
        public DataTable FiltrarProductosEnsamble(string buscarProducto)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "filtro_ProductosEnsamble";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 60).Value = buscarProducto;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.CerrarConexion();
            }


        }
    }
}
