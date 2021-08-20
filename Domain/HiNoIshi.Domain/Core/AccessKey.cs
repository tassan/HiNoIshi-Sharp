using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core
{
    public class AccessKey : IEntity
    {
        public Guid Id { get; set; }
        public Guid CharacterId { get; set; }
        public string Alias { get; set; }
    }
}