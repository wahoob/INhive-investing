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

namespace INhive
{
    public partial class Admin : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        
        public Admin(int adminId = 1)
        {
            InitializeComponent();

            Set_Data();

            cn.Open();
            SqlCommand cm3 = new SqlCommand("SELECT * FROM admin WHERE admin_id = '" + adminId + "'", cn);
            SqlDataReader rdr3 = cm3.ExecuteReader();
            rdr3.Read();
            string firstName = rdr3["first_name"].ToString();
            string lastName = rdr3["last_name"].ToString();
            string capitalizedFirstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            string capitalizedLastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
            label1.Text = capitalizedFirstName + " " + capitalizedLastName;
            label5.Text = capitalizedFirstName;
            cn.Close();
        }
        private void Set_Data()
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT COUNT(*) AS NumberOfUsers FROM [dbo].[users]", cn);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                users_number.Text = rdr["NumberOfUsers"].ToString();
            }
            cn.Close();
            cn.Open();
            SqlCommand cm1 = new SqlCommand("SELECT COUNT(*) AS NumberOfStocks FROM [dbo].[stocks]", cn);
            SqlDataReader rdr1 = cm1.ExecuteReader();
            if (rdr1.Read())
            {
                stocks_number.Text = rdr1["NumberOfStocks"].ToString();
            }
            cn.Close();
            cn.Open();
            SqlCommand cm2 = new SqlCommand("SELECT SUM(stock_price) AS SumOfStockPrice FROM [dbo].[stocks]", cn);
            SqlDataReader rdr2 = cm2.ExecuteReader();
            if (rdr2.Read())
            {
                marketCap_number.Text = rdr2["SumOfStockPrice"].ToString();
            }
            cn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_marketDataSet4.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter3.Fill(this.stock_marketDataSet4.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet3.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.stock_marketDataSet3.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet2.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.stock_marketDataSet2.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.stock_marketDataSet1.users);
            // TODO: This line of code loads data into the 'stock_marketDataSet.stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stock_marketDataSet.stocks);
        }

        private void user_edit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(user_input.Text))
            {
                MessageBox.Show("Please Enter a user id first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int userId = int.Parse(user_input.Text);

                CustomeMessageBox customeMessageBox = new CustomeMessageBox("user_edit", userId: userId);
                customeMessageBox.UserDataUpdated += CustomeMessageBox_UserDataUpdated;
                customeMessageBox.ShowDialog();
            }
        }
        private void CustomeMessageBox_UserDataUpdated(object sender, EventArgs e)
        {
            this.usersTableAdapter3.Fill(this.stock_marketDataSet4.users);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(user_input.Text))
            {
                MessageBox.Show("Please Enter a user id first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int userId = int.Parse(user_input.Text);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    cn.Open();

                    SqlCommand cm1 = new SqlCommand("DELETE FROM owned_stocks WHERE user_id = '" + userId + "'", cn);
                    cm1.ExecuteNonQuery();

                    SqlCommand cm2 = new SqlCommand("DELETE FROM payment_details WHERE user_id = '" + userId + "'", cn);
                    cm2.ExecuteNonQuery();

                    SqlCommand cm = new SqlCommand("DELETE FROM [dbo].[users] WHERE user_id = '" + userId + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                }
                this.usersTableAdapter3.Fill(this.stock_marketDataSet4.users);
                Set_Data();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CustomeMessageBox customeMessageBox = new CustomeMessageBox("stock_add");
            customeMessageBox.StockDataUpdated += CustomeMessageBox_StockDataUpdated;
            customeMessageBox.ShowDialog();
            Set_Data();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(stock_input.Text))
            {
                MessageBox.Show("Please Enter a ticker first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else { 
            string ticker = stock_input.Text.ToString();
            CustomeMessageBox customeMessageBox = new CustomeMessageBox("stock_edit", ticker: ticker);
            customeMessageBox.StockDataUpdated += CustomeMessageBox_StockDataUpdated;
            customeMessageBox.ShowDialog();
            }
        }
        private void CustomeMessageBox_StockDataUpdated(object sender, EventArgs e)
        {
            this.stocksTableAdapter.Fill(this.stock_marketDataSet.stocks);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(stock_input.Text))
            {
                MessageBox.Show("Please Enter a ticker first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else { 
            string ticker = stock_input.Text.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                    cn.Open();

                    SqlCommand cm1 = new SqlCommand("DELETE FROM [dbo].[stock_prices_for_chart] WHERE ticker = '" + ticker + "'", cn);
                    cm1.ExecuteNonQuery();

                    SqlCommand cm2 = new SqlCommand("DELETE FROM [dbo].[owned_stocks] WHERE ticker = '" + ticker + "'", cn);
                    cm2.ExecuteNonQuery();

                    SqlCommand cm = new SqlCommand("DELETE FROM [dbo].[stocks] WHERE ticker = '" + ticker + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    Set_Data();
            }
            this.stocksTableAdapter.Fill(this.stock_marketDataSet.stocks);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
