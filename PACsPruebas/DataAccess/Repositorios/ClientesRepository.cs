using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class ClientesRepository : MasterRepository, IClientesRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public ClientesRepository()
        {
            selectAll = "select *from Clientes";
            insert = "insert into Clientes values(@Nombre,@telefono,@correo,@direccion,@rfc)";
            update = "update Clientes set Nombre_RazonSocial=@Nombre,Telefono=@telefono,CorreoEl=@correo,Direccion=@direccion,RFC=@rfc where idClient=@idClient";
            delete = "delete from Clientes where idClient=@idClient";
        }
        public int Add(Clientes entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Nombre",entity.nombre_RazonSocial));
            parameters.Add(new SqlParameter("@telefono", entity.telefono));
            parameters.Add(new SqlParameter("@correo", entity.correoEL));
            parameters.Add(new SqlParameter("@direccion", entity.direccion));
            parameters.Add(new SqlParameter("@rfc", entity.rFC));
            return ExecuteNonQuery(insert);
        }

        public int Adit(Clientes entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idClient", entity.idClient));
            parameters.Add(new SqlParameter("@Nombre", entity.nombre_RazonSocial));
            parameters.Add(new SqlParameter("@telefono", entity.telefono));
            parameters.Add(new SqlParameter("@correo", entity.correoEL));
            parameters.Add(new SqlParameter("@direccion", entity.direccion));
            parameters.Add(new SqlParameter("@rfc", entity.rFC));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Clientes> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listClientes = new List<Clientes>();
            foreach(DataRow item in tableResult.Rows)
            {
                listClientes.Add(new Clientes
                {
                    idClient = Convert.ToInt32(item[0]),
                    nombre_RazonSocial = item[1].ToString(),
                    telefono = item[2].ToString(),
                    correoEL = item[3].ToString(),
                    direccion = item[4].ToString(),
                    rFC = item[5].ToString()
                } );
            }
            return listClientes;
        }

        public int Romove(int idClient)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idClient", idClient));
            return ExecuteNonQuery(delete);
        }
    }
}
