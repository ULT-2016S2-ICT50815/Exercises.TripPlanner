﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Model
{
    public class TransportType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Trip> Trips { get; set; }

    }
}