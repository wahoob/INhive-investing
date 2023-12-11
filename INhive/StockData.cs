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

namespace INhive
{
    public partial class StockData : Form
    {
        private string ticker;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        private int userId;
        


        public StockData(string ticker = "", int userId = 1)
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
            BuyStock buyStock =new BuyStock(ticker);
            buyStock.Show();
            this.Hide();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            BuyStock buyStock = new BuyStock(ticker, userId);
            buyStock.Show();
            this.Hide();
        }
    }
}