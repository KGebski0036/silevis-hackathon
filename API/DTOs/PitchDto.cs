using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class PitchDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double CoordLat { get; set; }
        public double CoordLon { get; set; }
    }
}