using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CarPriceUSA.Models;

namespace CarPriceUSA.Services
{
    public class DeliveryService
    {
        private readonly FixedCostsConfig _config;
        private readonly List<Port> _ports;
        private readonly string _geoApiKey;

        public DeliveryService(FixedCostsConfig config, string geoApiKey)
        {
            _config = config;
            _geoApiKey = geoApiKey;
            _ports = new List<Port>
            {
                new Port { Name = "Los Angeles", State = "California", Latitude = 33.7405, Longitude = -118.27 },
                new Port { Name = "New York and New Jersey", State = "New York/New Jersey", Latitude = 40.6681, Longitude = -74.0451 },
                new Port { Name = "Houston", State = "Texas", Latitude = 29.7363, Longitude = -95.265 },
                new Port { Name = "Savannah", State = "Georgia", Latitude = 32.0809, Longitude = -81.0912 },
                new Port { Name = "Miami", State = "Florida", Latitude = 25.7781, Longitude = -80.1794 },
                new Port { Name = "Baltimore", State = "Maryland", Latitude = 39.2747, Longitude = -76.5794 },
                new Port { Name = "Brunswick", State = "Georgia", Latitude = 31.1499, Longitude = -81.4915 }
            };
        }

        public async Task<(decimal finalCostAuctionPayment,
            decimal deliveryToPortCost,
            decimal deliveryToCity,
            decimal paymentToSeason,
            decimal fullRefundCost,
            decimal fullRefundDamagesCost)>
            Delivery(decimal price, bool fullRefund, bool fullRefundDamages, string city)
        {
            decimal deliveryToPortCost = (decimal)await DeliveryToPort(city);
            decimal deliveryToCity = _config.DeliveryToCity;
            decimal paymentToSeason = _config.PaymentToSeason;

            decimal fullRefundCost = fullRefund ? price * 1.5m : 0;
            decimal fullRefundDamagesCost = fullRefundDamages ? price * 5m : 0;

            decimal finalCostAuctionPayment = deliveryToPortCost + deliveryToCity +
                                             paymentToSeason + fullRefundCost + fullRefundDamagesCost;

            return (finalCostAuctionPayment,
                    deliveryToPortCost,
                    deliveryToCity,
                    paymentToSeason,
                    fullRefundCost,
                    fullRefundDamagesCost);
        }

        private async Task<double> DeliveryToPort(string city)
        {
            double distanceKm = await GetDistanceToNearestPortKmAsync(city);
            double ratePerKm = 1.2; // Наприклад, $1.2 за км
            return distanceKm * ratePerKm;
        }

        public async Task<double> GetDistanceToNearestPortKmAsync(string cityStateName)
        {
            var (lat, lon) = await GetCoordinatesAsync(cityStateName);
            var nearestPort = _ports.OrderBy(p => CalculateDistance(lat, lon, p.Latitude, p.Longitude)).First();
            return CalculateDistance(lat, lon, nearestPort.Latitude, nearestPort.Longitude);
        }

        private async Task<(double lat, double lon)> GetCoordinatesAsync(string location)
        {
            var url = $"https://api.opencagedata.com/geocode/v1/json?q={Uri.EscapeDataString(location)}&key={_geoApiKey}";
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url);
            using var doc = JsonDocument.Parse(response);

            var geometry = doc.RootElement
                .GetProperty("results")[0]
                .GetProperty("geometry");

            double lat = geometry.GetProperty("lat").GetDouble();
            double lon = geometry.GetProperty("lng").GetDouble();

            return (lat, lon);
        }

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // радіус Землі км
            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private double ToRadians(double angle) => angle * Math.PI / 180.0;
    }
}
