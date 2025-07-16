using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using CarPriceUSA.Models;

namespace CarPriceUSA
{
    public partial class FormSettings : Form
    {
        private FixedCostsConfig _config;

        public FormSettings(FixedCostsConfig config)
        {
            InitializeComponent();
            _config = config;

            // Заповнення текстбоксів
            //textBoxTransportUSA.Text = _config.TransportUSA.ToString();
            textBoxTransportKlaipeda.Text = _config.TransportKlaipeda.ToString();
            textBoxTransportTernopil.Text = _config.TransportTernopil.ToString();
            textBoxBroker.Text = _config.Broker.ToString();
            textBoxCommission.Text = _config.Commission.ToString();
            textBoxAdditionalCosts.Text = _config.AdditionalCosts.ToString();
            textBoxRepairCost.Text = _config.RepairCost.ToString();

            //buttonSaveResult.Click += buttonSaveResult_Click;
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                //_config.TransportUSA = decimal.Parse(textBoxTransportUSA.Text);
                _config.TransportKlaipeda = decimal.Parse(textBoxTransportKlaipeda.Text);
                _config.TransportTernopil = decimal.Parse(textBoxTransportTernopil.Text);
                _config.Broker = decimal.Parse(textBoxBroker.Text);
                _config.Commission = decimal.Parse(textBoxCommission.Text);
                _config.AdditionalCosts = decimal.Parse(textBoxAdditionalCosts.Text);
                _config.RepairCost = decimal.Parse(textBoxRepairCost.Text);

                string json = JsonSerializer.Serialize(_config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("config.json", json);

                MessageBox.Show(this, "Налаштування збережено!", "Info");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }
    }
}
