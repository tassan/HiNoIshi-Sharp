using System.Collections.Generic;
using HiNoIshi.Domain.Core.RPGData;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Attributes
    {
        public ExperiencePoints ExperiencePoints { get; set; }
        public Reputation Reputation { get; set; }
        public Fame Fame { get; set; }
        public Attribute Strength { get; set; } = new("FOR", 1);
        public Attribute Agility { get; set; } = new("AGI", 1);
        public Attribute Dexterity { get; set; } = new("DES", 1);
        public Attribute Vitality { get; set; } = new("VIT", 1);
        public Attribute Stamina { get; set; } = new("DES", 1);
        public Attribute Perception { get; set; } = new("PER", 1);
        public Attribute Charisma { get; set; } = new("CAR", 1);
        public Attribute Knowledge { get; set; } = new("CON", 1);
        public Attribute Focus { get; set; } = new("FOC", 1);
        public Attribute Jutsu { get; set; } = new("JUT", 1);
        public Attribute Chakra { get; set; } = new("CH", 1);
        public Attribute ChakraControl { get; set; } = new("CC", 1);
        public IEnumerable<Trait> Traits { get; set; }
        
    }
}