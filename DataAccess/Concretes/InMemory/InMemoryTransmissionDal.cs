using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concretes;
namespace DataAccess.Concretes.InMemory
{
    public class InMemoryTransmissionDal : InMemoryEntityRepositoryBase<Transmission, int> , ITransmissionDal
    {
        protected override int generateId()
        {
            int nextId = _entities.Count == 0 ? 1 : _entities.Max(e => e.Id) + 1;
            return nextId;
        }
    }
}
