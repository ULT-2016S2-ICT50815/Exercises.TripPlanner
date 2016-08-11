﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TripPlanner.DataAccess.Models
{
    public class Trip
    {
        public int Id { get; set; }
        [Required]
        public DateTime TripDate { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        //add transportTypeId(foreign key)
    }
}
