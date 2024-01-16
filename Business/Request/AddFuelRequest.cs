namespace Business.Request
{
    public class AddFuelRequest
    {
        public string FuelTypeName { get; set; }
        public AddFuelRequest(string fuelTypeName)
        {
            this.FuelTypeName = fuelTypeName;
        }
    }
}
