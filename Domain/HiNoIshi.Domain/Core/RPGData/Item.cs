using HiNoIshi.Domain.Enums;

namespace HiNoIshi.Domain.Core.RPGData
{
    public class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public string Description { get; set; }
    }
}