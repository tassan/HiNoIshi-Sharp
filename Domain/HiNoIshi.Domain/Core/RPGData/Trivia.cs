using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.RPGData
{
    public class Trivia : IEntity
    {
        public Guid CharacterId { get; set; }
        public string Resume { get; set; }
        public Guid Id { get; set; }
    }
}