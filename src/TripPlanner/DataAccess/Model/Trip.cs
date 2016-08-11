using System;

namespace TripPlanner.DataAccess.Model
{
    public class Trip
    {
        public int Id { get; set; }
        public DateTime TripDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string TransportTypeId { get; set; }
        public TransportType TransportType { get; set; }
    }
}