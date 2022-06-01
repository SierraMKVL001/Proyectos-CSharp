using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contratos
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        int Add(Entity entity);
        int Adit(Entity entity);
        int Romove(int idPk);
        IEnumerable<Entity> GetAll();
    }
}
