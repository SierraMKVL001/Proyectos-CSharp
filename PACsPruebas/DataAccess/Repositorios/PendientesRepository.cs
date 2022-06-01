using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class PendientesRepository : MasterRepository, IDetalleEnsambleRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public PendientesRepository()
        {
            selectAll = "select *from Detalles_Ensamble";
            insert = "";
            update = "update Detalles_Ensamble set NumSerie=@NumSerie where idDet_Ens=@idDet_Ens";
            delete = "delete from Detalles_Ensamble where idDet_Ens=@idDet_Ens";
        }
        public int Add(DetalleEnsambles entity)
        {
            return ExecuteNonQuery(insert);
        }

        public int Adit(DetalleEnsambles entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idDet_Ens", entity.idDet_Ens));
            parameters.Add(new SqlParameter("@NumSerie", entity.NumSerie));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<DetalleEnsambles> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listEmpleados = new List<DetalleEnsambles>();
            foreach (DataRow item in tableResult.Rows)
            {
                listEmpleados.Add(new DetalleEnsambles
                {
                    idDet_Ens = Convert.ToInt32(item[0]),
                    idEnsam = Convert.ToInt32(item[1]),
                    idProduct = Convert.ToInt32(item[2]),
                    Cantidad = Convert.ToInt32(item[3]),
                    idObser = Convert.ToInt32(item[4]),
                    NumSerie = item[5].ToString()


                });
            }
            return listEmpleados;
        }

        public int Romove(int idDet_Ens)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idDet_Ens", idDet_Ens));
            return ExecuteNonQuery(delete);
        }
    }
}

