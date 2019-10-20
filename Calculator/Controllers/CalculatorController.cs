using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;
using Calculator.Interfaces;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculate _calculate;
        public CalculatorController(ICalculate calculate)
        {
            _calculate = calculate;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Calculate([FromBody]ResistorValuesModel resistorValues)
        {
            if(resistorValues == null)
            {
                return "Bad Request";
            }
            var result = _calculate.CalculateOhmValue(resistorValues.Band1, resistorValues.Band2, resistorValues.Multiplier, resistorValues.Tolerance);
            return result;
        } 
    }
}
