using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TripPlanner.DataAccess.Models
{
    public class TripPlannerDbContext : DbContext
    {
        public DbSet<TransportType> TransportTypes { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<PackageTrip> PackageTrips { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public TripPlannerDbContext(DbContextOptions<TripPlannerDbContext> options) : base(options) { }
    }
}
