using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concretes;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryBrandDal :InMemoryEntityRepositoryBase<Brand,int>, IBrandDal
    {
        
    }
}
