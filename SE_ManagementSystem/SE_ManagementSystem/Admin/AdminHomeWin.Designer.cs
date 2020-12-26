
namespace SE_ManagementSystem
{
    partial class AdminHomeWin
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
            this.adminMenu = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new System.Windows.Forms.Button();
            this.stocks = new System.Windows.Forms.Button();
            this.companies = new System.Windows.Forms.Button();
            this.brokers = new System.Windows.Forms.Button();
            this.transactions = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Button();
            this.shareholders = new System.Windows.Forms.Button();
            this.left.SuspendLayout();
            this.right.SuspendLayout();
            this.adminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(350, 572);
            // 
            // right
            // 
            this.right.Controls.Add(this.adminMenu);
            this.right.Size = new System.Drawing.Size(934, 572);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.adminMenu, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(934, 72);
            // 
            // adminMenu
            // 
            this.adminMenu.ColumnCount = 4;
            this.adminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.adminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.adminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.adminMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.adminMenu.Controls.Add(this.chart, 2, 1);
            this.adminMenu.Controls.Add(this.stocks, 1, 1);
            this.adminMenu.Controls.Add(this.companies, 0, 1);
            this.adminMenu.Controls.Add(this.brokers, 3, 0);
            this.adminMenu.Controls.Add(this.transactions, 3, 1);
            this.adminMenu.Controls.Add(this.customers, 0, 0);
            this.adminMenu.Controls.Add(this.shareholders, 1, 0);
            this.adminMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminMenu.Location = new System.Drawing.Point(0, 72);
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.RowCount = 2;
            this.adminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adminMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.adminMenu.Size = new System.Drawing.Size(934, 500);
            this.adminMenu.TabIndex = 1;
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart.FlatAppearance.BorderSize = 2;
            this.chart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.chart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chart.ForeColor = System.Drawing.Color.Azure;
            this.chart.Location = new System.Drawing.Point(469, 253);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(227, 244);
            this.chart.TabIndex = 5;
            this.chart.Text = "Chart";
            this.chart.UseVisualStyleBackColor = true;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // stocks
            // 
            this.stocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stocks.FlatAppearance.BorderSize = 2;
            this.stocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.stocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocks.ForeColor = System.Drawing.Color.Azure;
            this.stocks.Location = new System.Drawing.Point(236, 253);
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(227, 244);
            this.stocks.TabIndex = 4;
            this.stocks.Text = "Stocks";
            this.stocks.UseVisualStyleBackColor = true;
            this.stocks.Click += new System.EventHandler(this.stocks_Click);
            // 
            // companies
            // 
            this.companies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.companies.FlatAppearance.BorderSize = 2;
            this.companies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.companies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.companies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companies.ForeColor = System.Drawing.Color.Azure;
            this.companies.Location = new System.Drawing.Point(3, 253);
            this.companies.Name = "companies";
            this.companies.Size = new System.Drawing.Size(227, 244);
            this.companies.TabIndex = 3;
            this.companies.Text = "Companies";
            this.companies.UseVisualStyleBackColor = true;
            this.companies.Click += new System.EventHandler(this.companies_Click);
            // 
            // brokers
            // 
            this.brokers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brokers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brokers.FlatAppearance.BorderSize = 2;
            this.brokers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.brokers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brokers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brokers.ForeColor = System.Drawing.Color.Azure;
            this.brokers.Location = new System.Drawing.Point(702, 3);
            this.brokers.Name = "brokers";
            this.brokers.Size = new System.Drawing.Size(229, 244);
            this.brokers.TabIndex = 1;
            this.brokers.Text = "Brokers";
            this.brokers.UseVisualStyleBackColor = true;
            this.brokers.Click += new System.EventHandler(this.brokers_Click);
            // 
            // transactions
            // 
            this.transactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transactions.FlatAppearance.BorderSize = 2;
            this.transactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.transactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactions.ForeColor = System.Drawing.Color.Azure;
            this.transactions.Location = new System.Drawing.Point(702, 253);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(229, 244);
            this.transactions.TabIndex = 2;
            this.transactions.Text = "Transactions";
            this.transactions.UseVisualStyleBackColor = true;
            this.transactions.Click += new System.EventHandler(this.transactions_Click);
            // 
            // customers
            // 
            this.customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customers.FlatAppearance.BorderSize = 2;
            this.customers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers.ForeColor = System.Drawing.Color.Azure;
            this.customers.Location = new System.Drawing.Point(3, 3);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(227, 244);
            this.customers.TabIndex = 0;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // shareholders
            // 
            this.shareholders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareholders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shareholders.FlatAppearance.BorderSize = 2;
            this.shareholders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.shareholders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shareholders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shareholders.Location = new System.Drawing.Point(236, 3);
            this.shareholders.Name = "shareholders";
            this.shareholders.Size = new System.Drawing.Size(227, 244);
            this.shareholders.TabIndex = 6;
            this.shareholders.Text = "ShareHolders";
            this.shareholders.UseVisualStyleBackColor = true;
            this.shareholders.Click += new System.EventHandler(this.shareholders_Click);
            // 
            // AdminHomeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 572);
            this.Name = "AdminHomeWin";
            this.Text = "Admin Menu";
            this.left.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.adminMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel adminMenu;
        private System.Windows.Forms.Button chart;
        private System.Windows.Forms.Button stocks;
        private System.Windows.Forms.Button companies;
        private System.Windows.Forms.Button transactions;
        private System.Windows.Forms.Button brokers;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button shareholders;
    }
}