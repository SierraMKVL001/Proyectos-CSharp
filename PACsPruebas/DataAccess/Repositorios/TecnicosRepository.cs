using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.Repositorios
{
    public class TecnicosRepository:MasterRepository,ITecnicosRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public TecnicosRepository()
        {
            selectAll = "select *from tecnicos";
            insert = "insert into tecnicos values(@tecnico)";
            update = "update tecnico set idEmplea=@tecnico where idTec=@idTec";
            delete = "delete from tecnicos where idTec=@idTec";
        }
        public int Add(Tecnicos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@tecnico", entity.idEMplea));
            return ExecuteNonQuery(insert);
        }
        public int Adit(Tecnicos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idTec", entity.idTec));
            parameters.Add(new SqlParameter("@tecnico", entity.idEMplea));
            return ExecuteNonQuery(update);
        }
        public IEnumerable<Tecnicos> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listTecnicos = new List<Tecnicos>();
            foreach (DataRow item in tableResult.Rows)
            {
                listTecnicos.Add(new Tecnicos
                {
                    idTec = Convert.ToInt32(item[0]),
                    idEMplea=Convert.ToInt32(item[1])
                    
                });
            }
            return listTecnicos;
        }
        public int Romove(int idTec)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idTec", idTec));
            return ExecuteNonQuery(delete);
        }
    }
}
