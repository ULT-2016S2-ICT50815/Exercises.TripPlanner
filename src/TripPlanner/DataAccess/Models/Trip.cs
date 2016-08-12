using System;
using System.Collections.Generic;

namespace TripPlanner.DataAccess.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public DateTime TripDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int TransportTypeId { get; set; }
        public TransportType TransportType { get; set; }
        public List<PackageTrip> PackageTrips { get; set; }
    }
}
