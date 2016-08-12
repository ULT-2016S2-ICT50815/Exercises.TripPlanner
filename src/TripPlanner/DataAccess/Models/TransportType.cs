using System.Collections.Generic;

namespace TripPlanner.DataAccess.Models
{
    public class TransportType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Trip> Trips { get; set; }
    }
}