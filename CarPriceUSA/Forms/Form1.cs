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
                (!int.TryParse(comboBoxYears.Text, out var year) && !comboBoxYears.Text.Contains("������")))
            {
                MessageBox.Show("����������� ������� ����.");
                return;
            }

            if (comboBoxYears.Text.Contains("������")) year = 2008;

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
                MessageBox.Show("������ ��� ��������.");
                return;
            }
            var cityInput = textBoxCity.Text.Trim();
            string city;

            if (string.IsNullOrEmpty(cityInput))
            {
                MessageBox.Show("̳��� �� �������. ����������� ���� �� �������������: CA - SAN BERNARDINO",
                                "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



            labelAuctionFee.Text = $"{auctionFee:0} {_currentCurrency}";
            labelToll.Text = $"{toll:0} {_currentCurrency}";
            labelExcise.Text = $"{excise:0} {_currentCurrency}";
            labelVAT.Text = $"{vat:0} {_currentCurrency}";
            labelFinalClearance.Text = $"{clearance:0} {_currentCurrency}";
            labelFinalCost.Text = $"{total:0} {_currentCurrency}";

            labelTransportingAcrossUSA.Text = $"{transportUsa:0} {_currentCurrency}";
            labelTransportingAcrossKlaiped.Text = $"{_fixedCosts.TransportKlaipeda:0} {_currentCurrency}";
            labelTransportingAcrossTernopil.Text = $"{_fixedCosts.TransportTernopil:0} {_currentCurrency}";
            labelBroker.Text = $"{_fixedCosts.Broker:0} {_currentCurrency}";
            labelAdditionalCosts.Text = $"{_fixedCosts.AdditionalCosts:0} {_currentCurrency}";
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
            var result = $@"
            ֳ�� �� ��������: {textCostAuto.Text} {_currentCurrency}
            ����� ��������: {labelAuctionFee.Text}
            ��������������� ���: {labelTransportingAcrossUSA.Text}
            ��������������� ��������: {labelTransportingAcrossKlaiped.Text}
            ��������������� ��������: {labelTransportingAcrossTernopil.Text}
            ����: {labelToll.Text}
            �����: {labelExcise.Text}
            ���: {labelVAT.Text}
            ������: {labelBroker.Text}
            �������� �������: {labelAdditionalCosts.Text}
            �������: {labelFinalClearance.Text}
            ������: {(checkBoxIsRepair.Checked ? _fixedCosts.RepairCost : "ͳ")}
            �������� �������: {labelFinalCost.Text}
            ����: {DateTime.Now}";

            using SaveFileDialog sfd = new() { Filter = "Text files (*.txt)|*.txt", FileName = "CarPriceCalculation.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, result);
                MessageBox.Show("��������� ���������!");
            }
        }
    }
}
