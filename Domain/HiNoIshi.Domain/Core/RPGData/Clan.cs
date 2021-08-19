using System.Collections.Generic;

namespace HiNoIshi.Domain.Core.RPGData
{
    public class Clan
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}