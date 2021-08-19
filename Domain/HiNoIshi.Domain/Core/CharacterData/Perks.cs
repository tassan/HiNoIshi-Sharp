using System.Collections.Generic;
using HiNoIshi.Domain.Core.RPGData;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Perks
    {
        public IEnumerable<Perk> Advantages { get; set; }
        public IEnumerable<Perk> Disadvantages { get; set; }
        public IEnumerable<Perk> Neutral { get; set; }
    }
}