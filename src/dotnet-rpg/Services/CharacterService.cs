using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using dotnet_rpg.Models;

namespace dotnet_rpg.Services
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character{Id =1, Name="Clement"}
        };
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int Id)
        {
            return characters.Find(x => x.Id == Id);
        }

        public async Task<Character> UpdateCharacter(Character updateCharacter)
        {
            var character = characters.Find(x => x.Id == updateCharacter.Id);
            character.Name = updateCharacter.Name;
            character.Intelligence = updateCharacter.Intelligence;
            character.Strength = updateCharacter.Strength;
            character.Class = updateCharacter.Class;
            character.Defence = updateCharacter.Defence;
            character.HitPoints = updateCharacter.HitPoints;
            return character;
        }
    }
}
