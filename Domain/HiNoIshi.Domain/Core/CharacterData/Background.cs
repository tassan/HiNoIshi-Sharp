using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Background : IEntity
    {
        public Guid Id { get; set; }
        public Guid CharacterId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}