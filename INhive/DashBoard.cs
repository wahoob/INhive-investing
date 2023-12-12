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
