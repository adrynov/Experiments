using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments.Common
{
    public enum LookupType
    {
        State = 0,
        Country = 1
    }

    public class Lookup
    {
        [Key]
        public string Code { get; set; }

        public string Description { get; set; }

        public LookupType LookUpType { get; set; }
    }
}
