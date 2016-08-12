using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Model
{
    public class Trip
    {
        public int Id { get; set; }
        public DateTime TripDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int TransportTypeId { get; set; }
        public List<PackageTrip> PackageTrips { get; set; }
        public TransportType TransportType { get; set; }
    }
}
