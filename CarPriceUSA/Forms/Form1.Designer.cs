﻿namespace CarPriceUSA
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            checkBoxIsRepair = new CheckBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            buttonRun = new Button();
            labelFinalCost = new Label();
            labelAuctionFee = new Label();
            labelTransportingAcrossUSA = new Label();
            labelTransportingAcrossKlaiped = new Label();
            labelTransportingAcrossTernopil = new Label();
            labelFinalClearance = new Label();
            labelBroker = new Label();
            labelAdditionalCosts = new Label();
            labelExcise = new Label();
            labelToll = new Label();
            labelVAT = new Label();
            buttonSaveResultInTxt = new Button();
            buttonSettings = new Button();
            radioButtonGas = new RadioButton();
            radioButtonDiesel = new RadioButton();
            textBoxCity = new TextBox();
            label19 = new Label();
            SuspendLayout();
            // 
            // textCostAuto
            // 
            textCostAuto.Location = new Point(14, 47);
            textCostAuto.Margin = new Padding(3, 4, 3, 4);
            textCostAuto.Name = "textCostAuto";
            textCostAuto.Size = new Size(171, 27);
            textCostAuto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Ціна на аукціоні";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 96);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Рік авто";
            // 
            // comboBoxYears
            // 
            comboBoxYears.FormattingEnabled = true;
            comboBoxYears.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008 і старіші" });
            comboBoxYears.Location = new Point(14, 120);
            comboBoxYears.Margin = new Padding(3, 4, 3, 4);
            comboBoxYears.Name = "comboBoxYears";
            comboBoxYears.Size = new Size(171, 28);
            comboBoxYears.TabIndex = 2;
            comboBoxYears.Text = "Виберіть рік";
            // 
            // comboBoxVolume
            // 
            comboBoxVolume.FormattingEnabled = true;
            comboBoxVolume.Items.AddRange(new object[] { "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0", "4.1", "4.2", "4.3", "4.4", "4.5", "4.6", "4.7", "4.8", "4.9", "5.0", "5.1", "5.2", "5.3", "5.4", "5.5", "5.6", "5.7", "5.8", "5.9", "6.0", "6.1", "6.2", "6.3", "6.4", "6.5", "6.6", "6.7", "6.8", "6.9", "7.0", "7.1", "7.2", "7.3", "7.4", "7.5", "7.6", "7.7", "7.8", "7.9", "8.0", "8.1", "8.2", "8.3", "8.4", "8.5", "8.6", "8.7", "8.8", "8.9", "9.0", "9.1", "9.2", "9.3", "9.4", "9.5", "9.6", "9.7", "9.8", "9.9", "10.0" });
            comboBoxVolume.Location = new Point(14, 191);
            comboBoxVolume.Margin = new Padding(3, 4, 3, 4);
            comboBoxVolume.Name = "comboBoxVolume";
            comboBoxVolume.Size = new Size(171, 28);
            comboBoxVolume.TabIndex = 2;
            comboBoxVolume.Text = "Виберіть обєм двигуна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 167);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 1;
            label3.Text = "Обєм двигуна";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 87);
            label4.Name = "label4";
            label4.Size = new Size(185, 20);
            label4.TabIndex = 3;
            label4.Text = "Танспортування по США:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 132);
            label5.Name = "label5";
            label5.Size = new Size(218, 20);
            label5.TabIndex = 3;
            label5.Text = "Танспортування до Клайпеда:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(481, 48);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 3;
            label6.Text = "Аукціоний збір:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(481, 180);
            label7.Name = "label7";
            label7.Size = new Size(310, 20);
            label7.TabIndex = 3;
            label7.Text = "Танспортування з Клайпеда до Тернополя:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(481, 248);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 3;
            label8.Text = "Мито:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(481, 287);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 3;
            label9.Text = "Акциз:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(481, 325);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 3;
            label10.Text = "ПДВ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(481, 391);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 3;
            label11.Text = "Брокер:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(481, 434);
            label13.Name = "label13";
            label13.Size = new Size(140, 20);
            label13.TabIndex = 3;
            label13.Text = "Додаткові витрати:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 50F);
            label14.Location = new Point(693, 227);
            label14.Name = "label14";
            label14.Size = new Size(72, 112);
            label14.TabIndex = 3;
            label14.Text = "}";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20F);
            label15.Location = new Point(14, 640);
            label15.Name = "label15";
            label15.Size = new Size(122, 46);
            label15.TabIndex = 3;
            label15.Text = "Разом:";
            // 
            // checkBoxIsRepair
            // 
            checkBoxIsRepair.AutoSize = true;
            checkBoxIsRepair.Location = new Point(231, 95);
            checkBoxIsRepair.Margin = new Padding(3, 4, 3, 4);
            checkBoxIsRepair.Name = "checkBoxIsRepair";
            checkBoxIsRepair.Size = new Size(82, 24);
            checkBoxIsRepair.TabIndex = 4;
            checkBoxIsRepair.Text = "Ремонт";
            checkBoxIsRepair.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F);
            label16.Location = new Point(-18, 577);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(1378, 46);
            label16.TabIndex = 3;
            label16.Text = "_________________________________________________________________________________________________";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 20F);
            label17.Location = new Point(-162, 333);
            label17.Name = "label17";
            label17.Size = new Size(28, 460);
            label17.TabIndex = 5;
            label17.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(210, 17);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.Yes;
            label18.Size = new Size(0, 39);
            label18.TabIndex = 6;
            // 
            // buttonRun
            // 
            buttonRun.BackColor = Color.DarkSeaGreen;
            buttonRun.FlatAppearance.BorderColor = Color.Chartreuse;
            buttonRun.Font = new Font("Segoe UI", 20F);
            buttonRun.ForeColor = SystemColors.ControlLightLight;
            buttonRun.Location = new Point(693, 631);
            buttonRun.Margin = new Padding(3, 4, 3, 4);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(208, 68);
            buttonRun.TabIndex = 7;
            buttonRun.Text = "Рахувати";
            buttonRun.UseVisualStyleBackColor = false;
            buttonRun.Click += buttonRun_Click;
            // 
            // labelFinalCost
            // 
            labelFinalCost.AutoSize = true;
            labelFinalCost.Font = new Font("Segoe UI", 20F);
            labelFinalCost.Location = new Point(134, 640);
            labelFinalCost.Name = "labelFinalCost";
            labelFinalCost.Size = new Size(38, 46);
            labelFinalCost.TabIndex = 3;
            labelFinalCost.Text = "0";
            // 
            // labelAuctionFee
            // 
            labelAuctionFee.AutoSize = true;
            labelAuctionFee.Location = new Point(769, 48);
            labelAuctionFee.Name = "labelAuctionFee";
            labelAuctionFee.Size = new Size(17, 20);
            labelAuctionFee.TabIndex = 8;
            labelAuctionFee.Text = "0";
            // 
            // labelTransportingAcrossUSA
            // 
            labelTransportingAcrossUSA.AutoSize = true;
            labelTransportingAcrossUSA.Location = new Point(769, 87);
            labelTransportingAcrossUSA.Name = "labelTransportingAcrossUSA";
            labelTransportingAcrossUSA.Size = new Size(17, 20);
            labelTransportingAcrossUSA.TabIndex = 8;
            labelTransportingAcrossUSA.Text = "0";
            // 
            // labelTransportingAcrossKlaiped
            // 
            labelTransportingAcrossKlaiped.AutoSize = true;
            labelTransportingAcrossKlaiped.Location = new Point(769, 132);
            labelTransportingAcrossKlaiped.Name = "labelTransportingAcrossKlaiped";
            labelTransportingAcrossKlaiped.Size = new Size(17, 20);
            labelTransportingAcrossKlaiped.TabIndex = 8;
            labelTransportingAcrossKlaiped.Text = "0";
            // 
            // labelTransportingAcrossTernopil
            // 
            labelTransportingAcrossTernopil.AutoSize = true;
            labelTransportingAcrossTernopil.Location = new Point(769, 180);
            labelTransportingAcrossTernopil.Name = "labelTransportingAcrossTernopil";
            labelTransportingAcrossTernopil.Size = new Size(17, 20);
            labelTransportingAcrossTernopil.TabIndex = 8;
            labelTransportingAcrossTernopil.Text = "0";
            // 
            // labelFinalClearance
            // 
            labelFinalClearance.AutoSize = true;
            labelFinalClearance.Location = new Point(766, 287);
            labelFinalClearance.Name = "labelFinalClearance";
            labelFinalClearance.Size = new Size(17, 20);
            labelFinalClearance.TabIndex = 8;
            labelFinalClearance.Text = "0";
            // 
            // labelBroker
            // 
            labelBroker.AutoSize = true;
            labelBroker.Location = new Point(766, 391);
            labelBroker.Name = "labelBroker";
            labelBroker.Size = new Size(17, 20);
            labelBroker.TabIndex = 8;
            labelBroker.Text = "0";
            // 
            // labelAdditionalCosts
            // 
            labelAdditionalCosts.AutoSize = true;
            labelAdditionalCosts.Location = new Point(766, 434);
            labelAdditionalCosts.Name = "labelAdditionalCosts";
            labelAdditionalCosts.Size = new Size(17, 20);
            labelAdditionalCosts.TabIndex = 8;
            labelAdditionalCosts.Text = "0";
            // 
            // labelExcise
            // 
            labelExcise.AutoSize = true;
            labelExcise.Location = new Point(537, 287);
            labelExcise.Name = "labelExcise";
            labelExcise.Size = new Size(17, 20);
            labelExcise.TabIndex = 8;
            labelExcise.Text = "0";
            // 
            // labelToll
            // 
            labelToll.AutoSize = true;
            labelToll.Location = new Point(537, 248);
            labelToll.Name = "labelToll";
            labelToll.Size = new Size(17, 20);
            labelToll.TabIndex = 8;
            labelToll.Text = "0";
            // 
            // labelVAT
            // 
            labelVAT.AutoSize = true;
            labelVAT.Location = new Point(537, 325);
            labelVAT.Name = "labelVAT";
            labelVAT.Size = new Size(17, 20);
            labelVAT.TabIndex = 8;
            labelVAT.Text = "0";
            // 
            // buttonSaveResultInTxt
            // 
            buttonSaveResultInTxt.Location = new Point(531, 640);
            buttonSaveResultInTxt.Margin = new Padding(3, 4, 3, 4);
            buttonSaveResultInTxt.Name = "buttonSaveResultInTxt";
            buttonSaveResultInTxt.Size = new Size(154, 49);
            buttonSaveResultInTxt.TabIndex = 10;
            buttonSaveResultInTxt.Text = "Зберегти Розрахунок";
            buttonSaveResultInTxt.UseVisualStyleBackColor = true;
            buttonSaveResultInTxt.Click += buttonSaveResultInTxt_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Font = new Font("Segoe UI", 10F);
            buttonSettings.Location = new Point(864, 9);
            buttonSettings.Margin = new Padding(3, 4, 3, 4);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(37, 44);
            buttonSettings.TabIndex = 10;
            buttonSettings.Text = "⚙";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // radioButtonGas
            // 
            radioButtonGas.AutoSize = true;
            radioButtonGas.Location = new Point(17, 223);
            radioButtonGas.Margin = new Padding(3, 4, 3, 4);
            radioButtonGas.Name = "radioButtonGas";
            radioButtonGas.Size = new Size(81, 24);
            radioButtonGas.TabIndex = 11;
            radioButtonGas.TabStop = true;
            radioButtonGas.Text = "Бензин";
            radioButtonGas.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiesel
            // 
            radioButtonDiesel.AutoSize = true;
            radioButtonDiesel.Location = new Point(97, 223);
            radioButtonDiesel.Margin = new Padding(3, 4, 3, 4);
            radioButtonDiesel.Name = "radioButtonDiesel";
            radioButtonDiesel.Size = new Size(80, 24);
            radioButtonDiesel.TabIndex = 11;
            radioButtonDiesel.TabStop = true;
            radioButtonDiesel.Text = "Дизель";
            radioButtonDiesel.UseVisualStyleBackColor = true;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(231, 48);
            textBoxCity.Margin = new Padding(3, 4, 3, 4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(171, 27);
            textBoxCity.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(231, 23);
            label19.Name = "label19";
            label19.Size = new Size(94, 20);
            label19.TabIndex = 1;
            label19.Text = "Місто і Штат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 715);
            Controls.Add(radioButtonDiesel);
            Controls.Add(radioButtonGas);
            Controls.Add(buttonSettings);
            Controls.Add(buttonSaveResultInTxt);
            Controls.Add(labelVAT);
            Controls.Add(labelToll);
            Controls.Add(labelExcise);
            Controls.Add(labelAdditionalCosts);
            Controls.Add(labelBroker);
            Controls.Add(labelFinalClearance);
            Controls.Add(labelTransportingAcrossTernopil);
            Controls.Add(labelTransportingAcrossKlaiped);
            Controls.Add(labelTransportingAcrossUSA);
            Controls.Add(labelAuctionFee);
            Controls.Add(buttonRun);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(checkBoxIsRepair);
            Controls.Add(label6);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(labelFinalCost);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label4;
        private Label label5;
        private Label label6;
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
        private Label labelFinalCost;
        private Label labelAuctionFee;
        private Label labelTransportingAcrossUSA;
        private Label labelTransportingAcrossKlaiped;
        private Label labelTransportingAcrossTernopil;
        private Label labelFinalClearance;
        private Label labelBroker;
        private Label labelAdditionalCosts;
        private Label labelExcise;
        private Label labelToll;
        private Label labelVAT;
        private Button buttonSaveResultInTxt;
        private Button buttonSettings;
        private RadioButton radioButtonGas;
        private RadioButton radioButtonDiesel;
        private TextBox textBoxCity;
        private Label label19;
    }
}
