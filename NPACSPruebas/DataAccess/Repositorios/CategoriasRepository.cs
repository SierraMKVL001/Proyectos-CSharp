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
    public class CategoriasRepository : MasterRepository, ICategoriasRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public CategoriasRepository()
        {
            selectAll = "select *from Categorias";
            insert = "insert into Categorias values(@categoria)";
            update = "update Categorias set Categoria=@categoria where idC=@idC";
            delete = "delete from Categorias where idC=@idC";
        }
        public int Add(Categorias entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@categoria", entity.categoria));
            return ExecuteNonQuery(insert);
        }
        public int Adit(Categorias entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idC", entity.idC));
            parameters.Add(new SqlParameter("@categoria", entity.categoria));
            return ExecuteNonQuery(update);
        }
        public int Romove(int idC)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idC", idC));
            return ExecuteNonQuery(delete);
        }
        public IEnumerable<Categorias> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listCategorias = new List<Categorias>();
            foreach (DataRow item in tableResult.Rows)
            {
                listCategorias.Add(new Categorias
                {
                    idC = Convert.ToInt32(item[0]),
                    categoria = item[1].ToString()

                });
            }
            return listCategorias;
        }
    }
}
