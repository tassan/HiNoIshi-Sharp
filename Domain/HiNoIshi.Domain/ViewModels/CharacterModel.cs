using HiNoIshi.Domain.Core;
using HiNoIshi.Domain.Core.CharacterData;

namespace HiNoIshi.Domain.ViewModels
{
    public class CharacterModel
    {
        public Profile Profile { get; set; }
        public Attributes Attributes { get; set; }
        public Skills Skills { get; set; }
        public Background Background { get; set; }
        public AccessKey AccessKey { get; set; }
    }
}