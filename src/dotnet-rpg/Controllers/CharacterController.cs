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
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character{Id =1, Name="Clement"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }

        [HttpGet("{Id}")]
        public IActionResult GetSingle(int Id)
        {
            return Ok(characters.Find(x => x.Id == Id));
        }

        [HttpPost]
        public IActionResult AddCharacter([FromBody]Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}
