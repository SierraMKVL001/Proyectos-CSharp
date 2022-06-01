using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using DataAccess.Repositorios;
using Dominio.ValueObjects;


namespace Dominio.Modelos
{
    public class PzasAsigModel
    {
        private int idEnsamble;
        private int idOrdeno;
        private int idEstatus;

        private IEnsamblesRepository ensamblesRepository;
        public EntityState State { get; set; }
        private List<PzasAsigModel> listPzasAsig;

        public int IdEnsamble { get => idEnsamble; set => idEnsamble = value; }
        public int IdOrdeno { get => idOrdeno; set => idOrdeno = value; }
        public int IdEstatus { get => idEstatus; set => idEstatus = value; }

        public PzasAsigModel()
        {
            ensamblesRepository = new PzasAsigRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var pzasDataModel = new Ensambles();
                pzasDataModel.idEnsamble = idEnsamble;
                pzasDataModel.idOrdeno = idOrdeno;
                pzasDataModel.idEstatus = idEstatus;


                switch (State)
                {
                    case EntityState.Added:
                        ensamblesRepository.Add(pzasDataModel);
                        message = "Datos agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        ensamblesRepository.Adit(pzasDataModel);
                        message = "Las Piezas se han asignado al Ensamble Correctamente";
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
        public List<PzasAsigModel> GetAll()
        {
            var pzasDataModel = ensamblesRepository.GetAll();
            listPzasAsig = new List<PzasAsigModel>();
            foreach (Ensambles item in pzasDataModel)
            {
                listPzasAsig.Add(new PzasAsigModel
                {
                    idEnsamble = item.idEnsamble,
                    idOrdeno = item.idOrdeno,
                    idEstatus=item.idEstatus

                });
            }
            return listPzasAsig;

        }
    }
}
