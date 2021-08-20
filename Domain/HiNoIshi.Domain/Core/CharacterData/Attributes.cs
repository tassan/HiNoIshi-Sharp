using System;
using System.Collections.Generic;
using HiNoIshi.Domain.Core.RPGData;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;
using Attribute = HiNoIshi.Domain.Core.RPGData.Attribute;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Attributes : IEntity
    {
        public Guid Id { get; set; }
        public Guid CharacterId { get; set; }
        public int ExperiencePoints { get; set; }
        public string Reputation { get; set; }
        public int Fame { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Stamina { get; set; }
        public int Perception { get; set; }
        public int Charisma { get; set; }
        public int Knowledge { get; set; }
        public int Focus { get; set; }
        public int Jutsu { get; set; }
        public int Chakra { get; set; }
        public int ChakraControl { get; set; }
        public IEnumerable<Trait> Traits { get; set; }
    }
}

// public Attribute Strength { get; set; } = new("FOR", 1);
// public Attribute Agility { get; set; } = new("AGI", 1);
// public Attribute Dexterity { get; set; } = new("DES", 1);
// public Attribute Vitality { get; set; } = new("VIT", 1);
// public Attribute Stamina { get; set; } = new("DES", 1);
// public Attribute Perception { get; set; } = new("PER", 1);
// public Attribute Charisma { get; set; } = new("CAR", 1);
// public Attribute Knowledge { get; set; } = new("CON", 1);
// public Attribute Focus { get; set; } = new("FOC", 1);
// public Attribute Jutsu { get; set; } = new("JUT", 1);
// public Attribute Chakra { get; set; } = new("CH", 1);
// public Attribute ChakraControl { get; set; } = new("CC", 1);