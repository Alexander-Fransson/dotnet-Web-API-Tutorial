using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_Web_API_Tutorial.Models;

namespace dotnet_Web_API_Tutorial.Services.CombatantService
{
    public interface ICombatantService
    {
        
         Task<List<Character>> GetAllCombatants();
         Task<Character> GetCombatanatByID(int id);
         Task<List<Character>> AddComatant(Character newCombatant);
    }
}