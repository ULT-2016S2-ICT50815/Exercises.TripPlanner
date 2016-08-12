using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.Model
{
    public class Package
    {
        public int Id { get; set; }
        public List<PackageTrip> PackageTrips { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
