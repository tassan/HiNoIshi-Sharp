using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.RPGData
{
    public class Perk
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }
        public int Value { get; set; }
    }
}