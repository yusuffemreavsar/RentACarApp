using Core.Entities;

namespace Entities.Concretes
{
    public class Brand : Entity<int>
    {
        public string Name { get; set; }
        public Brand()
        {
            
        }
        public Brand(string Name)
        {
            this.Name = Name;
        }
    }
}
