using Entities.Concretes;

namespace Business.Abstract
{
    internal interface IBrandService
    {
        public Brand Add(Brand brand);
        public IList<Brand> GetList();
    }
}
