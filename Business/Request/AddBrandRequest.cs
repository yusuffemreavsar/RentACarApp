namespace Business.Request
{
    public class AddBrandRequest
    {
        public string Name { get; set; }
        public AddBrandRequest(string Name)
        {
            this.Name = Name;
        }
    }
}
