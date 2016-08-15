using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.UI.Models.TripViewModels
{
    public class TripCreateViewModel
    {
        [Required]
        [Display(Name = "Trip Date")]
        public DateTime TripDate { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        [Display(Name = "Transport Type")]
        //public int TransportTypeId { get; set; }
        //[Required]
        //public List<TransportType> TransportTypes { get; set; }

        //What does this do?
        private int _transportTypeId { get; set; }
        public int transportTypeId

        {
            get { return _transportTypeId; }
            set
            {
                _transportTypeId = value;
            }
        }
    }
}
