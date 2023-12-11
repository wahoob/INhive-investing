using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace INhive
{
    public partial class BuyStock : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        private int userId;
        private string ticker;
        public BuyStock(string ticker = "", int userId = 1)
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
            StockData stockdata = new StockData();
            stockdata.Show();
            this.Hide();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            int num_of_shares = int.Parse(num_of_stocks.Text);
            cn.Open();

            SqlCommand cm = new SqlCommand(@"SELECT shares FROM owned_stocks WHERE user_id = '"+userId+"' and ticker = '"+ticker+"'", cn);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                int shares = int.Parse(rdr["shares"].ToString());
                rdr.Close();

                SqlCommand cm1 = new SqlCommand(@"UPDATE [dbo].[owned_stocks] SET shares = '"+ (shares+num_of_shares) +"' WHERE user_id = '"+ userId +"' and ticker = '"+ ticker +"'", cn);
                cm1.ExecuteNonQuery();
            } else
            {
                rdr.Close();

                SqlCommand cm2 = new SqlCommand(@"INSERT INTO [dbo].[owned_stocks] (shares, market_value, purchase_price, purchase_value, unrealized_return, total_market_value, total_purchase_value, user_id, ticker) VALUES ('" + num_of_shares + "', 1000, 198, 1456, 50, 1400, 1990, '" + userId +"', '"+ ticker +"');", cn);
                cm2.ExecuteNonQuery();
            }
            cn.Close();
            MessageBox.Show("Shares have been added to your account successfuly");


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
                    MessageBox.Show(num_of_shares + " has been solen");
                } else
                {
                    MessageBox.Show("not enough shares");
                }
                
            }
            cn.Close();
        }
    }
}