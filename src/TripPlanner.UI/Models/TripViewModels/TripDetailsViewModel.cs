using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.UI.Models.TripViewModels
{
    public class TripDetailsViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Trip Date")]
        public DateTime TripDate { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        [Display(Name = "Transport Type")]
        public string TransportType { get; set; }
    }
}
