using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Linq;
using dotnet_rpg.Services.CharacterServices;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;

        // call characterService parameter in Constructor
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        // example >> localhost5000:/character/getall = baseURL
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        // example >> localhost5000:/character/1 = baseURL
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}
