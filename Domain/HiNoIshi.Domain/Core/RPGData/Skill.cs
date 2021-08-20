using System;
using HiNoIshi.Domain.Enums;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.RPGData
{
    public class Skill : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillRank Rank { get; set; }
        public int Value { get; set; }
        public SkillType Type { get; set; }
        public ElementalType ElementalType { get; set; }
        public Guid Id { get; set; }
    }
}