using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concretes;
using Business.Request;
using Business.Response;
using DataAccess.Abstract;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;

namespace WebAPI
{
    public static class ServiceRegistration
    {
        public static IBrandDal BrandDal = new InMemoryBrandDal();
        public static readonly BrandBusinessRules brandBusinessRules = new BrandBusinessRules(BrandDal);
        public static IMapper Mapper => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<AddBrandRequest, Brand>();
            cfg.CreateMap<Brand, AddBrandResponse>();
            cfg.CreateMap<AddModelRequest, Model>();   
            cfg.CreateMap<Model, AddModelResponse>();
            cfg.CreateMap<AddFuelRequest, Fuel>();
            cfg.CreateMap<Fuel,AddFuelResponse>();
            cfg.CreateMap<AddTransmissionRequest, Transmission>();
            cfg.CreateMap<Transmission, AddTransmissionResponse>();
        }
        ).CreateMapper();
        public static IBrandService BrandService = new BrandManager(BrandDal,brandBusinessRules,Mapper);

        public static IModelDal ModelDal = new InMemoryModelDal();
        public static readonly ModelBusinessRules modelBusinessRules = new ModelBusinessRules(ModelDal);
        public static IModelService ModelService = new ModelManager(ModelDal, modelBusinessRules, Mapper);

        public static IFuelDal FuelDal = new InMemoryFuelDal();
        public static readonly FuelBusinessRules fuelBusinessRules = new FuelBusinessRules(FuelDal);
        public static IFuelService FuelService = new FuelManager(FuelDal, fuelBusinessRules, Mapper);

        public static ITransmissionDal TransmissionDal = new InMemoryTransmissionDal();
        public static readonly TransmissionBusinessRules transmissionBusinessRules = new TransmissionBusinessRules(TransmissionDal);
        public static ITransmissionService TransmissionService = new TransmissionManager(TransmissionDal, transmissionBusinessRules, Mapper);


    }
}
