using FotofabriekWars.Api.Data.Models.Enums;

namespace FotofabriekWars.Api.Data.Models
{
    public class Effect
    {
        public EffectType EffectType { get; set; }

        public int Duration { get; set; }

        public SkillModifier SkillModifier { get; set; }
    }
}
