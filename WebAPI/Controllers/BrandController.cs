using Business.Abstract;
using Business.Request;
using Business.Response;
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
        [HttpPost]
        public AddBrandResponse Add(AddBrandRequest addBrandRequest)
        {
            AddBrandResponse brandResponse = _brandService.Add(addBrandRequest);
            return brandResponse;
        }
        [HttpGet]
        public ICollection<AddBrandResponse> GetList()
        {
            IList<AddBrandResponse> brandlist = _brandService.GetList();
            return brandlist;
        }


        [HttpGet("{id}")]
        public AddBrandResponse GetById(int id)
        {
            AddBrandResponse brandResponse = _brandService.GetById(id);
            return brandResponse;
        }
        [HttpPut("{id}")]
        public AddBrandResponse Add(AddBrandRequest addBrandRequest,int id)
        {
            AddBrandResponse brandResponse = _brandService.Update(id, addBrandRequest);
            return brandResponse;
        }


       
        [HttpDelete("{id}")]
        public AddBrandResponse Delete(int id)
        {
            AddBrandResponse brandResponse = _brandService.Delete(id);
            return brandResponse;
        }

    }
}
