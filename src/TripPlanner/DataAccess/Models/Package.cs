using System.Collections.Generic;

namespace TripPlanner.DataAccess.Models
{
    public class Package
    {
        public int Id { get; set; }
        public List<PackageTrip> PackageTrips { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}