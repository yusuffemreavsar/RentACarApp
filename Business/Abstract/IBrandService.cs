using Entities.Concretes;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public Brand Add(Brand brand);
        public IList<Brand> GetList();
    }
}
