﻿namespace Business.Response
{
    public class AddTransmissionResponse
    {
        public int Id { get; set; }
        public string TransmissionTypeName { get; set; }
        public AddTransmissionResponse(string transMissionTypeName)
        {
            this.TransmissionTypeName = transMissionTypeName;
        }
    }
}

