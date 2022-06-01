using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class ProvedoresRepository:MasterRepository,IProvedoresRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public ProvedoresRepository()
        {
            selectAll = "select *from Provedores";
            insert = "insert into Provedores values(@Provedor)";
            update = "update Provedores set Provedor=@Provedor where idProv=@idProv";
            delete = "delete from Provedores where idProv=@idProv";
        }
        public int Add(Provedores entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Provedor", entity.provedor));
            return ExecuteNonQuery(insert);
        }
        public int Adit(Provedores entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idProv", entity.idProv));
            parameters.Add(new SqlParameter("@Provedor", entity.provedor));
            return ExecuteNonQuery(update);
        }
        public int Romove(int idProv)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idProv", idProv));
            return ExecuteNonQuery(delete);
        }
        public IEnumerable<Provedores> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listProvedores = new List<Provedores>();
            foreach (DataRow item in tableResult.Rows)
            {
                listProvedores.Add(new Provedores
                {
                    idProv = Convert.ToInt32(item[0]),
                    provedor = item[1].ToString()

                });
            }
            return listProvedores;
        }
    }
}
