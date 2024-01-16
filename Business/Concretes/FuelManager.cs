using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request;
using Business.Response;
using DataAccess.Abstract;
using Entities.Concretes;

namespace Business.Concretes
{
    public class FuelManager:IFuelService
    {
        private IFuelDal _fuelDal;
        private FuelBusinessRules _fuelBusinessRules;
        private IMapper _mapper;

        public FuelManager(IFuelDal fuelDal,FuelBusinessRules fuelBusinessRules,IMapper mapper)
        {
            this._fuelDal = fuelDal;
            this._mapper = mapper;
            this._fuelBusinessRules = fuelBusinessRules;
        }

        public AddFuelResponse Add(AddFuelRequest addFuelRequest)
        {
            _fuelBusinessRules.CheckFuelTypeName(addFuelRequest.FuelTypeName);
            _fuelBusinessRules.CheckIfBrandNameAlreadyExists(addFuelRequest.FuelTypeName);
            Fuel fuel= _mapper.Map<Fuel>(addFuelRequest);
            _fuelDal.Add(fuel);
            AddFuelResponse addFuelResponse = _mapper.Map<AddFuelResponse>(fuel);
            return addFuelResponse;
        }

        public AddFuelResponse Delete(int id)
        {
            Fuel fuel = _fuelBusinessRules.FindFuelWithId(id);
            fuel.DeletedAt = DateTime.Now;
            AddFuelResponse fuelResponse = _mapper.Map<AddFuelResponse>(fuel);
            return fuelResponse;
        }

        public AddFuelResponse GetById(int id)
        {
            Fuel fuel = _fuelBusinessRules.FindFuelWithId(id);
            if (fuel == null)
            {
                throw new Exception("Fuel is not exists...");
            }
            AddFuelResponse fuelResponse = _mapper.Map<AddFuelResponse>(fuel);
            return fuelResponse;
        }

        public IList<AddFuelResponse> GetList()
        {
            IList<Fuel> fuelList = _fuelDal.GetList();
            List<AddFuelResponse> fuelListResponse = new List<AddFuelResponse>();
            foreach (Fuel model in fuelList)
            {
                fuelListResponse.Add(_mapper.Map<AddFuelResponse>(model));

            }
            return fuelListResponse;
        }

        public AddFuelResponse Update(int id, AddFuelRequest fuelRequest)
        {
            Fuel fuel = _fuelBusinessRules.FindFuelWithId(id);
            fuel.FuelTypeName = fuelRequest.FuelTypeName;
            fuel.UpdateAt = DateTime.Now;
            AddFuelResponse fuelResponse = _mapper.Map<AddFuelResponse>(fuel);
            return fuelResponse;
        }
    }
}
