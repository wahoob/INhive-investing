using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using Siticone.Desktop.UI.WinForms;

namespace INhive
{
    public partial class BuyStock : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        private int userId;
        private string ticker;
        public BuyStock(string ticker = "AAPL", int userId = 1)
        {
            InitializeComponent();
            siticoneHtmlLabel1.Text = ticker;
            this.userId = userId;
            this.ticker = ticker;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT stock_price from stocks WHERE ticker = '" + ticker + "'", cn);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                guna2HtmlLabel1.Text = rdr["stock_price"].ToString() + "EGP";
            }
            cn.Close();

            cn.Open();
            SqlCommand cm2 = new SqlCommand("SELECT first_name FROM users WHERE user_id = '" + userId + "'", cn);
            SqlDataReader rdr2 = cm2.ExecuteReader();
            if (rdr2.Read())
            {
                label1.Text = rdr2["first_name"].ToString();
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

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            StockData stockdata = new StockData(ticker, userId);
            stockdata.Show();
            this.Hide();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(userId, ticker, int.Parse(num_of_stocks.Text));
            payment.Show();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            int num_of_shares = int.Parse(num_of_stocks.Text);
            cn.Open();

            SqlCommand cm = new SqlCommand(@"SELECT shares FROM owned_stocks WHERE user_id = '" + userId + "' and ticker = '" + ticker + "'", cn);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                int shares = int.Parse(rdr["shares"].ToString());
                rdr.Close();

                if(shares-num_of_shares > 0)
                {
                    SqlCommand cm1 = new SqlCommand(@"UPDATE [dbo].[owned_stocks] SET shares = '" + (shares - num_of_shares) + "' WHERE user_id = '" + userId + "' and ticker = '" + ticker + "'", cn);
                    cm1.ExecuteNonQuery();
                    MessageBox.Show(num_of_shares + " has been sold");
                } else
                {
                    MessageBox.Show("not enough shares");
                } 
            }
            cn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks(userId);
            stocks.Show();
            this.Hide();
        }
    }
}