using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson.Serialization.Attributes;

namespace HiNoIshi.Domain.Core
{
    public class Entity : IEntity
    {
        [BsonId] public Guid Id { get; set; }

        public Entity() => Id = Guid.NewGuid();
    }
}