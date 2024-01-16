using DataAccess.Abstract;
using Entities.Concretes;

namespace Business.BusinessRules
{
    public class BrandBusinessRules
    {
        private readonly IBrandDal _branDal;
        public BrandBusinessRules(IBrandDal branDal)
        {
            _branDal = branDal;
        }
        public void CheckIfBrandNameAlreadyExists(string brandName)
        {
            bool isExists = _branDal.GetList().Any(e=>e.Name == brandName);
            if (isExists)
            {
                throw new Exception("Brand already exist...");
            }
        }

        public Brand FindBrandWithId(int id)
        {
            Brand brand = _branDal.GetList().Where(e=>e.Id == id).SingleOrDefault();
            return brand;
        }
    }
}
