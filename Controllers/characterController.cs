using Microsoft.AspNetCore.Mvc;
using dotnet_Web_API_Tutorial.Models;
using System.Collections.Generic;
using dotnet_Web_API_Tutorial.Services.CombatantService;
using System.Threading.Tasks;

namespace dotnet_Web_API_Tutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class characterController: ControllerBase
    {
        private readonly ICombatantService _combatantService;

        public characterController(ICombatantService combatantService)
        {
            _combatantService = combatantService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _combatantService.GetAllCombatants());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetOne(int id)
        {
            return Ok( await _combatantService.GetCombatanatByID(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCombatant(Character newCombatant){
            return Ok(await _combatantService.AddComatant(newCombatant));
        }
    }
}