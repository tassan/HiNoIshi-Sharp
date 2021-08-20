using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core
{
    public class AccessKey
    {
        public Guid CharacterId { get; set; }
        public string Alias { get; set; }
    }
}