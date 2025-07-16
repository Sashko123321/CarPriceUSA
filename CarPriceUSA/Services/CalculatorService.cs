using CarPriceUSA.Models;

namespace CarPriceUSA.Services
{
    public class CalculatorService
    {
        private readonly List<PriceRangeFee> _fees;
        private readonly FixedCostsConfig _costs;
        private readonly NearestPortService _portService;

        public CalculatorService(List<PriceRangeFee> fees, FixedCostsConfig costs, NearestPortService portService)
        {
            _fees = fees;
            _costs = costs;
            _portService = portService;
        }


        public decimal GetAuctionFee(decimal price)
        {
            var matched = _fees.FirstOrDefault(r => price >= r.Min && (r.Max == null || price <= r.Max));
            return matched == null ? 0 : matched.IsPercentage ? price * matched.Fee : matched.Fee;
        }

        public async Task<(decimal auctionFee, decimal toll, decimal excise, decimal vat, decimal clearance, decimal total, decimal transportUsa)>
    CalculateTotalAsync(decimal price, decimal engineVolume, int year, bool isRepair, bool isDiesel, string cityStateName)
        {
            var auctionFee = GetAuctionFee(price);
            var distance = await _portService.GetDistanceToNearestPortKmAsync(cityStateName);
            var transportUsa = (decimal)distance * 0.6m * 2;

            var baseForDuty = price + auctionFee + _costs.TransportKlaipeda + 300;
            var toll = baseForDuty * 0.10m;
            var age = Math.Max(0, 2025 - year);

            decimal excise;
            if (isDiesel)
            {
                excise = engineVolume * age * (engineVolume >= 3.5m ? 150 : 75);
            }
            else
            {
                excise = engineVolume * age * (engineVolume >= 3.0m ? 100 : 50);
            }

            var vat = (baseForDuty + toll + excise) * 0.20m;
            var clearance = toll + excise + vat;
            var repair = isRepair ? _costs.RepairCost : 0;

            var total = price + auctionFee + transportUsa + _costs.TransportKlaipeda +
                        _costs.TransportTernopil + clearance + _costs.Broker +
                        _costs.Commission + _costs.AdditionalCosts + repair;

            return (auctionFee, toll, excise, vat, clearance, total, transportUsa);
        }


    }
}
