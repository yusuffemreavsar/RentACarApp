namespace Business.Request
{
    public class AddTransmissionRequest
    {
        public string TransmissionTypeName { get; set; }
        public AddTransmissionRequest(string transMissionTypeName)
        {
            this.TransmissionTypeName = transMissionTypeName;
        }
    }
}
