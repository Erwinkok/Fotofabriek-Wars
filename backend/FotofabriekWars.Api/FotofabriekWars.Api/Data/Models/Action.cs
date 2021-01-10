using System.Collections.Generic;

namespace FotofabriekWars.Api.Data.Models
{
    public class Action
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BaseDamage { get; set; }

        public ICollection<SkillModifier> SkillModifiers { get; set; }
    }
}
