
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
            this.detailsGroup = new System.Windows.Forms.GroupBox();
            this.shareholderDataSet = new System.Windows.Forms.DataGridView();
            this.sNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareholderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brokerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.detailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shareholderDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // middleRight
            // 
            this.middleRight.Size = new System.Drawing.Size(991, 70);
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(154, 30);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(350, 656);
            // 
            // right
            // 
            this.right.Controls.Add(this.detailsGroup);
            this.right.Size = new System.Drawing.Size(991, 656);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.middleRight, 0);
            this.right.Controls.SetChildIndex(this.detailsGroup, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(991, 72);
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.shareholderDataSet);
            this.detailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.detailsGroup.Location = new System.Drawing.Point(0, 142);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(991, 514);
            this.detailsGroup.TabIndex = 2;
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
            this.gain,
            this.noOfShares,
            this.brokerID});
            this.shareholderDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shareholderDataSet.Location = new System.Drawing.Point(3, 26);
            this.shareholderDataSet.Name = "shareholderDataSet";
            this.shareholderDataSet.ReadOnly = true;
            this.shareholderDataSet.RowHeadersWidth = 51;
            this.shareholderDataSet.Size = new System.Drawing.Size(985, 485);
            this.shareholderDataSet.TabIndex = 0;
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
            // gain
            // 
            this.gain.HeaderText = "Gains/Losses";
            this.gain.MinimumWidth = 6;
            this.gain.Name = "gain";
            this.gain.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(1341, 656);
            this.Name = "AdminShareholderWin";
            this.Text = "AdminShareholderWin";
            this.left.ResumeLayout(false);
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.detailsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shareholderDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.DataGridView shareholderDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareholderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn currBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn gain;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn brokerID;
    }
}