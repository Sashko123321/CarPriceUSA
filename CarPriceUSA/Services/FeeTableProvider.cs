using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPriceUSA.Models;

namespace CarPriceUSA.Services;

public class FeeTableProvider
{
    public static List<PriceRangeFee> GetFeeTable() => new List<PriceRangeFee>
    {
         new PriceRangeFee { Min = 0.00m, Max = 49.99m, Fee = 25.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 50.00m, Max = 99.99m, Fee = 45.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 100.00m, Max = 199.99m, Fee = 80.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 200.00m, Max = 299.99m, Fee = 130.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 300.00m, Max = 349.99m, Fee = 137.5000m, IsPercentage = false },
            new PriceRangeFee { Min = 350.00m, Max = 399.99m, Fee = 145.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 400.00m, Max = 449.99m, Fee = 175.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 450.00m, Max = 499.99m, Fee = 185.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 500.00m, Max = 549.99m, Fee = 205.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 550.00m, Max = 599.99m, Fee = 210.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 600.00m, Max = 699.99m, Fee = 240.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 700.00m, Max = 799.99m, Fee = 270.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 800.00m, Max = 899.99m, Fee = 295.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 900.00m, Max = 999.99m, Fee = 320.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1000.00m, Max = 1199.99m, Fee = 375.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1200.00m, Max = 1299.99m, Fee = 395.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1300.00m, Max = 1399.99m, Fee = 410.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1400.00m, Max = 1499.99m, Fee = 430.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1500.00m, Max = 1599.99m, Fee = 445.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1600.00m, Max = 1699.99m, Fee = 465.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1700.00m, Max = 1799.99m, Fee = 485.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 1800.00m, Max = 1999.99m, Fee = 510.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 2000.00m, Max = 2399.99m, Fee = 535.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 2400.00m, Max = 2499.99m, Fee = 570.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 2500.00m, Max = 2999.99m, Fee = 610.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 3000.00m, Max = 3499.99m, Fee = 655.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 3500.00m, Max = 3999.99m, Fee = 705.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 4000.00m, Max = 4499.99m, Fee = 725.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 4500.00m, Max = 4999.99m, Fee = 750.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 5000.00m, Max = 5499.99m, Fee = 775.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 5500.00m, Max = 5999.99m, Fee = 800.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 6000.00m, Max = 6499.99m, Fee = 825.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 6500.00m, Max = 6999.99m, Fee = 845.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 7000.00m, Max = 7499.99m, Fee = 880.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 7500.00m, Max = 7999.99m, Fee = 900.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 8000.00m, Max = 8499.99m, Fee = 925.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 8500.00m, Max = 8999.99m, Fee = 945.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 9000.00m, Max = 9999.99m, Fee = 945.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 10000.00m, Max = 10499.99m, Fee = 1000.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 10500.00m, Max = 10999.99m, Fee = 1000.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 11000.00m, Max = 11499.99m, Fee = 1000.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 11500.00m, Max = 11999.99m, Fee = 1000.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 12000.00m, Max = 12499.99m, Fee = 1000.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 12500.00m, Max = 14999.99m, Fee = 1000.0000m, IsPercentage = false },
            new PriceRangeFee { Min = 15000.00m, Max = null, Fee = 0.0750m, IsPercentage = true }
    };
}