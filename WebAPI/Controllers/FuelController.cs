using Business.Abstract;
using Business.Request;
using Business.Response;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : Controller
    {


        private readonly IFuelService _fuelService;
        public FuelController()
        {
            _fuelService = ServiceRegistration.FuelService;


        }
        [HttpGet]
        public ICollection<AddFuelResponse> GetList()
        {
            IList<AddFuelResponse> fuellist = _fuelService.GetList();
            return fuellist;
        }


        [HttpGet("{id}")]
        public AddFuelResponse GetById(int id)
        {
            AddFuelResponse fuelResponse = _fuelService.GetById(id);
            return fuelResponse;
        }
        [HttpPut("{id}")]
        public AddFuelResponse Add(AddFuelRequest addBrandRequest, int id)
        {
            AddFuelResponse fuelResponse = _fuelService.Update(id, addBrandRequest);
            return fuelResponse;
        }


        [HttpPost]
        public AddFuelResponse Add(AddFuelRequest addFuelRequest)
        {
            AddFuelResponse fuelResponse = _fuelService.Add(addFuelRequest);
            return fuelResponse;
        }
        [HttpDelete("{id}")]
        public AddFuelResponse Delete(int id)
        {
            AddFuelResponse fuelResponse = _fuelService.Delete(id);
            return fuelResponse;
        }


    }
}
