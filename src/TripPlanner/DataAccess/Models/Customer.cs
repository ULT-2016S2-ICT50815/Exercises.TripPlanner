using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public int LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }       
        //What if a customer is a traveller?
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        //Navigational Properties!!
        public List<Package> Packages { get; set; }
    }
}
