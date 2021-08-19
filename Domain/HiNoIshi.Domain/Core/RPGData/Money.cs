namespace HiNoIshi.Domain.Core.RPGData
{
    public class Money
    {
        public decimal Quantity { get; set; }
        public string Currency = "¥";

        public override string ToString() => $"{Quantity:C0}{Currency}";
    }
}