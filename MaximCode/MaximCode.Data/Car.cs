using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximCode.Data
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public int Price { get; set; }
        public double TCCRating { get; set; }
        public int HwyMPG { get; set; }
    }
}
