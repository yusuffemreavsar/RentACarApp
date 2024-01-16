using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request;
using Business.Response;
using DataAccess.Abstract;
using Entities.Concretes;
namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        private readonly BrandBusinessRules _brandBusinessRules;
        private readonly IMapper _mapper;
        public BrandManager(IBrandDal brandDal,BrandBusinessRules brandBusinessRules,IMapper mapper)
        {
            _brandDal = brandDal;
            _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
        }
       
        public AddBrandResponse Add(AddBrandRequest brandRequest)
        {
            _brandBusinessRules.CheckIfBrandNameAlreadyExists(brandRequest.Name);

            Brand brandToAdd = _mapper.Map<Brand>(brandRequest);
            _brandDal.Add(brandToAdd);
            AddBrandResponse brandResponse = _mapper.Map<AddBrandResponse>(brandToAdd);
            return brandResponse;
        }

        public IList<AddBrandResponse> GetList()
        {
            IList<Brand> brandList = _brandDal.GetList();
            List<AddBrandResponse> brandResponseList=new List<AddBrandResponse>();
            foreach (Brand brand in brandList)
            {
                brandResponseList.Add(_mapper.Map<AddBrandResponse>(brand)) ;
                
            }
            return brandResponseList;
        }

        public AddBrandResponse GetById(int id)
        {
            Brand brand=_brandBusinessRules.FindBrandWithId(id);
            if(brand == null)
            {
                throw new Exception("Brand is not exists...");
            }
            AddBrandResponse brandResponse = _mapper.Map<AddBrandResponse>(brand);
            return brandResponse;
        }

        public AddBrandResponse Update(int id, AddBrandRequest brandRequest)
        {
            Brand brand = _brandBusinessRules.FindBrandWithId(id);
            brand.Name=brandRequest.Name;
            brand.UpdateAt = DateTime.Now;
            AddBrandResponse brandResponse = _mapper.Map<AddBrandResponse>(brand);
            return brandResponse;
        }

        public AddBrandResponse Delete(int id)
        {
            Brand brand = _brandBusinessRules.FindBrandWithId(id);
            brand.DeletedAt = DateTime.Now;
            AddBrandResponse brandResponse = _mapper.Map<AddBrandResponse>(brand);
            return brandResponse;
        }
    }
}
