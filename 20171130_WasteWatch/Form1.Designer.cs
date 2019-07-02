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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lbLandkreis = new System.Windows.Forms.ListBox();
            this.lbFraktion = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lbClients.Location = new System.Drawing.Point(33, 29);
            this.lbClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(212, 108);
            this.lbClients.TabIndex = 0;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            this.lbClients.DoubleClick += new System.EventHandler(this.lbClients_DoubleClick);
            // 
            // gpControl
            // 
            this.gpControl.Controls.Add(this.btnStream);
            this.gpControl.Controls.Add(this.btnClient);
            this.gpControl.Location = new System.Drawing.Point(47, 425);
            this.gpControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpControl.Name = "gpControl";
            this.gpControl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpControl.Size = new System.Drawing.Size(182, 150);
            this.gpControl.TabIndex = 1;
            this.gpControl.TabStop = false;
            this.gpControl.Text = "Steuerelemente";
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(4, 58);
            this.btnStream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(158, 31);
            this.btnStream.TabIndex = 1;
            this.btnStream.Text = "Neuer Stoffstrom";
            this.btnStream.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(4, 17);
            this.btnClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(159, 28);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Neuer Kunde";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bundesland";
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
            this.grpCustomerInformation.Location = new System.Drawing.Point(252, 425);
            this.grpCustomerInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustomerInformation.Size = new System.Drawing.Size(313, 150);
            this.grpCustomerInformation.TabIndex = 3;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Kundeninformationen";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(10, 67);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(87, 13);
            this.lblCustID.TabIndex = 2;
            this.lblCustID.Text = "Kundennummer: ";
            // 
            // lblCustContact
            // 
            this.lblCustContact.AutoSize = true;
            this.lblCustContact.Location = new System.Drawing.Point(10, 41);
            this.lblCustContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustContact.Name = "lblCustContact";
            this.lblCustContact.Size = new System.Drawing.Size(88, 13);
            this.lblCustContact.TabIndex = 1;
            this.lblCustContact.Text = "Ansprechpartner:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(10, 20);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(41, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Name: ";
            // 
            // chartF1
            // 
            chartArea5.Name = "ChartArea1";
            this.chartF1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartF1.Legends.Add(legend5);
            this.chartF1.Location = new System.Drawing.Point(264, 29);
            this.chartF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartF1.Name = "chartF1";
            this.chartF1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartF1.Series.Add(series5);
            this.chartF1.Size = new System.Drawing.Size(469, 367);
            this.chartF1.TabIndex = 4;
            this.chartF1.Text = "chart1";
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.dgvOrders);
            this.gbOrders.Location = new System.Drawing.Point(592, 425);
            this.gbOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOrders.Size = new System.Drawing.Size(447, 150);
            this.gbOrders.TabIndex = 5;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Aufträge";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 24);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(402, 122);
            this.dgvOrders.TabIndex = 0;
            // 
            // gbSorts
            // 
            this.gbSorts.Controls.Add(this.cbPaper);
            this.gbSorts.Controls.Add(this.cbWood);
            this.gbSorts.Controls.Add(this.cbAzV);
            this.gbSorts.Controls.Add(this.cbSperrmuell);
            this.gbSorts.Controls.Add(this.cbRestmuell);
            this.gbSorts.Location = new System.Drawing.Point(772, 29);
            this.gbSorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSorts.Name = "gbSorts";
            this.gbSorts.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSorts.Size = new System.Drawing.Size(198, 142);
            this.gbSorts.TabIndex = 6;
            this.gbSorts.TabStop = false;
            this.gbSorts.Text = "Sorten";
            // 
            // cbPaper
            // 
            this.cbPaper.AutoSize = true;
            this.cbPaper.Enabled = false;
            this.cbPaper.Location = new System.Drawing.Point(14, 116);
            this.cbPaper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPaper.Name = "cbPaper";
            this.cbPaper.Size = new System.Drawing.Size(56, 17);
            this.cbPaper.TabIndex = 4;
            this.cbPaper.Text = "Papier";
            this.cbPaper.UseVisualStyleBackColor = true;
            this.cbPaper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cbPaper_MouseMove);
            // 
            // cbWood
            // 
            this.cbWood.AutoSize = true;
            this.cbWood.Enabled = false;
            this.cbWood.Location = new System.Drawing.Point(14, 93);
            this.cbWood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbWood.Name = "cbWood";
            this.cbWood.Size = new System.Drawing.Size(47, 17);
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
            this.cbAzV.Location = new System.Drawing.Point(14, 71);
            this.cbAzV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAzV.Name = "cbAzV";
            this.cbAzV.Size = new System.Drawing.Size(45, 17);
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
            this.cbSperrmuell.Location = new System.Drawing.Point(14, 48);
            this.cbSperrmuell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSperrmuell.Name = "cbSperrmuell";
            this.cbSperrmuell.Size = new System.Drawing.Size(69, 17);
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
            this.cbRestmuell.Location = new System.Drawing.Point(14, 25);
            this.cbRestmuell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRestmuell.Name = "cbRestmuell";
            this.cbRestmuell.Size = new System.Drawing.Size(66, 17);
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
            this.gpKeyfacts.Location = new System.Drawing.Point(772, 191);
            this.gpKeyfacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpKeyfacts.Name = "gpKeyfacts";
            this.gpKeyfacts.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpKeyfacts.Size = new System.Drawing.Size(198, 206);
            this.gpKeyfacts.TabIndex = 7;
            this.gpKeyfacts.TabStop = false;
            this.gpKeyfacts.Text = "Keyfacts";
            // 
            // lblNoOrders12Months
            // 
            this.lblNoOrders12Months.AutoSize = true;
            this.lblNoOrders12Months.Location = new System.Drawing.Point(12, 116);
            this.lblNoOrders12Months.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOrders12Months.Name = "lblNoOrders12Months";
            this.lblNoOrders12Months.Size = new System.Drawing.Size(112, 26);
            this.lblNoOrders12Months.TabIndex = 3;
            this.lblNoOrders12Months.Text = "Anzahl Bestellung\r\n in letzten 12 Monate: ";
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Location = new System.Drawing.Point(12, 85);
            this.lbAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(112, 13);
            this.lbAverage.TabIndex = 2;
            this.lbAverage.Text = "Durchschnittsgewicht:";
            // 
            // lblLastOrder
            // 
            this.lblLastOrder.AutoSize = true;
            this.lblLastOrder.Location = new System.Drawing.Point(12, 56);
            this.lblLastOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastOrder.Name = "lblLastOrder";
            this.lblLastOrder.Size = new System.Drawing.Size(94, 13);
            this.lblLastOrder.TabIndex = 1;
            this.lblLastOrder.Text = "Letzte Bestellung: ";
            // 
            // lbOrdersTotal
            // 
            this.lbOrdersTotal.AutoSize = true;
            this.lbOrdersTotal.Location = new System.Drawing.Point(12, 28);
            this.lbOrdersTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrdersTotal.Name = "lbOrdersTotal";
            this.lbOrdersTotal.Size = new System.Drawing.Size(125, 13);
            this.lbOrdersTotal.TabIndex = 0;
            this.lbOrdersTotal.Text = "Anzahl Aufträge gesamt: ";
            // 
            // lbLandkreis
            // 
            this.lbLandkreis.FormattingEnabled = true;
            this.lbLandkreis.Location = new System.Drawing.Point(33, 167);
            this.lbLandkreis.Name = "lbLandkreis";
            this.lbLandkreis.Size = new System.Drawing.Size(212, 95);
            this.lbLandkreis.TabIndex = 8;
            // 
            // lbFraktion
            // 
            this.lbFraktion.FormattingEnabled = true;
            this.lbFraktion.Location = new System.Drawing.Point(33, 292);
            this.lbFraktion.Name = "lbFraktion";
            this.lbFraktion.Size = new System.Drawing.Size(212, 95);
            this.lbFraktion.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Landkreis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fraktion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFraktion);
            this.Controls.Add(this.lbLandkreis);
            this.Controls.Add(this.gpKeyfacts);
            this.Controls.Add(this.gbSorts);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.chartF1);
            this.Controls.Add(this.grpCustomerInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpControl);
            this.Controls.Add(this.lbClients);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ListBox lbLandkreis;
        private System.Windows.Forms.ListBox lbFraktion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

