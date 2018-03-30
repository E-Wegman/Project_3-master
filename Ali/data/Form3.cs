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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Weereffecten";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (StraatrovenEntities db = new StraatrovenEntities())
            {
                var data = db.wrO();
                
                LineSeries col = new LineSeries() { Title = "Gemiddelde temperatuur bij overvallen per dag", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                LineSeries colO = new LineSeries() { Title = "Gemiddelde temperatuur in graden per dag", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };


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

        public ColumnSeries Col { get; set; }
        public ColumnSeries ColO { get; set; }


        public object Data { get; private set; }

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
            cartesianChart1.AxisX[0].MaxValue = 31;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 31;
            cartesianChart1.AxisX[0].MaxValue = 59;
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Close();
        }
    }
}
