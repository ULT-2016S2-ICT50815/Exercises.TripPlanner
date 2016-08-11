using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StreetAddess { get; set; }
        public string Surburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public Package Packages { get; set; }

    }
}
