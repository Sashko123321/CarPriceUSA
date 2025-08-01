namespace CarPriceUSA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textCostAuto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxYears = new ComboBox();
            comboBoxVolume = new ComboBox();
            label3 = new Label();
            labeldsf = new Label();
            label11 = new Label();
            label15 = new Label();
            checkBoxIsRepair = new CheckBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            buttonRun = new Button();
            buttonSaveResultInTxt = new Button();
            buttonSettings = new Button();
            radioButtonGas = new RadioButton();
            radioButtonDiesel = new RadioButton();
            textBoxCity = new TextBox();
            label19 = new Label();
            label99 = new Label();
            labelAuctionСommission = new Label();
            label21 = new Label();
            labelFinalBid = new Label();
            label23 = new Label();
            labelgh = new Label();
            labelAuctionFee = new Label();
            label27 = new Label();
            labelDelivery = new Label();
            label30 = new Label();
            labelBrokerFee = new Label();
            label32 = new Label();
            labelCityDelivery = new Label();
            label36 = new Label();
            labelCustoms = new Label();
            label38 = new Label();
            labelCustomsClearance = new Label();
            label40 = new Label();
            labelDeliveryPort = new Label();
            label42 = new Label();
            labelUnloadingPort = new Label();
            labelPaymentForDocuments = new Label();
            labelTariffs = new Label();
            label4 = new Label();
            labelTotalPrices = new Label();
            labelTottal = new Label();
            SuspendLayout();
            // 
            // textCostAuto
            // 
            textCostAuto.Location = new Point(12, 35);
            textCostAuto.Name = "textCostAuto";
            textCostAuto.Size = new Size(150, 23);
            textCostAuto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Ціна на аукціоні";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Рік авто";
            // 
            // comboBoxYears
            // 
            comboBoxYears.FormattingEnabled = true;
            comboBoxYears.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008 і старіші" });
            comboBoxYears.Location = new Point(12, 90);
            comboBoxYears.Name = "comboBoxYears";
            comboBoxYears.Size = new Size(150, 23);
            comboBoxYears.TabIndex = 2;
            comboBoxYears.Text = "Виберіть рік";
            // 
            // comboBoxVolume
            // 
            comboBoxVolume.FormattingEnabled = true;
            comboBoxVolume.Items.AddRange(new object[] { "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0", "4.1", "4.2", "4.3", "4.4", "4.5", "4.6", "4.7", "4.8", "4.9", "5.0", "5.1", "5.2", "5.3", "5.4", "5.5", "5.6", "5.7", "5.8", "5.9", "6.0", "6.1", "6.2", "6.3", "6.4", "6.5", "6.6", "6.7", "6.8", "6.9", "7.0", "7.1", "7.2", "7.3", "7.4", "7.5", "7.6", "7.7", "7.8", "7.9", "8.0", "8.1", "8.2", "8.3", "8.4", "8.5", "8.6", "8.7", "8.8", "8.9", "9.0", "9.1", "9.2", "9.3", "9.4", "9.5", "9.6", "9.7", "9.8", "9.9", "10.0" });
            comboBoxVolume.Location = new Point(12, 143);
            comboBoxVolume.Name = "comboBoxVolume";
            comboBoxVolume.Size = new Size(150, 23);
            comboBoxVolume.TabIndex = 2;
            comboBoxVolume.Text = "Виберіть обєм двигуна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 1;
            label3.Text = "Обєм двигуна";
            // 
            // labeldsf
            // 
            labeldsf.AutoSize = true;
            labeldsf.Location = new Point(415, 87);
            labeldsf.Name = "labeldsf";
            labeldsf.Padding = new Padding(5);
            labeldsf.Size = new Size(103, 25);
            labeldsf.TabIndex = 3;
            labeldsf.Text = "Аукціоний збір:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(184, 440);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 3;
            label11.Text = "Брокер:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20F);
            label15.Location = new Point(12, 480);
            label15.Name = "label15";
            label15.Size = new Size(99, 37);
            label15.TabIndex = 3;
            label15.Text = "Разом:";
            // 
            // checkBoxIsRepair
            // 
            checkBoxIsRepair.AutoSize = true;
            checkBoxIsRepair.Location = new Point(202, 71);
            checkBoxIsRepair.Name = "checkBoxIsRepair";
            checkBoxIsRepair.Size = new Size(67, 19);
            checkBoxIsRepair.TabIndex = 4;
            checkBoxIsRepair.Text = "Ремонт";
            checkBoxIsRepair.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F);
            label16.Location = new Point(-16, 433);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(1084, 37);
            label16.TabIndex = 3;
            label16.Text = "_________________________________________________________________________________________________";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 20F);
            label17.Location = new Point(-142, 250);
            label17.Name = "label17";
            label17.Size = new Size(23, 370);
            label17.TabIndex = 5;
            label17.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(184, 13);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.Yes;
            label18.Size = new Size(0, 31);
            label18.TabIndex = 6;
            // 
            // buttonRun
            // 
            buttonRun.BackColor = Color.DarkSeaGreen;
            buttonRun.FlatAppearance.BorderColor = Color.Chartreuse;
            buttonRun.Font = new Font("Segoe UI", 20F);
            buttonRun.ForeColor = SystemColors.ControlLightLight;
            buttonRun.Location = new Point(606, 473);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(182, 51);
            buttonRun.TabIndex = 7;
            buttonRun.Text = "Рахувати";
            buttonRun.UseVisualStyleBackColor = false;
            buttonRun.Click += buttonRun_Click;
            // 
            // buttonSaveResultInTxt
            // 
            buttonSaveResultInTxt.Location = new Point(465, 480);
            buttonSaveResultInTxt.Name = "buttonSaveResultInTxt";
            buttonSaveResultInTxt.Size = new Size(135, 37);
            buttonSaveResultInTxt.TabIndex = 10;
            buttonSaveResultInTxt.Text = "Зберегти Розрахунок";
            buttonSaveResultInTxt.UseVisualStyleBackColor = true;
            //buttonSaveResultInTxt.Click += buttonSaveResultInTxt_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Font = new Font("Segoe UI", 10F);
            buttonSettings.Location = new Point(756, 7);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(32, 33);
            buttonSettings.TabIndex = 10;
            buttonSettings.Text = "⚙";
            buttonSettings.UseVisualStyleBackColor = true;
            //buttonSettings.Click += buttonSettings_Click;
            // 
            // radioButtonGas
            // 
            radioButtonGas.AutoSize = true;
            radioButtonGas.Location = new Point(15, 167);
            radioButtonGas.Name = "radioButtonGas";
            radioButtonGas.Size = new Size(64, 19);
            radioButtonGas.TabIndex = 11;
            radioButtonGas.TabStop = true;
            radioButtonGas.Text = "Бензин";
            radioButtonGas.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiesel
            // 
            radioButtonDiesel.AutoSize = true;
            radioButtonDiesel.Location = new Point(85, 167);
            radioButtonDiesel.Name = "radioButtonDiesel";
            radioButtonDiesel.Size = new Size(64, 19);
            radioButtonDiesel.TabIndex = 11;
            radioButtonDiesel.TabStop = true;
            radioButtonDiesel.Text = "Дизель";
            radioButtonDiesel.UseVisualStyleBackColor = true;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(202, 36);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(150, 23);
            textBoxCity.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(202, 17);
            label19.Name = "label19";
            label19.Size = new Size(75, 15);
            label19.TabIndex = 1;
            label19.Text = "Місто і Штат";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label99.Location = new Point(403, 38);
            label99.Name = "label99";
            label99.Size = new Size(148, 21);
            label99.TabIndex = 3;
            label99.Text = "Комісія аукціону:";
            // 
            // labelAuctionСommission
            // 
            labelAuctionСommission.AutoSize = true;
            labelAuctionСommission.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelAuctionСommission.Location = new Point(702, 36);
            labelAuctionСommission.Name = "labelAuctionСommission";
            labelAuctionСommission.Size = new Size(13, 13);
            labelAuctionСommission.TabIndex = 8;
            labelAuctionСommission.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label21.Location = new Point(415, 62);
            label21.Name = "label21";
            label21.Padding = new Padding(5);
            label21.Size = new Size(173, 25);
            label21.TabIndex = 3;
            label21.Text = "Фінальна ставка на аукціоні:";
            // 
            // labelFinalBid
            // 
            labelFinalBid.AutoSize = true;
            labelFinalBid.Location = new Point(702, 62);
            labelFinalBid.Name = "labelFinalBid";
            labelFinalBid.Size = new Size(13, 15);
            labelFinalBid.TabIndex = 8;
            labelFinalBid.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(415, 112);
            label23.Name = "label23";
            label23.Padding = new Padding(5);
            label23.Size = new Size(282, 25);
            label23.TabIndex = 3;
            label23.Text = "Тарифи на проведення операцій AutoBidMaster:";
            // 
            // labelgh
            // 
            labelgh.AutoSize = true;
            labelgh.Location = new Point(415, 137);
            labelgh.Name = "labelgh";
            labelgh.Padding = new Padding(5);
            labelgh.Size = new Size(136, 25);
            labelgh.TabIndex = 3;
            labelgh.Text = "Оплата за документи:";
            // 
            // labelAuctionFee
            // 
            labelAuctionFee.AutoSize = true;
            labelAuctionFee.Location = new Point(702, 87);
            labelAuctionFee.Name = "labelAuctionFee";
            labelAuctionFee.Size = new Size(13, 15);
            labelAuctionFee.TabIndex = 8;
            labelAuctionFee.Text = "0";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label27.Location = new Point(403, 162);
            label27.Name = "label27";
            label27.Size = new Size(87, 21);
            label27.TabIndex = 3;
            label27.Text = "Доставка:";
            // 
            // labelDelivery
            // 
            labelDelivery.AutoSize = true;
            labelDelivery.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelDelivery.Location = new Point(702, 167);
            labelDelivery.Name = "labelDelivery";
            labelDelivery.Size = new Size(13, 13);
            labelDelivery.TabIndex = 8;
            labelDelivery.Text = "0";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label30.Location = new Point(415, 254);
            label30.Margin = new Padding(5, 0, 5, 0);
            label30.Name = "label30";
            label30.Padding = new Padding(5);
            label30.Size = new Size(112, 25);
            label30.TabIndex = 3;
            label30.Text = "Тарифи Брокера:";
            // 
            // labelBrokerFee
            // 
            labelBrokerFee.AutoSize = true;
            labelBrokerFee.Location = new Point(702, 254);
            labelBrokerFee.Name = "labelBrokerFee";
            labelBrokerFee.Size = new Size(13, 15);
            labelBrokerFee.TabIndex = 8;
            labelBrokerFee.Text = "0";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label32.Location = new Point(415, 208);
            label32.Name = "label32";
            label32.Padding = new Padding(5);
            label32.Size = new Size(158, 25);
            label32.TabIndex = 3;
            label32.Text = "Доставка до м. Тернопіль";
            // 
            // labelCityDelivery
            // 
            labelCityDelivery.AutoSize = true;
            labelCityDelivery.Location = new Point(702, 208);
            labelCityDelivery.Name = "labelCityDelivery";
            labelCityDelivery.Size = new Size(13, 15);
            labelCityDelivery.TabIndex = 8;
            labelCityDelivery.Text = "0";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label36.Location = new Point(403, 233);
            label36.Name = "label36";
            label36.Size = new Size(85, 21);
            label36.TabIndex = 3;
            label36.Text = "Митниця:";
            // 
            // labelCustoms
            // 
            labelCustoms.AutoSize = true;
            labelCustoms.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelCustoms.Location = new Point(702, 233);
            labelCustoms.Name = "labelCustoms";
            labelCustoms.Size = new Size(13, 13);
            labelCustoms.TabIndex = 8;
            labelCustoms.Text = "0";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label38.Location = new Point(415, 279);
            label38.Name = "label38";
            label38.Padding = new Padding(5);
            label38.Size = new Size(133, 25);
            label38.TabIndex = 3;
            label38.Text = "Митне Оформлення:";
            // 
            // labelCustomsClearance
            // 
            labelCustomsClearance.AutoSize = true;
            labelCustomsClearance.Location = new Point(702, 279);
            labelCustomsClearance.Name = "labelCustomsClearance";
            labelCustomsClearance.Size = new Size(13, 15);
            labelCustomsClearance.TabIndex = 8;
            labelCustomsClearance.Text = "0";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label40.Location = new Point(415, 183);
            label40.Name = "label40";
            label40.Padding = new Padding(5);
            label40.Size = new Size(162, 25);
            label40.TabIndex = 3;
            label40.Text = "Доставка до Savannah, GA:";
            // 
            // labelDeliveryPort
            // 
            labelDeliveryPort.AutoSize = true;
            labelDeliveryPort.Location = new Point(702, 183);
            labelDeliveryPort.Name = "labelDeliveryPort";
            labelDeliveryPort.Size = new Size(13, 15);
            labelDeliveryPort.TabIndex = 8;
            labelDeliveryPort.Text = "0";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label42.Location = new Point(415, 304);
            label42.Name = "label42";
            label42.Padding = new Padding(5);
            label42.Size = new Size(213, 25);
            label42.TabIndex = 3;
            label42.Text = "Вартість розвантаження в Клайпеді:";
            // 
            // labelUnloadingPort
            // 
            labelUnloadingPort.AutoSize = true;
            labelUnloadingPort.Location = new Point(702, 304);
            labelUnloadingPort.Name = "labelUnloadingPort";
            labelUnloadingPort.Size = new Size(13, 15);
            labelUnloadingPort.TabIndex = 8;
            labelUnloadingPort.Text = "0";
            // 
            // labelPaymentForDocuments
            // 
            labelPaymentForDocuments.AutoSize = true;
            labelPaymentForDocuments.Location = new Point(702, 137);
            labelPaymentForDocuments.Name = "labelPaymentForDocuments";
            labelPaymentForDocuments.Size = new Size(13, 15);
            labelPaymentForDocuments.TabIndex = 8;
            labelPaymentForDocuments.Text = "0";
            // 
            // labelTariffs
            // 
            labelTariffs.AutoSize = true;
            labelTariffs.Location = new Point(702, 112);
            labelTariffs.Name = "labelTariffs";
            labelTariffs.Size = new Size(13, 15);
            labelTariffs.TabIndex = 8;
            labelTariffs.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(403, 351);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 3;
            label4.Text = "Загальна ціна:";
            // 
            // labelTotalPrices
            // 
            labelTotalPrices.AutoSize = true;
            labelTotalPrices.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelTotalPrices.Location = new Point(702, 357);
            labelTotalPrices.Name = "labelTotalPrices";
            labelTotalPrices.Size = new Size(13, 13);
            labelTotalPrices.TabIndex = 8;
            labelTotalPrices.Text = "0";
            // 
            // labelTottal
            // 
            labelTottal.AutoSize = true;
            labelTottal.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTottal.Location = new Point(202, 491);
            labelTottal.Name = "labelTottal";
            labelTottal.Size = new Size(20, 24);
            labelTottal.TabIndex = 8;
            labelTottal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 536);
            Controls.Add(radioButtonDiesel);
            Controls.Add(radioButtonGas);
            Controls.Add(buttonSettings);
            Controls.Add(buttonSaveResultInTxt);
            Controls.Add(labelTottal);
            Controls.Add(labelTotalPrices);
            Controls.Add(labelCustoms);
            Controls.Add(labelDelivery);
            Controls.Add(labelAuctionСommission);
            Controls.Add(labelCityDelivery);
            Controls.Add(labelUnloadingPort);
            Controls.Add(labelCustomsClearance);
            Controls.Add(labelDeliveryPort);
            Controls.Add(labelBrokerFee);
            Controls.Add(labelFinalBid);
            Controls.Add(labelAuctionFee);
            Controls.Add(labelTariffs);
            Controls.Add(labelPaymentForDocuments);
            Controls.Add(buttonRun);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label4);
            Controls.Add(label36);
            Controls.Add(label27);
            Controls.Add(checkBoxIsRepair);
            Controls.Add(label99);
            Controls.Add(label42);
            Controls.Add(label32);
            Controls.Add(label38);
            Controls.Add(label40);
            Controls.Add(label30);
            Controls.Add(label21);
            Controls.Add(labeldsf);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(labelgh);
            Controls.Add(label23);
            Controls.Add(comboBoxVolume);
            Controls.Add(comboBoxYears);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label19);
            Controls.Add(label1);
            Controls.Add(textBoxCity);
            Controls.Add(textCostAuto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "CarPriceUSA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCostAuto;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxYears;
        private ComboBox comboBoxVolume;
        private Label label3;
        private Label labelTariffs;
        private Label labeldsf;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private CheckBox checkBoxIsRepair;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button buttonRun;
        private Button buttonSaveResultInTxt;
        private Button buttonSettings;
        private RadioButton radioButtonGas;
        private RadioButton radioButtonDiesel;
        private TextBox textBoxCity;
        private Label label19;
        private Label label99;
        private Label labelAuctionСommission;
        private Label label21;
        private Label labelFinalBid;
        private Label label23;
        private Label labelgh;
        private Label labelAuctionFee;
        private Label label26;
        private Label label28;
        private Label label27;
        private Label labelDelivery;
        private Label label30;
        private Label labelBrokerFee;
        private Label label32;
        private Label labelCityDelivery;
        private Label label36;
        private Label labelCustoms;
        private Label label38;
        private Label labelCustomsClearance;
        private Label label40;
        private Label labelDeliveryPort;
        private Label label42;
        private Label labelUnloadingPort;
        private Label labelPaymentForDocuments;
        private Label label4;
        private Label labelTotalPrices;
        private Label labelTottal;
    }
}
