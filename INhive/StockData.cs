using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Siticone.Desktop.UI.WinForms;
using System.Windows.Forms.DataVisualization.Charting;

namespace INhive
{
    public partial class StockData : Form
    {
        private string ticker;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        private int userId;
        public StockData(string ticker = "AAPL", int userId = 1)
        {
            InitializeComponent();
            siticoneHtmlLabel1.Text = ticker;
            this.ticker = ticker;
            this.userId = userId;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT risk_profile, subsecription_frequency, expense_ratio, payback_period, about, market_cap, average_price, stock_price from stocks WHERE ticker = '"+ticker+"'", cn);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                guna2HtmlLabel5.Text = rdr["risk_profile"].ToString();
                guna2HtmlLabel6.Text = rdr["subsecription_frequency"].ToString();
                guna2HtmlLabel10.Text = rdr["expense_ratio"].ToString();
                guna2HtmlLabel8.Text = rdr["payback_period"].ToString();
                label2.Text = rdr["about"].ToString();
                guna2HtmlLabel14.Text = rdr["market_cap"].ToString();
                guna2HtmlLabel21.Text = rdr["average_price"].ToString();
                guna2HtmlLabel1.Text = rdr["stock_price"].ToString() + "EGP";
            }
            cn.Close();

            cn.Open();
            SqlCommand cm1 = new SqlCommand("SELECT purchase_price, unrealized_return, shares from owned_stocks WHERE ticker = '"+ticker+"' and user_id = '"+userId +"'", cn);
            SqlDataReader rdr1 = cm1.ExecuteReader();
            if (rdr1.Read())
            {
                guna2HtmlLabel16.Text = rdr1["purchase_price"].ToString();
                guna2HtmlLabel12.Text = rdr1["unrealized_return"].ToString();
                guna2HtmlLabel18.Text = rdr1["shares"].ToString();
            }
            cn.Close();

            cn.Open();
            SqlCommand cm2 = new SqlCommand("SELECT first_name FROM users WHERE user_id = '"+userId+"'", cn);
            SqlDataReader rdr2 = cm2.ExecuteReader();
            if (rdr2.Read())
            {
                label1.Text = rdr2["first_name"].ToString();
            }
            cn.Close();
            //
            cn.Open();
            string query = "SELECT ticker, date_recorded, price FROM [stock_prices_for_chart] where ticker = '" + ticker + "' ";
            SqlCommand chart_data_qr = new SqlCommand(query, cn);
            SqlDataReader chart_data = chart_data_qr.ExecuteReader();
            while (chart_data.Read())
            {
                string stockTicker = chart_data["ticker"].ToString();
                DateTime dateRecorded = Convert.ToDateTime(chart_data["date_recorded"]);
                decimal price = Convert.ToDecimal(chart_data["price"]);

                Series series = chart1.Series.FindByName(stockTicker);
                if (series == null)
                {
                    series = new Series(stockTicker);
                    series.ChartType = SeriesChartType.Spline;
                    chart1.Series.Add(series);
                }

                series.Points.AddXY(dateRecorded, price);

                // Enable cursor tracking
                chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

                chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

                // Set up tooltips for the individual series
                series.ToolTip = "#VALY";

                // Disable major grid lines
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                // Adjust the size of the horizontal scroll bar
                chart1.ChartAreas[0].AxisX.ScrollBar.Size = 5;

                // Adjust the size of the vertical scroll bar
                chart1.ChartAreas[0].AxisY.ScrollBar.Size = 5;
            }

            cn.Close();
        }
        public int UserId
        {
            get { return userId; }
        }
        public string Ticker
        {
            get { return ticker; }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            BuyStock buyStock =new BuyStock(ticker, userId);
            buyStock.Show();
            this.Hide();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            BuyStock buyStock = new BuyStock(ticker, userId);
            buyStock.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(userId);
            home.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(siticoneTextBox1.Text))
            {
                MessageBox.Show("Enter a ticker name to buy first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ticker = siticoneTextBox1.Text;

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