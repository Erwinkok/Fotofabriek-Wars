using FotofabriekWars.Api.Data.Models;
using FotofabriekWars.Api.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotofabriekWars.Api.Services
{
    public class DamageCalculator
    {
        public int CalculateDamage(Character attacker, Character defender, Data.Models.Action action)
        {
            var totalDamage = 0;

            foreach (var actionSkillModifier in action.SkillModifiers)
            {
                var modifier = action.SkillModifiers
                    .FirstOrDefault(s => s.Skill == actionSkillModifier.Skill)
                    ?.Modifier ?? 1;

                var attackerSkill = _getSkillFromCharacter(attacker, actionSkillModifier.Skill);
                var defenderSkill = _getSkillFromCharacter(defender, actionSkillModifier.Skill);
                var damageModifier = (attackerSkill.Proficiency * modifier) / defenderSkill.Proficiency;

                totalDamage += (int)Math.Ceiling(action.BaseDamage * damageModifier);
            }

            return totalDamage;
        }

        private CharacterSkill _getSkillFromCharacter(Character character, Skill skill)
        {
            return character.Skills.First(s => s.Skill == skill);
        }
    }
}
