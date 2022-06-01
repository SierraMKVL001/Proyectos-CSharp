using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contratos
{
    public interface IGenericRepository<Entity>where Entity :class
    {
        int Add(Entity entity);
        int Adit(Entity entity);
        int Romove(int idPk);
        IEnumerable<Entity> GetAll();
    }
}
