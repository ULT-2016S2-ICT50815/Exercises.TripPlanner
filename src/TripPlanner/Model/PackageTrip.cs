using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Model
{
    public class PackageTrip
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int TripId { get; set; }
        [Required]
        public decimal TripCost { get; set; }
        public Package Package { get; set; }
        public Trip Trip { get; set; }

    }
}
