using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.UI.Models.TripViewModels
{
    public class TripEditViewModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime TripDate { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        [Display(Name = "Transport Type")]
        public int TransportTypeId { get; set; }
        [Required]
        private int _transportTypeId { get; set; }
        //What does this do?
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
