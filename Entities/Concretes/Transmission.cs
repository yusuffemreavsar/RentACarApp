﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Transmission : Entity<int>
    {
        public string TransmissionTypeName { get; set; }
        public Transmission()
        {
            
        }
        public Transmission(string transMissionTypeName)
        {
            this.TransmissionTypeName = transMissionTypeName;
        }
    }
}
