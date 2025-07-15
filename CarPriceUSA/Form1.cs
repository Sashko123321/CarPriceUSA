using System.Globalization;
using System.Text.Json;
using CarPriceUSA.Models;

namespace CarPriceUSA
{
    public partial class Form1 : Form
    {
        private readonly List<PriceRangeFee> _auctionFeeTable = new List<PriceRangeFee>
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

        private readonly Dictionary<string, decimal> _currencyRates = new Dictionary<string, decimal>
        {
            { "USD", 1m },
            { "UAH", 38m },
            { "EUR", 0.9m }
        };

        private string _currentCurrency = "USD";
        private FixedCostsConfig _fixedCosts;

        public Form1()
        {
            InitializeComponent();
            LoadFixedCosts();
            buttonRun.Click += buttonRun_Click;
            buttonSaveResult.Click += buttonSaveResult_Click;
            buttonSettings.Click += buttonSettings_Click;
            comboBoxSetCurrency.SelectedIndexChanged += comboBoxSetCurrency_SelectedIndexChanged;
        }
        private void LoadFixedCosts()
        {
            try
            {
                string json = File.ReadAllText("config.json");
                _fixedCosts = JsonSerializer.Deserialize<FixedCostsConfig>(json);
            }
            catch
            {
                _fixedCosts = new FixedCostsConfig
                {
                    TransportUSA = 550,
                    TransportKlaipeda = 1300,
                    TransportTernopil = 800,
                    Broker = 200,
                    Commission = 450,
                    AdditionalCosts = 300,
                    RepairCost = 1000
                };
            }
        }

        private decimal CalculateAuctionFee(decimal price)
        {
            var matched = _auctionFeeTable.FirstOrDefault(r =>
                price >= r.Min && (r.Max == null || price <= r.Max));
            if (matched == null) return 0;
            return matched.IsPercentage ? price * matched.Fee : matched.Fee;
        }

        private CultureInfo GetCultureInfoForCurrency(string currency)
        {
            return currency switch
            {
                "USD" => new CultureInfo("en-US"),
                "UAH" => new CultureInfo("uk-UA"),
                "EUR" => new CultureInfo("fr-FR"),
                _ => CultureInfo.InvariantCulture
            };
        }

        private void comboBoxSetCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newCurrency = comboBoxSetCurrency.SelectedItem?.ToString() ?? "USD";
            if (!_currencyRates.ContainsKey(newCurrency)) return;

            decimal oldRate = _currencyRates[_currentCurrency];
            decimal newRate = _currencyRates[newCurrency];
            decimal conversionFactor = newRate / oldRate;

            decimal ParseLabel(Label lbl)
            {
                var text = lbl.Text.Replace("?", "").Replace("$", "").Replace("€", "").Trim();
                return decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out var val) ? val : 0m;
            }

            void UpdateLabel(Label lbl) =>
                lbl.Text = (ParseLabel(lbl) * conversionFactor).ToString("C0", GetCultureInfoForCurrency(newCurrency));

            UpdateLabel(labelAuctionFee);
            UpdateLabel(labelTransportingAcrossUSA);
            UpdateLabel(labelTransportingAcrossKlaiped);
            UpdateLabel(labelTransportingAcrossTernopil);
            UpdateLabel(labelToll);
            UpdateLabel(labelExcise);
            UpdateLabel(labelVAT);
            UpdateLabel(labelBroker);
            UpdateLabel(labelCommission);
            UpdateLabel(labelAdditionalCosts);
            UpdateLabel(labelFinalClearance);
            UpdateLabel(labelFinalCost);

            _currentCurrency = newCurrency;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textCostAuto.Text, out decimal auctionPrice))
            {
                MessageBox.Show("Некоректна ціна на аукціоні.");
                return;
            }

            if (!decimal.TryParse(comboBoxVolume.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal engineVolume))
            {
                MessageBox.Show("Оберіть об’єм двигуна.");
                return;
            }

            int carYear;
            if (!int.TryParse(comboBoxYears.Text, out carYear))
            {
                if (comboBoxYears.Text.Contains("старіші"))
                    carYear = 2008;
                else
                {
                    MessageBox.Show("Оберіть рік автомобіля.");
                    return;
                }
            }

            // Підрахунок
            decimal auctionFee = CalculateAuctionFee(auctionPrice);
            decimal transportUSA = _fixedCosts.TransportUSA;
            decimal transportKlaipeda = _fixedCosts.TransportKlaipeda;
            decimal transportTernopil = _fixedCosts.TransportTernopil;
            decimal broker = _fixedCosts.Broker;
            decimal commission = _fixedCosts.Commission;
            decimal additionalCosts = _fixedCosts.AdditionalCosts;
            decimal repairCost = checkBoxIsRepair.Checked ? _fixedCosts.RepairCost : 0;

            decimal baseForDuty = auctionPrice + auctionFee + transportKlaipeda + 300;
            decimal toll = baseForDuty * 0.10m;

            int age = Math.Max(0, 2025 - carYear);
            decimal excise = engineVolume * age * (engineVolume >= 3.0m ? 100 : 50);

            decimal vat = (baseForDuty + toll + excise) * 0.20m;
            decimal clearance = toll + excise + vat;

            decimal total = auctionPrice + auctionFee + transportUSA + transportKlaipeda + transportTernopil +
                            clearance + broker + commission + additionalCosts + repairCost;

            // Вивід
            labelAuctionFee.Text = auctionFee.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelTransportingAcrossUSA.Text = transportUSA.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelTransportingAcrossKlaiped.Text = transportKlaipeda.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelTransportingAcrossTernopil.Text = transportTernopil.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelToll.Text = toll.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelExcise.Text = excise.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelVAT.Text = vat.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelBroker.Text = broker.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelCommission.Text = commission.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelAdditionalCosts.Text = additionalCosts.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelFinalClearance.Text = clearance.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
            labelFinalCost.Text = total.ToString("C0", GetCultureInfoForCurrency(_currentCurrency));
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            string result = $@"
Розрахунок вартості авто:
--------------------------
Ціна на аукціоні: {textCostAuto.Text} {_currentCurrency}
Комісія аукціону: {labelAuctionFee.Text}
Транспортування США: {labelTransportingAcrossUSA.Text}
Транспортування Клайпеда: {labelTransportingAcrossKlaiped.Text}
Транспортування Тернопіль: {labelTransportingAcrossTernopil.Text}
Мито: {labelToll.Text}
Акциз: {labelExcise.Text}
ПДВ: {labelVAT.Text}
Брокер: {labelBroker.Text}
Комісія: {labelCommission.Text}
Додаткові витрати: {labelAdditionalCosts.Text}
Очистка: {labelFinalClearance.Text}
Ремонт: {(checkBoxIsRepair.Checked ? "Так" : "Ні")}
Загальна вартість: {labelFinalCost.Text}
Дата: {DateTime.Now}
";

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Text files (*.txt)|*.txt", FileName = "CarPriceCalculation.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, result);
                    MessageBox.Show("Результат збережено!");
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var configCopy = JsonSerializer.Deserialize<FixedCostsConfig>(JsonSerializer.Serialize(_fixedCosts));
            using (var settingsForm = new FormSettings(configCopy))
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    _fixedCosts = configCopy;
                    LoadFixedCosts();
                }
            }
        }
    }
}
