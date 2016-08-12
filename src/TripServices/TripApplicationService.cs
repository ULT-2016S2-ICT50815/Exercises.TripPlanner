using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripPlanner.DataAccess.Models;

namespace TripServices
{
    public class TripApplicationService
    {
        TripPlannerDbContext _context;
        public TripApplicationService(TripPlannerDbContext tripPlannerDbContext)
        {
            _context = tripPlannerDbContext;
        }


        public async Task CreateTripAsync (DateTime tripDate, string destination, int transportTypeId)
        {
            var trip = new Trip
            {
                TripDate = tripDate,
                Destination = destination,
                TransportTypeId = transportTypeId
            };

            _context.Add(trip);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTripAsync(int tripId, DateTime tripDate, string origin, string destination, int transportTypeId)
        {
            var updateTrip = _context.Trips.FirstOrDefault(t => t.Id == tripId);
            _context.Update(updateTrip);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteTripAsync(int tripId)
        {
            var deleletrip = _context.Trips.First(t => t.Id == tripId);
            _context.Trips.Remove(deleletrip);
            await _context.SaveChangesAsync();
        }

    }
}
