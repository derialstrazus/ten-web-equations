using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ten_web_equations_backend.Controllers
{
    //Note: These countrollers have their routes and methods inferred.
    //This works, but is not encouraged. 
    //It leaves a lot of work to the reader to infer the routes, and is prone to creating errors
    //The routes themselves are also not very implicit.

    [Route("api/[controller]")]
    [ApiController]    
    public class BadEquationController : ControllerBase
    {
        //https://localhost:44358/api/EquationInferredRouting?a=1&b=2
        public int Get(int a, int b)
        {
            return a + b;
        }

        [HttpPost]
        //https://localhost:44358/api/EquationInferredRouting?a=1&b=2
        public int Post(int a, int b)
        {
            return a * b;
        }
    }
}
