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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            this.Text = "Huizenprijzen";
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            using (StraatrovenEntities db = new StraatrovenEntities())
            {
                var data = db.hsp400k();

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

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Close();
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
            (new Form2()).Show(); this.Hide();
        }
    }
}
