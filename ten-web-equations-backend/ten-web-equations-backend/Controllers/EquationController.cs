using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ten_web_equations_backend.Model;

namespace ten_web_equations_backend.Controllers
{

    //Note: These controllers have their routes and methods explicitly declared.
    //Explicit is better than implicit.

    //Note: These controllers explore different ways to pass data
    //This is called model binding
    //Research more at https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-6.0

    //https://localhost:44358/api/equation
    [Route("api/equation")]
    [ApiController]
    public class EquationController : ControllerBase
    {
        //https://localhost:44358/api/equation/sum?a=1&b=2
        [HttpGet]
        [Route("sum")]
        public int GetSum(int a, int b)
        {
            return a + b;
        }

        //https://localhost:44358/api/equation/difference?a=1&b=2
        [HttpGet]
        [Route("difference")]
        public int GetDifference(int a, int b)
        {
            return a - b;
        }

        //https://localhost:44358/api/equation/multiply/20/4
        [HttpGet]
        [Route("multiply/{a}/{b}")]
        public int GetMultiply(int a, int b)
        {
            return a * b;
        }

        //https://localhost:44358/api/equation/divide/20/4
        [HttpGet]
        [Route("divide/{a}/{b}")]
        public int GetDivide(int a, int b)
        {
            return a / b;
        }

        //curl --location --request POST 'https://localhost:44358/api/equation/average' \
        //--header 'Content-Type: application/json' \
        //--data-raw '[1,2,3,4,5]'
        [HttpPost]
        [Route("average")]
        public double PostAverage(List<int> values)
        {
            int total = 0;
            int count = values.Count;
            for (int i = 0; i < count; i++)
            {
                total += values[i];
            }
            double avg = total / count;

            return avg;
        }

        //curl --location --request POST 'https://localhost:44358/api/equation/power' \
        //--header 'Content-Type: application/json' \
        //--data-raw '{
        //    "base": 3,
        //    "exponent": 5
        //}'
        [HttpPost]
        [Route("power")]
        public int GetPower(PowerValues powerValues)
        {
            int baseValue = powerValues.Base;
            int exponentValue = powerValues.Exponent;

            int returnThis = 1;            
            while (exponentValue > 0)
            {
                returnThis *= baseValue;
                exponentValue--;
            }

            return returnThis;
        }
    }
}
