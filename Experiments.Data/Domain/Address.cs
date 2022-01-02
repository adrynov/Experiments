using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments.Data
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string AddressLine1 { get; set; } = "";

        public string? AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }
        public string State { get; set; }

        [Required]
        public string Country { get; set; }
        
        public string PostCode { get; set; }
        
        public int PersonId { get; set; }
    }
}
