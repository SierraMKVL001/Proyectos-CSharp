using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contratos;
using DataAccess.Entidades;
using DataAccess.Repositorios;
using Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Domain.Modelos
{
    public class PendientesModel:IDisposable
    {
        private int idDet_Ens;
        private string NumSerie;

        private IDetalleEnsambleRepository detalleEnsambleRepository;
        public EntityState State { get; set; }
        private List<PendientesModel> listPendientes;

        public int IdDet_Ens { get => idDet_Ens; set => idDet_Ens = value; }
        [Required(ErrorMessage = "El Numero de Serie del Producto es requerido")]
        public string NumSerie1 { get => NumSerie; set => NumSerie = value; }

        public PendientesModel()
        {
            detalleEnsambleRepository = new PendientesRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var pendientesDataModel = new DetalleEnsambles();
                pendientesDataModel.idDet_Ens = idDet_Ens;
                pendientesDataModel.NumSerie = NumSerie;

                switch (State)
                {
                    case EntityState.Added:
                        detalleEnsambleRepository.Add(pendientesDataModel);
                        message = "Datos agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        detalleEnsambleRepository.Adit(pendientesDataModel);
                        message = "Numero de Serie Asignado Correctamente";
                        break;
                    case EntityState.Deleted:
                        detalleEnsambleRepository.Romove(IdDet_Ens);
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
        public List<PendientesModel> GetAll()
        {
            var pendDataModel = detalleEnsambleRepository.GetAll();
            listPendientes = new List<PendientesModel>();
            foreach (DetalleEnsambles item in pendDataModel)
            {
                listPendientes.Add(new PendientesModel
                {
                    idDet_Ens = item.idDet_Ens,
                    NumSerie = item.NumSerie,

                });
            }
            return listPendientes;

        }

        public void Dispose()
        {

        }
    }
}
