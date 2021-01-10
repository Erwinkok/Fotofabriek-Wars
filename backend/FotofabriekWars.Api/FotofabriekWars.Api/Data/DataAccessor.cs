using FotofabriekWars.Api.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace FotofabriekWars.Api.Data
{
    public class DataAccessor
    {
        private ICollection<Character> _characters = new List<Character>();

        public Character GetCharacter(int id)
        {
            return _characters.SingleOrDefault(c => c.Id == id);
        }
    }
}
