using Core.Entities;


namespace Entities.Concretes
{
    public class Model : Entity<int>
    {
        public int BrandId { get; set; }
        public int FuelId {  get; set; }
        public int TransmissionId {  get; set; }
        public string? Name { get; set; }
        public short Year { get; set; }
        public Brand Brand { get; set; } = null;
        public Model()
        {
            
        }
        public Model(int brandId, string? name, short year,Brand? brand)
        {
            this.BrandId = brandId;
            this.Name = name;
            this.Year = year;
            this.Brand = brand;
        }

    }
}
