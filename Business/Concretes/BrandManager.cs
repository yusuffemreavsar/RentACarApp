using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concretes;
using System.Collections.Generic;
namespace Business.Concretes
{
    internal class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
       
        public Brand Add(Brand brand)
        {
            _brandDal.Add(brand);
            return brand;
        }

        public IList<Brand> GetList()
        {
            IList<Brand> brandList = _brandDal.GetList();
            return brandList;
        }
    }
}
