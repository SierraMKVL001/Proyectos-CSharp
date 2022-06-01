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
    public class MarcasModel:IDisposable
    {
        private int idM;
        private string marca;

        private IMarcasRepository marcasRepository;
        public EntityState State { get; set; }
        private List<MarcasModel> listMarcas;

        public int IdM { get => idM; set => idM = value; }
        [Required(ErrorMessage = "El campo Marca no puede estar Vacio")]
        public string Marca { get => marca; set => marca = value; }

        public MarcasModel()
        {
            marcasRepository = new MarcasRepositry();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var marcasDataModel = new Marcas();
                marcasDataModel.idM = idM;
                marcasDataModel.marca = marca;

                switch (State)
                {
                    case EntityState.Added:
                        marcasRepository.Add(marcasDataModel);
                        message = "Datos Agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        marcasRepository.Adit(marcasDataModel);
                        message = "Datos Editados correctamente";
                        break;
                    case EntityState.Deleted:
                        marcasRepository.Romove(IdM);
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
        public List<MarcasModel> GetAll()
        {
            var marcasDataModel = marcasRepository.GetAll();
            listMarcas = new List<MarcasModel>();
            foreach (Marcas item in marcasDataModel)
            {
                listMarcas.Add(new MarcasModel
                {
                    idM = item.idM,
                    marca = item.marca

                });
            }
            return listMarcas;
        }
        public void Dispose()
        {

        }
    }
}
