using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace INhive
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.emailvalidation = new System.Windows.Forms.Label();
            this.messagePasswprd = new System.Windows.Forms.Label();
            this.confirmpassTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.requiredFieldsLabel = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.phoneTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateAccountButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.siticonePasswordValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticonePasswordValidationTool();
            this.siticoneEmailValidatingTool1 = new Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool();
            this.siticoneCreditCardValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 30;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.emailvalidation);
            this.guna2Panel1.Controls.Add(this.messagePasswprd);
            this.guna2Panel1.Controls.Add(this.confirmpassTextBox1);
            this.guna2Panel1.Controls.Add(this.phoneErrorLabel);
            this.guna2Panel1.Controls.Add(this.requiredFieldsLabel);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Controls.Add(this.phoneTextBox3);
            this.guna2Panel1.Controls.Add(this.passwordTextBox4);
            this.guna2Panel1.Controls.Add(this.usernameTextBox1);
            this.guna2Panel1.Controls.Add(this.emailTextBox2);
            this.guna2Panel1.Controls.Add(this.CreateAccountButton);
            this.guna2Panel1.Controls.Add(this.fnameTextBox);
            this.guna2Panel1.Controls.Add(this.lnameTextBox);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(1206, 147);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(460, 640);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(131, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Already Have An Account?";
            // 
            // emailvalidation
            // 
            this.emailvalidation.AutoSize = true;
            this.emailvalidation.Location = new System.Drawing.Point(62, 290);
            this.emailvalidation.Name = "emailvalidation";
            this.emailvalidation.Size = new System.Drawing.Size(0, 17);
            this.emailvalidation.TabIndex = 17;
            // 
            // messagePasswprd
            // 
            this.messagePasswprd.AutoSize = true;
            this.messagePasswprd.Location = new System.Drawing.Point(62, 435);
            this.messagePasswprd.Name = "messagePasswprd";
            this.messagePasswprd.Size = new System.Drawing.Size(0, 17);
            this.messagePasswprd.TabIndex = 16;
            // 
            // confirmpassTextBox1
            // 
            this.confirmpassTextBox1.Animated = true;
            this.confirmpassTextBox1.AutoRoundedCorners = true;
            this.confirmpassTextBox1.BorderRadius = 13;
            this.confirmpassTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmpassTextBox1.DefaultText = "";
            this.confirmpassTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmpassTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmpassTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmpassTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmpassTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmpassTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmpassTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmpassTextBox1.Location = new System.Drawing.Point(54, 404);
            this.confirmpassTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmpassTextBox1.Name = "confirmpassTextBox1";
            this.confirmpassTextBox1.PasswordChar = '*';
            this.confirmpassTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.confirmpassTextBox1.PlaceholderText = "Confirm Password";
            this.confirmpassTextBox1.SelectedText = "";
            this.confirmpassTextBox1.Size = new System.Drawing.Size(333, 29);
            this.confirmpassTextBox1.TabIndex = 6;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(82, 344);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.phoneErrorLabel.TabIndex = 14;
            // 
            // requiredFieldsLabel
            // 
            this.requiredFieldsLabel.AutoSize = true;
            this.requiredFieldsLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredFieldsLabel.Location = new System.Drawing.Point(132, 520);
            this.requiredFieldsLabel.Name = "requiredFieldsLabel";
            this.requiredFieldsLabel.Size = new System.Drawing.Size(0, 17);
            this.requiredFieldsLabel.TabIndex = 13;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 21;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(255)))), ((int)(((byte)(89)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.Location = new System.Drawing.Point(128, 584);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(197, 45);
            this.guna2GradientButton1.TabIndex = 9;
            this.guna2GradientButton1.Text = "LOGIN";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // phoneTextBox3
            // 
            this.phoneTextBox3.Animated = true;
            this.phoneTextBox3.AutoRoundedCorners = true;
            this.phoneTextBox3.BorderRadius = 13;
            this.phoneTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox3.DefaultText = "";
            this.phoneTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox3.Location = new System.Drawing.Point(53, 313);
            this.phoneTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTextBox3.Name = "phoneTextBox3";
            this.phoneTextBox3.PasswordChar = '\0';
            this.phoneTextBox3.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.phoneTextBox3.PlaceholderText = "Phone Number";
            this.phoneTextBox3.SelectedText = "";
            this.phoneTextBox3.Size = new System.Drawing.Size(333, 29);
            this.phoneTextBox3.TabIndex = 4;
            // 
            // passwordTextBox4
            // 
            this.passwordTextBox4.Animated = true;
            this.passwordTextBox4.AutoRoundedCorners = true;
            this.passwordTextBox4.BorderRadius = 13;
            this.passwordTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox4.DefaultText = "";
            this.passwordTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox4.Location = new System.Drawing.Point(53, 361);
            this.passwordTextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox4.Name = "passwordTextBox4";
            this.passwordTextBox4.PasswordChar = '*';
            this.passwordTextBox4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox4.PlaceholderText = "Password";
            this.passwordTextBox4.SelectedText = "";
            this.passwordTextBox4.Size = new System.Drawing.Size(333, 29);
            this.passwordTextBox4.TabIndex = 5;
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.Animated = true;
            this.usernameTextBox1.AutoRoundedCorners = true;
            this.usernameTextBox1.BorderRadius = 13;
            this.usernameTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox1.DefaultText = "";
            this.usernameTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox1.Location = new System.Drawing.Point(53, 214);
            this.usernameTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.PasswordChar = '\0';
            this.usernameTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.usernameTextBox1.PlaceholderText = "User Name";
            this.usernameTextBox1.SelectedText = "";
            this.usernameTextBox1.Size = new System.Drawing.Size(333, 29);
            this.usernameTextBox1.TabIndex = 2;
            // 
            // emailTextBox2
            // 
            this.emailTextBox2.Animated = true;
            this.emailTextBox2.AutoRoundedCorners = true;
            this.emailTextBox2.BorderRadius = 13;
            this.emailTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox2.DefaultText = "";
            this.emailTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox2.Location = new System.Drawing.Point(53, 259);
            this.emailTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox2.Name = "emailTextBox2";
            this.emailTextBox2.PasswordChar = '\0';
            this.emailTextBox2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailTextBox2.PlaceholderText = "Email";
            this.emailTextBox2.SelectedText = "";
            this.emailTextBox2.Size = new System.Drawing.Size(333, 29);
            this.emailTextBox2.TabIndex = 3;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Animated = true;
            this.CreateAccountButton.AutoRoundedCorners = true;
            this.CreateAccountButton.BorderRadius = 21;
            this.CreateAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccountButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(255)))), ((int)(((byte)(89)))));
            this.CreateAccountButton.FillColor2 = System.Drawing.Color.Yellow;
            this.CreateAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CreateAccountButton.ForeColor = System.Drawing.Color.Black;
            this.CreateAccountButton.Location = new System.Drawing.Point(121, 468);
            this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(197, 45);
            this.CreateAccountButton.TabIndex = 7;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click_1);
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Animated = true;
            this.fnameTextBox.AutoRoundedCorners = true;
            this.fnameTextBox.BorderRadius = 13;
            this.fnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameTextBox.DefaultText = "";
            this.fnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTextBox.Location = new System.Drawing.Point(53, 121);
            this.fnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.PasswordChar = '\0';
            this.fnameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.fnameTextBox.PlaceholderText = "First Name";
            this.fnameTextBox.SelectedText = "";
            this.fnameTextBox.Size = new System.Drawing.Size(333, 29);
            this.fnameTextBox.TabIndex = 0;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Animated = true;
            this.lnameTextBox.AutoRoundedCorners = true;
            this.lnameTextBox.BorderRadius = 13;
            this.lnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameTextBox.DefaultText = "";
            this.lnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTextBox.Location = new System.Drawing.Point(53, 165);
            this.lnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.PasswordChar = '\0';
            this.lnameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lnameTextBox.PlaceholderText = "Last Name";
            this.lnameTextBox.SelectedText = "";
            this.lnameTextBox.Size = new System.Drawing.Size(333, 29);
            this.lnameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "If you  already have a thndr account please use the same\nmethod to sign in.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F);
            this.label1.Location = new System.Drawing.Point(115, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Account";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // siticonePasswordValidationTool1
            // 
            this.siticonePasswordValidationTool1.MessageLabel = this.messagePasswprd;
            this.siticonePasswordValidationTool1.PasswordMaximumLength = ((long)(16));
            this.siticonePasswordValidationTool1.PasswordTextBox = this.passwordTextBox4;
            this.siticonePasswordValidationTool1.PasswordTextBoxConfirm = this.confirmpassTextBox1;
            this.siticonePasswordValidationTool1.PasswordValidColor = System.Drawing.Color.Lime;
            // 
            // siticoneEmailValidatingTool1
            // 
            this.siticoneEmailValidatingTool1.EmailTextbox = this.emailTextBox2;
            this.siticoneEmailValidatingTool1.MessageDescription = this.emailvalidation;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1815, 826);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton CreateAccountButton;
        private Guna.UI2.WinForms.Guna2TextBox fnameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox lnameTextBox;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox1;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Label requiredFieldsLabel;
        private Label phoneErrorLabel;
        private Guna.UI2.WinForms.Guna2TextBox confirmpassTextBox1;
        private Siticone.Desktop.UI.Winforms.SiticonePasswordValidationTool siticonePasswordValidationTool1;
        private Label messagePasswprd;
        private Label emailvalidation;
        private Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool siticoneEmailValidatingTool1;
        private Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool siticoneCreditCardValidationTool1;
        private Label label3;
    }
}