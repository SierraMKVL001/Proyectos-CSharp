using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class EmpleadosRepositry : MasterRepository, IEmpleadosRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public EmpleadosRepositry()
        {
            selectAll = "select *from Empleados";
            insert = "insert into Empleados values(@nombres,@apellidos,@logname,@pass,@email,@idpuesto)";
            update = "update Empleados set Nombres=@nombres,Apellidos=@apellidos,LogName=@logname,Email=@email,idPuesto=@idpuesto where idEmp=@idEmp";
            delete = "delete from Empleados where idEmp=@idEmp";
        }

        public int Add(Empleados entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nombres", entity.nombres));
            parameters.Add(new SqlParameter("@apellidos", entity.apellidos));
            parameters.Add(new SqlParameter("@logname", entity.logName));
            parameters.Add(new SqlParameter("@pass", entity.pass));
            parameters.Add(new SqlParameter("@email", entity.email));
            parameters.Add(new SqlParameter("@idpuesto", entity.idPuesto));
            return ExecuteNonQuery(insert);
        }

        public int Adit(Empleados entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idEmp", entity.idEmp));
            parameters.Add(new SqlParameter("@nombres", entity.nombres));
            parameters.Add(new SqlParameter("@apellidos", entity.apellidos));
            parameters.Add(new SqlParameter("@logname", entity.logName));
            parameters.Add(new SqlParameter("@email", entity.email));
            parameters.Add(new SqlParameter("@idpuesto", entity.idPuesto));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Empleados> GetAll()
        {
            var tableResult = ExecuterReader(selectAll);
            var listEmpleados = new List<Empleados>();
            foreach (DataRow item in tableResult.Rows)
            {
                listEmpleados.Add(new Empleados
                {
                    idEmp = Convert.ToInt32(item[0]),
                    nombres = item[1].ToString(),
                    apellidos = item[2].ToString(),
                    logName = item[3].ToString(),
                    email=item[4].ToString(),
                    idPuesto = Convert.ToInt32(item[5])
                    

                });
            }
            return listEmpleados;
        }

        public int Romove(int idEmp)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idEmp", idEmp));
            return ExecuteNonQuery(delete);
        }
    }
}
