﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using dotnet_rpg.Models;

namespace dotnet_rpg.Services
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int Id);
        Task<List<Character>> AddCharacter(Character newCharacter);
        Task<Character> UpdateCharacter(Character updateCharacter);

    }
}
