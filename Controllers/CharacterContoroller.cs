using System.Collections.Generic;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterContoroller : ControllerBase
    {
        // private static Character knight = new Character();
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Name = "Sam" }
        };

        public IActionResult Get()
        {
            // return Ok(knight);
            return Ok(characters);
        }
    }
}