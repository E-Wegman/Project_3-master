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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.Text = "Weersomstandigheden cirkeldiagram";
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            using (StraatrovenEntities db = new StraatrovenEntities())
            {
                var data = db.wrP();

                PieSeries col = new PieSeries() { Title = "Rest", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries colO = new PieSeries() { Title = "Sneeuw", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries colT = new PieSeries() { Title = "IJsvorming", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries colTr = new PieSeries() { Title = "Regen", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries colF = new PieSeries() { Title = "Mist", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries colFi = new PieSeries() { Title = "Onweer", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };


                //Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                //ax.Labels = new List<string>();
                //ax.LabelsRotation = 45;


                foreach (var a in data)

                {
                    col.Values.Add(a.rest);
                    colO.Values.Add(a.sneeuw);
                    colT.Values.Add(a.ijsvorming);
                    colTr.Values.Add(a.regen);
                    colF.Values.Add(a.mist);
                    colFi.Values.Add(a.onweer);
                    //ax.Labels.Add(a.mnd.ToString());
                }



                pieChart1.Series.Add(col);
                pieChart1.Series.Add(colO);
                pieChart1.Series.Add(colT);
                pieChart1.Series.Add(colTr);
                pieChart1.Series.Add(colF);
                pieChart1.Series.Add(colFi);
                pieChart1.LegendLocation = LegendLocation.Bottom;


                //cartesianChart1.AxisX.Add(ax);
                //cartesianChart1.AxisY.Add(new Axis
                //{
                //    LabelFormatter = value => value.ToString(),
                //    Separator = new Separator()
                //});
            }

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form2()).Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Form3()).Show(); this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Form8()).Show(); this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new Form9()).Show(); this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new Form10()).Show(); this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Close();
        }
    }
}
