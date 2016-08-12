﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string Suburb { get; set; }
        [Required]
        [Column(TypeName ="char(3)")]
        public string State { get; set; }
        [Required]
        [Column(TypeName = "char(4)")]
        public string PostCode { get; set; }
        public List<Package> Packages { get; set; }
    }
}