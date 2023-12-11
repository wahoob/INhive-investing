using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INhive
{
    public partial class Stocks : Form
    {
        private int userId;
        public Stocks(int userId = 1)
        {
            InitializeComponent();
            this.userId = userId;
        }
        public int UserId
        {
            get { return userId; }
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_marketDataSet8.stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stock_marketDataSet8.stocks);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(buy_label.Text))
            {
                MessageBox.Show("Enter a ticker name to buy first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string ticker = buy_label.Text;
                StockData stockData = new StockData(ticker, userId);
                stockData.Show();
                this.Hide();
            }
        }
    }
}
