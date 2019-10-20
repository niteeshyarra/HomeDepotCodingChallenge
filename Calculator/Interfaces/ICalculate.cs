using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    public interface ICalculate
    {
        string CalculateOhmValue(int bandAColor, int bandBColor, decimal bandCColor, decimal bandDColor);
    }
}
