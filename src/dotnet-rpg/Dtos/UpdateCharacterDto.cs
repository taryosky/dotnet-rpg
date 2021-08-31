using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 10;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Healer;
    }
}
