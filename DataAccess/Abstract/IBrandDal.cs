using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand,int>
    {
    }
}
