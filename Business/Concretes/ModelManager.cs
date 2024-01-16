using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request;
using Business.Response;
using DataAccess.Abstract;
using Entities.Concretes;
namespace Business.Concretes
{
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;
        private readonly ModelBusinessRules _modelBusinessRules;
        private readonly IMapper _mapper;
        public ModelManager(IModelDal modeldal,ModelBusinessRules modelBusinessRules,IMapper mapper)
        {
            this._modelDal = modeldal;
            this._modelBusinessRules = modelBusinessRules;
            this._mapper = mapper;  
            
        }

        public AddModelResponse Add(AddModelRequest modelRequest)
        {
            _modelBusinessRules.CheckIfModelNameAlreadyExists(modelRequest.Name);

            Model model = _mapper.Map<Model>(modelRequest);         
            _modelDal.Add(model);
            AddModelResponse modelResponse = _mapper.Map<AddModelResponse>(model);
            return modelResponse;
        }
        public IList<AddModelResponse> GetList()
        {
            IList<Model> modelList = _modelDal.GetList();
            List<AddModelResponse> modelListResponse = new List<AddModelResponse>();
            foreach (Model model in modelList)
            {
                modelListResponse.Add(_mapper.Map<AddModelResponse>(model));

            }
            return modelListResponse;
        }

        public AddModelResponse GetById(int id)
        {
            Model model = _modelBusinessRules.FindModelWithId(id);
            if (model == null)
            {
                throw new Exception("Brand is not exists...");
            }
            AddModelResponse modelResponse = _mapper.Map<AddModelResponse>(model);
            return modelResponse;
        }

        public AddModelResponse Update(int id, AddModelRequest modelRequest)
        {
            Model model = _modelBusinessRules.FindModelWithId(id);
            model.Name = modelRequest.Name;
            model.UpdateAt = DateTime.Now;
            AddModelResponse modelResponse = _mapper.Map<AddModelResponse>(model);
            return modelResponse;
        }

        public AddModelResponse Delete(int id)
        {
            Model model = _modelBusinessRules.FindModelWithId(id);
            model.DeletedAt = DateTime.Now;
            AddModelResponse modelResponse = _mapper.Map<AddModelResponse>(model);
            return modelResponse;
        }


    }
}
