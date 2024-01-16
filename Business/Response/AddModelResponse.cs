using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Response
{
    public class AddModelResponse
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        
        public string? Name { get; set; }
        public short Year { get; set; }
        private Brand Brand { get; set; } = null;
        public DateTime? CreatedAt { get; set; }
        public AddModelResponse(int brandId, string? name, short year, Brand? brand,DateTime? createdAt)
        {
            this.BrandId = brandId;
            this.Name = name;
            this.Year = year;
            this.Brand = brand;
            this.CreatedAt = createdAt;
        }
        public AddModelResponse(string? name, short year,  DateTime? createdAt)
        {
        
            this.Name = name;
            this.Year = year;
            this.CreatedAt = createdAt;
        }
    }
}
