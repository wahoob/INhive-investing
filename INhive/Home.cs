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

namespace INhive
{
    public partial class Home : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        private int userId;
        public Home(int userId = 1) 
        {
            InitializeComponent();
            this.userId = userId;

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Explore Explore = new Explore(userId);
            this.Hide();
            Explore.Show();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks(userId);
            stocks.Show();
            this.Hide();
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

                SqlCommand cm = new SqlCommand("SELECT * FROM stocks WHERE ticker = '"+ticker+"';", cn);
                SqlDataReader rdr = cm.ExecuteReader();
                if (rdr.HasRows)
                {
                    StockData stockData = new StockData(ticker, userId);
                    stockData.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter a correct ticker", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cn.Close();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId);
            dashboard.Show();
            this.Hide();
        }
    }
}
