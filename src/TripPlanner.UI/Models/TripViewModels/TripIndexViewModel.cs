using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.UI.Models.TripViewModels
{
    public class TripIndexViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Trip Date")]
        public DateTime TripDate { get; set; }
        [Required]
        [Display(Name = "Trip Details")]
        public string TripDetails { get; set; }
        
    }
}
