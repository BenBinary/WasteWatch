namespace _20171130_WasteWatch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.gpControl = new System.Windows.Forms.GroupBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustContact = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.chartF1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.gbSorts = new System.Windows.Forms.GroupBox();
            this.cbPaper = new System.Windows.Forms.CheckBox();
            this.cbWood = new System.Windows.Forms.CheckBox();
            this.cbAzV = new System.Windows.Forms.CheckBox();
            this.cbSperrmuell = new System.Windows.Forms.CheckBox();
            this.cbRestmuell = new System.Windows.Forms.CheckBox();
            this.gpKeyfacts = new System.Windows.Forms.GroupBox();
            this.lblNoOrders12Months = new System.Windows.Forms.Label();
            this.lbAverage = new System.Windows.Forms.Label();
            this.lblLastOrder = new System.Windows.Forms.Label();
            this.lbOrdersTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpControl.SuspendLayout();
            this.grpCustomerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartF1)).BeginInit();
            this.gbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.gbSorts.SuspendLayout();
            this.gpKeyfacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 16;
            this.lbClients.Location = new System.Drawing.Point(43, 36);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(282, 452);
            this.lbClients.TabIndex = 0;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            this.lbClients.DoubleClick += new System.EventHandler(this.lbClients_DoubleClick);
            // 
            // gpControl
            // 
            this.gpControl.Controls.Add(this.btnStream);
            this.gpControl.Controls.Add(this.btnClient);
            this.gpControl.Location = new System.Drawing.Point(63, 523);
            this.gpControl.Name = "gpControl";
            this.gpControl.Size = new System.Drawing.Size(243, 185);
            this.gpControl.TabIndex = 1;
            this.gpControl.TabStop = false;
            this.gpControl.Text = "Steuerelemente";
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(6, 71);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(211, 38);
            this.btnStream.TabIndex = 1;
            this.btnStream.Text = "Neuer Stoffstrom";
            this.btnStream.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(6, 21);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(212, 34);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Neuer Kunde";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kunden";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.lblCustID);
            this.grpCustomerInformation.Controls.Add(this.lblCustContact);
            this.grpCustomerInformation.Controls.Add(this.lblCustName);
            this.grpCustomerInformation.Location = new System.Drawing.Point(336, 523);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(417, 185);
            this.grpCustomerInformation.TabIndex = 3;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Kundeninformationen";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(13, 82);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(116, 17);
            this.lblCustID.TabIndex = 2;
            this.lblCustID.Text = "Kundennummer: ";
            // 
            // lblCustContact
            // 
            this.lblCustContact.AutoSize = true;
            this.lblCustContact.Location = new System.Drawing.Point(13, 51);
            this.lblCustContact.Name = "lblCustContact";
            this.lblCustContact.Size = new System.Drawing.Size(118, 17);
            this.lblCustContact.TabIndex = 1;
            this.lblCustContact.Text = "Ansprechpartner:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(13, 25);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(53, 17);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Name: ";
            // 
            // chartF1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartF1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartF1.Legends.Add(legend1);
            this.chartF1.Location = new System.Drawing.Point(352, 36);
            this.chartF1.Name = "chartF1";
            this.chartF1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartF1.Series.Add(series1);
            this.chartF1.Size = new System.Drawing.Size(625, 452);
            this.chartF1.TabIndex = 4;
            this.chartF1.Text = "chart1";
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.dgvOrders);
            this.gbOrders.Location = new System.Drawing.Point(790, 523);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(596, 185);
            this.gbOrders.TabIndex = 5;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Aufträge";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(16, 29);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(536, 150);
            this.dgvOrders.TabIndex = 0;
            // 
            // gbSorts
            // 
            this.gbSorts.Controls.Add(this.cbPaper);
            this.gbSorts.Controls.Add(this.cbWood);
            this.gbSorts.Controls.Add(this.cbAzV);
            this.gbSorts.Controls.Add(this.cbSperrmuell);
            this.gbSorts.Controls.Add(this.cbRestmuell);
            this.gbSorts.Location = new System.Drawing.Point(1029, 36);
            this.gbSorts.Name = "gbSorts";
            this.gbSorts.Size = new System.Drawing.Size(264, 175);
            this.gbSorts.TabIndex = 6;
            this.gbSorts.TabStop = false;
            this.gbSorts.Text = "Sorten";
            // 
            // cbPaper
            // 
            this.cbPaper.AutoSize = true;
            this.cbPaper.Enabled = false;
            this.cbPaper.Location = new System.Drawing.Point(19, 143);
            this.cbPaper.Name = "cbPaper";
            this.cbPaper.Size = new System.Drawing.Size(71, 21);
            this.cbPaper.TabIndex = 4;
            this.cbPaper.Text = "Papier";
            this.cbPaper.UseVisualStyleBackColor = true;
            this.cbPaper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbPaper_MouseMove);
            // 
            // cbWood
            // 
            this.cbWood.AutoSize = true;
            this.cbWood.Enabled = false;
            this.cbWood.Location = new System.Drawing.Point(19, 115);
            this.cbWood.Name = "cbWood";
            this.cbWood.Size = new System.Drawing.Size(58, 21);
            this.cbWood.TabIndex = 3;
            this.cbWood.Text = "Holz";
            this.cbWood.UseVisualStyleBackColor = true;
            this.cbWood.Click += new System.EventHandler(this.cbWood_Click);
            this.cbWood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbWood_MouseMove);
            // 
            // cbAzV
            // 
            this.cbAzV.AutoSize = true;
            this.cbAzV.Enabled = false;
            this.cbAzV.Location = new System.Drawing.Point(19, 87);
            this.cbAzV.Name = "cbAzV";
            this.cbAzV.Size = new System.Drawing.Size(55, 21);
            this.cbAzV.TabIndex = 2;
            this.cbAzV.Text = "AzV";
            this.cbAzV.UseVisualStyleBackColor = true;
            this.cbAzV.Click += new System.EventHandler(this.cbAzV_Click);
            this.cbAzV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbAzV_MouseMove);
            // 
            // cbSperrmuell
            // 
            this.cbSperrmuell.AutoSize = true;
            this.cbSperrmuell.Enabled = false;
            this.cbSperrmuell.Location = new System.Drawing.Point(19, 59);
            this.cbSperrmuell.Name = "cbSperrmuell";
            this.cbSperrmuell.Size = new System.Drawing.Size(90, 21);
            this.cbSperrmuell.TabIndex = 1;
            this.cbSperrmuell.Text = "Sperrmüll";
            this.cbSperrmuell.UseVisualStyleBackColor = true;
            this.cbSperrmuell.Click += new System.EventHandler(this.cbSperrmuell_Click);
            this.cbSperrmuell.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbSperrmuell_MouseMove);
            // 
            // cbRestmuell
            // 
            this.cbRestmuell.AutoSize = true;
            this.cbRestmuell.Enabled = false;
            this.cbRestmuell.Location = new System.Drawing.Point(19, 31);
            this.cbRestmuell.Name = "cbRestmuell";
            this.cbRestmuell.Size = new System.Drawing.Size(84, 21);
            this.cbRestmuell.TabIndex = 0;
            this.cbRestmuell.Text = "Restmüll";
            this.cbRestmuell.UseVisualStyleBackColor = true;
            // 
            // gpKeyfacts
            // 
            this.gpKeyfacts.Controls.Add(this.lblNoOrders12Months);
            this.gpKeyfacts.Controls.Add(this.lbAverage);
            this.gpKeyfacts.Controls.Add(this.lblLastOrder);
            this.gpKeyfacts.Controls.Add(this.lbOrdersTotal);
            this.gpKeyfacts.Location = new System.Drawing.Point(1029, 235);
            this.gpKeyfacts.Name = "gpKeyfacts";
            this.gpKeyfacts.Size = new System.Drawing.Size(264, 253);
            this.gpKeyfacts.TabIndex = 7;
            this.gpKeyfacts.TabStop = false;
            this.gpKeyfacts.Text = "Keyfacts";
            // 
            // lblNoOrders12Months
            // 
            this.lblNoOrders12Months.AutoSize = true;
            this.lblNoOrders12Months.Location = new System.Drawing.Point(16, 143);
            this.lblNoOrders12Months.Name = "lblNoOrders12Months";
            this.lblNoOrders12Months.Size = new System.Drawing.Size(148, 34);
            this.lblNoOrders12Months.TabIndex = 3;
            this.lblNoOrders12Months.Text = "Anzahl Bestellung\r\n in letzten 12 Monate: ";
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Location = new System.Drawing.Point(16, 105);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(145, 17);
            this.lbAverage.TabIndex = 2;
            this.lbAverage.Text = "Durchschnittsgewicht:";
            // 
            // lblLastOrder
            // 
            this.lblLastOrder.AutoSize = true;
            this.lblLastOrder.Location = new System.Drawing.Point(16, 69);
            this.lblLastOrder.Name = "lblLastOrder";
            this.lblLastOrder.Size = new System.Drawing.Size(125, 17);
            this.lblLastOrder.TabIndex = 1;
            this.lblLastOrder.Text = "Letzte Bestellung: ";
            // 
            // lbOrdersTotal
            // 
            this.lbOrdersTotal.AutoSize = true;
            this.lbOrdersTotal.Location = new System.Drawing.Point(16, 35);
            this.lbOrdersTotal.Name = "lbOrdersTotal";
            this.lbOrdersTotal.Size = new System.Drawing.Size(167, 17);
            this.lbOrdersTotal.TabIndex = 0;
            this.lbOrdersTotal.Text = "Anzahl Aufträge gesamt: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 735);
            this.Controls.Add(this.gpKeyfacts);
            this.Controls.Add(this.gbSorts);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.chartF1);
            this.Controls.Add(this.grpCustomerInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpControl);
            this.Controls.Add(this.lbClients);
            this.Name = "Form1";
            this.Text = "WasteWatch 2018 V1";
            this.gpControl.ResumeLayout(false);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartF1)).EndInit();
            this.gbOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.gbSorts.ResumeLayout(false);
            this.gbSorts.PerformLayout();
            this.gpKeyfacts.ResumeLayout(false);
            this.gpKeyfacts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.GroupBox gpControl;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustContact;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartF1;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox gbSorts;
        private System.Windows.Forms.CheckBox cbWood;
        private System.Windows.Forms.CheckBox cbAzV;
        private System.Windows.Forms.CheckBox cbSperrmuell;
        private System.Windows.Forms.CheckBox cbRestmuell;
        private System.Windows.Forms.CheckBox cbPaper;
        private System.Windows.Forms.GroupBox gpKeyfacts;
        private System.Windows.Forms.Label lblLastOrder;
        private System.Windows.Forms.Label lbOrdersTotal;
        private System.Windows.Forms.Label lblNoOrders12Months;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

