using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class MarcasRepositry:MasterRepository,IMarcasRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public MarcasRepositry()
        {
            selectAll = "select *from Marcas";
            insert = "insert into Marcas values(@Marca)";
            update = "update Marcas set Marca=@Marca where idM=@idM";
            delete = "delete from Marcas where idM=@idM";
        }
        public int Add(Marcas entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Marca", entity.marca));
            return ExecuteNonQuery(insert);
        }
        public int Adit(Marcas entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idM", entity.idM));
            parameters.Add(new SqlParameter("@Marca", entity.marca));
            return ExecuteNonQuery(update);
        }
        public int Romove(int idM)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idM", idM));
            return ExecuteNonQuery(delete);
        }
        public IEnumerable<Marcas> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listMarcas = new List<Marcas>();
            foreach (DataRow item in tableResult.Rows)
            {
                listMarcas.Add(new Marcas
                {
                    idM = Convert.ToInt32(item[0]),
                    marca = item[1].ToString()

                });
            }
            return listMarcas;
        }
    }
}
