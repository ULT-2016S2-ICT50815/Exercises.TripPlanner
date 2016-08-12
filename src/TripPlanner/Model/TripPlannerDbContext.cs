using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Model
{
    public class TripPlannerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public TripPlannerDbContext(DbContextOptions<TripPlannerDbContext> options) 
            : base(options)
        {

        }
    }
}
