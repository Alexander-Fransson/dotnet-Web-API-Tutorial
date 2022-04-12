using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_Web_API_Tutorial.DTOs.CombatantDTOs;
using dotnet_Web_API_Tutorial.Models;

namespace dotnet_Web_API_Tutorial.Services.CombatantService
{
    public class CombatantService : ICombatantService
    {
        private static List<Character> Combatants = new List<Character> 
        {
            new Character (),
            new Character {ID = 1, Name = "Seagul"}
        };

        public async Task<ServiceResponse<List<GetCombatantDTO>>> GetAllCombatants()
        {
            var serviceResponse = new ServiceResponse<List<GetCombatantDTO>>();
            serviceResponse.Data = Combatants;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCombatantDTO>> GetCombatanatByID(int id)
        {
            var serviceResponse = new ServiceResponse<GetCombatantDTO>();
            serviceResponse.Data = Combatants.FirstOrDefault(c => c.ID == id);      
            return serviceResponse;  
        }

        public async Task<ServiceResponse<List<GetCombatantDTO>>> AddComatant(AddCombatantDTO newCombatant)
        {
            var serviceResponse = new ServiceResponse<List<GetCombatantDTO>>();
            Combatants.Add(newCombatant);
            serviceResponse.Data = Combatants;
            return serviceResponse;
        }
    }
}