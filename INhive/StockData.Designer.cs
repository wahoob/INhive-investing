using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace INhive
{
    partial class StockData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockData));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticoneButton7 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel33 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.siticonePictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.siticoneTextBox1);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1771, 68);
            this.panel1.TabIndex = 0;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(53)))));
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(341, 19);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(94, 34);
            this.guna2Button2.TabIndex = 29;
            this.guna2Button2.Text = "Search";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(1417, 6);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(107, 55);
            this.guna2Button3.TabIndex = 13;
            this.guna2Button3.Text = "Logout";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.siticoneTextBox1.BorderRadius = 15;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.White;
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.White;
            this.siticoneTextBox1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.siticoneTextBox1.Location = new System.Drawing.Point(77, 17);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneTextBox1.PlaceholderText = " Search for symbol ex. AAPL ";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(248, 37);
            this.siticoneTextBox1.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1183, 6);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(210, 55);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1612, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(7, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 47);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(784, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 59);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.siticoneButton7);
            this.panel2.Controls.Add(this.siticoneButton6);
            this.panel2.Controls.Add(this.siticoneHtmlLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1771, 61);
            this.panel2.TabIndex = 2;
            // 
            // siticoneButton7
            // 
            this.siticoneButton7.BorderRadius = 15;
            this.siticoneButton7.BorderThickness = 2;
            this.siticoneButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton7.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.78182F);
            this.siticoneButton7.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.siticoneButton7.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton7.Location = new System.Drawing.Point(1563, 8);
            this.siticoneButton7.Name = "siticoneButton7";
            this.siticoneButton7.Size = new System.Drawing.Size(159, 46);
            this.siticoneButton7.TabIndex = 4;
            this.siticoneButton7.Text = "Sell";
            this.siticoneButton7.Click += new System.EventHandler(this.siticoneButton7_Click);
            // 
            // siticoneButton6
            // 
            this.siticoneButton6.BorderRadius = 15;
            this.siticoneButton6.BorderThickness = 2;
            this.siticoneButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.siticoneButton6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.78182F);
            this.siticoneButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneButton6.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton6.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.78182F);
            this.siticoneButton6.HoverState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton6.Location = new System.Drawing.Point(1398, 6);
            this.siticoneButton6.Name = "siticoneButton6";
            this.siticoneButton6.Size = new System.Drawing.Size(159, 46);
            this.siticoneButton6.TabIndex = 3;
            this.siticoneButton6.Text = "Buy";
            this.siticoneButton6.Click += new System.EventHandler(this.siticoneButton6_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(35, 17);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(167, 34);
            this.siticoneHtmlLabel1.TabIndex = 5;
            this.siticoneHtmlLabel1.Text = "Azimut Gold";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel10);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel11);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(77, 629);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(760, 271);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(593, 181);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(103, 42);
            this.guna2HtmlLabel8.TabIndex = 8;
            this.guna2HtmlLabel8.Text = "Daily";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(593, 160);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(137, 28);
            this.guna2HtmlLabel9.TabIndex = 7;
            this.guna2HtmlLabel9.Text = "Payback Period";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(593, 102);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(121, 33);
            this.guna2HtmlLabel10.TabIndex = 6;
            this.guna2HtmlLabel10.Text = "4.90%";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.AutoSize = false;
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(593, 81);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(155, 23);
            this.guna2HtmlLabel11.TabIndex = 5;
            this.guna2HtmlLabel11.Text = "Expense Ratio";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(20, 181);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(117, 33);
            this.guna2HtmlLabel6.TabIndex = 4;
            this.guna2HtmlLabel6.Text = "Weekly";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(20, 160);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(194, 29);
            this.guna2HtmlLabel7.TabIndex = 3;
            this.guna2HtmlLabel7.Text = "Subscription Frequency";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(19, 102);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(105, 33);
            this.guna2HtmlLabel5.TabIndex = 2;
            this.guna2HtmlLabel5.Text = "Low";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(19, 81);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(167, 23);
            this.guna2HtmlLabel4.TabIndex = 1;
            this.guna2HtmlLabel4.Text = "Risk Profile";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(19, 26);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(170, 33);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Fact Sheet";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.29091F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(90, 561);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(152, 48);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "11.93693";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel2.BorderRadius = 20;
            this.guna2CustomGradientPanel2.BorderThickness = 1;
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel21);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel22);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel12);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel13);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel14);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel15);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel16);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel17);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel18);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel19);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2HtmlLabel20);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(819, 959);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(760, 267);
            this.guna2CustomGradientPanel2.TabIndex = 6;
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.AutoSize = false;
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(638, 87);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(100, 33);
            this.guna2HtmlLabel21.TabIndex = 10;
            this.guna2HtmlLabel21.Text = "4.90%";
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.AutoSize = false;
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(638, 63);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(121, 30);
            this.guna2HtmlLabel22.TabIndex = 9;
            this.guna2HtmlLabel22.Text = "Average Price";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.AutoSize = false;
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(364, 193);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(151, 33);
            this.guna2HtmlLabel12.TabIndex = 8;
            this.guna2HtmlLabel12.Text = "EGP 129.80";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.AutoSize = false;
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(364, 171);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(151, 23);
            this.guna2HtmlLabel13.TabIndex = 7;
            this.guna2HtmlLabel13.Text = "Unrealized Return";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.AutoSize = false;
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(364, 87);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(75, 33);
            this.guna2HtmlLabel14.TabIndex = 6;
            this.guna2HtmlLabel14.Text = "1218";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.AutoSize = false;
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(364, 63);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(118, 23);
            this.guna2HtmlLabel15.TabIndex = 5;
            this.guna2HtmlLabel15.Text = "Market Value";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.AutoSize = false;
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(19, 193);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(132, 33);
            this.guna2HtmlLabel16.TabIndex = 4;
            this.guna2HtmlLabel16.Text = "1.019.06";
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.AutoSize = false;
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(19, 171);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(132, 23);
            this.guna2HtmlLabel17.TabIndex = 3;
            this.guna2HtmlLabel17.Text = "Purchase Value";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.AutoSize = false;
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(19, 87);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(73, 33);
            this.guna2HtmlLabel18.TabIndex = 2;
            this.guna2HtmlLabel18.Text = "102";
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.AutoSize = false;
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(19, 63);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(73, 23);
            this.guna2HtmlLabel19.TabIndex = 1;
            this.guna2HtmlLabel19.Text = "Shares";
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.AutoSize = false;
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(19, 20);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(165, 33);
            this.guna2HtmlLabel20.TabIndex = 0;
            this.guna2HtmlLabel20.Text = "Your Position";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel3.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.BorderThickness = 1;
            this.guna2CustomGradientPanel3.Controls.Add(this.label2);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2HtmlLabel33);
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(77, 1282);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(760, 249);
            this.guna2CustomGradientPanel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 156);
            this.label2.TabIndex = 12;
            this.label2.Text = "label4";
            // 
            // guna2HtmlLabel33
            // 
            this.guna2HtmlLabel33.AutoSize = false;
            this.guna2HtmlLabel33.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel33.Font = new System.Drawing.Font("Segoe UI Semibold", 13.74545F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel33.Location = new System.Drawing.Point(19, 16);
            this.guna2HtmlLabel33.Name = "guna2HtmlLabel33";
            this.guna2HtmlLabel33.Size = new System.Drawing.Size(90, 33);
            this.guna2HtmlLabel33.TabIndex = 0;
            this.guna2HtmlLabel33.Text = "About";
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox2.Image")));
            this.siticonePictureBox2.ImageRotate = 0F;
            this.siticonePictureBox2.Location = new System.Drawing.Point(107, 916);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.Size = new System.Drawing.Size(333, 345);
            this.siticonePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox2.TabIndex = 10;
            this.siticonePictureBox2.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(1146, 366);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(591, 475);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1127, 1483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 111);
            this.label3.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(77, 167);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1122, 375);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // StockData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1814, 850);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticonePictureBox2);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Name = "StockData";
            this.Text = "Stock Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel33;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}