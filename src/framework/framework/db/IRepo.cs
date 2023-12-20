using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.db
{

    // IRepository.cs
    public interface IRepository<T>
    {
        T[] FindAll();
        T FindOneById(string id);
        bool Save(T entity);
        bool Delete(T entity);
    }
}
