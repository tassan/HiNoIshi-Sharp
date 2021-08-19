namespace HiNoIshi.Domain.Core.RPGData
{
    public class Level
    {
        public int Value { get; set; }

        public void Increase() => Value++;
        public void Decrease() => Value--;
    }
}