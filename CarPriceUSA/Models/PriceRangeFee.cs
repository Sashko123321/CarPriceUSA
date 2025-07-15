namespace CarPriceUSA.Models
{
    public class PriceRangeFee
    {
        public decimal Min { get; set; }
        public decimal? Max { get; set; }
        public decimal Fee { get; set; }
        public bool IsPercentage { get; set; }
    }
}
