using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace INhive
{
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        private int userId;
        public Dashboard(int userId = 1)
        {
            InitializeComponent();
            this.userId = userId;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT first_name FROM users WHERE user_id = '" + userId + "'", cn);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                label1.Text = rdr["first_name"].ToString();
            }
            cn.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_marketDataSet7.owned_stocks' table. You can move, or remove it, as needed.
            //this.owned_stocksTableAdapter1.Fill(this.stock_marketDataSet7.owned_stocks);

            string query = "SELECT shares, market_value, purchase_price, purchase_value, unrealized_return, total_market_value, total_purchase_value, ticker FROM dbo.owned_stocks WHERE user_id = @UserId;";
            cn.Open();

            SqlCommand cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@UserId", userId);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
            {
                adapter.Fill(dataTable);
            }
            guna2DataGridView2.DataSource = dataTable;

            cn.Close();

            cn.Open();

            string total_purchase_value_q = "SELECT SUM(purchase_value) AS total_purchase_value FROM owned_stocks WHERE user_id = @user_id;";
            SqlCommand total_purchase_value = new SqlCommand(total_purchase_value_q, cn);
            total_purchase_value.Parameters.AddWithValue("@user_id", userId);

            string total_market_value_q = "SELECT SUM(market_value) AS total_market_value FROM owned_stocks WHERE user_id = @user_id;";
            SqlCommand total_market_value = new SqlCommand(total_market_value_q, cn);
            total_market_value.Parameters.AddWithValue("@user_id", userId);

            // Get the total purchase value as a decimal
            decimal purchaseValue = 0;
            object purchaseValueResult = total_purchase_value.ExecuteScalar();
            if (purchaseValueResult != null && purchaseValueResult != DBNull.Value)
            {
                purchaseValue = Convert.ToDecimal(purchaseValueResult);
            }

            // Get the total market value as a decimal
            decimal marketValue = 0;
            object marketValueResult = total_market_value.ExecuteScalar();
            if (marketValueResult != null && marketValueResult != DBNull.Value)
            {
                marketValue = Convert.ToDecimal(marketValueResult);
            }

            // Set the values to your controls
            purchase_value.Text = purchaseValue.ToString();
            siticoneHtmlLabel19.Text = marketValue.ToString();

            decimal difference = marketValue - purchaseValue;
            siticoneHtmlLabel20.Text = difference.ToString();

            decimal percentageDifference = 0;

            if (purchaseValue != 0)
            {
                percentageDifference = Math.Round(((marketValue - purchaseValue) / purchaseValue) * 100, 1);
            }

            siticoneHtmlLabel22.Text = percentageDifference.ToString() + "%";


            cn.Close();




            // Initialize the Chart object
            chart1 = new Chart();
            chart1.Size = new System.Drawing.Size(300, 300);
            chart1.Location = new System.Drawing.Point(100, 150);

            // Create a ChartArea
            ChartArea chartArea1 = new ChartArea();
            chart1.ChartAreas.Add(chartArea1);

            // Create a Series with Pie chart type
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Pie;
            series1.Points.AddXY("Profit", percentageDifference);

            series1.Points.AddXY("Base", purchaseValue);

            chart1.Series.Add(series1);

            // Add the Chart to the form
            this.Controls.Add(chart1);
        }
        public int UserId
        {
            get { return userId; }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Home Home = new Home(userId);
            this.Hide();
            Home.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(siticoneTextBox2.Text))
            {
                MessageBox.Show("Enter a ticker name to buy first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ticker = siticoneTextBox2.Text;

                cn.Open();

                SqlCommand cm = new SqlCommand("SELECT * FROM stocks WHERE ticker = '" + ticker + "';", cn);
                SqlDataReader rdr = cm.ExecuteReader();
                if (rdr.HasRows)
                {
                    StockData stockData = new StockData(ticker, userId);
                    stockData.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter a correct ticker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cn.Close();
            }
        }
    }
}
