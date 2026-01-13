using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using SchoolBusRoutingSystem.Models;

namespace SchoolBusRoutingSystem.Services
    {
    public static class DistanceCalculater
    {
        public static double Calculate(Location from, Location to)
        {
            if (from == null || to == null)
                return 0;

            if (!from.IsValid() || !to.IsValid())
                return 0;

            return Math.Abs(from.Latitude - to.Latitude)
                 + Math.Abs(from.Longitude - to.Longitude);
        }
    } }




