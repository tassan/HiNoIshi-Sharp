using System;
using System.Collections.Generic;
using HiNoIshi.Domain.Core.RPGData;
using HiNoIshi.Domain.Enums;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Profile
    {
        public string PlayerName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public CharacterRank Rank { get; set; }
        public Division Division { get; set; }
        public Alignment Alignment { get; set; }
        public IEnumerable<Trivia> Trivias { get; set; }
    }
}