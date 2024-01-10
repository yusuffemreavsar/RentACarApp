using Core.DataAccess;
using Entities.Concretes;


namespace DataAccess.Abstract
{
    public interface IModelDal :IEntityRepository<Model,int>
    {
    }
}
