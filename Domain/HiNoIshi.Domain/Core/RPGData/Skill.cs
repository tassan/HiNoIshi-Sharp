using HiNoIshi.Domain.Enums;

namespace HiNoIshi.Domain.Core.RPGData
{
    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillRank Rank { get; set; }
        public int Value { get; set; }
        public SkillType Type { get; set; }
        public ElementalType ElementalType { get; set; }
    }
}