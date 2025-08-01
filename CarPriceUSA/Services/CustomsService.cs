using CarPriceUSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPriceUSA.Services;

public class CustomService
{

    private readonly FixedCostsConfig _config;

    public CustomService(FixedCostsConfig config)
    {
        _config = config;

    }

    /// <summary>
    /// Розрахунок митних платежів
    /// </summary>
    /// <param name="finalCostAuctionPayment">Вартість авто з аукціону</param>
    /// <param name="year">Рік випуску авто</param>
    /// <param name="engineVolume">Обʼєм двигуна в літрах</param>
    /// <param name="isDiesel">Дизель чи ні</param>
    /// <returns>Кортеж з: загальна вартість митних платежів, тариф брокера, власне мито</returns>
    public (decimal finalCustomsCost, decimal tariffBroker, decimal customsCost, decimal unloadingKlaipeda) Customs(
        decimal finalCostAuctionPayment,
        int year,
        decimal engineVolume,
        bool isDiesel)
    {
        // База для розрахунку мита — вважаємо що це finalCostAuctionPayment
        decimal baseForDuty = finalCostAuctionPayment;

        // Мито — 10% від бази
        decimal toll = baseForDuty * 0.10m;

        // Вік авто
        int age = Math.Max(0, 2025 - year);

        // Акциз
        decimal excise;
        if (isDiesel)
        {
            excise = engineVolume * age * (engineVolume >= 3.5m ? 150m : 75m);
        }
        else
        {
            excise = engineVolume * age * (engineVolume >= 3.0m ? 100m : 50m);
        }

        // ПДВ (20%)
        decimal vat = (baseForDuty + toll + excise) * 0.20m;

        // Загальна сума митних платежів (без брокера і розвантаження)
        decimal customsCost = toll + excise + vat;

        // Фінальна вартість з урахуванням брокера і розвантаження
        decimal finalCustomsCost = customsCost + _config.TariffBroker + _config.UnloadingKlaipeda;

        return (finalCustomsCost, _config.TariffBroker, customsCost, _config.UnloadingKlaipeda);
    }
}

