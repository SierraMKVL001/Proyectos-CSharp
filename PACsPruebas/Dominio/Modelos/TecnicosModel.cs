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
    public class TecnicosModel:IDisposable
    {
        private int idTec;
        private int idEmplea;

        private ITecnicosRepository tecnicosRepository;
        public EntityState State { get; set; }
        private List<TecnicosModel> listTecnicos;

        public int IdTec { get => idTec; set => idTec = value; }
        [Required(ErrorMessage = "El Empleado debe ser Seleccionado")]
        public int IdEmplea { get => idEmplea; set => idEmplea = value; }

        public TecnicosModel()
        {
            tecnicosRepository = new TecnicosRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var tecnicosDataModel = new Tecnicos();
                tecnicosDataModel.idTec = idTec;
                tecnicosDataModel.idEMplea = idEmplea;
               
                switch (State)
                {
                    case EntityState.Added:
                        tecnicosRepository.Add(tecnicosDataModel);
                        message = "Datos agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        tecnicosRepository.Adit(tecnicosDataModel);
                        message = "Datos editados correctamente";
                        break;
                    case EntityState.Deleted:
                        tecnicosRepository.Romove(IdTec);
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
        public List<TecnicosModel> GetAll()
        {
            var tecnicosDataModel = tecnicosRepository.GetAll();
            listTecnicos = new List<TecnicosModel>();
            foreach (Tecnicos item in tecnicosDataModel)
            {
                listTecnicos.Add(new TecnicosModel
                {
                    idTec = item.idTec,
                    idEmplea = item.idEMplea
                   
                });
            }
            return listTecnicos;
        }
        public void Dispose()
        {

        }
    }

    
}
