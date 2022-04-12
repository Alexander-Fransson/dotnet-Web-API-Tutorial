using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_Web_API_Tutorial.DTOs.CombatantDTOs;
using dotnet_Web_API_Tutorial.Models;

namespace dotnet_Web_API_Tutorial.Services.CombatantService
{
    public interface ICombatantService
    {
        
         Task<ServiceResponse<List<GetCombatantDTO>>> GetAllCombatants();
         Task<ServiceResponse<GetCombatantDTO>> GetCombatanatByID(int id);
         Task<ServiceResponse<List<GetCombatantDTO>>> AddComatant(AddCombatantDTO newCombatant);
    }
}