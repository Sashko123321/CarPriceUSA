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
        private readonly NearestPortService _portService;

        private CalculatorService _calculator;


        public Form1()
        {
            InitializeComponent();  
            _auctionFeeTable = FeeTableProvider.GetFeeTable();
            _fixedCosts = LoadFixedCosts();
            string geoApiKey = "d8a92b2c7e66433b8a88cb636180e783";
            _portService = new NearestPortService(geoApiKey);
            _calculator = new CalculatorService(_auctionFeeTable, _fixedCosts, _portService);

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
                    TransportKlaipeda = 1300,
                    TransportTernopil = 900,
                    Broker = 450,
                    AdditionalCosts = 700,
                    RepairCost = 1000
                };
            }
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textCostAuto.Text, out var price) ||
                !decimal.TryParse(comboBoxVolume.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var volume) ||
                (!int.TryParse(comboBoxYears.Text, out var year) && !comboBoxYears.Text.Contains("старіші")))
            {
                MessageBox.Show("Неправильно введені дані.");
                return;
            }

            if (comboBoxYears.Text.Contains("старіші")) year = 2008;

            bool isDiesel;
            if (radioButtonDiesel.Checked)
            {
                isDiesel = true;
            }
            else if (radioButtonGas.Checked)
            {
                isDiesel = false;
            }
            else
            {
                MessageBox.Show("Оберіть тип пального.");
                return;
            }
            var cityInput = textBoxCity.Text.Trim();
            string city;

            if (string.IsNullOrEmpty(cityInput))
            {
                MessageBox.Show("Місто не введено. Використано місто за замовчуванням: CA - SAN BERNARDINO",
                                "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                city = "CA - SAN BERNARDINO";
            }
            else
            {
                city = cityInput;
            }

            var (auctionFee, toll, excise, vat, clearance, total, transportUsa) =
                await _calculator.CalculateTotalAsync(
                    price,
                    volume,
                    year,
                    checkBoxIsRepair.Checked,
                    isDiesel,
                    city
                );


            labelAuctionСommission.Text = $"{price + auctionFee + _fixedCosts.AdditionalCosts + _fixedCosts.RepairCost} {_currentCurrency}";
            labelFinalBid.Text = $"{price:0} {_currentCurrency}";
            labelAuctionFee.Text = $"{auctionFee:0} {_currentCurrency}";
            labelTariffs.Text = $"{_fixedCosts.AdditionalCosts:0} {_currentCurrency}";
            labelPaymentForDocuments.Text = $"{_fixedCosts.RepairCost:0} {_currentCurrency}";

            labelDelivery.Text = $"{_fixedCosts.TransportKlaipeda + _fixedCosts.TransportTernopil + transportUsa} {_currentCurrency}";
            labelDeliveryPort.Text = $"{transportUsa:0} {_currentCurrency}";
            labelCityDelivery.Text = $"{_fixedCosts.TransportTernopil + _fixedCosts.TransportKlaipeda} {_currentCurrency}";

            labelCustoms.Text = $"{(toll + excise + vat) + _fixedCosts.TransportKlaipeda + _fixedCosts.Broker} {_currentCurrency}";

            labelBrokerFee.Text = $"{_fixedCosts.Broker:0} {_currentCurrency}";
            labelCustomsClearance.Text = $"{(toll + excise + vat):0} {_currentCurrency}";
            labelUnloadingPort.Text = $"{_fixedCosts.TransportKlaipeda:0} {_currentCurrency}";

            labelTotalPrices.Text = $"{total:0} {_currentCurrency}";


        }



        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var configCopy = JsonSerializer.Deserialize<FixedCostsConfig>(
                JsonSerializer.Serialize(_fixedCosts));

            using var settingsForm = new FormSettings(configCopy);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText("config.json",
                    JsonSerializer.Serialize(configCopy, new JsonSerializerOptions { WriteIndented = true }));


                _fixedCosts.TransportKlaipeda = configCopy.TransportKlaipeda;
                _fixedCosts.TransportTernopil = configCopy.TransportTernopil;
                _fixedCosts.Broker = configCopy.Broker;
                _fixedCosts.Commission = configCopy.Commission;
                _fixedCosts.AdditionalCosts = configCopy.AdditionalCosts;
                _fixedCosts.RepairCost = configCopy.RepairCost;

                _calculator = new CalculatorService(_auctionFeeTable, _fixedCosts, _portService);

            }
        }


        private void buttonSaveResultInTxt_Click(object sender, EventArgs e)
        {
            //var result = $@"
            //Ціна на аукціоні: {textCostAuto.Text} {_currentCurrency}
            //Комісія аукціону: {labelAuctionFee.Text}
            //Транспортування США: {labelTransportingAcrossUSA.Text}
            //Транспортування Клайпеда: {labelTransportingAcrossKlaiped.Text}
            //Транспортування Тернопіль: {labelTransportingAcrossTernopil.Text}
            //Мито: {labelToll.Text}
            //Акциз: {labelExcise.Text}
            //ПДВ: {labelVAT.Text}
            //Брокер: {labelBroker.Text}
            //Додаткові витрати: {labelAdditionalCosts.Text}
            //Очистка: {labelFinalClearance.Text}
            //Ремонт: {(checkBoxIsRepair.Checked ? _fixedCosts.RepairCost : "Ні")}
            //Загальна вартість: {labelFinalCost.Text}
            //Дата: {DateTime.Now}";

            using SaveFileDialog sfd = new() { Filter = "Text files (*.txt)|*.txt", FileName = "CarPriceCalculation.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //File.WriteAllText(sfd.FileName, result);
                MessageBox.Show("Результат збережено!");
            }
        }
    }
}
