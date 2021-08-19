using System;

namespace HiNoIshi.Domain.Core.CharacterData
{
    public class Character
    {
        public Profile Profile { get; set; }
        public Attributes Attributes { get; set; }
        public Skills Skills { get; set; }
        public Background Background { get; set; }
        public AccessKey AccessKey { get; set; }
    }
}