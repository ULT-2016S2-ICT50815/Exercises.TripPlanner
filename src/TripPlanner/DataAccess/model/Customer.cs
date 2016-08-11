using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.DataAccess.model
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(255)]
        [DataType("varchar")]
        public string FirstName { get; set; }
        [StringLength(255)]
        [DataType("varchar")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(255)]
        [DataType("varchar")]
        public string StreeAddress { get; set; }
        [StringLength(255)]
        [DataType("varchar")]
        public string Suburb { get; set; }
        
        [StringLength(3)]
        [DataType("char")]
        public string State { get; set; }

        [StringLength(4)]
        [DataType("char")]
        public string Postcode { get; set; }

        public Package Package { get; set; }

    }
}
