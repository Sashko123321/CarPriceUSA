using CarPriceUSA.Models;

namespace CarPriceUSA.Services
{
    public class AuctionPaymentService
    {
        private readonly FixedCostsConfig _config;

        public AuctionPaymentService(FixedCostsConfig config)
        {
            _config = config;
        }

        public (
            decimal FinalPrice,
            decimal BidPrice,
            decimal TariffCopart,
            decimal TariffAutoBidMaster,
            decimal DocumentCost,
            decimal MoneyTransfer,
            decimal UnlimitSavedCarCost
        ) CalculateFinalCost(decimal bidPrice, bool unlimitSavedCars)
        {
            decimal unlimitCost = unlimitSavedCars ? _config.UnlimitSavedCarCost : 0;

            decimal finalPrice = bidPrice
                + _config.TariffCopart
                + _config.TariffAutoBidMaster
                + _config.DocumentCost
                + _config.MoneyTransfer
                + unlimitCost;

            return (
                finalPrice,
                bidPrice,
                _config.TariffCopart,
                _config.TariffAutoBidMaster,
                _config.DocumentCost,
                _config.MoneyTransfer,
                unlimitCost
            );
        }
    }
}
