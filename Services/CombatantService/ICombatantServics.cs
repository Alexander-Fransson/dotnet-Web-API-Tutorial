using System.Collections.Generic;
using dotnet_Web_API_Tutorial.Models;

namespace dotnet_Web_API_Tutorial.Services.CombatantService
{
    public interface ICombatantService
    {
         List<Character> GetAllCombatants();
         Character GetCombatanatByID();
         List<Character> AddComatant(Character newCombatant);
    }
}