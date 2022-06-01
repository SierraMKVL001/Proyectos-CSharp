using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class ProductosRepository : MasterRepository, IProductosRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public ProductosRepository()
        {
            selectAll = "select *from Productos";
            insert = "insert into Productos values(@codigo,@nombre,@descripcion,@idCategoria,@idMarca,@precioUnid,@idProvedor,@stock)";
            update = "update Productos set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,idCategoria=@idCategoria,idMarca=@idMarca,PrecioUnid=@precioUnid,idProvedor=@idProvedor,stock=@stock where idPro=@idPro";
            delete = "delete from Productos where idPro=@idPro";
        }
        public int Add(Productos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@codigo", entity.codigo));
            parameters.Add(new SqlParameter("@nombre", entity.nombre));
            parameters.Add(new SqlParameter("@descripcion", entity.Descripcion));
            parameters.Add(new SqlParameter("@idCategoria", entity.idCategoria));
            parameters.Add(new SqlParameter("@idMarca", entity.idMarca));
            parameters.Add(new SqlParameter("@precioUnid", entity.precioUnid));
            parameters.Add(new SqlParameter("@idProvedor", entity.idProvedor));
            parameters.Add(new SqlParameter("@stock", entity.stock));
            return ExecuteNonQuery(insert);

        }
        public int Adit(Productos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPro", entity.idPro));
            parameters.Add(new SqlParameter("@codigo", entity.codigo));
            parameters.Add(new SqlParameter("@nombre", entity.nombre));
            parameters.Add(new SqlParameter("@descripcion", entity.Descripcion));
            parameters.Add(new SqlParameter("@idCategoria", entity.idCategoria));
            parameters.Add(new SqlParameter("@idMarca", entity.idMarca));
            parameters.Add(new SqlParameter("@precioUnid", entity.precioUnid));
            parameters.Add(new SqlParameter("@idProvedor", entity.idProvedor));
            parameters.Add(new SqlParameter("@stock", entity.stock));
            return ExecuteNonQuery(update);

        }
        public IEnumerable<Productos> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listProductos = new List<Productos>();
            foreach (DataRow item in tableResult.Rows)
            {
                listProductos.Add(new Productos
                {
                    idPro = Convert.ToInt32(item[0]),
                    codigo = item[1].ToString(),
                    nombre = item[2].ToString(),
                    Descripcion = item[3].ToString(),
                    idCategoria = Convert.ToInt32(item[4]),
                    idMarca = Convert.ToInt32(item[5]),
                    precioUnid = Convert.ToDecimal(item[6]),
                    idProvedor = Convert.ToInt32(item[7]),
                    stock = Convert.ToInt32(item[8])

                });
            }
            return listProductos;
        }
        public int Romove(int idPro)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPro", idPro));
            return ExecuteNonQuery(delete);
        }
    }
}
