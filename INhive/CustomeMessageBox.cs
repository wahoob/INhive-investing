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
    public partial class CustomeMessageBox : Form
    {
        private int userId;
        private string ticker;
        private string type;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");
        public CustomeMessageBox(string type, int userId = 0, string ticker = "")
        {
            InitializeComponent();

            if (type == "user_edit")
            {
                edit_user_panel.Visible = true;
                stock_panal.Visible = false;
                this.userId = userId;
                cn.Open();

                SqlCommand cm = new SqlCommand("SELECT * FROM [dbo].[users] WHERE user_id = '" + userId + "'", cn);
                SqlDataReader sdr = cm.ExecuteReader();
                if(sdr.Read())
                {
                    string username = sdr["username"].ToString();
                    string email = sdr["email"].ToString();
                    string fName = sdr["first_name"].ToString();
                    string lName = sdr["last_name"].ToString();
                    string phoneNumber = sdr["phone_number"].ToString();
                    Username_input.Text = username;
                    Email_input.Text = email;
                    FName_input.Text = fName;
                    LName_input.Text = lName;
                    Phonenumber_input.Text = phoneNumber;
                }

                cn.Close();
            } else if (type == "stock_add")
            {
                edit_user_panel.Visible = false;
                stock_panal.Visible = true;
                add_edit_stock_button.Text = "Add Stock Data";
                this.type = type;
            } else if (type == "stock_edit")
            {
                edit_user_panel.Visible = false;
                stock_panal.Visible = true;
                add_edit_stock_button.Text = "Edit Stock Data";
                this.ticker = ticker;
                this.type = type;

                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM [dbo].[stocks] WHERE ticker = '"+ ticker +"'", cn);
                SqlDataReader sdr = cm.ExecuteReader();
                if (sdr.Read())
                {
                    string tickerInp = sdr["ticker"].ToString();
                    string shareType = sdr["share_type"].ToString();
                    string subFreq = sdr["subsecription_frequency"].ToString();
                    string paybackPeriod = sdr["payback_period"].ToString();
                    string expenseRatio = sdr["expense_ratio"].ToString();
                    string dailyChange = sdr["daily_change"].ToString();
                    string stockPrice = sdr["stock_price"].ToString();
                    string closePrice = sdr["close_price"].ToString();
                    string companyName = sdr["company_name"].ToString();
                    string sector = sdr["sector"].ToString();
                    string marketCap = sdr["market_cap"].ToString();
                    ticker_input.Text = tickerInp;
                    shareType_input.Text = shareType;
                    subFreq_input.Text = subFreq;
                    paybackPeriod_input.Text = paybackPeriod;
                    expenseRatio_input.Text = expenseRatio;
                    dailyChange_input.Text = dailyChange;
                    stockPrice_input.Text = stockPrice;
                    closePrice_input.Text = closePrice;
                    companyName_input.Text = companyName;
                    sector_input.Text = sector;
                    marketCap_input.Text = marketCap;
                }
                cn.Close();
            }
        }
        public int UserId
        {
            get { return userId; }
        }
        public string Ticker
        {
            get { return ticker; }
        }
        public string Type
        {
            get { return type; }
        }
        public event EventHandler UserDataUpdated;

        private void edit_user_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Username_input.Text) || string.IsNullOrWhiteSpace(Email_input.Text) ||
                string.IsNullOrWhiteSpace(FName_input.Text) || string.IsNullOrWhiteSpace(LName_input.Text) ||
                string.IsNullOrWhiteSpace(Phonenumber_input.Text))
            {
                MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("UPDATE [dbo].[users] SET username = '"+ Username_input.Text +"', email = '"+ Email_input.Text +"', first_name = '"+ FName_input.Text +"', last_name = '"+ LName_input.Text +"', phone_number = '"+ Phonenumber_input.Text +"' WHERE user_id = '"+ userId +"';", cn);
                cm.ExecuteNonQuery();

                cn.Close();
                OnUserDataUpdated(EventArgs.Empty);
                this.Close();
            }
        }
        public event EventHandler StockDataUpdated;
        private void add_edit_stock_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ticker_input.Text) || string.IsNullOrEmpty(shareType_input.Text) ||
                string.IsNullOrEmpty(subFreq_input.Text) || string.IsNullOrEmpty(paybackPeriod_input.Text) ||
                string.IsNullOrEmpty(expenseRatio_input.Text) || string.IsNullOrEmpty(dailyChange_input.Text) ||
                string.IsNullOrEmpty(stockPrice_input.Text) || string.IsNullOrEmpty(closePrice_input.Text) ||
                string.IsNullOrEmpty(companyName_input.Text) || string.IsNullOrEmpty(sector_input.Text) ||
                string.IsNullOrEmpty(marketCap_input.Text))
            {
                MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("yyyy-M-d");
                
                if (type == "stock_add")
                {
                    cn.Open();

                    SqlCommand cm = new SqlCommand("INSERT INTO [dbo].[stocks] ([ticker],[share_type],[risk_profile],[subsecription_frequency],[payback_period],[expense_ratio],[daily_change],[stock_price],[open_price],[close_price],[average_price],[date_data],[company_name],[sector],[market_cap],[admin_id]) VALUES ('" + ticker_input.Text + "', '" + shareType_input.Text + "', '"+ set_risk_profile(shareType_input.Text) + "', '"+ subFreq_input.Text + "', '"+ paybackPeriod_input.Text + "', '"+ expenseRatio_input.Text + "', '"+ dailyChange_input.Text + "', '"+ stockPrice_input.Text + "', '"+ stockPrice_input.Text + "', '"+ closePrice_input.Text + "', '"+ (int.Parse(stockPrice_input.Text) / 2).ToString() + "', '"+formattedDate+"', '"+ companyName_input.Text +"', '"+sector_input.Text+"', '"+marketCap_input.Text+"', '1')", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    OnStockDataUpdated(EventArgs.Empty);
                    this.Close();
                }
                else if(type == "stock_edit")
                {
                    cn.Open();

                    SqlCommand cm = new SqlCommand("UPDATE [dbo].[stocks] SET ticker = '" + ticker_input.Text + "', share_type = '" + shareType_input.Text + "', risk_profile = '" + set_risk_profile(shareType_input.Text) + "', subsecription_frequency = '" + subFreq_input.Text + "', payback_period = '" + paybackPeriod_input.Text + "', expense_ratio = '" + expenseRatio_input.Text + "', daily_change = '" + dailyChange_input.Text + "', stock_price = '" + int.Parse(stockPrice_input.Text) + "', open_price = '" + stockPrice_input.Text + "', close_price = '" + closePrice_input.Text + "', average_price = '" + (int.Parse(stockPrice_input.Text) / 2).ToString() + "', date_data = '" + formattedDate + "', company_name = '" + companyName_input.Text + "', sector = '" + sector_input.Text + "', market_cap = '" + int.Parse(marketCap_input.Text) + "', admin_id = '1' WHERE ticker = '" + ticker + "'", cn);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    OnStockDataUpdated(EventArgs.Empty);
                    this.Close();
                }
            }
        }
        private string set_risk_profile(string share_type)
        {
            if (share_type == "atf")
            {
                return "low";
            } else if (share_type == "bond" || share_type == "stock")
            {
                return "medium";
            } else
            {
                return "high";
            }
        }
        protected virtual void OnUserDataUpdated(EventArgs e)
        {
            UserDataUpdated?.Invoke(this, e);
        }
        protected virtual void OnStockDataUpdated(EventArgs e)
        {
            StockDataUpdated?.Invoke(this, e);
        }

        private void cancel_user_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shareType_input_TextChanged(object sender, EventArgs e)
        {
            CheckButtonState();
        }

        private void stockPrice_input_TextChanged(object sender, EventArgs e)
        {
            CheckButtonState();
        }

        private void CheckButtonState()
        {
            bool isShareTypeValid = shareType_input.Text.ToLower() == "atf" || shareType_input.Text.ToLower() == "bond" || shareType_input.Text.ToLower() == "stock" || shareType_input.Text.ToLower() == "share";
            bool isStockPriceValid = int.TryParse(stockPrice_input.Text, out _);

            if (isShareTypeValid && isStockPriceValid)
            {
                label18.Visible = false;
                label17.Visible = false;
                add_edit_stock_button.Enabled = true;
            }
            else
            {
                label18.Visible = !isShareTypeValid;
                label17.Visible = !isStockPriceValid;
                add_edit_stock_button.Enabled = false;
            }
        }

    }
}
