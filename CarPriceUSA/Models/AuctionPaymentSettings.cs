using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPriceUSA.Models;

public class AuctionPaymentSettings
{
    public decimal TariffCopart { get; set; }
    public decimal TariffAutoBidMaster { get; set; }
    public decimal DocumentCost { get; set; }
    public decimal MoneyTransfer { get; set; }
    public decimal UnlimitSavedCarCost { get; set; }
}
