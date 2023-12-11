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
        string ticker = "AAPL";
        int user_id = 1;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            this.Hide();
            Home.Show();
        }
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Explore Explore = new Explore();
            this.Hide();
            Explore.Show();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_marketDataSet7.owned_stocks' table. You can move, or remove it, as needed.
            //this.owned_stocksTableAdapter1.Fill(this.stock_marketDataSet7.owned_stocks);

            string query = "SELECT shares, market_value, purchase_price, purchase_value, unrealized_return, total_market_value, total_purchase_value, ticker FROM dbo.owned_stocks WHERE user_id = @UserId;";
            cn.Open();

            SqlCommand cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@UserId", user_id);
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
            {
                adapter.Fill(dataTable);
            }
            guna2DataGridView2.DataSource = dataTable;

            cn.Close();
        }
    }
}
