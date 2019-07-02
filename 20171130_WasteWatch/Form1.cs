using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _20171130_WasteWatch
{
    public partial class Form1 : Form
    {
        // globale Variablendeklaration
        Refresh objRefresh = new Refresh(); 
        string globalConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\temp\\WasteWatch2003.mdb";
        List<string> f1Kunden = new List<string>();
        int series_count = 0;
       
        int series_count_azv = 0;
        int series_count_sperrmuell = 0;
        int series_count_wood = 0;
        int series_count_paper = 0;

        //Var für ToolTip
        int amoAmount_sperr = 0;
        int amoAmount_azv = 0;
        int amoAmount_wood = 0;
        int amoAmount_paper = 0;

        //Var for Keyfacts
        DateTime dt_last_order = new DateTime();
        int middle_weight = 0;
        int int_last_12m_orders;


        public Form1()
        {
            InitializeComponent();

            F1Refresh();

            dgvOrders.Columns.Add("coArt", "Art");
            dgvOrders.Columns.Add("coMenge", "Menge in Tonnen");
            dgvOrders.Columns.Add("coDate", "Datum");

            //dgvCustomer.Columns.Add("coCustName", "Kundenname");
            //dgvCustomer.Columns.Add("coBranch", "Branchenschlüssel");
            //dgvCustomer.Columns.Add("coSIze", "Unternehmensgröße");

        }
    

        public virtual void F1Refresh()
        {

            //dgvCustomer.Rows.Clear();
            lbClients.Items.Clear();
            f1Kunden.Clear();

            f1Kunden = objRefresh.ReRefresh();

            int items = f1Kunden.Count;

            for (int j = 0; j < items;  j++)
            {
                lbClients.Items.Add(f1Kunden[j]);
            }


            // Eröffnungsdialog anzeigen
            Welcome wel = new Welcome();

            wel.Show();
            wel.BringToFront();
        }

    

        //Neuer Kunde anlegen
        private void btnClient_Click(object sender, EventArgs e)
        {
            //lbClients.Items.Clear();
            this.F1Refresh();
            newClient openNCdialogue = new newClient();
            bool check = openNCdialogue.NewClient(globalConnectionString);
            openNCdialogue.Show();
            //openNCdialogue.FormClosed += OpenNCdialogue_FormClosed;
            //if (openNCdialogue.FormClosed) 
              //  this.F1Refresh();
           

        }



        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            this.F1Refresh();
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartF1.Series.Clear();
            dgvOrders.Rows.Clear();
            clCust objCust = new clCust();
            dt_last_order = new DateTime();

            //Resten der Check-Boxen
            cbWood.Enabled = false;
            cbWood.Checked = false;
            cbAzV.Checked = false;
            cbAzV.Enabled = false;
            cbRestmuell.Enabled = false;
            cbRestmuell.Checked = false;
            cbSperrmuell.Enabled = false;
            cbSperrmuell.Checked = false;
            cbPaper.Checked = false;
            cbPaper.Enabled = false;

            //Variablendeklaration
            //Diese Nummern bekommen die Serien des Charts
            series_count = 0;
            //series_count_azv = 0;
            //series_count_sperrmuell = 0;
            //series_count_wood = 0;
            amoAmount_sperr = 0;
            amoAmount_azv = 0;
            amoAmount_wood = 0;
            amoAmount_paper = 0;
            middle_weight = 0;
            int_last_12m_orders = 0;


            string customer_name = Convert.ToString(lbClients.SelectedItem);

            objCust.getCust(globalConnectionString, customer_name);



            lblCustID.Text = "Kundennumer: " +  Convert.ToString(objCust.kundennummer);
            lblCustName.Text = "Name: " + objCust.name;
            lblCustContact.Text = "Ansprechpartner: " + objCust.strasse + " " + Convert.ToString(objCust.Hausnummer) + ", " + Convert.ToString(objCust.PLZ) + " " + objCust.ort;

            clAmount_get f1_clAmountGet = new clAmount_get();

            List < clAmount > f1_list_clAmountt = new List<clAmount>();
            f1_list_clAmountt = f1_clAmountGet.getAmount(customer_name, globalConnectionString);

            //Abfrage für die letzte Bestellung
            try
            {
                dt_last_order = f1_list_clAmountt[0].amoDate;
            }
                
            catch
            {
                dt_last_order = DateTime.MinValue;
            }




            //Auffüllen der DGV mit den jeweiligen Aufträgen
            for (int i = 0; i < f1_list_clAmountt.Count; i++)
            {
                dgvOrders.Rows.Add(f1_list_clAmountt[i].amoArt, f1_list_clAmountt[i].amoAmount, f1_list_clAmountt[i].amoDate.ToShortDateString());

                middle_weight += f1_list_clAmountt[i].amoAmount;

                //Abfrage nach der letzten Bestellung
                if (f1_list_clAmountt[i].amoDate > dt_last_order)
                    dt_last_order = f1_list_clAmountt[i].amoDate;

                //Abfrage nach der Anzahl der Bestellungen in den letzten 12 Monaten
                if (f1_list_clAmountt[i].amoDate < DateTime.Now)
                    int_last_12m_orders += 1;
            }

            draw_Chart(f1_list_clAmountt);

            

        }

        public void draw_Chart (List<clAmount> par_f1_clamount_get)
        {
            int list_count = par_f1_clamount_get.Count;
            //Diese Nummern bekommen die Serien des Charts
            
            int series_count_azv = 0;
            int series_count_sperrmuell = 0;
            int series_count_wood = 0;


            //Keyfacts befüllen 
                //Anzahl Aufträge
                lbOrdersTotal.Text = "Anzahl Aufträge gesamt: " + Convert.ToString(list_count);
                
                //Letzte Bestellung
                if (dt_last_order.Year == 1)
                    lblLastOrder.Text = "Letzte Bestellung: ";
                else
                    lblLastOrder.Text = "Letzte Bestellung: " + dt_last_order.Day + "." + dt_last_order.Month + "." + dt_last_order.Year;
           
                //Durchschnittsgewicht
                if (middle_weight != 0)
                    lbAverage.Text = "Durchschnittsgewicht: " + Convert.ToString(middle_weight / list_count + " Tonnen");
                else
                    lbAverage.Text = "Durchschnittsgewicht:";

            //Bestellung in letzten 12 Monaten
            lblNoOrders12Months.Text = "Anzahl Bestellung \n in letzten 12 Monate: " + Convert.ToString(int_last_12m_orders);

            // AzV Abfrage
            for (int i = 0; i < list_count; i++)
            {
                if (par_f1_clamount_get[i].amoArt == "AzV")
                {
                    //Anlegen der AzV-Kurve
                    if (!(chartF1.Series.IndexOf("AzV") != -1))
                    {

                        chartF1.Series.Add(new Series("AzV"));
                        chartF1.Series[series_count].XValueType = ChartValueType.DateTime;
                        chartF1.Series[series_count].Color = Color.Black;
                        chartF1.Series[series_count].BorderWidth = 3;
                        chartF1.Series[series_count].ChartType = SeriesChartType.Line;
                        series_count_azv = series_count;
                        series_count += 1;
                        //Gestalten der Check-Boxen
                        cbAzV.Enabled = true;
                        cbAzV.Checked = true;
                    }

                        DateTime dt1 = par_f1_clamount_get[i].amoDate;
                    chartF1.Series[series_count_azv].Points.AddXY(dt1, par_f1_clamount_get[i].amoAmount);

                    amoAmount_azv += par_f1_clamount_get[i].amoAmount;
                }


                //Sperrmuell Abfrage
                else if (par_f1_clamount_get[i].amoArt == "Sperrmuell")
                {
                    //Anlegen der Sperrmuell Kurve
                    if (!(chartF1.Series.IndexOf("Sperrmuell") != -1))
                    {
                        chartF1.Series.Add(new Series("Sperrmuell"));
                        chartF1.Series[series_count].XValueType = ChartValueType.DateTime;
                        chartF1.Series[series_count].Color = Color.Blue;
                        chartF1.Series[series_count].BorderWidth = 3;
                        chartF1.Series[series_count].ChartType = SeriesChartType.Line;
                        series_count_sperrmuell = series_count;
                        series_count += 1;
                        //Gestalten der Check-Boxen
                        cbSperrmuell.Checked = true;
                        cbSperrmuell.Enabled = true;
                    }
                    DateTime dt1 = par_f1_clamount_get[i].amoDate;
                    chartF1.Series[series_count_sperrmuell].Points.AddXY(dt1, par_f1_clamount_get[i].amoAmount);

                    amoAmount_sperr += par_f1_clamount_get[i].amoAmount;
                }

                //Holz Abfrage
                else if (par_f1_clamount_get[i].amoArt == "Holz")
                {
                    //Anlegen der Holz Kurve
                    if (!(chartF1.Series.IndexOf("Holz") != -1))
                    {
                        chartF1.Series.Add(new Series("Holz"));
                        chartF1.Series[series_count].XValueType = ChartValueType.DateTime;
                        chartF1.Series[series_count].Color = Color.Brown;
                        chartF1.Series[series_count].BorderWidth = 3;
                        chartF1.Series[series_count].ChartType = SeriesChartType.Line;
                        series_count_wood = series_count;
                        series_count += 1;
                        //Gestalten der Check-Boxen
                        cbWood.Checked = true;
                        cbWood.Enabled = true;
                    }
                    DateTime dt1 = par_f1_clamount_get[i].amoDate;
                    chartF1.Series[series_count_wood].Points.AddXY(dt1, par_f1_clamount_get[i].amoAmount);

                    amoAmount_wood += par_f1_clamount_get[i].amoAmount;
                }

                //Papier Abfrage
                else if (par_f1_clamount_get[i].amoArt == "B12" | par_f1_clamount_get[i].amoArt == "Welle" | par_f1_clamount_get[i].amoArt == "Kaufhaus")
                {
                    //Anlegen der Papier Kurve
                    if (!(chartF1.Series.IndexOf("Papier") != -1))
                    {
                        chartF1.Series.Add(new Series("Papier"));
                        chartF1.Series[series_count].XValueType = ChartValueType.DateTime;
                        chartF1.Series[series_count].Color = Color.White;
                        chartF1.Series[series_count].BorderWidth = 3;
                        chartF1.Series[series_count].ChartType = SeriesChartType.Line;
                        series_count_wood = series_count;
                        series_count += 1;
                        //Gestalten der Check-Boxen
                        cbPaper.Checked = true;
                        cbPaper.Enabled = true;
                    }
                    DateTime dt1 = par_f1_clamount_get[i].amoDate;
                    chartF1.Series[series_count_paper].Points.AddXY(dt1, par_f1_clamount_get[i].amoAmount);

                    amoAmount_paper += par_f1_clamount_get[i].amoAmount;
                }

            }


            //Legende
            chartF1.Legends[0].Position = new ElementPosition(15, 10, 40, 10);
            chartF1.Legends[0].BackColor = Color.LightCyan;
            chartF1.Legends[0].BorderWidth = 1;
            chartF1.Legends[0].BorderColor = Color.Black;

            //Kosmetik X-Achse
            chartF1.ChartAreas[0].AxisX.Title = "Datum";
            chartF1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chartF1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);

            //Kosmetik Y-Achse
            chartF1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chartF1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 8);
            chartF1.ChartAreas[0].AxisY.Title = "Gewicht in Tonnen";

            //Hintergrundfarben
            chartF1.BackColor = Color.LightGray;
            chartF1.ChartAreas[0].BackColor = Color.LightBlue;


        }

        private void lbClients_DoubleClick(object sender, EventArgs e)
        {
            newClient dc_newClient = new newClient();

            dc_newClient.reqClient(globalConnectionString, Convert.ToString(lbClients.SelectedItem));

            dc_newClient.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbWood_Click(object sender, EventArgs e)
        {
            if (cbWood.Checked == false && cbWood.Enabled == true)
            {
                chartF1.Series[series_count_wood].Enabled = false;
            }

            if (cbWood.Checked == true && cbWood.Enabled == true)
            {

                chartF1.Series[series_count_wood].Enabled = true;
            }
        }

        private void cbSperrmuell_Click(object sender, EventArgs e)
        {
            if (cbSperrmuell.Checked == false && cbSperrmuell.Enabled == true)
            {
                chartF1.Series[series_count_sperrmuell].Enabled = false;
            }

            if (cbSperrmuell.Checked == true && cbSperrmuell.Enabled == true)
            {

                chartF1.Series[series_count_sperrmuell].Enabled = true;

                
            }
        }

        private void cbAzV_Click(object sender, EventArgs e)
        {
            if (cbAzV.Checked == false && cbAzV.Enabled == true)
            {
                chartF1.Series[series_count_azv].Enabled = false;
            }

            if (cbAzV.Checked == true && cbAzV.Enabled == true)
            {

                chartF1.Series[series_count_azv].Enabled = true;

            }
        }

        private void cbWood_MouseMove(object sender, MouseEventArgs e)
        {
           if (cbWood.Enabled == true)
            {
                toolTip1.SetToolTip(cbWood, "Gesamte Menge Holz (in Tonnen):  " + Convert.ToString(amoAmount_wood));
            }
        }

        private void cbAzV_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(cbAzV, "Gesamte Menge AzV (in Tonnen):  " + Convert.ToString(amoAmount_azv));
        }

        private void cbSperrmuell_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(cbSperrmuell, "Gesamte Menge Sperrmüll (in Tonnen):  " + Convert.ToString(amoAmount_sperr));
        }

        private void cbPaper_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(cbPaper, "Gesamte Menge Papier (in Tonnen):  " + Convert.ToString(amoAmount_paper));
        }
    }


}
