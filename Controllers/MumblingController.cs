using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace stringmanipulation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{Mumbling}")]
        public string Mumbled(string Mumbling)
        {
            var parts = Mumbling.Select((character, index) => new String(character, index + 1)).Select(subString => subString.Substring(0, 1).ToUpper() + subString.Substring(1).ToLower());

            return String.Join("-", parts);
        }
    }
}




