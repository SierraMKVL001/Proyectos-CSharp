using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using DataAccess.Repositorios;
using Dominio.ValueObjects;

namespace Dominio.Modelos
{
    public class AsigTecEnsamblesModel
    {
        private int idEnsamble;
        private int idTecnico;
        private int idEstatus;

        private IEnsamblesRepository ensamblesRepository;
        public EntityState State { get; set; }
        private List<AsigTecEnsamblesModel> listasigtec;
        public int IdEnsamble { get => idEnsamble; set => idEnsamble = value; }
        public int IdTecnico { get => idTecnico; set => idTecnico = value; }
        public int IdEstatus { get => idEstatus; set => idEstatus = value; }
        public AsigTecEnsamblesModel()
        {
            ensamblesRepository = new AsigTecEnsamblesRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var asigTecDataModel = new Ensambles();
                asigTecDataModel.idEnsamble = idEnsamble;
                asigTecDataModel.idTecnico = idTecnico;
                asigTecDataModel.idEstatus = idEstatus;


                switch (State)
                {
                    case EntityState.Added:
                        ensamblesRepository.Add(asigTecDataModel);
                        message = "Datos agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        ensamblesRepository.Adit(asigTecDataModel);
                        message = "El Tecnico se han asignado al Ensamble Correctamente";
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
        public List<AsigTecEnsamblesModel> GetAll()
        {
            var asigTecDataModel = ensamblesRepository.GetAll();
            listasigtec = new List<AsigTecEnsamblesModel>();
            foreach (Ensambles item in asigTecDataModel)
            {
                listasigtec.Add(new AsigTecEnsamblesModel
                {
                    idEnsamble = item.idEnsamble,
                    idTecnico = item.idTecnico,
                    idEstatus = item.idEstatus

                });
            }
            return listasigtec;

        }
    }
}
