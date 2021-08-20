using System;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}