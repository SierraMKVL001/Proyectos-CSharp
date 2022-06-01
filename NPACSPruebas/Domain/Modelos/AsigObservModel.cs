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
    public class AsigObservModel
    {
        private int idEnsamble;
        private int idObser;

        private IEnsamblesRepository ensamblesRepository;
        public EntityState State { get; set; }
        public int IdEnsamble { get => idEnsamble; set => idEnsamble = value; }
        public int IdObser { get => idObser; set => idObser = value; }
        private List<AsigObservModel> listasigObs;

        public AsigObservModel()
        {
            ensamblesRepository = new AsigObservRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var asigObserdataModel = new Ensambles();
                asigObserdataModel.idEnsamble = idEnsamble;
                asigObserdataModel.idObser = idObser;
                switch (State)
                {
                    case EntityState.Added:
                        ensamblesRepository.Add(asigObserdataModel);
                        message = "Datos agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        ensamblesRepository.Adit(asigObserdataModel);
                        message = "La nueva Observacion fue agregada al Ensamble Correctamente";
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
        public List<AsigObservModel> GetAll()
        {
            var asigTecDataModel = ensamblesRepository.GetAll();
            listasigObs = new List<AsigObservModel>();
            foreach (Ensambles item in asigTecDataModel)
            {
                listasigObs.Add(new AsigObservModel
                {
                    idEnsamble = item.idEnsamble,
                    idObser = item.idObser

                });
            }
            return listasigObs;

        }
    }
}
