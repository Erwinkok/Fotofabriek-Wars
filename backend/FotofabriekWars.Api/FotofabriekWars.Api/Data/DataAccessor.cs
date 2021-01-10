using FotofabriekWars.Api.Data.Models;
using FotofabriekWars.Api.Data.Seed;
using System.Collections.Generic;
using System.Linq;

namespace FotofabriekWars.Api.Data
{
    public class DataAccessor
    {
        private ICollection<Character> _characters = new List<Character>();

        public DataAccessor(DataSeed dataSeed)
        {
            _characters = dataSeed.GetCharacters();
        }

        public Character GetCharacter(int id)
        {
            return _characters.SingleOrDefault(c => c.Id == id);
        }
    }
}
