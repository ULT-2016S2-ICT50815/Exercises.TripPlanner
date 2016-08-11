using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripPlanner.DataAccess.Model;

namespace TripPlanner.Services
{
    public class TripApplicationService
    {
        private TripPlannerDbContext _context;
        public TripApplicationService(TripPlannerDbContext context)
        {
            _context = context;
        }

        public Trip CreateTrip(DateTime tripDate, string origin, string destination, int transportTypeId)
        {
            var trip = new Trip()
            {
                TripDate = tripDate,
                Origin = origin,
                Destination = destination,
                TransportTypeId = transportTypeId
            };

            return trip;
        }

        public Trip UpdateTrip(int tripId, DateTime tripDate, string origin, string destination, int transportTypeId)
        {
            var trip = _context.Trips.FirstOrDefault(t => t.Id == tripId);

            if (trip == null)
            {
                throw new InvalidOperationException("Cant find trip with the provided id");
            }

            trip.Id = tripId;
            trip.TripDate = tripDate;
            trip.Origin = origin;
            trip.Destination = destination;
            trip.TransportTypeId = transportTypeId;

            _context.SaveChanges();
            return trip;
        }
        public Trip DeleteTrip(int tripId)
        {
            var trip = _context.Trips.FirstOrDefault(t => t.Id == tripId);
            if (trip == null)
            {
                throw new InvalidOperationException("Cant find trip with the provided id");
            }

            _context.Remove(trip);
            _context.SaveChanges();

            return trip;
        }
    }
}
