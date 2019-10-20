using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class ResistorValuesModel
    {
        public int Band1 { get; set; }
        public int Band2 { get; set; }
        public decimal Multiplier { get; set; }
        public decimal Tolerance { get; set; }

    }
}
