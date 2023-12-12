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
using System.Net;
using INhive;

namespace INhive
{
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");

        //Thread th;

        public Login()
        {
            InitializeComponent();
        }


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                SqlCommand cm = new SqlCommand("select * from [dbo].[admin] where email='" + EmailTextBox.Text + "'and password='" + passwordTextBox.Text + "'", cn);
                SqlDataReader ardr = cm.ExecuteReader();

                if (ardr.HasRows)
                {
                    wrong.Text = "";
                    ardr.Read();
                    int adminId = int.Parse(ardr["admin_id"].ToString());
                    Admin admin = new Admin(adminId);
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    ardr.Close(); // Close the admin data reader

                    cm = new SqlCommand("select * from [dbo].[users] where email='" + EmailTextBox.Text + "'and password='" + passwordTextBox.Text + "'", cn);
                    SqlDataReader rdr = cm.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        wrong.Text = "";
                        rdr.Read();
                        int userId = int.Parse(rdr["user_id"].ToString());
                        Home Home = new Home(userId);
                        this.Hide();
                        Home.Show();
                        // User login logic
                    }
                    else
                    {
                        wrong.Text = "Wrong Password Or Email";

                    }

                    rdr.Close(); // Close the user data reader
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close(); // Close the connection in the finally block to ensure it gets closed even if an exception occurs
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTextBox.PasswordChar = '\0';

            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void CreateButton_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
            this.Invalidate();
        }
    }

}
