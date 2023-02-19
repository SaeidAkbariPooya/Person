using Microsoft.EntityFrameworkCore;

namespace MiniPerson.Infrastructure.Patterns
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(long id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);

        //DbSet<TEntity> Entities { get; }
        //IQueryable<TEntity> Table { get; }
        //IQueryable<TEntity> TableNoTracking { get; }

        //List<string> GetKey();

        //void EnableIdentityInsert();
        //void DisableIdentityInsert();
        //void Add(TEntity entity, bool saveNow = true, bool noAudit = false);
        //Task AddAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true, bool noAudit = false);
        //void AddRange(IEnumerable<TEntity> entities, bool saveNow = true, bool noAudit = false);
        //Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true, bool noAudit = false);
        //void Attach(TEntity entity);
        //void Delete(TEntity entity, bool saveNow = true, bool noAudit = false);
        //Task DeleteAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true, bool noAudit = false);
        //void DeleteRange(IEnumerable<TEntity> entities, bool saveNow = true, bool noAudit = false);
        //Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true, bool noAudit = false);
        //void Detach(TEntity entity);
        //TEntity GetById(params object[] ids);
        //Task<TEntity> GetByIdAsync(CancellationToken cancellationToken, params object[] ids);


        //void LoadCollection<TProperty>(TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> collectionProperty) where TProperty : class;
        //Task LoadCollectionAsync<TProperty>(TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> collectionProperty, CancellationToken cancellationToken) where TProperty : class;
        //void LoadReference<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> referenceProperty) where TProperty : class;
        //Task LoadReferenceAsync<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> referenceProperty, CancellationToken cancellationToken) where TProperty : class;
        //void Update(TEntity entity, bool saveNow = true, bool noAudit = false);
        //Task UpdateAsync(TEntity entity, CancellationToken cancellationToken, bool saveNow = true, bool noAudit = false);
        //void UpdateRange(IEnumerable<TEntity> entities, bool saveNow = true, bool noAudit = false);
        //Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken, bool saveNow = true, bool noAudit = false);
    }
}
