using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.db
{
    public class Repository<T> : IRepository<T>
    {
        private IDatabase _database;
        public Repository(IDatabase database)
        {
            _database = database;
        }
        public T[] FindAll()
        {
            // Implement the logic to find all entities
            throw new NotImplementedException();
        }

        public T FindOneById(string id)
        {
            // Implement the logic to find an entity by id
            throw new NotImplementedException();
        }

        public bool Save(T entity)
        {
            // Implement the logic to save an entity
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            // Implement the logic to delete an entity
            throw new NotImplementedException();
        }
    }
}