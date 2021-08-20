using System;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Background
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}