using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HiNoIshi.Domain.Interfaces
{
    public interface IEntity
    {
        [BsonId] public Guid Id { get; set; }
    }
}