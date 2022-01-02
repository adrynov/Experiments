using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments.Common
{
    [Table("Shape")]
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    [Table("Cube")]
    public class Cube: Shape
    {
        public int Length { get; set; }

    }
}
