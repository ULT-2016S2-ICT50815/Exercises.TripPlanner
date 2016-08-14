using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.Models
{
    public class Trip
    {
        public int Id { get; set; }
        [Required]
        public DateTime TripDate { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        public TransportType TransportType { get; set; }
        public List<PackageTrip> PackageTrips { get; set; }
    }
}
