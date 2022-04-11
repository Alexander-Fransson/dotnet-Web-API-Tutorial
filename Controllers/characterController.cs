using Microsoft.AspNetCore.Mvc;
using dotnet_Web_API_Tutorial.Models;
using System.Collections.Generic;
using System.Linq;
using dotnet_Web_API_Tutorial.Services.CombatantService;

namespace dotnet_Web_API_Tutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class characterController: ControllerBase
    {
        private static List<Character> Combatants = new List<Character> {
            new Character (),
            new Character {ID = 1, Name = "Seagul"}
        };

        private readonly ICombatantService _combatantService;

        public characterController(ICombatantService combatantService)
        {
            _combatantService = combatantService;
        }

        [HttpGet("GetAll")]
        public ActionResult<Character> Get()
        {
            return Ok(Combatants);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetOne(int id)
        {
            return Ok(Combatants.FirstOrDefault(c => c.ID == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCombatant(Character newCombatant){
            Combatants.Add(newCombatant);
            return Ok(Combatants);
        }
    }
}