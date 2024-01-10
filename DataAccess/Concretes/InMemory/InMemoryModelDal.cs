using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concretes;

namespace DataAccess.Concretes.InMemory
{
    internal class InMemoryModelDal : InMemoryEntityRepositoryBase<Model,int>,IModelDal
    {
    }
}
