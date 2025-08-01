using CarPriceUSA.Models;
using CarPriceUSA.Services;
using System.Globalization;
using System.Text.Json;

namespace CarPriceUSA
{
    public partial class Form1 : Form
    {
        private FixedCostsConfig _config;
        private DeliveryService _deliveryService;
        private CustomService _customService;

        private string _geoApiKey = "d8a92b2c7e66433b8a88cb636180e783";

        public Form1()
        {
            InitializeComponent();
            LoadConfig();
            InitializeServices();

            buttonRun.Click += ButtonRun_Click;

        }

        private void LoadConfig()
        {
            try
            {
                string json = File.ReadAllText("config.json");
                _config = JsonSerializer.Deserialize<FixedCostsConfig>(json)!;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading config: {ex.Message}");
                _config = new FixedCostsConfig(); // default values if needed
            }
        }

        private void InitializeServices()
        {
            _deliveryService = new DeliveryService(_config, _geoApiKey);
            _customService = new CustomService(_config);
        }

        private async void ButtonRun_Click(object sender, EventArgs e)
        {
            try
            {
                // Парсимо вхідні дані
                if (!decimal.TryParse(textCostAuto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price))
                {
                    MessageBox.Show("Invalid price");
                    return;
                }

                if (comboBoxYears.SelectedItem == null || !int.TryParse(comboBoxYears.SelectedItem.ToString(), out int year))
                {
                    MessageBox.Show("Select valid year");
                    return;
                }

                if (comboBoxVolume.SelectedItem == null || !decimal.TryParse(comboBoxVolume.SelectedItem.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal volume))
                {
                    MessageBox.Show("Select valid engine volume");
                    return;
                }

                bool isDiesel = radioButtonDiesel.Checked;
                string city = textBoxCity.Text.Trim();

                // Розрахунок аукціону (припустимо fullRefund=false, fullRefundDamages=false, бо не вказано UI для них)
                // Якщо потрібні чекбокси - додай аналогічно.
                var auctionService = new AuctionPaymentService(_config);
                var auctionResult = auctionService.CalculateFinalCost(price, false);

                // Розрахунок доставки
                var deliveryResult = await _deliveryService.Delivery(auctionResult.FinalPrice, fullRefund: false, fullRefundDamages: false, city);

                // Розрахунок митних платежів
                var customsResult = _customService.Customs(deliveryResult.finalCostAuctionPayment, year, volume, isDiesel);

                // Відображення результатів у Label

                labelFinalBid.Text = auctionResult.BidPrice.ToString("C", CultureInfo.CurrentCulture);
                labelAuctionСommission.Text = auctionResult.TariffCopart.ToString("C", CultureInfo.CurrentCulture);
                labelAuctionFee.Text = auctionResult.TariffAutoBidMaster.ToString("C", CultureInfo.CurrentCulture);
                labelPaymentForDocuments.Text = auctionResult.DocumentCost.ToString("C", CultureInfo.CurrentCulture);
                labelDelivery.Text = deliveryResult.finalCostAuctionPayment.ToString("C", CultureInfo.CurrentCulture);
                labelDeliveryPort.Text = deliveryResult.deliveryToPortCost.ToString("C", CultureInfo.CurrentCulture);
                labelCityDelivery.Text = deliveryResult.deliveryToCity.ToString("C", CultureInfo.CurrentCulture);
                labelPaymentForDocuments.Text = deliveryResult.paymentToSeason.ToString("C", CultureInfo.CurrentCulture);
                labelUnloadingPort.Text = deliveryResult.fullRefundCost.ToString("C", CultureInfo.CurrentCulture);
                labelBrokerFee.Text = customsResult.tariffBroker.ToString("C", CultureInfo.CurrentCulture);
                labelCustoms.Text = customsResult.customsCost.ToString("C", CultureInfo.CurrentCulture);
                labelUnloadingPort.Text = customsResult.unloadingKlaipeda.ToString("C", CultureInfo.CurrentCulture);
                labelCustomsClearance.Text = customsResult.finalCustomsCost.ToString("C", CultureInfo.CurrentCulture);

                // Сума загальна
                decimal totalPrice = auctionResult.FinalPrice + deliveryResult.finalCostAuctionPayment + customsResult.finalCustomsCost;
                labelTotalPrices.Text = totalPrice.ToString("C", CultureInfo.CurrentCulture);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during calculation: {ex.Message}");
            }
        }
    }
}
