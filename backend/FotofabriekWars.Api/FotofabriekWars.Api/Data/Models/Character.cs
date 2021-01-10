using FotofabriekWars.Api.Data.Models.Enums;
using System.Collections.Generic;

namespace FotofabriekWars.Api.Data.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CharacterType Type { get; set; }

        public int Experience { get; set; }

        public int Health { get; set; }

        public int MaxHealth { get; set; }

        public ICollection<CharacterSkill> Skills { get; set; }

        public ICollection<Action> KnownActions { get; set; }

        public ICollection<Effect> ActiveEffects { get; set; }
    }
}
