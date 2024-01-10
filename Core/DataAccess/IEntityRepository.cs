namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity,TId>
    {
        IList<TEntity> GetList();
        TEntity? GetById(TId id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
