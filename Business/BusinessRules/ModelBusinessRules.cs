using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class ModelBusinessRules
    {
        private readonly IModelDal _modelDal;
        public ModelBusinessRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public void CheckIfModelNameAlreadyExists(string modelName)
        {
            bool isExists = _modelDal.GetList().Any(e => e.Name == modelName);
            if (isExists)
            {
                throw new Exception("Model already exist...");
            }
        }

        public Model FindModelWithId(int id)
        {
            Model model = _modelDal.GetList().Where(e => e.Id == id).SingleOrDefault();
            return model;
        }
    }
}
