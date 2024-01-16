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
    public class ModelController : ControllerBase
    {
        private readonly IModelService _modelService;
        public ModelController()
        {
            _modelService = ServiceRegistration.ModelService;
        }


        [HttpPost]
        public AddModelResponse Add(AddModelRequest modelRequest)
        {
            AddModelResponse modelResponse= _modelService.Add(modelRequest);

            return modelResponse;
        }
        [HttpGet]
        public ICollection<AddModelResponse> GetList()
        {
            IList<AddModelResponse> modellist = _modelService.GetList();
            return modellist;
        }


        [HttpGet("{id}")]
        public AddModelResponse GetById(int id)
        {
            AddModelResponse modelResponse = _modelService.GetById(id);
            return modelResponse;
        }
        [HttpPut("{id}")]
        public AddModelResponse Add(AddModelRequest addModelRequest, int id)
        {
            AddModelResponse modelResponse = _modelService.Update(id, addModelRequest);
            return modelResponse;
        }



        [HttpDelete("{id}")]
        public AddModelResponse Delete(int id)
        {
            AddModelResponse modelResponse = _modelService.Delete(id);
            return modelResponse;
        }


    }
}
