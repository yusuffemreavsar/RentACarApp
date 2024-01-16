namespace Business.Request
{
    public class AddModelRequest
    {
        public string? Name { get; set; }
        public short Year { get; set; }
        public AddModelRequest(string? name, short year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
}
