using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ten_web_equations_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public int Get()
        {
            return 3;

            throw new NotImplementedException();
        }
    }
}
