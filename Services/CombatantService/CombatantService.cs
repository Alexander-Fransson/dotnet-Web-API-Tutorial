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

        private readonly DataContext _context;
        public CombatantService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCombatants()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = _context.Characters.ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCombatanatByID(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = _context.Characters.FirstOrDefault(c => c.ID == id);      
            return serviceResponse;  
        }

        public async Task<ServiceResponse<List<Character>>> AddComatant(Character newCombatant)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            _context.Characters.Add(newCombatant);
            _context.SaveChanges();
            serviceResponse.Data = _context.Characters.ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> updateCharacter(Character updatedCombatant){
            var serviceResponse = new ServiceResponse<Character>();

            try{
                Character combatant = _context.Characters.FirstOrDefault(c => c.ID == updatedCombatant.ID); 

                combatant.Name = updatedCombatant.Name;
                combatant.HP = updatedCombatant.HP;
                combatant.DP = updatedCombatant.DP;
                combatant.IP = updatedCombatant.IP;
                combatant.SP = updatedCombatant.SP;
                combatant.ID = updatedCombatant.ID;
                combatant.Class = updatedCombatant.Class;

                serviceResponse.Data = combatant;
                _context.SaveChanges();


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
                Character combatant = _context.Characters.First(c => c.ID == id); 

                _context.Characters.Remove(combatant);
                _context.SaveChanges();
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