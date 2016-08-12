﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.Model
{
    public class PackageTrip
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public decimal TripCost { get; set; }
    }
}
