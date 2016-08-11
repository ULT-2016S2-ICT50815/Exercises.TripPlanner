using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.Models
{
    public class PackageTrip
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int TripId { get; set; }
        public double TripCost { get; set; }
        public Package Packages { get; set; }
    }
}
