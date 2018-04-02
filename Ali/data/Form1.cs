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
using System.Windows;
using System.Windows.Forms;


namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Werkzoekenden";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StraatrovenEntities db = new StraatrovenEntities())
            {
                var data = db.wzA();

                Col = new ColumnSeries() { Title = "Werkzoekenden totaal", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString()};
                ColO = new ColumnSeries() { Title = "Werkzoekenden 15 t/m 24 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                ColT = new ColumnSeries() { Title = "Werkzoekenden 25 t/m 34 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                ColTr = new ColumnSeries() { Title = "Werkzoekenden 35 t/m 44 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                ColF = new ColumnSeries() { Title = "Werkzoekenden 45 t/m 54 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                ColFi = new ColumnSeries() { Title = "Werkzoekenden 55 t/m 65 jaar oud", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                ColS = new ColumnSeries() { Title = "Overvallen per buurt", DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };


                Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                ax.Labels = new List<string>();
                ax.LabelsRotation = 45;
                foreach (var x in data)

                {
                    Col.Values.Add(x.wzA);
                    ColO.Values.Add(x.wz15);
                    ColT.Values.Add(x.wz25);
                    ColTr.Values.Add(x.wz35);
                    ColF.Values.Add(x.wz45);
                    ColFi.Values.Add(x.wz55);
                    ColS.Values.Add(x.ov);
                    ax.Labels.Add(x.bn);
                    //ax.Labels.Add(x.bn);



                }

                cartesianChart1.Series.Add(Col);
                cartesianChart1.Series.Add(ColO);
                cartesianChart1.Series.Add(ColT);
                cartesianChart1.Series.Add(ColTr);
                cartesianChart1.Series.Add(ColF);
                cartesianChart1.Series.Add(ColFi);
                cartesianChart1.Series.Add(ColS);
                cartesianChart1.LegendLocation = LegendLocation.Bottom;

                //cartesianChart1.Series = new SeriesCollection
                //{
                //    Col,
                //    ColO,
                //    ColT,
                //    ColTr,
                //    ColF,
                //    ColFi,
                //    ColS,

                //};


                cartesianChart1.AxisX.Add(ax);
                cartesianChart1.AxisY.Add(new Axis
                {
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator() 
                });
            }
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        public ColumnSeries Col { get; set; }
        public ColumnSeries ColO { get; set; }
        public ColumnSeries ColT { get; set; }
        public ColumnSeries ColTr { get; set; }
        public ColumnSeries ColF { get; set; }
        public ColumnSeries ColFi { get; set; }
        public ColumnSeries ColS { get; set; }



        private void checkWzT_CheckedChanged(object sender, EventArgs e)
        {
            Col.Visibility = Col.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        private void checkWz15_CheckedChanged(object sender, EventArgs e)
        {
            ColO.Visibility = ColO.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void checkWz20_CheckedChanged(object sender, EventArgs e)
        {
            ColT.Visibility = ColT.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void checkWz25_CheckedChanged(object sender, EventArgs e)
        {
            ColTr.Visibility = ColTr.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void checkWz30_CheckedChanged(object sender, EventArgs e)
        {
            ColF.Visibility = ColF.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void checkWz35_CheckedChanged(object sender, EventArgs e)
        {
            ColFi.Visibility = ColFi.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 11;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 11;
            cartesianChart1.AxisX[0].MaxValue = 23;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 23;
            cartesianChart1.AxisX[0].MaxValue = 35;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 35;
            cartesianChart1.AxisX[0].MaxValue = 47;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 47;
            cartesianChart1.AxisX[0].MaxValue = 59;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 59;
            cartesianChart1.AxisX[0].MaxValue = 71;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 71;
            cartesianChart1.AxisX[0].MaxValue = 83;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 83;
            cartesianChart1.AxisX[0].MaxValue = 92;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 92;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form2()).Show(); this.Hide();
        }

        private void btnZoom_Click_1(object sender, EventArgs e)
        {
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 92;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Hide();
        }

        private void btnGraphiek_Click(object sender, EventArgs e)
        {
            (new Form6()).Show(); this.Hide();
        }

        //private void button1_MouseHover(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Navigeer naar huizenprijzen deelvraag");
        //}

        private void button9_Click(object sender, EventArgs e)
        {
            (new Form5()).Show(); this.Hide();
        }




        //private void btnZoom_MouseHover(object sender, EventArgs e)
        //{
        //    Color ActiveBorder = default(Color);
        //    btnZoom.ForeColor = ActiveBorder;
        //}

        //------------------------------------------------------------------------------------------------------------------------------------------------//

        // public LineSeries CharlesSeries { get; set; }
        // public LineSeries JohnSeries { get; set; }


    }
}
