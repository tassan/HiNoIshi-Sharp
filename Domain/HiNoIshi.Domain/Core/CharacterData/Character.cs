using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Character : IEntity, IDisposable
    {
        public Guid Id { get; set; }
        public Profile Profile { get; set; }
        public Attributes Attributes { get; set; }
        public Skills Skills { get; set; }
        public Background Background { get; set; }
        public AccessKey AccessKey { get; set; }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}