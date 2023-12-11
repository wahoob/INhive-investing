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
using System.Web.UI.WebControls;

namespace INhive
{
    public partial class Register : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F7CTSK1\SQLEXPRESS;Initial Catalog=stock_market;Integrated Security=True;");

        public Register()
        {
            InitializeComponent();
        }
        private void OpenNewForm()
        {
            Application.Run(new Login());
        }
        private bool IsNumeric(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d+$");
        }

        private void CreateAccountButton_Click_1(object sender, EventArgs e)
        {
            // Check for all required fields
            if (string.IsNullOrWhiteSpace(fnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(usernameTextBox1.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox2.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox3.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox4.Text) ||
                string.IsNullOrWhiteSpace(confirmpassTextBox1.Text)
                )

            {
                requiredFieldsLabel.Text = "Please fill out all required fields.";
                return;
            }
            else
            {
                requiredFieldsLabel.Text = ""; // Clear the error message if all fields are filled
            }
            if (!IsNumeric(phoneTextBox3.Text))
            {
                phoneErrorLabel.Text = "Phone number must contain only numbers.";
                return;
            }
            else
            {
                phoneErrorLabel.Text = ""; // Clear the error message if phone number contains only numbers
            }





            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("INSERT INTO [dbo].[users] (first_name, last_name, username, email, phone_number, [password]) VALUES ('" + fnameTextBox.Text + "','" + lnameTextBox.Text + "','" + usernameTextBox1.Text + "','" + emailTextBox2.Text + "','" + phoneTextBox3.Text + "','" + passwordTextBox4.Text + "')", cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Your account has been created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fnameTextBox.Text = lnameTextBox.Text = usernameTextBox1.Text = emailTextBox2.Text = phoneTextBox3.Text = passwordTextBox4.Text = confirmpassTextBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            this.Invalidate();
        }
    }
}
