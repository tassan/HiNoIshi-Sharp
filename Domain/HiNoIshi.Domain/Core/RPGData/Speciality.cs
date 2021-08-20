using System;
using System.Collections.Generic;
using HiNoIshi.Domain.Interfaces;
using MongoDB.Bson;

namespace HiNoIshi.Domain.Core.RPGData
{
    public class Speciality
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}