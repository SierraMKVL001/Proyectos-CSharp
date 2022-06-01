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
    public class EmpleadosModel:IDisposable
    {
        private int idEmp;
        private string nombres;
        private  string apellidos;
        private string logName;
        private string pass;
        private string email;
        private int idPuesto;

        private IEmpleadosRepository empleadosRepositry;
        public EntityState State { private get; set; }
        private List<EmpleadosModel> listEmpleados;

        public int IdEmp { get => idEmp; set => idEmp = value; }
        [Required(ErrorMessage = "El Nombre del Empleado es requerido")]
        public string Nombres { get => nombres; set => nombres = value; }
        [Required(ErrorMessage = "Los Apellidos del Empleado son requeridos")]
        public string Apellidos { get => apellidos; set => apellidos = value; }
        [Required(ErrorMessage = "Nombre de Usuario requerido")]
        public string LogName { get => logName; set => logName = value; }
        public string Pass { get => pass; set => pass = value; }
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress]
        public string Email { get => email; set => email = value; }
        [Required(ErrorMessage = "Puesto del Empleado Requerido")]
        public int IdPuesto { get => idPuesto; set => idPuesto = value; }

        public EmpleadosModel()
        {
            empleadosRepositry = new EmpleadosRepositry();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var empleadosDataModel = new Empleados();
                empleadosDataModel.idEmp = idEmp;
                empleadosDataModel.nombres = nombres;
                empleadosDataModel.apellidos = apellidos;
                empleadosDataModel.logName = logName;
                empleadosDataModel.pass = pass;
                empleadosDataModel.email = email;
                empleadosDataModel.idPuesto = idPuesto;
                switch (State)
                {
                    case EntityState.Added:
                        empleadosRepositry.Add(empleadosDataModel);
                        message = "Usuario Agegado correctamente";
                        break;
                    case EntityState.Modifed:
                        empleadosRepositry.Adit(empleadosDataModel);
                        message = "Usuario Editado correctamente";
                        break;
                    case EntityState.Deleted:
                        empleadosRepositry.Romove(idEmp);
                        message = "Usuario Eliminado correctamente";
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
        public List<EmpleadosModel> GetAll()
        {
            var empleadosDataModel = empleadosRepositry.GetAll();
            listEmpleados = new List<EmpleadosModel>();
            foreach(Empleados item in empleadosDataModel)
            {
                listEmpleados.Add(new EmpleadosModel{
                    idEmp = item.idEmp,
                    nombres = item.nombres,
                    apellidos = item.apellidos,
                    logName=item.logName,
                    pass=item.pass,
                    email=item.email,
                    idPuesto=item.idPuesto
                });
            }
            return listEmpleados;

        }

        public void Dispose()
        {

        }
    }
    
    
}
