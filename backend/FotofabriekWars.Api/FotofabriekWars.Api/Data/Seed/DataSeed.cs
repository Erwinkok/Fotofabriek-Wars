using FotofabriekWars.Api.Data.Models;
using FotofabriekWars.Api.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotofabriekWars.Api.Data.Seed
{
    public class DataSeed
    {
        public ICollection<Character> GetCharacters()
        {
            return new List<Character>()
            {
                new Character
                {
                    Id = 0,
                    Name = "Raymond",
                    Health = 200,
                    MaxHealth = 200,
                    Type = CharacterType.Developer,
                    Experience = 0,
                    Skills = new List<CharacterSkill>()
                    {
                        new CharacterSkill
                        {
                            Skill = Skill.Communication,
                            Proficiency = 1,
                        },
                        new CharacterSkill
                        {
                            Skill = Skill.Intelligence,
                            Proficiency = 10,
                        },
                    },
                    KnownActions = new List<Models.Action>()
                    {
                        new Models.Action
                        {
                            Name = "Explain why enemy is wrong",
                            SkillModifier = new SkillModifier
                            {
                                Skill = Skill.Intelligence,
                                Modifier = 3,
                            },
                        },
                        new Models.Action
                        {
                            Name = "Explain why task is delayed",
                            SkillModifier = new SkillModifier
                            {
                                Skill = Skill.Communication,
                                Modifier = 3,
                            },
                        },
                    },
                },
                new Character
                {
                    Id = 0,
                    Name = "Jelle",
                    Health = 200,
                    MaxHealth = 200,
                    Type = CharacterType.Developer,
                    Experience = 0,
                    Skills = new List<CharacterSkill>()
                    {
                        new CharacterSkill
                        {
                            Skill = Skill.Communication,
                            Proficiency = 5,
                        },
                        new CharacterSkill
                        {
                            Skill = Skill.Intelligence,
                            Proficiency = 5,
                        },
                    },
                    KnownActions = new List<Models.Action>()
                    {
                        new Models.Action
                        {
                            Name = "Refactor ShoppingCart frontend",
                            SkillModifier = new SkillModifier
                            {
                                Skill = Skill.Intelligence,
                                Modifier = 2,
                            },
                        },
                        new Models.Action
                        {
                            Name = "Train intern",
                            SkillModifier = new SkillModifier
                            {
                                Skill = Skill.Communication,
                                Modifier = 4,
                            },
                        },
                    },
                },
                new Character
                {
                    Id = 0,
                    Name = "Erwin",
                    Health = 200,
                    MaxHealth = 200,
                    Type = CharacterType.Developer,
                    Experience = 0,
                    Skills = new List<CharacterSkill>()
                    {
                        new CharacterSkill
                        {
                            Skill = Skill.Communication,
                            Proficiency = 8,
                        },
                        new CharacterSkill
                        {
                            Skill = Skill.Intelligence,
                            Proficiency = 5,
                        },
                    },
                    KnownActions = new List<Models.Action>()
                    {
                        new Models.Action
                        {
                            Name = "Have conversation with manager",
                            SkillModifier = new SkillModifier
                            {
                                Skill = Skill.Communication,
                                Modifier = 5,
                            },
                        },
                    },
                },
            };
        }
    }
}
