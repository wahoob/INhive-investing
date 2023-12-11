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
    public partial class Home : Form
    {
        private int userId;
        public Home(int userId = 1) 
        {
            InitializeComponent();
            this.userId = userId;
        }
        public int UserId
        {
            get { return userId; }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Explore Explore = new Explore();
            this.Hide();
            Explore.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
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
    }
}
