using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contratos;
using DataAccess.Entidades;
using DataAccess.Repositorios;
using Domain.ValueObjects;

namespace Domain.Modelos
{
    public class EstatusModel
    {
        private int idEnsamble;
        private int idEstatus;
        private IEnsamblesRepository ensamblesRepository;
        public EntityState State { get; set; }
        private List<EstatusModel> listEstatus;
        public int IdEnsamble { get => idEnsamble; set => idEnsamble = value; }
        public int IdEstatus { get => idEstatus; set => idEstatus = value; }

        public EstatusModel()
        {
            ensamblesRepository = new EstatusRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var estatusDataMosel = new Ensambles();
                estatusDataMosel.idEnsamble = idEnsamble;
                estatusDataMosel.idEstatus = idEstatus;


                switch (State)
                {
                    case EntityState.Added:
                        ensamblesRepository.Add(estatusDataMosel);
                        message = "Datos agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        ensamblesRepository.Adit(estatusDataMosel);
                        message = "El Estatus del Ensamble se ha Modificado Correctamente";
                        break;
                    case EntityState.Deleted:
                        ensamblesRepository.Romove(idEnsamble);
                        message = "Datos eliminados correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                message = ex.ToString();
            }
            return message;
        }
        public List<EstatusModel> GetAll()
        {
            var estatusDataMosel = ensamblesRepository.GetAll();
            listEstatus = new List<EstatusModel>();
            foreach (Ensambles item in estatusDataMosel)
            {
                listEstatus.Add(new EstatusModel
                {
                    idEnsamble = item.idEnsamble,
                    idEstatus = item.idEstatus

                });
            }
            return listEstatus;

        }
    }
}
