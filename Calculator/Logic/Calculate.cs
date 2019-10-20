using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    public class Calculate : ICalculate
    {
        public string CalculateOhmValue(int bandAColor, int bandBColor, decimal bandCColor, decimal bandDColor)
        {
            if (bandAColor >= 0 && bandBColor >= 0 && bandCColor>= 0 && bandDColor>= 0)
            {
                var bandValue = (bandAColor * 10) + bandBColor;
                var MultiplierValue = (bandValue * bandCColor);
                if (MultiplierValue >= 1000 && MultiplierValue < 1000000)
                {
                    var OhmsValue = (MultiplierValue / 1000).ToString() + "K";
                    return OhmsValue + " Ohms ±" + bandDColor + "%";
                }
                else if (MultiplierValue >= 1000000 && MultiplierValue < 1000000000)
                {
                    var OhmsValue = (MultiplierValue / 1000000).ToString() + "M";
                    return OhmsValue + " Ohms ±" + bandDColor + "%";
                }
                else if (MultiplierValue >= 1000000000)
                {
                    var OhmsValue = (MultiplierValue / 1000000000).ToString() + "G";
                    return OhmsValue + " Ohms ±" + bandDColor + "%";
                }
                else
                {
                    return MultiplierValue + " Ohms ±" + bandDColor + "%";
                }
            }
            else
            {
                return "Invalid Parameters";
            }
        }
    }
}
