using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace stringmanipulation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{Explosion}")]
        public string Exploded(string Explosion)
        {
            var parts = Explosion.Select(character => new String(character, int.Parse(character.ToString())));

            return String.Concat(parts);
        }
    }
}