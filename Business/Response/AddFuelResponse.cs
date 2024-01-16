namespace Business.Response
{
    public class AddFuelResponse
    {
        public int Id { get; set; }
        public string FuelTypeName { get; set; }
        public AddFuelResponse(string fuelTypeName)
        {
            this.FuelTypeName = fuelTypeName;
        }
    }
}
