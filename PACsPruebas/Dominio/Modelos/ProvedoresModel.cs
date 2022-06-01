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
    public class ProvedoresModel:IDisposable
    {
        private int idProv;
        private string provedor;

        private IProvedoresRepository provedoresRepository;
        public EntityState State { get; set; }
        private List<ProvedoresModel> listProvedores;

        public int IdProv { get => idProv; set => idProv = value; }
        [Required(ErrorMessage = "El campo Provedor no puede estar Vacio")]
        public string Provedor { get => provedor; set => provedor = value; }

        public ProvedoresModel()
        {
            provedoresRepository = new ProvedoresRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var provedoresDataModel = new Provedores();
                provedoresDataModel.idProv = idProv;
                provedoresDataModel.provedor = provedor;

                switch (State)
                {
                    case EntityState.Added:
                        provedoresRepository.Add(provedoresDataModel);
                        message = "Datos Agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        provedoresRepository.Adit(provedoresDataModel);
                        message = "Datos Editados correctamente";
                        break;
                    case EntityState.Deleted:
                        provedoresRepository.Romove(IdProv);
                        message = "Datos Eliminados correctamente";
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
        public List<ProvedoresModel> GetAll()
        {
            var provedoresDataModel = provedoresRepository.GetAll();
            listProvedores = new List<ProvedoresModel>();
            foreach (Provedores item in provedoresDataModel)
            {
                listProvedores.Add(new ProvedoresModel
                {
                    idProv = item.idProv,
                    provedor = item.provedor

                });
            }
            return listProvedores;
        }
        public void Dispose()
        {

        }
    }
}
