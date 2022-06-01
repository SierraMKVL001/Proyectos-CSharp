using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class ObservacionesRepository:MasterRepository,IObservacionesRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public ObservacionesRepository()
        {
            selectAll = "select *from Observaciones";
            insert = "insert into Observaciones values(@observacion)";
            update = "update Observaciones set Observacion=@observacion where idObs=@idObs";
            delete = "delete from Categorias where idObs=@idObs";
        }
        public int Add(Observaciones entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@observacion", entity.observacion));
            return ExecuteNonQuery(insert);
        }
        public int Adit(Observaciones entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idObs", entity.idObs));
            parameters.Add(new SqlParameter("@obsercavion", entity.observacion));
            return ExecuteNonQuery(update);
        }
        public int Romove(int idObs)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idObs", idObs));
            return ExecuteNonQuery(delete);
        }
        public IEnumerable<Observaciones> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listObservaciones = new List<Observaciones>();
            foreach (DataRow item in tableResult.Rows)
            {
                listObservaciones.Add(new Observaciones
                {
                    idObs = Convert.ToInt32(item[0]),
                    observacion = item[1].ToString()

                });
            }
            return listObservaciones;
        }
    }
}
