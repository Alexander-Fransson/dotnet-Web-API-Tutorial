using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<List<Character>> GetAllCombatants()
        {
            return Combatants;
        }

        public async Task<Character> GetCombatanatByID(int id)
        {
            return Combatants.FirstOrDefault(c => c.ID == id);        
        }

        public async Task<List<Character>> AddComatant(Character newCombatant)
        {
            Combatants.Add(newCombatant);
            return Combatants;
        }
    }
}