using DataAccess.Abstract;
using Entities.Concretes;

namespace Business.BusinessRules
{
    public class TransmissionBusinessRules
    {
        private readonly ITransmissionDal _transmissionDal;
        public TransmissionBusinessRules(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }
        public void CheckIfTransmissionNameAlreadyExists(string transmissionTypeName)
        {
            bool isExists = _transmissionDal.GetList().Any(e => e.TransmissionTypeName == transmissionTypeName);
            if (isExists)
            {
                throw new Exception("Transmission already exist...");
            }
        }
        public void CheckTransmissionTypeName(string transmissionType)
        {
            List<string> transmissionTypes = new() { "Automatic", "Manual" };
            bool isContain = transmissionTypes.Contains(transmissionType);
            if (!isContain)
            {
                throw new Exception("Invalid Transmission Type...");
            }

        }

        public Transmission FindTransmissionWithId(int id)
        {
            Transmission transmission = _transmissionDal.GetList().Where(e => e.Id == id).SingleOrDefault();
            return transmission;
        }
    }
}
