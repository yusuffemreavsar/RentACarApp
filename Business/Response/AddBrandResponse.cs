namespace Business.Response
{
    public class AddBrandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }


        public AddBrandResponse(string name, int id, DateTime? createdAt)
        {
            this.Name = name;
            this.Id = id;
            this.CreatedAt = createdAt;
        }
    }
}
