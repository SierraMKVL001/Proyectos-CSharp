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
    public class ClientesModel:IDisposable
    {
        private int idClient;
        private string nombre_RazonSocial;
        private string telefono;
        private string correoEL;
        private string direccion;
        private string rFC;

        private IClientesRepository clientesRepository;
        public EntityState State { private get; set; }
        private List<ClientesModel> listClientes;

        //Propiedades/ModeloVista
        public int IdClient { get => idClient; set => idClient = value; }
        [Required(ErrorMessage = "El Nombre o Razon Social del cliente es requerido")]
        public string Nombre_RazonSocial { get => nombre_RazonSocial; set => nombre_RazonSocial = value; }
        [Required(ErrorMessage = "El Telefono del cliente es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo Telefono solo puede contener Numeros")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "El campo Telefono solo puede tener 10 digitos")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Required(ErrorMessage = "El Correo Electronico del cliente es requerido")]
        [EmailAddress]
        public string CorreoEL { get => correoEL; set => correoEL = value; }
        [Required(ErrorMessage = "La Direccion del cliente es requerida")]
        public string Direccion { get => direccion; set => direccion = value; }
        [Required(ErrorMessage = "El RFC del cliente es requerido")]
        public string RFC { get => rFC; set => rFC = value; }

        public ClientesModel()
        {
            clientesRepository = new ClientesRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var clientesDataModel = new Clientes();
                clientesDataModel.idClient = idClient;
                clientesDataModel.nombre_RazonSocial = nombre_RazonSocial;
                clientesDataModel.telefono = telefono;
                clientesDataModel.correoEL = correoEL;
                clientesDataModel.direccion = direccion;
                clientesDataModel.rFC = rFC;
                switch (State)
                {
                    case EntityState.Added:
                        clientesRepository.Add(clientesDataModel);
                        message = "Datos agregados correctamente";
                        break;
                    case EntityState.Modifed:
                        clientesRepository.Adit(clientesDataModel);
                        message = "Datos editados correctamente";
                        break;
                    case EntityState.Deleted:
                        clientesRepository.Romove(idClient);
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
        public List<ClientesModel> GetAll()
        {
            var clienteDataModel = clientesRepository.GetAll();
            listClientes = new List<ClientesModel>();
            foreach (Clientes item in clienteDataModel)
            {
                listClientes.Add(new ClientesModel
                {
                    idClient = item.idClient,
                    nombre_RazonSocial = item.nombre_RazonSocial,
                    telefono = item.telefono,
                    correoEL = item.correoEL,
                    direccion = item.direccion,
                    rFC = item.rFC
                });
            }
            return listClientes;
        }
        public IEnumerable<ClientesModel> FindById(string filter)
        {
            return listClientes.FindAll(c => c.Nombre_RazonSocial.Contains(filter) || c.RFC.Contains(filter));
        }

        public void Dispose()
        {

        }
    }
}
