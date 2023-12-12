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
    public partial class Payment : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        private int userId;
        private string ticker;
        private int num_of_stocks;
        public Payment(int userId = 1, string ticker = "AAPL", int num_of_stocks = 1)
        {
            InitializeComponent();
            this.userId = userId;
            this.ticker = ticker;
            this.num_of_stocks = num_of_stocks;
        }
        public int UserId
        {
            get { return userId; }
        }
        public string Ticker
        {
            get { return ticker; }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_edit_stock_button_Click(object sender, EventArgs e)
        {
            int num_of_shares = num_of_stocks;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                error1.Visible = true;
            } else if (string.IsNullOrEmpty(textBox2.Text))
            {
                error2.Visible = true;
            } else if (string.IsNullOrEmpty(textBox3.Text))
            {
                error3.Visible = true;
            } else if (string.IsNullOrEmpty(textBox4.Text))
            {
                error4.Visible = true;
            } else if (string.IsNullOrEmpty(textBox5.Text))
            {
                error5.Visible = true;
            } else
            {
                cn.Open();

                SqlCommand cm1 = new SqlCommand(@"SELECT * FROM payment_details WHERE credit_card_number = '"+textBox1.Text+"'", cn);
                SqlDataReader rdr1 = cm1.ExecuteReader();
                if (!rdr1.HasRows)
                {
                    rdr1.Close();
                    SqlCommand cm2 = new SqlCommand(@"INSERT INTO payment_details (credit_card_number, expire_date, security_code, country, address, user_id) VALUES ('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"', '"+userId+"')", cn);
                    cm2.ExecuteNonQuery();
                }

                cn.Close();
            }

            cn.Open();
            SqlCommand cm = new SqlCommand(@"SELECT shares FROM owned_stocks WHERE user_id = '" + userId + "' and ticker = '" + ticker + "'", cn);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                int shares = int.Parse(rdr["shares"].ToString());
                rdr.Close();

                SqlCommand cm3 = new SqlCommand(@"UPDATE [dbo].[owned_stocks] SET shares = '" + (shares + num_of_shares) + "' WHERE user_id = '" + userId + "' and ticker = '" + ticker + "'", cn);
                cm3.ExecuteNonQuery();
            }
            else
            {
                rdr.Close();

                SqlCommand cm4 = new SqlCommand(@"INSERT INTO [dbo].[owned_stocks] (shares, market_value, purchase_price, purchase_value, unrealized_return, total_market_value, total_purchase_value, user_id, ticker) VALUES ('" + num_of_shares + "', 1000, 198, 1456, 50, 1400, 1990, '" + userId + "', '" + ticker + "');", cn);
                cm4.ExecuteNonQuery();
            }
            cn.Close();
            DialogResult result = MessageBox.Show("Shares have been added to your account successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
