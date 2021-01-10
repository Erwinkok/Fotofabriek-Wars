using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FotofabriekWars.Api.Data;
using FotofabriekWars.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FotofabriekWars.Api.Controllers
{
    [ApiController]
    [Route("api/combat/[controller]")]
    public class DamageController : ControllerBase
    {
        private readonly DataAccessor _dataAccessor;
        private readonly DamageCalculator _damageCalculator;

        public DamageController(DataAccessor dataAccessor,
            DamageCalculator damageCalculator)
        {
            _dataAccessor = dataAccessor;
            _damageCalculator = damageCalculator;
        }

        [HttpGet]
        public int Get(int attackerId, int defenderId, int actionId)
        {
            var attacker = _dataAccessor.GetCharacter(attackerId);
            var defender = _dataAccessor.GetCharacter(defenderId);
            var action = _dataAccessor.GetAction(actionId);

            return _damageCalculator.CalculateDamage(attacker, defender, action);
        }
    }
}