using Business.Abstract;
using Business.Concretes;
using DataAccess.Abstract;
using DataAccess.Concretes.InMemory;

namespace WebAPI
{
    public static class ServiceRegistration
    {
        public static IBrandDal BrandDal = new InMemoryBrandDal();
        public static IBrandService BrandService = new BrandManager(BrandDal);
    }
}
