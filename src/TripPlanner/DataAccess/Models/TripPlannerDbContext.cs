using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.Models
{
    public class TripPlannerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; 
    }
}
