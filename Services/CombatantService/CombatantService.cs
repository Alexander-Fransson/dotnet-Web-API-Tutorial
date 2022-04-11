using System.Collections.Generic;
using System.Linq;
using dotnet_Web_API_Tutorial.Models;

namespace dotnet_Web_API_Tutorial.Services.CombatantService
{
    public class CombatantService : ICombatantService
    {
        private static List<Character> Combatants = new List<Character> {
            new Character (),
            new Character {ID = 1, Name = "Seagul"}
        };
        public List<Character> AddComatant(Character newCombatant)
        {
            Combatants.Add(newCombatant);
            return Combatants;        
        }

        public Character GetCombatantsByID(int id)
        {
            return Combatants.FirstOrDefault(c => c.ID == id);        
        }

        public List<Character> GetAllCombatanat()
        {
            return Combatants;
        }

        public List<Character> GetAllCombatants()
        {
            throw new System.NotImplementedException();
        }

        public Character GetCombatanatByID()
        {
            throw new System.NotImplementedException();
        }
    }
}