using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRoutingSystem.Models
{

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public bool IsValid()
        {
            return Latitude != 0 && Longitude != 0;
        }
    }
    
}
