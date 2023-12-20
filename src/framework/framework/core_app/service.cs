using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using framework.db;
namespace framework.core_app
{
    public class AppService<TEntity> : IServiceApp<TEntity>
    {
        private readonly IRepository<TEntity> _appRepository;


        public AppService(IRepository<TEntity> repository)
        {
            _appRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public void create(TEntity entity)
        {
            Console.WriteLine("create");
        }
        public void read(TEntity entity)
        {
            Console.WriteLine("read");

        }
        public void delete(TEntity entity)
        {
            Console.WriteLine("delete");

        }
        public void update(TEntity entity)
        {
            Console.WriteLine("update");

        }

    }
}
