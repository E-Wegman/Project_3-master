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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Text = "Werkzoekenden Cirkeldiagram";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (StraatrovenEntities db = new StraatrovenEntities())
            {
                var data = db.wzP();

                //PieSeries Col = new PieSeries() { Title = "Werkzoekende totaal", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries ColO = new PieSeries() { Title = "Werkzoekenden 15 t/m 24 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries ColT = new PieSeries() { Title = "Werkzoekenden 25 t/m 34 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries ColTr = new PieSeries() { Title = "Werkzoekenden 35 t/m 44 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries ColF = new PieSeries() { Title = "Werkzoekenden 45 t/m 54 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries ColFi = new PieSeries() { Title = "Werkzoekenden 55 t/m 65 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                PieSeries ColS = new PieSeries() { Title = "Totaal overvallen", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };

                //RowSeries ColSe = new RowSeries() { Title = "Werkzoekende 15 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                //RowSeries ColE = new RowSeries() { Title = "Werkzoekende 25 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                //RowSeries ColN = new RowSeries() { Title = "Werkzoekende 35 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                //RowSeries ColTe = new RowSeries() { Title = "Werkzoekende 45 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                //RowSeries ColEl = new RowSeries() { Title = "Werkzoekende 55 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                //RowSeries ColTw = new RowSeries() { Title = "Overvallen", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };

                //Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                //ax.Labels = new List<string>();
                //ax.LabelsRotation = 45;


                //cartesianChart1.AxisY.Add(new Axis
                //{
                //    Labels = new[] { "werkzoekende 15", "werkzoekende 25", "werkzoekende 35", "werkzoekende 45", "werkzoekende 55"}
                //});

                //cartesianChart1.AxisX.Add(new Axis
                //{
                //    LabelFormatter = value => value.ToString("N")
                //});


                foreach (var x in data)

                {
                    //Col.Values.Add(x.wzA);
                    ColO.Values.Add(x.wz15);
                    ColT.Values.Add(x.wz25);
                    ColTr.Values.Add(x.wz35);
                    ColF.Values.Add(x.wz45);
                    ColFi.Values.Add(x.wz55);
                    ColS.Values.Add(x.overvallen);

                    //ColSe.Values.Add(x.wz15);
                    //ColE.Values.Add(x.wz25);
                    //ColN.Values.Add(x.wz35);
                    //ColTe.Values.Add(x.wz45);
                    //ColEl.Values.Add(x.wz55);
                    //ColTw.Values.Add(x.overvallen);


                    //ax.Labels.Add(x.bn);
                    //ax.Labels.Add(x.bn);



                }

                //pieChart1.Series.Add(Col);
                pieChart1.Series.Add(ColO);
                pieChart1.Series.Add(ColT);
                pieChart1.Series.Add(ColTr);
                pieChart1.Series.Add(ColF);
                pieChart1.Series.Add(ColFi);
                pieChart1.Series.Add(ColS);
                pieChart1.LegendLocation = LegendLocation.Bottom;

                //cartesianChart1.Series.Add(ColSe);
                //cartesianChart1.Series.Add(ColE);
                //cartesianChart1.Series.Add(ColN);
                //cartesianChart1.Series.Add(ColTe);
                //cartesianChart1.Series.Add(ColEl);
                //cartesianChart1.Series.Add(ColTw);
                //cartesianChart1.LegendLocation = LegendLocation.Bottom;




                //pieChart1.Series = new SeriesCollection
                //{
                //    Col,
                //    ColO,
                //    ColT,
                //    ColTr,
                //    ColF,
                //    ColFi,
                //    ColS,

                //};


                //cartesianChart1.AxisX.Add(ax);
                //cartesianChart1.AxisY.Add(new Axis
                //{
                //    LabelFormatter = value => value.ToString(),
                //    Separator = new Separator()
                //});
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form2()).Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new Form6()).Show(); this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Hide();
        }
    }
}
