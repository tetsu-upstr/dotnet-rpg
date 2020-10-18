using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Linq;
using dotnet_rpg.Services.CharacterServices;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Character;

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
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        // example >> localhost5000:/character/1 = baseURL
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}
