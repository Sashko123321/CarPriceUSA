using CarPriceUSA.Models;
using CarPriceUSA.Services;
using System.Globalization;
using System.Text.Json;

namespace CarPriceUSA
{
    public partial class Form1 : Form
    {
        private readonly List<PriceRangeFee> _auctionFeeTable;
        private readonly FixedCostsConfig _fixedCosts;
        private readonly Dictionary<string, decimal> _currencyRates;
        private readonly string _currentCurrency;
        private CalculatorService _calculator; // без readonly


        public Form1()
        {
            InitializeComponent();
            _auctionFeeTable = FeeTableProvider.GetFeeTable();
            _currencyRates = new() { { "USD", 1 }, { "UAH", 41 }, { "EUR", 0.9m } };
            _currentCurrency = "USD";
            _fixedCosts = LoadFixedCosts();
            _calculator = new CalculatorService(_auctionFeeTable, _fixedCosts);
        }

        private FixedCostsConfig LoadFixedCosts()
        {
            try
            {
                string json = File.ReadAllText("config.json");
                return JsonSerializer.Deserialize<FixedCostsConfig>(json);
            }
            catch
            {
                return new FixedCostsConfig
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

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textCostAuto.Text, out var price) ||
                !decimal.TryParse(comboBoxVolume.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var volume) ||
                (!int.TryParse(comboBoxYears.Text, out var year) && !comboBoxYears.Text.Contains("старіші")))
            {
                MessageBox.Show("Неправильно введені дані.");
                return;
            }

            if (comboBoxYears.Text.Contains("старіші")) year = 2008;

            var (auctionFee, toll, excise, vat, clearance, total) = _calculator.CalculateTotal(
                price, volume, year, checkBoxIsRepair.Checked);

            labelAuctionFee.Text = $"{auctionFee:0} {_currentCurrency}";
            labelToll.Text = $"{toll:0} {_currentCurrency}";
            labelExcise.Text = $"{excise:0} {_currentCurrency}";
            labelVAT.Text = $"{vat:0} {_currentCurrency}";
            labelFinalClearance.Text = $"{clearance:0} {_currentCurrency}";
            labelFinalCost.Text = $"{total:0} {_currentCurrency}";

            labelTransportingAcrossUSA.Text = $"{_fixedCosts.TransportUSA:0} {_currentCurrency}";
            labelTransportingAcrossKlaiped.Text = $"{_fixedCosts.TransportKlaipeda:0} {_currentCurrency}";
            labelTransportingAcrossTernopil.Text = $"{_fixedCosts.TransportTernopil:0} {_currentCurrency}";
            labelBroker.Text = $"{_fixedCosts.Broker:0} {_currentCurrency}";
            labelCommission.Text = $"{_fixedCosts.Commission:0} {_currentCurrency}";
            labelAdditionalCosts.Text = $"{_fixedCosts.AdditionalCosts:0} {_currentCurrency}";
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var configCopy = JsonSerializer.Deserialize<FixedCostsConfig>(
                JsonSerializer.Serialize(_fixedCosts));

            using var settingsForm = new FormSettings(configCopy);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                // Збереження у файл
                File.WriteAllText("config.json",
                    JsonSerializer.Serialize(configCopy, new JsonSerializerOptions { WriteIndented = true }));

                // ? Оновити основні об'єкти
                _fixedCosts.TransportUSA = configCopy.TransportUSA;
                _fixedCosts.TransportKlaipeda = configCopy.TransportKlaipeda;
                _fixedCosts.TransportTernopil = configCopy.TransportTernopil;
                _fixedCosts.Broker = configCopy.Broker;
                _fixedCosts.Commission = configCopy.Commission;
                _fixedCosts.AdditionalCosts = configCopy.AdditionalCosts;
                _fixedCosts.RepairCost = configCopy.RepairCost;

                // ?? оновити CalculatorService
                _calculator = new CalculatorService(_auctionFeeTable, _fixedCosts);

            }
        }


        private void buttonSaveResultInTxt_Click(object sender, EventArgs e)
        {
            var result = $@"
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
            Дата: {DateTime.Now}";

            using SaveFileDialog sfd = new() { Filter = "Text files (*.txt)|*.txt", FileName = "CarPriceCalculation.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, result);
                MessageBox.Show("Результат збережено!");
            }
        }
    }
}
