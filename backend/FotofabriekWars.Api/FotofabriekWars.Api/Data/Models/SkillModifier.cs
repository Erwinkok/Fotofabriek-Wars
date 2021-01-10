using FotofabriekWars.Api.Data.Models.Enums;

namespace FotofabriekWars.Api.Data.Models
{
    public class SkillModifier
    {
        public decimal Modifier { get; set; }

        public Skill Skill { get; set; }
    }
}
