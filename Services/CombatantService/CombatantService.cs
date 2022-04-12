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

        public async Task<ServiceResponse<List<Character>>> GetAllCombatants()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = Combatants;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCombatanatByID(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = Combatants.FirstOrDefault(c => c.ID == id);      
            return serviceResponse;  
        }

        public async Task<ServiceResponse<List<Character>>> AddComatant(Character newCombatant)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            Combatants.Add(newCombatant);
            serviceResponse.Data = Combatants;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> updateCharacter(Character updatedCombatant){
            var serviceResponse = new ServiceResponse<Character>();

            try{
                Character combatant = Combatants.FirstOrDefault(c => c.ID == updatedCombatant.ID); 

                combatant.Name = updatedCombatant.Name;
                combatant.HP = updatedCombatant.HP;
                combatant.DP = updatedCombatant.DP;
                combatant.IP = updatedCombatant.IP;
                combatant.SP = updatedCombatant.SP;
                combatant.ID = updatedCombatant.ID;
                combatant.Class = updatedCombatant.Class;

                serviceResponse.Data = combatant;

            }
            catch(System.NullReferenceException ex)
            {
                serviceResponse.Successfulness = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<Character>>> DeleteCombatant(int id)
    {
        var serviceResponse = new ServiceResponse<List<Character>>();

            try{
                Character combatant = Combatants.First(c => c.ID == id); 

                Combatants.Remove(combatant);
                serviceResponse.Data = Combatants;
            }
            catch(System.NullReferenceException ex)
            {
                serviceResponse.Successfulness = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;

        }
    }
}