
using Core.Entities;

namespace Core.DataAccess.InMemory
{
    public abstract class InMemoryEntityRepositoryBase<TEntity, TId> : IEntityRepository<TEntity, TId>
        where TEntity : class,IEntity<TId>,new()
    {
        protected readonly HashSet<TEntity> _entities = new();
        protected abstract TId generateId(); 
        public void Add(TEntity entity)
        {
            entity.Id=generateId(); 
            entity.CreatedAt = DateTime.Now;
            _entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.DeletedAt = DateTime.Now;
        }

        public TEntity? GetById(TId id)
        {
            TEntity entity = _entities.FirstOrDefault(e => e.Id.Equals(id) && e.DeletedAt.HasValue==false);
            return entity;
        }

        public IList<TEntity> GetList()
        {
          
            IList<TEntity> entities = _entities.Where(e => e.DeletedAt.HasValue == false).ToList();
            return entities;
        }

        public void Update(TEntity entity)
        {
            entity.UpdateAt = DateTime.Now; 
        }
    }
}
