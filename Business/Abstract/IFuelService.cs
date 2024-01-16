using Business.Request;
using Business.Response;
using Entities.Concretes;

namespace Business.Abstract
{
    public interface IFuelService
    {
        public AddFuelResponse Add(AddFuelRequest addFuelRequest);
        public IList<AddFuelResponse> GetList();
        public AddFuelResponse GetById(int id);
        public AddFuelResponse Update(int id, AddFuelRequest fuelRequest);
        public AddFuelResponse Delete(int id);

    }
}
