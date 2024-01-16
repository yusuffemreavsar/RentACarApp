using Business.Request;
using Business.Response;
using Entities.Concretes;

namespace Business.Abstract
{
    public interface IModelService
    {
        public AddModelResponse Add(AddModelRequest addModelRequest);
        public IList<AddModelResponse> GetList();
        public AddModelResponse GetById(int id);
        public AddModelResponse Update(int id, AddModelRequest modelRequest);
        public AddModelResponse Delete(int id);
    }
}
