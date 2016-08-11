using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TripPlanner.DataAccess.Models
{
    public class TransportType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
