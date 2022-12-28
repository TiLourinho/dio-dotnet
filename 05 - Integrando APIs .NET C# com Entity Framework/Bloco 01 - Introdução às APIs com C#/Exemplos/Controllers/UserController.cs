using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Exemplos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetActualDateTime")]
        public IActionResult GetDateTime()
        {
            var obj = new
            {
                Date = DateTime.Now.ToLongDateString(),
                Time = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Introduce/{name}")]
        public IActionResult Introduce(string name)
        {
            var message = $"Hi, {name}! Welcome!";

            return Ok(new { message });
        }
    }
}