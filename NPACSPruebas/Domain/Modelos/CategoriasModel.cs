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
    public class CategoriasModel : IDisposable
    {
        private int idC;
        private string categoria;

        private ICategoriasRepository categoriasRepository;
        public EntityState State { get; set; }
        private List<CategoriasModel> listCategorias;

        public int IdC { get => idC; set => idC = value; }
        [Required(ErrorMessage = "El campo Categoria no puede estar Vacio")]
        public string Categoria { get => categoria; set => categoria = value; }

        public CategoriasModel()
        {
            categoriasRepository = new CategoriasRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var categoriasDataModel = new Categorias();
                categoriasDataModel.idC = idC;
                categoriasDataModel.categoria = categoria;

                switch (State)
                {
                    case EntityState.Added:
                        categoriasRepository.Add(categoriasDataModel);
                        message = "Categoria agregada correctamente";
                        break;
                    case EntityState.Modifed:
                        categoriasRepository.Adit(categoriasDataModel);
                        message = "Categoria editada correctamente";
                        break;
                    case EntityState.Deleted:
                        categoriasRepository.Romove(IdC);
                        message = "Categoria eliminada correctamente";
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
        public List<CategoriasModel> GetAll()
        {
            var categoriasDataModel = categoriasRepository.GetAll();
            listCategorias = new List<CategoriasModel>();
            foreach (Categorias item in categoriasDataModel)
            {
                listCategorias.Add(new CategoriasModel
                {
                    idC = item.idC,
                    categoria = item.categoria

                });
            }
            return listCategorias;
        }
        public void Dispose()
        {

        }
    }
}
