using CarPriceUSA.Models;

namespace CarPriceUSA.Services
{
    public class CalculatorService
    {
        private readonly List<PriceRangeFee> _fees;
        private readonly FixedCostsConfig _costs;

        public CalculatorService(List<PriceRangeFee> fees, FixedCostsConfig costs)
        {
            _fees = fees;
            _costs = costs;
        }

        public decimal GetAuctionFee(decimal price)
        {
            var matched = _fees.FirstOrDefault(r => price >= r.Min && (r.Max == null || price <= r.Max));
            return matched == null ? 0 : matched.IsPercentage ? price * matched.Fee : matched.Fee;
        }

        public (decimal auctionFee, decimal toll, decimal excise, decimal vat, decimal clearance, decimal total) CalculateTotal(
            decimal price, decimal engineVolume, int year, bool isRepair)
        {
            var auctionFee = GetAuctionFee(price);
            var baseForDuty = price + auctionFee + _costs.TransportKlaipeda + 300;
            var toll = baseForDuty * 0.10m;
            var age = Math.Max(0, 2025 - year);
            var excise = engineVolume * age * (engineVolume >= 3.0m ? 100 : 50);
            var vat = (baseForDuty + toll + excise) * 0.20m;
            var clearance = toll + excise + vat;
            var repair = isRepair ? _costs.RepairCost : 0;

            var total = price + auctionFee + _costs.TransportUSA + _costs.TransportKlaipeda +
                        _costs.TransportTernopil + clearance + _costs.Broker +
                        _costs.Commission + _costs.AdditionalCosts + repair;

            return (auctionFee, toll, excise, vat, clearance, total);
        }
    }
}
