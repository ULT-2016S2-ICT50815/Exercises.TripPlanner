using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripPlanner.Commands.Trip;
using TripPlanner.DataAccess.Model;


namespace TripPlanner.Services
{
    public class TripApplicationService
    {
        public TripPlannerDbContext Context { get; private set; }

        public TripApplicationService(TripPlannerDbContext context)
        {
            Context = context;
        }

        public async Task<Trip> Create(TripCommand trip)
        {
            var newTrip = new Trip()
            {
                TripDate = trip.TripDate,
                Origin = trip.Origin,
                Destination = trip.Destination,
                TransportTypeId = trip.TransportTypeId,
            };
            Context.Trips.Add(newTrip);
            await Context.SaveChangesAsync();
            return newTrip;
        }
        public async Task<Trip> Update(int tripId, TripCommand trip)
        {
            var tripToUpdate = Context.Trips.FirstOrDefault(t => t.Id == tripId);

            tripToUpdate.Id = trip.Id;
            tripToUpdate.TripDate = trip.TripDate;
            tripToUpdate.Origin = trip.Origin;
            tripToUpdate.Destination = trip.Destination;
            tripToUpdate.TransportTypeId = trip.TransportTypeId;

            await Context.SaveChangesAsync();
            return tripToUpdate;
        }

        public async Task<TripPlannerResult> Delete(int tripId)
        {
            var trip = Context.Trips.FirstOrDefault(t => t.Id == tripId);

            if (trip == null)
            {
                return TripPlannerResult.Failed(
                    new TripPlannerError()
                    {
                        Description = $"There is no trip with the Id {tripId}"
                    });
            }

            Context.Trips.Remove(trip);
            await Context.SaveChangesAsync();
            return TripPlannerResult.Success;
        }
    }
}