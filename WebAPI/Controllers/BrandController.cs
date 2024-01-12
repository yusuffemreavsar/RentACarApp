using Business.Abstract;
using Business.Concretes;
using DataAccess.Abstract;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController()
        {
            _brandService = ServiceRegistration.BrandService;
           
        }
        [HttpGet]
        public ICollection<Brand> GetList()
        {
            IList<Brand> brandlist = _brandService.GetList();
            return brandlist;
        }
        [HttpPost]
        public Brand GetList(Brand addBrand)
        {
            Brand brand = _brandService.Add(addBrand);
            return brand;
        }

    }
}
