using Business.Request;
using Business.Response;
using Entities.Concretes;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public AddBrandResponse Add(AddBrandRequest brandRequest);
        public IList<AddBrandResponse> GetList();
        public AddBrandResponse GetById(int id);
        public AddBrandResponse Update(int id, AddBrandRequest brandRequest);
        public AddBrandResponse Delete(int id);

    }
}
