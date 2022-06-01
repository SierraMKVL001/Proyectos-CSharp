using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class AsigTecEnsamblesRepository : MasterRepository, IEnsamblesRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public AsigTecEnsamblesRepository()
        {
            selectAll = "select *from Ensambles";
            insert = "";
            update = "update Ensambles set idTecnico=@idTecnico,idEstatus=@idEstatus where idEnsamble=@idEnsamble";
            delete = "delete from Ensambles where idEnsamble=@idEnsamble";
        }
        public int Add(Ensambles entity)
        {
            return ExecuteNonQuery(insert);
        }

        public int Adit(Ensambles entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idEnsamble", entity.idEnsamble));
            parameters.Add(new SqlParameter("@idTecnico", entity.idTecnico));
            parameters.Add(new SqlParameter("@idEstatus", entity.idEstatus));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Ensambles> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listEnsambles = new List<Ensambles>();
            foreach (DataRow item in tableResult.Rows)
            {
                listEnsambles.Add(new Ensambles
                {
                    idEnsamble = Convert.ToInt32(item[0]),
                    idCliente = Convert.ToInt32(item[1]),
                    idEmpleado = Convert.ToInt32(item[2]),
                    idEstatus = Convert.ToInt32(item[3]),
                    idTipo = Convert.ToInt32(item[4]),
                    NumFolio = item[5].ToString()


                }); ;
            }
            return listEnsambles;
        }

        public int Romove(int idEnsamble)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idEnsamble", idEnsamble));
            return ExecuteNonQuery(delete);
        }
    }
}
