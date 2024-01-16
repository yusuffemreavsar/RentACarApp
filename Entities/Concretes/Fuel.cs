﻿using Core.Entities;
namespace Entities.Concretes
{
    public class Fuel: Entity<int>
    {
        public string FuelTypeName { get; set; }
        public Fuel()
        {
            
        }
        public Fuel(string fuelTypeName)
        {
            this.FuelTypeName = fuelTypeName;   
        }
    }
}
