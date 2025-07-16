using System.Net.Http;
using System.Text.Json;
using CarPriceUSA.Models;

public class NearestPortService
{
    private readonly List<Port> _ports;
    private readonly string _geoApiKey;

    public NearestPortService(string geoApiKey)
    {
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
        const double R = 6371;
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
