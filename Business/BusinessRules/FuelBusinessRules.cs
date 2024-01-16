using DataAccess.Abstract;
using Entities.Concretes;
using System.Linq;

namespace Business.BusinessRules
{
    public class FuelBusinessRules
    {
        private readonly IFuelDal _fuelDal;
        public FuelBusinessRules(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }
        public void CheckIfBrandNameAlreadyExists(string fuelTypeName)
        {
            bool isExists = _fuelDal.GetList().Any(e => e.FuelTypeName == fuelTypeName);
            if (isExists)
            {
                throw new Exception("Fuel already exist...");
            }
        }
        public void CheckFuelTypeName(string fuelType)
        {
            List<string> fuelTypes = new() { "Gasoline", "Diesel", "Gas","Electric" };
            bool isContain=fuelTypes.Contains(fuelType);
            if(!isContain)
            {
                throw new Exception("Invalid Fuel Type...");
            }

        }

        public Fuel FindFuelWithId(int id)
        {
            Fuel fuel = _fuelDal.GetList().Where(e => e.Id == id).SingleOrDefault();
            return fuel;
        }
    }
}
