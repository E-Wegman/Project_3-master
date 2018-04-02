using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Huizenprijzen staafdiagram";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (StraatrovenEntities db = new StraatrovenEntities())
            {
                var data = db.hspA();

                Hcol = new ColumnSeries() { Title = "Overvallen per buurt", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                HcolO = new ColumnSeries() { Title = "Prijzen in euro(x1000)", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };

                Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                ax.Labels = new List<string>();
                ax.LabelsRotation = 45;
                foreach (var x in data)

                {
                    Hcol.Values.Add(x.ov);
                    HcolO.Values.Add(x.hsp);


                    ax.Labels.Add(x.bn);
                    //ax.Labels.Add(x.bn);



                }

                cartesianChart1.Series.Add(Hcol);
                cartesianChart1.Series.Add(HcolO);
                cartesianChart1.LegendLocation = LegendLocation.Bottom;

                //cartesianChart1.Series = new SeriesCollection
                //{
                //    Hcol,
                //    HcolO,

                //};


                cartesianChart1.AxisX.Add(ax);
                cartesianChart1.AxisY.Add(new Axis
                {
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator()
                });
            }
        }

            public ColumnSeries Hcol { get; set; }
            public ColumnSeries HcolO { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Close();
        }


        private void btn1_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 10;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 67;
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 10;
            cartesianChart1.AxisX[0].MaxValue = 20;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 20;
            cartesianChart1.AxisX[0].MaxValue = 30;
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 30;
            cartesianChart1.AxisX[0].MaxValue = 40;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 40;
            cartesianChart1.AxisX[0].MaxValue = 50;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 50;
            cartesianChart1.AxisX[0].MaxValue = 60;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 60;
            cartesianChart1.AxisX[0].MaxValue = 67;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Hide();
        }

        private void btnGraphiek_Click(object sender, EventArgs e)
        {
            (new Form7()).Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Form13()).Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form14()).Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Form15()).Show(); this.Hide();
        }
    }
}
