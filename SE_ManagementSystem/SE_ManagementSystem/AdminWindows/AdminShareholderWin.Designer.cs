
namespace SE_ManagementSystem
{
    partial class AdminShareholderWin
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
            this.middleRight = new System.Windows.Forms.Panel();
            this.menuOptions = new System.Windows.Forms.TableLayoutPanel();
            this.viewBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.middleLeft = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.detailsGroup = new System.Windows.Forms.GroupBox();
            this.shareholderDataSet = new System.Windows.Forms.DataGridView();
            this.currBalanceTxt = new System.Windows.Forms.TextBox();
            this.shareNameL = new System.Windows.Forms.Label();
            this.shareholderIDL = new System.Windows.Forms.Label();
            this.shareIDCombo = new System.Windows.Forms.ComboBox();
            this.currBalanceL = new System.Windows.Forms.Label();
            this.shareNameCombo = new System.Windows.Forms.ComboBox();
            this.numberOfSharesL = new System.Windows.Forms.Label();
            this.numberOfSharesTxt = new System.Windows.Forms.TextBox();
            this.sNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareholderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brokerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.middleRight.SuspendLayout();
            this.menuOptions.SuspendLayout();
            this.searchGroup.SuspendLayout();
            this.middleLeft.SuspendLayout();
            this.detailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shareholderDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Controls.Add(this.middleLeft);
            this.left.Controls.Add(this.numberOfSharesL);
            this.left.Controls.Add(this.numberOfSharesTxt);
            this.left.Controls.Add(this.shareNameCombo);
            this.left.Controls.Add(this.currBalanceL);
            this.left.Controls.Add(this.currBalanceTxt);
            this.left.Controls.Add(this.shareIDCombo);
            this.left.Controls.Add(this.shareholderIDL);
            this.left.Controls.Add(this.shareNameL);
            this.left.Size = new System.Drawing.Size(350, 650);
            this.left.Controls.SetChildIndex(this.shareNameL, 0);
            this.left.Controls.SetChildIndex(this.shareholderIDL, 0);
            this.left.Controls.SetChildIndex(this.shareIDCombo, 0);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.currBalanceTxt, 0);
            this.left.Controls.SetChildIndex(this.currBalanceL, 0);
            this.left.Controls.SetChildIndex(this.shareNameCombo, 0);
            this.left.Controls.SetChildIndex(this.numberOfSharesTxt, 0);
            this.left.Controls.SetChildIndex(this.numberOfSharesL, 0);
            this.left.Controls.SetChildIndex(this.middleLeft, 0);
            // 
            // right
            // 
            this.right.Controls.Add(this.detailsGroup);
            this.right.Controls.Add(this.middleRight);
            this.right.Size = new System.Drawing.Size(996, 650);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.middleRight, 0);
            this.right.Controls.SetChildIndex(this.detailsGroup, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(996, 72);
            // 
            // middleRight
            // 
            this.middleRight.Controls.Add(this.menuOptions);
            this.middleRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.middleRight.Location = new System.Drawing.Point(0, 72);
            this.middleRight.Name = "middleRight";
            this.middleRight.Size = new System.Drawing.Size(996, 70);
            this.middleRight.TabIndex = 2;
            // 
            // menuOptions
            // 
            this.menuOptions.ColumnCount = 5;
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.Controls.Add(this.viewBtn, 0, 0);
            this.menuOptions.Controls.Add(this.deleteBtn, 3, 0);
            this.menuOptions.Controls.Add(this.saveBtn, 2, 0);
            this.menuOptions.Controls.Add(this.editBtn, 1, 0);
            this.menuOptions.Controls.Add(this.searchGroup, 4, 0);
            this.menuOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.RowCount = 1;
            this.menuOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuOptions.Size = new System.Drawing.Size(996, 70);
            this.menuOptions.TabIndex = 0;
            // 
            // viewBtn
            // 
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewBtn.Location = new System.Drawing.Point(3, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(193, 64);
            this.viewBtn.TabIndex = 5;
            this.viewBtn.Text = "&View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteBtn.Location = new System.Drawing.Point(600, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(193, 64);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveBtn.Location = new System.Drawing.Point(401, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(193, 64);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBtn.Location = new System.Drawing.Point(202, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(193, 64);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // searchGroup
            // 
            this.searchGroup.BackColor = System.Drawing.Color.Transparent;
            this.searchGroup.Controls.Add(this.searchText);
            this.searchGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchGroup.Location = new System.Drawing.Point(799, 3);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(194, 64);
            this.searchGroup.TabIndex = 4;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            // 
            // searchText
            // 
            this.searchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.Location = new System.Drawing.Point(3, 26);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(188, 30);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // middleLeft
            // 
            this.middleLeft.Controls.Add(this.backBtn);
            this.middleLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.middleLeft.Location = new System.Drawing.Point(0, 72);
            this.middleLeft.Name = "middleLeft";
            this.middleLeft.Size = new System.Drawing.Size(350, 70);
            this.middleLeft.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::SE_ManagementSystem.Properties.Resources._064_Back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(71, 67);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.shareholderDataSet);
            this.detailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroup.ForeColor = System.Drawing.Color.Cyan;
            this.detailsGroup.Location = new System.Drawing.Point(0, 142);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(996, 508);
            this.detailsGroup.TabIndex = 3;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "Details";
            // 
            // shareholderDataSet
            // 
            this.shareholderDataSet.AllowUserToAddRows = false;
            this.shareholderDataSet.AllowUserToDeleteRows = false;
            this.shareholderDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shareholderDataSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.shareholderDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shareholderDataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNo,
            this.shareholderID,
            this.shareName,
            this.shareValue,
            this.currBalance,
            this.noOfShares,
            this.brokerID});
            this.shareholderDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareholderDataSet.Location = new System.Drawing.Point(3, 26);
            this.shareholderDataSet.Name = "shareholderDataSet";
            this.shareholderDataSet.ReadOnly = true;
            this.shareholderDataSet.RowHeadersWidth = 51;
            this.shareholderDataSet.Size = new System.Drawing.Size(990, 479);
            this.shareholderDataSet.TabIndex = 3;
            // 
            // currBalanceTxt
            // 
            this.currBalanceTxt.Enabled = false;
            this.currBalanceTxt.Location = new System.Drawing.Point(21, 539);
            this.currBalanceTxt.Name = "currBalanceTxt";
            this.currBalanceTxt.Size = new System.Drawing.Size(313, 30);
            this.currBalanceTxt.TabIndex = 31;
            // 
            // shareNameL
            // 
            this.shareNameL.AutoSize = true;
            this.shareNameL.Location = new System.Drawing.Point(17, 395);
            this.shareNameL.Name = "shareNameL";
            this.shareNameL.Size = new System.Drawing.Size(104, 23);
            this.shareNameL.TabIndex = 30;
            this.shareNameL.Text = "Share Name";
            // 
            // shareholderIDL
            // 
            this.shareholderIDL.AutoSize = true;
            this.shareholderIDL.Location = new System.Drawing.Point(17, 326);
            this.shareholderIDL.Name = "shareholderIDL";
            this.shareholderIDL.Size = new System.Drawing.Size(124, 23);
            this.shareholderIDL.TabIndex = 33;
            this.shareholderIDL.Text = "Shareholder ID";
            // 
            // shareIDCombo
            // 
            this.shareIDCombo.FormattingEnabled = true;
            this.shareIDCombo.Location = new System.Drawing.Point(21, 358);
            this.shareIDCombo.Name = "shareIDCombo";
            this.shareIDCombo.Size = new System.Drawing.Size(313, 31);
            this.shareIDCombo.TabIndex = 36;
            // 
            // currBalanceL
            // 
            this.currBalanceL.AutoSize = true;
            this.currBalanceL.Location = new System.Drawing.Point(17, 513);
            this.currBalanceL.Name = "currBalanceL";
            this.currBalanceL.Size = new System.Drawing.Size(132, 23);
            this.currBalanceL.TabIndex = 37;
            this.currBalanceL.Text = "Current Balance";
            // 
            // shareNameCombo
            // 
            this.shareNameCombo.FormattingEnabled = true;
            this.shareNameCombo.Location = new System.Drawing.Point(21, 422);
            this.shareNameCombo.Name = "shareNameCombo";
            this.shareNameCombo.Size = new System.Drawing.Size(313, 31);
            this.shareNameCombo.TabIndex = 38;
            // 
            // numberOfSharesL
            // 
            this.numberOfSharesL.AutoSize = true;
            this.numberOfSharesL.Location = new System.Drawing.Point(17, 577);
            this.numberOfSharesL.Name = "numberOfSharesL";
            this.numberOfSharesL.Size = new System.Drawing.Size(151, 23);
            this.numberOfSharesL.TabIndex = 40;
            this.numberOfSharesL.Text = "Number Of Shares";
            // 
            // numberOfSharesTxt
            // 
            this.numberOfSharesTxt.Enabled = false;
            this.numberOfSharesTxt.Location = new System.Drawing.Point(21, 603);
            this.numberOfSharesTxt.Name = "numberOfSharesTxt";
            this.numberOfSharesTxt.Size = new System.Drawing.Size(313, 30);
            this.numberOfSharesTxt.TabIndex = 39;
            // 
            // sNo
            // 
            this.sNo.HeaderText = "";
            this.sNo.MinimumWidth = 6;
            this.sNo.Name = "sNo";
            this.sNo.ReadOnly = true;
            this.sNo.Visible = false;
            // 
            // shareholderID
            // 
            this.shareholderID.HeaderText = "ID";
            this.shareholderID.MinimumWidth = 6;
            this.shareholderID.Name = "shareholderID";
            this.shareholderID.ReadOnly = true;
            // 
            // shareName
            // 
            this.shareName.HeaderText = "Share Name";
            this.shareName.MinimumWidth = 6;
            this.shareName.Name = "shareName";
            this.shareName.ReadOnly = true;
            // 
            // shareValue
            // 
            this.shareValue.HeaderText = "Value";
            this.shareValue.MinimumWidth = 6;
            this.shareValue.Name = "shareValue";
            this.shareValue.ReadOnly = true;
            // 
            // currBalance
            // 
            this.currBalance.HeaderText = "Balance";
            this.currBalance.MinimumWidth = 6;
            this.currBalance.Name = "currBalance";
            this.currBalance.ReadOnly = true;
            // 
            // noOfShares
            // 
            this.noOfShares.HeaderText = "Volume";
            this.noOfShares.MinimumWidth = 6;
            this.noOfShares.Name = "noOfShares";
            this.noOfShares.ReadOnly = true;
            // 
            // brokerID
            // 
            this.brokerID.HeaderText = "Broker";
            this.brokerID.MinimumWidth = 6;
            this.brokerID.Name = "brokerID";
            this.brokerID.ReadOnly = true;
            // 
            // AdminShareholderWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 650);
            this.Name = "AdminShareholderWin";
            this.Text = "AdminShareholderWin";
            this.Load += new System.EventHandler(this.AdminShareholderWin_Load);
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.middleRight.ResumeLayout(false);
            this.menuOptions.ResumeLayout(false);
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.middleLeft.ResumeLayout(false);
            this.detailsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shareholderDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel middleLeft;
        protected System.Windows.Forms.Panel middleRight;
        protected System.Windows.Forms.TableLayoutPanel menuOptions;
        protected System.Windows.Forms.GroupBox searchGroup;
        protected System.Windows.Forms.TextBox searchText;
        protected System.Windows.Forms.Button viewBtn;
        protected System.Windows.Forms.Button deleteBtn;
        protected System.Windows.Forms.Button saveBtn;
        protected System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.DataGridView shareholderDataSet;
        private System.Windows.Forms.TextBox currBalanceTxt;
        private System.Windows.Forms.Label shareNameL;
        private System.Windows.Forms.Label numberOfSharesL;
        private System.Windows.Forms.TextBox numberOfSharesTxt;
        private System.Windows.Forms.ComboBox shareNameCombo;
        private System.Windows.Forms.Label currBalanceL;
        private System.Windows.Forms.ComboBox shareIDCombo;
        private System.Windows.Forms.Label shareholderIDL;
        protected System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareholderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn currBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn brokerID;
    }
}