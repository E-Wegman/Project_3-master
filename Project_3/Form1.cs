using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
namespace Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void displayData(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string r = "";
                var line = table.Rows[0];

                for (var i = 0; i < line.ItemArray.Length; i++)
                {
                    r = r + row[i];
                }

                //chart1.Series.Add("Test0");
                //int r_int = Convert.ToInt32(r);
                //int numVal = Int32.Parse(r);
                //Console.WriteLine("waarde:" + numVal);
              //chart1.Series["Series2"].Points.AddXY(0,234);
              //chart1.Series["Series2"].Points.AddXY(1, 234);
              chart1.Series["Series2"].Points.AddXY(0, int.Parse(r));
                //Console.WriteLine(line);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataTable data = GrabData("select count ( distinct dagsoort) from  overvallen");
          // DataTable data1 = GrabData("select count (    dagdeel) from  overvallen");

          displayData(data);
          // displayData(data1);

        }

        /// <summary>
        /// Grabs data from a, specified, remote SQL source.
        /// </summary>
        /// <param name="statement">A String which represents the SQL statement.</param>
        /// <returns>DataTable</returns>
        static public DataTable GrabData(string statement)
        {
            //Setup:
            ///Creeër een plaats om de data van ons request op te slaan.
            DataTable dataStore = new DataTable();
            ///Creeër de connectie die gebruikt zal worden om met de database te communiceren. 
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True");
            //Creeër de SQL statement.
            SqlCommand sqlStatement = new SqlCommand(statement, connection);
            ///Creeër de adapter die de data van de database ophaalt.
            SqlDataAdapter dataGrabber = new SqlDataAdapter(sqlStatement);

            //Work:
            ///Open de connectie naar de database.
            connection.Open();
            ///Vul met de adapter de "dataStore".
            dataGrabber.Fill(dataStore);
            ///Sluit de connectie naar de database.
            connection.Close();

            //Shutdown:
            ///Return de "dataStore".
            return dataStore;
        }
        private void chart1_Click(object sender, EventArgs e)
        {

            
            //Application.Run(new button1_Click());  
        }
    }
}
