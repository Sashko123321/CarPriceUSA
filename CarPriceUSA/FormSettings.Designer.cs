namespace CarPriceUSA
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label3 = new Label();
            textBoxTransportUSA = new TextBox();
            textBoxTransportKlaipeda = new TextBox();
            textBoxTransportTernopil = new TextBox();
            textBoxBroker = new TextBox();
            textBoxCommission = new TextBox();
            textBoxAdditionalCosts = new TextBox();
            textBoxRepairCost = new TextBox();
            label16 = new Label();
            buttonSaveResult = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "Танспортування по США:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 57);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 0;
            label2.Text = "Танспортування до Клайпеда:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 95);
            label7.Name = "label7";
            label7.Size = new Size(163, 30);
            label7.TabIndex = 4;
            label7.Text = "Танспортування з Клайпеда \r\nдо Тернополя:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 149);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 5;
            label11.Text = "Брокер:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 187);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 6;
            label12.Text = "Комісія BIDCARS:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 223);
            label13.Name = "label13";
            label13.Size = new Size(110, 15);
            label13.TabIndex = 7;
            label13.Text = "Додаткові витрати:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 263);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Ремонт:";
            // 
            // textBoxTransportUSA
            // 
            textBoxTransportUSA.Location = new Point(200, 20);
            textBoxTransportUSA.Name = "textBoxTransportUSA";
            textBoxTransportUSA.Size = new Size(111, 23);
            textBoxTransportUSA.TabIndex = 9;
            // 
            // textBoxTransportKlaipeda
            // 
            textBoxTransportKlaipeda.Location = new Point(200, 54);
            textBoxTransportKlaipeda.Name = "textBoxTransportKlaipeda";
            textBoxTransportKlaipeda.Size = new Size(111, 23);
            textBoxTransportKlaipeda.TabIndex = 9;
            // 
            // textBoxTransportTernopil
            // 
            textBoxTransportTernopil.Location = new Point(200, 102);
            textBoxTransportTernopil.Name = "textBoxTransportTernopil";
            textBoxTransportTernopil.Size = new Size(111, 23);
            textBoxTransportTernopil.TabIndex = 9;
            // 
            // textBoxBroker
            // 
            textBoxBroker.Location = new Point(200, 146);
            textBoxBroker.Name = "textBoxBroker";
            textBoxBroker.Size = new Size(111, 23);
            textBoxBroker.TabIndex = 9;
            // 
            // textBoxCommission
            // 
            textBoxCommission.Location = new Point(200, 184);
            textBoxCommission.Name = "textBoxCommission";
            textBoxCommission.Size = new Size(111, 23);
            textBoxCommission.TabIndex = 9;
            // 
            // textBoxAdditionalCosts
            // 
            textBoxAdditionalCosts.Location = new Point(200, 220);
            textBoxAdditionalCosts.Name = "textBoxAdditionalCosts";
            textBoxAdditionalCosts.Size = new Size(111, 23);
            textBoxAdditionalCosts.TabIndex = 9;
            // 
            // textBoxRepairCost
            // 
            textBoxRepairCost.Location = new Point(200, 260);
            textBoxRepairCost.Name = "textBoxRepairCost";
            textBoxRepairCost.Size = new Size(111, 23);
            textBoxRepairCost.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F);
            label16.Location = new Point(-345, 286);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(1084, 37);
            label16.TabIndex = 10;
            label16.Text = "_________________________________________________________________________________________________";
            // 
            // buttonSaveResult
            // 
            buttonSaveResult.Location = new Point(200, 326);
            buttonSaveResult.Name = "buttonSaveResult";
            buttonSaveResult.Size = new Size(111, 32);
            buttonSaveResult.TabIndex = 11;
            buttonSaveResult.Text = "Зберегти ";
            buttonSaveResult.UseVisualStyleBackColor = true;
            buttonSaveResult.Click += buttonSaveResult_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 360);
            Controls.Add(buttonSaveResult);
            Controls.Add(label16);
            Controls.Add(textBoxRepairCost);
            Controls.Add(textBoxAdditionalCosts);
            Controls.Add(textBoxCommission);
            Controls.Add(textBoxBroker);
            Controls.Add(textBoxTransportTernopil);
            Controls.Add(textBoxTransportKlaipeda);
            Controls.Add(textBoxTransportUSA);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSettings";
            Text = "FormSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label3;
        private TextBox textBoxTransportUSA;
        private TextBox textBoxTransportKlaipeda;
        private TextBox textBoxTransportTernopil;
        private TextBox textBoxBroker;
        private TextBox textBoxCommission;
        private TextBox textBoxAdditionalCosts;
        private TextBox textBoxRepairCost;
        private Label label16;
        private Button buttonSaveResult;
    }
}