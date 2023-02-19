

using Microsoft.EntityFrameworkCore;
using MiniPerson.Infrastructure.DataBase.Context;

namespace MiniPerson.Infrastructure.Patterns
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        protected readonly PersonDbContext DbContext;
        public DbSet<T> Entities { get; }
        public Repository(PersonDbContext dbContext)
        {
            DbContext = dbContext;
            Entities = DbContext.Set<T>(); // City => Cities
        }
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
