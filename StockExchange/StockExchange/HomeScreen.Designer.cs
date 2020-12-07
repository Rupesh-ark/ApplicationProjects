
namespace StockExchange
{
    partial class HomeScreen
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
            this.Dashboard = new System.Windows.Forms.TableLayoutPanel();
            this.customers = new System.Windows.Forms.Button();
            this.brokers = new System.Windows.Forms.Button();
            this.stocks = new System.Windows.Forms.Button();
            this.transactions = new System.Windows.Forms.Button();
            this.companies = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.rightPanelBottomTop = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.leftPanelTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightPanelBottom.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(267, 592);
            // 
            // leftPanelBottom
            // 
            this.leftPanelBottom.Size = new System.Drawing.Size(267, 537);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(729, 592);
            // 
            // rightPanelBottom
            // 
            this.rightPanelBottom.Controls.Add(this.Dashboard);
            this.rightPanelBottom.Controls.Add(this.rightPanelBottomTop);
            this.rightPanelBottom.Size = new System.Drawing.Size(729, 537);
            // 
            // rightPanelTop
            // 
            this.rightPanelTop.Size = new System.Drawing.Size(729, 55);
            // 
            // Dashboard
            // 
            this.Dashboard.ColumnCount = 3;
            this.Dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Dashboard.Controls.Add(this.customers, 0, 0);
            this.Dashboard.Controls.Add(this.brokers, 1, 0);
            this.Dashboard.Controls.Add(this.stocks, 2, 0);
            this.Dashboard.Controls.Add(this.transactions, 0, 1);
            this.Dashboard.Controls.Add(this.companies, 1, 1);
            this.Dashboard.Controls.Add(this.exit, 2, 1);
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard.Location = new System.Drawing.Point(0, 14);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.RowCount = 2;
            this.Dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Dashboard.Size = new System.Drawing.Size(729, 523);
            this.Dashboard.TabIndex = 0;
            // 
            // customers
            // 
            this.customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customers.FlatAppearance.BorderSize = 2;
            this.customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers.Location = new System.Drawing.Point(3, 3);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(236, 255);
            this.customers.TabIndex = 0;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // brokers
            // 
            this.brokers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brokers.FlatAppearance.BorderSize = 2;
            this.brokers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brokers.Location = new System.Drawing.Point(245, 3);
            this.brokers.Name = "brokers";
            this.brokers.Size = new System.Drawing.Size(237, 255);
            this.brokers.TabIndex = 1;
            this.brokers.Text = "Brokers";
            this.brokers.UseVisualStyleBackColor = true;
            this.brokers.Click += new System.EventHandler(this.brokers_Click);
            // 
            // stocks
            // 
            this.stocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocks.FlatAppearance.BorderSize = 2;
            this.stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocks.Location = new System.Drawing.Point(488, 3);
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(238, 255);
            this.stocks.TabIndex = 2;
            this.stocks.Text = "Stocks";
            this.stocks.UseVisualStyleBackColor = true;
            this.stocks.Click += new System.EventHandler(this.stocks_Click);
            // 
            // transactions
            // 
            this.transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactions.FlatAppearance.BorderSize = 2;
            this.transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactions.Location = new System.Drawing.Point(3, 264);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(236, 256);
            this.transactions.TabIndex = 3;
            this.transactions.Text = "Transactions";
            this.transactions.UseVisualStyleBackColor = true;
            this.transactions.Click += new System.EventHandler(this.transactions_Click);
            // 
            // companies
            // 
            this.companies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companies.FlatAppearance.BorderSize = 2;
            this.companies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companies.Location = new System.Drawing.Point(245, 264);
            this.companies.Name = "companies";
            this.companies.Size = new System.Drawing.Size(237, 256);
            this.companies.TabIndex = 4;
            this.companies.Text = "Companies";
            this.companies.UseVisualStyleBackColor = true;
            this.companies.Click += new System.EventHandler(this.companies_Click);
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(488, 264);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(238, 256);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // rightPanelBottomTop
            // 
            this.rightPanelBottomTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightPanelBottomTop.Location = new System.Drawing.Point(0, 0);
            this.rightPanelBottomTop.Name = "rightPanelBottomTop";
            this.rightPanelBottomTop.Size = new System.Drawing.Size(729, 14);
            this.rightPanelBottomTop.TabIndex = 0;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 592);
            this.ControlBox = false;
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.leftPanel.ResumeLayout(false);
            this.leftPanelTop.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanelBottom.ResumeLayout(false);
            this.Dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Dashboard;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button brokers;
        private System.Windows.Forms.Button stocks;
        private System.Windows.Forms.Button transactions;
        private System.Windows.Forms.Button companies;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel rightPanelBottomTop;
    }
}