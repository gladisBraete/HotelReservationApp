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

namespace Gladis_Holtelz
{
    public partial class GraphicForm : Form
    {
        IDataAcces dataAcces;
        public GraphicForm()
        {
            InitializeComponent();
            this.dataAcces = new DataAcces();
        }

        private void GraphicForm_Load(object sender, EventArgs e)
        {

            TotalReceiptsChart.Visible = true;
            TotalReceiptsChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            TotalReceiptsChart.Series[0].Points.Clear();
            TotalReceiptsChart.Titles.Clear();
            ChartReservation[] charts = this.dataAcces.ChartReservation();
            var list=charts.ToList();
            var chartdata = list.SelectMany(r =>
            {
                var dataList = new List<ChartData>();
                var firstMonth = r.StartDate.Month;
                var lastDayOfMonth = new DateTime(r.StartDate.Year, r.StartDate.Month + 1, 1).AddDays(-1);
                if (r.EndDate < lastDayOfMonth)
                {
                    var days = (decimal)(r.EndDate - r.StartDate).TotalDays;
                    dataList.Add(new ChartData { Month = Enum.Parse(typeof(Months), firstMonth.ToString()).ToString(), Value = days * r.PricePerDay });
                }
                else
                {
                    var days = (decimal)(lastDayOfMonth - r.StartDate).TotalDays;
                    dataList.Add(new ChartData { Month = Enum.Parse(typeof(Months), firstMonth.ToString()).ToString(), Value = days * r.PricePerDay });

                    var secondMonth = firstMonth + 1;
                    days = (decimal)(r.EndDate - lastDayOfMonth).TotalDays - 1;
                    dataList.Add(new ChartData { Month = Enum.Parse(typeof(Months), secondMonth.ToString()).ToString(), Value = days * r.PricePerDay });
                }
                return dataList.ToArray();
            });
            var dataPoints = chartdata.GroupBy(d => d.Month).Select(d => new ChartData { Month = d.Key, Value = d.Sum(s => s.Value) }).ToArray();
            TotalReceiptsChart.DataSource = dataPoints;
            TotalReceiptsChart.Series[0].XValueMember = "Month";
            TotalReceiptsChart.Series[0].YValueMembers = "Value";
            TotalReceiptsChart.Titles.Add("Total Receipts");
        }

        public class ChartData
        {
            public string Month { get; set; }

            public decimal Value { get; set; }
        }

        public enum Months
        {
            Ianuarie = 1,
            Februarie = 2,
            Martie = 3,
            Aprilie = 4,
            Mai = 5,
            Iunie = 6,
            Iulie = 7,
            August = 8,
            Septembrie = 9,
            Octombrie = 10,
            Noiembrie = 11,
            Decemvrie = 12
        }
    }
}
