using System;
using System.Collections.Generic;
using HiNoIshi.Domain.Core.RPGData;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Skills : IEntity
    {
        public Guid Id { get; set; }
        public Guid CharacterId { get; set; }
        public Clan Clan { get; set; }
        public Speciality Speciality { get; set; }
        public IEnumerable<Skill> Basics { get; set; }
        public IEnumerable<Skill> ClanSkills { get; set; }
        public IEnumerable<Skill> Ninjutsus { get; set; }
        public IEnumerable<Skill> Taijutsus { get; set; }
        public IEnumerable<Skill> Genjutsus { get; set; }
        public IEnumerable<Skill> Fuuinjutsus { get; set; }
        public IEnumerable<Skill> Elementals { get; set; }
        public IEnumerable<Skill> FightingStyles { get; set; }
    }
}