using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using dotnet_rpg.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private static Character Knight = new Character();

        public IActionResult Get()
        {
            return Ok(Knight);
        }
    }
}
