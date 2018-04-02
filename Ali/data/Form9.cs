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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.Text = "Weersomstandigheden (1/1/2012 t/m 30/6/2012)";
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            using (StraatrovenEntities db = new StraatrovenEntities())
            {
                var data = db.wr3();

                LineSeries col = new LineSeries() { Title = "Gemiddelde temperatuur bij overvallen in graden Celsius per dag", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                LineSeries colO = new LineSeries() { Title = "Gemiddelde temperatuur in graden Celsius per dag", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };


                Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                ax.Labels = new List<string>();
                ax.LabelsRotation = 45;


                foreach (var a in data)

                {
                    col.Values.Add(a.ov);
                    colO.Values.Add(a.tmp);
                    ax.Labels.Add(a.mnd.ToString());
                }



                cartesianChart1.Series.Add(col);
                cartesianChart1.Series.Add(colO);
                cartesianChart1.LegendLocation = LegendLocation.Bottom;


                //if (dOne == true)
                //    cartesianChart1.Series = new SeriesCollection
                //    {
                //        Col,
                //        ColO,
                //    };
                //else
                //{
                //    cartesianChart1.Series = new SeriesCollection
                //    {
                //        ColT,
                //        ColF,
                //    };
                //}



                cartesianChart1.AxisX.Add(ax);
                cartesianChart1.AxisY.Add(new Axis
                {
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator()
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form2()).Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 28;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 29;
            cartesianChart1.AxisX[0].MaxValue = 57;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 58;
            cartesianChart1.AxisX[0].MaxValue = 88;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 89;
            cartesianChart1.AxisX[0].MaxValue = 116;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 117;
            cartesianChart1.AxisX[0].MaxValue = 146;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 148;
            cartesianChart1.AxisX[0].MaxValue = 176;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Form3()).Show(); this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new Form8()).Show(); this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new Form10()).Show(); this.Close();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 176;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new Form11()).Show(); this.Close();
        }
    }
}
