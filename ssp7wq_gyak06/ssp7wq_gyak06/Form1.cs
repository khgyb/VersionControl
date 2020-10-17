using ssp7wq_gyak06.Entities;
using ssp7wq_gyak06.MnbServiceReference;
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
using System.Xml;

namespace ssp7wq_gyak06
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();
            RefreshData();

            dataGridView1.DataSource = Rates;
            chart1.DataSource = Rates;
        }

        public void start()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = (comboBox1.SelectedItem).ToString(),
                startDate = (dateTimePicker1.Value).ToString(),
                endDate = (dateTimePicker2.Value).ToString()
            };
            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(item.GetAttribute("date"));

                var childElement = (XmlElement)item.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit!=0)
                {
                    rate.Value = value / unit;
                }

                var series = chart1.Series[0];
                series.ChartType = SeriesChartType.Line;
                series.XValueMember = "Date";
                series.YValueMembers = "Value";
                series.BorderWidth = 2;

                chart1.Legends[0].Enabled = false;
                var chartarea = chart1.ChartAreas[0];
                chartarea.AxisX.MajorGrid.Enabled = false;
                chartarea.AxisY.MajorGrid.Enabled = false;
                chartarea.AxisY.IsStartedFromZero = false;


            }
        }
        private void RefreshData()
        {
            Rates.Clear();
            start();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
