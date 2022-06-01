using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using DataAccess.Repositorios;
using Dominio.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos
{
    public class ObservacionesModel:IDisposable
    {
        private int idObs;
        private string observacion;

        private IObservacionesRepository observacionesRepository;
        public EntityState State { get; set; }
        private List<ObservacionesModel> listObservaciones;

        public int IdObs { get => idObs; set => idObs = value; }
        [Required(ErrorMessage = "El campo Observacion no puede estar Vacio")]
        public string Observaciones { get => observacion; set => observacion = value; }

        public ObservacionesModel()
        {
            observacionesRepository = new ObservacionesRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var observacionDataModel = new Observaciones();
                observacionDataModel.idObs = idObs;
                observacionDataModel.observacion = observacion;

                switch (State)
                {
                    case EntityState.Added:
                        observacionesRepository.Add(observacionDataModel);
                        message = "Observacion Agregada correctamente";
                        break;
                    case EntityState.Modifed:
                        observacionesRepository.Adit(observacionDataModel);
                        message = "Observacion Editada correctamente";
                        break;
                    case EntityState.Deleted:
                        observacionesRepository.Romove(IdObs);
                        message = "Observacion Eliminada correctamente";
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
        public List<ObservacionesModel> GetAll()
        {
            var observacionesDataModel = observacionesRepository.GetAll();
            listObservaciones = new List<ObservacionesModel>();
            foreach (Observaciones item in observacionesDataModel)
            {
                listObservaciones.Add(new ObservacionesModel
                {
                    idObs = item.idObs,
                    observacion = item.observacion

                });
            }
            return listObservaciones;
        }
        public void Dispose()
        {

        }
    }
}
