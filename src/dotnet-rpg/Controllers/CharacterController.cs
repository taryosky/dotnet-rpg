using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using dotnet_rpg.Dtos;
using dotnet_rpg.Models;
using dotnet_rpg.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;

        public CharacterController(ICharacterService characterService, IMapper mapper)
        {
            _characterService  = characterService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var characters = await _characterService.GetAllCharacters();
            var cha = characters.Select(x => _mapper.Map<GetCharacterDto>(x));
            var res = new ServiceResponse<List<GetCharacterDto>> { Data = cha.ToList(), Message = "Request successful" };

            return Ok(res);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetSingle(int Id)
        {
            var character = _mapper.Map<GetCharacterDto>(await _characterService.GetCharacterById(Id));
            var res = new ServiceResponse<GetCharacterDto> { Data = character, Message = "Request successful" };
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter([FromBody]AddCharacterDto newCharacter)
        {
            var chartoadd = _mapper.Map<Character>(newCharacter);
            var characters = await _characterService.AddCharacter(chartoadd);
            var chartoreturn = characters.Select(x => _mapper.Map<GetCharacterDto>(x));
            var res = new ServiceResponse<List<GetCharacterDto>> { Data = chartoreturn.ToList(), Message = "Request successful" };
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter([FromBody] UpdateCharacterDto updateCharacter)
        {
            var chartoadd = _mapper.Map<Character>(updateCharacter);
            var character = await _characterService.UpdateCharacter(chartoadd);
            var res = new ServiceResponse<GetCharacterDto> { Data = _mapper.Map<GetCharacterDto>(character), Message = "Request successful" };
            return Ok(res);
        }
    }
}
