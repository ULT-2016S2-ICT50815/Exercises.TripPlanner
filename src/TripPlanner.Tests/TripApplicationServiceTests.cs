using System;
using Microsoft.EntityFrameworkCore;
using TripPlanner.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using TripServices;

namespace TripPlanner.Tests
{
    public class TripApplicationServiceTests
    {
        [Fact]
        public async void CreateCustomerTest()
        {
            //Set up fixture
            var optionsBuilder = new DbContextOptionsBuilder<TripPlannerDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            
            //exercise the SUT
            //Add a transport to the Database
            using (var context = new TripPlannerDbContext(optionsBuilder.Options))
            {
                var transport = new TransportType()
                {
                    
                    Name = "Bus"

                };
                context.TransportTypes.Add(transport);
                context.SaveChanges();

                //TripToCreate
                var tripToCreate = new Trip()
                {
                    TripDate = DateTime.Today.AddDays(30),
                    Origin = "Sydney",
                    Destination = "Melbourne",
                    TransportTypeId = "Bus"

                };
                context.Trips.Add(tripToCreate);
                context.SaveChanges();

                //TripCreated from Services for comparison, 
                //don't forget to bring namespace and a ref to services

                var service = new TripApplicationService(context);
                var newTripInfo = new CreateTripAsync(DateTime tripDate, string Destination, TransportTypeId transportTypeId)
                {
                    tripDate = DateTime.Today.AddDays(30),
                    origin = "Sydney",
                    destination = "Melbourne",
                    transportTypeId = 1

                };
                var createdTrip = await service.CreateTripAsync(1, newTripInfo);

                //verify outcomes
                Assert.Equal(tripToCreate.TripDate, newTripInfo.tripDate);
                Assert.Equal(tripToCreate.Origin, newTripInfo.origin);
                Assert.Equal(tripToCreate.Destination, newTripInfo.destination);
                Assert.Equal(tripToCreate.TransportType, newTripInfo.transportType);
            };

        }

        [Fact]
        public async void UpdateCustomerTest()
        {
            //Set up fixture
            var optionsBuilder = new DbContextOptionsBuilder<TripPlannerDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            //exercise the SUT

            //Trip to Update 
            using (var context = new TripPlannerDbContext(optionsBuilder.Options))
            {
                var service = new TripApplicationService(context);
                var tripToUpdate = new UpdateTripAsync(int tripId, DateTime tripDate, string origin, string destination, int transportTypeId)
                {
                    var updateTrip = context.Trips.FirstOrDefault(t=> t.Id == tripId);
                context.Update(updateTrip);
                await context.SaveChangesAsync();


                //TripCreated from Services for comparison, 
                //don't forget to bring namespace and a ref to services
                //We Need to set updated values to compare against?


                var service = new TripApplicationService(context);
                var updatedTripInfo = new UpdateTripAsync(int tripId, DateTime tripDate, string origin, string destination, int transportTypeId)
            {
                var updateTripInfo = context.Trips.FirstOrDefault(t => t.Id == tripId);
                context.Update(updatedTripInfo);
                await context.SaveChangesAsync();

            };



            var updatedTrip = await service.UpdateTripAsync(1, updatedTripInfo);

            //verify Outcomes
            Assert.Equal(tripToUpdate.TripDate, updatedTripInfo.TripDate);
            Assert.Equal(tripToUpdate.Origin, updatedTripInfo.Origin);
            Assert.Equal(tripToUpdate.Destination, updatedTripInfo.Destination);
            Assert.Equal(tripToUpdate.TransportType, updatedTripInfo.Destination);

        };
            

        
    }
}
