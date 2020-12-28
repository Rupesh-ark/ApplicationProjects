
namespace SE_ManagementSystem
{
    partial class AdminStockWin
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
            this.stockDataSet = new System.Windows.Forms.DataGridView();
            this.sNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeInPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdingsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdingsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDL = new System.Windows.Forms.Label();
            this.IDDrop = new System.Windows.Forms.ComboBox();
            this.shareNameTxt = new System.Windows.Forms.TextBox();
            this.shareNameL = new System.Windows.Forms.Label();
            this.shareNameErr = new System.Windows.Forms.Label();
            this.IDErr = new System.Windows.Forms.Label();
            this.openingPriceTxt = new System.Windows.Forms.TextBox();
            this.openingPriceL = new System.Windows.Forms.Label();
            this.openingErr = new System.Windows.Forms.Label();
            this.volumeL = new System.Windows.Forms.Label();
            this.volumeTxt = new System.Windows.Forms.TextBox();
            this.volumeErr = new System.Windows.Forms.Label();
            this.holdingCostL = new System.Windows.Forms.Label();
            this.holdingsCostTxt = new System.Windows.Forms.TextBox();
            this.holdingCostErr = new System.Windows.Forms.Label();
            this.holdingQuantityL = new System.Windows.Forms.Label();
            this.holdingsQuantityTxt = new System.Windows.Forms.TextBox();
            this.quantityErr = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // middleRight
            // 
            this.middleRight.Size = new System.Drawing.Size(925, 70);
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(143, 30);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // left
            // 
            this.left.Controls.Add(this.holdingQuantityL);
            this.left.Controls.Add(this.holdingsQuantityTxt);
            this.left.Controls.Add(this.quantityErr);
            this.left.Controls.Add(this.holdingCostL);
            this.left.Controls.Add(this.holdingsCostTxt);
            this.left.Controls.Add(this.holdingCostErr);
            this.left.Controls.Add(this.volumeL);
            this.left.Controls.Add(this.volumeTxt);
            this.left.Controls.Add(this.volumeErr);
            this.left.Controls.Add(this.openingPriceL);
            this.left.Controls.Add(this.openingPriceTxt);
            this.left.Controls.Add(this.openingErr);
            this.left.Controls.Add(this.companyIDL);
            this.left.Controls.Add(this.IDDrop);
            this.left.Controls.Add(this.shareNameTxt);
            this.left.Controls.Add(this.shareNameL);
            this.left.Controls.Add(this.shareNameErr);
            this.left.Controls.Add(this.IDErr);
            this.left.Size = new System.Drawing.Size(350, 747);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.IDErr, 0);
            this.left.Controls.SetChildIndex(this.shareNameErr, 0);
            this.left.Controls.SetChildIndex(this.shareNameL, 0);
            this.left.Controls.SetChildIndex(this.shareNameTxt, 0);
            this.left.Controls.SetChildIndex(this.IDDrop, 0);
            this.left.Controls.SetChildIndex(this.companyIDL, 0);
            this.left.Controls.SetChildIndex(this.middleLeft, 0);
            this.left.Controls.SetChildIndex(this.openingErr, 0);
            this.left.Controls.SetChildIndex(this.openingPriceTxt, 0);
            this.left.Controls.SetChildIndex(this.openingPriceL, 0);
            this.left.Controls.SetChildIndex(this.volumeErr, 0);
            this.left.Controls.SetChildIndex(this.volumeTxt, 0);
            this.left.Controls.SetChildIndex(this.volumeL, 0);
            this.left.Controls.SetChildIndex(this.holdingCostErr, 0);
            this.left.Controls.SetChildIndex(this.holdingsCostTxt, 0);
            this.left.Controls.SetChildIndex(this.holdingCostL, 0);
            this.left.Controls.SetChildIndex(this.quantityErr, 0);
            this.left.Controls.SetChildIndex(this.holdingsQuantityTxt, 0);
            this.left.Controls.SetChildIndex(this.holdingQuantityL, 0);
            // 
            // right
            // 
            this.right.Controls.Add(this.stockDataSet);
            this.right.Size = new System.Drawing.Size(925, 747);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.middleRight, 0);
            this.right.Controls.SetChildIndex(this.stockDataSet, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(925, 72);
            // 
            // stockDataSet
            // 
            this.stockDataSet.AllowUserToAddRows = false;
            this.stockDataSet.AllowUserToDeleteRows = false;
            this.stockDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDataSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stockDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNO,
            this.shareName,
            this.companyID,
            this.openingPrice,
            this.changeInPrice,
            this.volume,
            this.holdingsCost,
            this.holdingsQuantity});
            this.stockDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockDataSet.Location = new System.Drawing.Point(0, 142);
            this.stockDataSet.Name = "stockDataSet";
            this.stockDataSet.ReadOnly = true;
            this.stockDataSet.RowHeadersWidth = 51;
            this.stockDataSet.RowTemplate.Height = 24;
            this.stockDataSet.Size = new System.Drawing.Size(925, 605);
            this.stockDataSet.TabIndex = 2;
            this.stockDataSet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataSet_CellClick);
            // 
            // sNO
            // 
            this.sNO.HeaderText = "";
            this.sNO.MinimumWidth = 6;
            this.sNO.Name = "sNO";
            this.sNO.ReadOnly = true;
            this.sNO.Visible = false;
            // 
            // shareName
            // 
            this.shareName.HeaderText = "Share Name";
            this.shareName.MinimumWidth = 6;
            this.shareName.Name = "shareName";
            this.shareName.ReadOnly = true;
            // 
            // companyID
            // 
            this.companyID.HeaderText = "Company ID";
            this.companyID.MinimumWidth = 6;
            this.companyID.Name = "companyID";
            this.companyID.ReadOnly = true;
            // 
            // openingPrice
            // 
            this.openingPrice.HeaderText = "Opening Price";
            this.openingPrice.MinimumWidth = 6;
            this.openingPrice.Name = "openingPrice";
            this.openingPrice.ReadOnly = true;
            // 
            // changeInPrice
            // 
            this.changeInPrice.HeaderText = "Change In Price";
            this.changeInPrice.MinimumWidth = 6;
            this.changeInPrice.Name = "changeInPrice";
            this.changeInPrice.ReadOnly = true;
            // 
            // volume
            // 
            this.volume.HeaderText = "Volume";
            this.volume.MinimumWidth = 6;
            this.volume.Name = "volume";
            this.volume.ReadOnly = true;
            // 
            // holdingsCost
            // 
            this.holdingsCost.HeaderText = "Holding Cost";
            this.holdingsCost.MinimumWidth = 6;
            this.holdingsCost.Name = "holdingsCost";
            this.holdingsCost.ReadOnly = true;
            // 
            // holdingsQuantity
            // 
            this.holdingsQuantity.HeaderText = "Holding Quantity";
            this.holdingsQuantity.MinimumWidth = 6;
            this.holdingsQuantity.Name = "holdingsQuantity";
            this.holdingsQuantity.ReadOnly = true;
            // 
            // companyIDL
            // 
            this.companyIDL.AutoSize = true;
            this.companyIDL.Location = new System.Drawing.Point(12, 281);
            this.companyIDL.Name = "companyIDL";
            this.companyIDL.Size = new System.Drawing.Size(105, 23);
            this.companyIDL.TabIndex = 31;
            this.companyIDL.Text = "Company ID";
            // 
            // IDDrop
            // 
            this.IDDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDDrop.FormattingEnabled = true;
            this.IDDrop.Location = new System.Drawing.Point(16, 307);
            this.IDDrop.Name = "IDDrop";
            this.IDDrop.Size = new System.Drawing.Size(313, 31);
            this.IDDrop.TabIndex = 30;
            this.IDDrop.SelectedIndexChanged += new System.EventHandler(this.IDDrop_SelectedIndexChanged);
            // 
            // shareNameTxt
            // 
            this.shareNameTxt.Enabled = false;
            this.shareNameTxt.Location = new System.Drawing.Point(16, 247);
            this.shareNameTxt.Name = "shareNameTxt";
            this.shareNameTxt.Size = new System.Drawing.Size(313, 30);
            this.shareNameTxt.TabIndex = 28;
            this.shareNameTxt.TextChanged += new System.EventHandler(this.shareNameTxt_TextChanged);
            // 
            // shareNameL
            // 
            this.shareNameL.AutoSize = true;
            this.shareNameL.Location = new System.Drawing.Point(12, 220);
            this.shareNameL.Name = "shareNameL";
            this.shareNameL.Size = new System.Drawing.Size(104, 23);
            this.shareNameL.TabIndex = 27;
            this.shareNameL.Text = "Share Name";
            // 
            // shareNameErr
            // 
            this.shareNameErr.AutoSize = true;
            this.shareNameErr.ForeColor = System.Drawing.Color.Turquoise;
            this.shareNameErr.Location = new System.Drawing.Point(312, 229);
            this.shareNameErr.Name = "shareNameErr";
            this.shareNameErr.Size = new System.Drawing.Size(17, 23);
            this.shareNameErr.TabIndex = 29;
            this.shareNameErr.Text = "*";
            this.shareNameErr.Visible = false;
            // 
            // IDErr
            // 
            this.IDErr.AutoSize = true;
            this.IDErr.ForeColor = System.Drawing.Color.Turquoise;
            this.IDErr.Location = new System.Drawing.Point(312, 288);
            this.IDErr.Name = "IDErr";
            this.IDErr.Size = new System.Drawing.Size(17, 23);
            this.IDErr.TabIndex = 32;
            this.IDErr.Text = "*";
            this.IDErr.Visible = false;
            // 
            // openingPriceTxt
            // 
            this.openingPriceTxt.Enabled = false;
            this.openingPriceTxt.Location = new System.Drawing.Point(16, 400);
            this.openingPriceTxt.Name = "openingPriceTxt";
            this.openingPriceTxt.Size = new System.Drawing.Size(313, 30);
            this.openingPriceTxt.TabIndex = 37;
            this.openingPriceTxt.TextChanged += new System.EventHandler(this.openingPriceTxt_TextChanged);
            // 
            // openingPriceL
            // 
            this.openingPriceL.AutoSize = true;
            this.openingPriceL.Location = new System.Drawing.Point(12, 374);
            this.openingPriceL.Name = "openingPriceL";
            this.openingPriceL.Size = new System.Drawing.Size(118, 23);
            this.openingPriceL.TabIndex = 36;
            this.openingPriceL.Text = "Opening Price";
            // 
            // openingErr
            // 
            this.openingErr.AutoSize = true;
            this.openingErr.ForeColor = System.Drawing.Color.Turquoise;
            this.openingErr.Location = new System.Drawing.Point(312, 383);
            this.openingErr.Name = "openingErr";
            this.openingErr.Size = new System.Drawing.Size(17, 23);
            this.openingErr.TabIndex = 38;
            this.openingErr.Text = "*";
            this.openingErr.Visible = false;
            // 
            // volumeL
            // 
            this.volumeL.AutoSize = true;
            this.volumeL.Location = new System.Drawing.Point(12, 436);
            this.volumeL.Name = "volumeL";
            this.volumeL.Size = new System.Drawing.Size(68, 23);
            this.volumeL.TabIndex = 39;
            this.volumeL.Text = "Volume";
            // 
            // volumeTxt
            // 
            this.volumeTxt.Enabled = false;
            this.volumeTxt.Location = new System.Drawing.Point(16, 463);
            this.volumeTxt.Name = "volumeTxt";
            this.volumeTxt.Size = new System.Drawing.Size(313, 30);
            this.volumeTxt.TabIndex = 40;
            this.volumeTxt.TextChanged += new System.EventHandler(this.volumeTxt_TextChanged);
            // 
            // volumeErr
            // 
            this.volumeErr.AutoSize = true;
            this.volumeErr.ForeColor = System.Drawing.Color.Turquoise;
            this.volumeErr.Location = new System.Drawing.Point(312, 446);
            this.volumeErr.Name = "volumeErr";
            this.volumeErr.Size = new System.Drawing.Size(17, 23);
            this.volumeErr.TabIndex = 41;
            this.volumeErr.Text = "*";
            this.volumeErr.Visible = false;
            // 
            // holdingCostL
            // 
            this.holdingCostL.AutoSize = true;
            this.holdingCostL.Location = new System.Drawing.Point(12, 497);
            this.holdingCostL.Name = "holdingCostL";
            this.holdingCostL.Size = new System.Drawing.Size(116, 23);
            this.holdingCostL.TabIndex = 42;
            this.holdingCostL.Text = "Holdings Cost";
            // 
            // holdingsCostTxt
            // 
            this.holdingsCostTxt.Enabled = false;
            this.holdingsCostTxt.Location = new System.Drawing.Point(16, 524);
            this.holdingsCostTxt.Name = "holdingsCostTxt";
            this.holdingsCostTxt.Size = new System.Drawing.Size(313, 30);
            this.holdingsCostTxt.TabIndex = 43;
            this.holdingsCostTxt.TextChanged += new System.EventHandler(this.holdingCostTxt_TextChanged);
            // 
            // holdingCostErr
            // 
            this.holdingCostErr.AutoSize = true;
            this.holdingCostErr.ForeColor = System.Drawing.Color.Turquoise;
            this.holdingCostErr.Location = new System.Drawing.Point(312, 507);
            this.holdingCostErr.Name = "holdingCostErr";
            this.holdingCostErr.Size = new System.Drawing.Size(17, 23);
            this.holdingCostErr.TabIndex = 44;
            this.holdingCostErr.Text = "*";
            this.holdingCostErr.Visible = false;
            // 
            // holdingQuantityL
            // 
            this.holdingQuantityL.AutoSize = true;
            this.holdingQuantityL.Location = new System.Drawing.Point(12, 559);
            this.holdingQuantityL.Name = "holdingQuantityL";
            this.holdingQuantityL.Size = new System.Drawing.Size(148, 23);
            this.holdingQuantityL.TabIndex = 45;
            this.holdingQuantityL.Text = "Holdings Quantity";
            // 
            // holdingQuantityTxt
            // 
            this.holdingsQuantityTxt.Enabled = false;
            this.holdingsQuantityTxt.Location = new System.Drawing.Point(16, 586);
            this.holdingsQuantityTxt.Name = "holdingQuantityTxt";
            this.holdingsQuantityTxt.Size = new System.Drawing.Size(313, 30);
            this.holdingsQuantityTxt.TabIndex = 46;
            this.holdingsQuantityTxt.TextChanged += new System.EventHandler(this.holdingQuantityTxt_TextChanged);
            // 
            // quantityErr
            // 
            this.quantityErr.AutoSize = true;
            this.quantityErr.ForeColor = System.Drawing.Color.Turquoise;
            this.quantityErr.Location = new System.Drawing.Point(312, 570);
            this.quantityErr.Name = "quantityErr";
            this.quantityErr.Size = new System.Drawing.Size(17, 23);
            this.quantityErr.TabIndex = 47;
            this.quantityErr.Text = "*";
            this.quantityErr.Visible = false;
            // 
            // AdminStockWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 747);
            this.Name = "AdminStockWin";
            this.Text = "AdminStockWin";
            this.Load += new System.EventHandler(this.AdminStockWin_Load);
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stockDataSet;
        private System.Windows.Forms.Label volumeL;
        private System.Windows.Forms.TextBox volumeTxt;
        private System.Windows.Forms.Label volumeErr;
        private System.Windows.Forms.Label openingPriceL;
        private System.Windows.Forms.TextBox openingPriceTxt;
        private System.Windows.Forms.Label openingErr;
        private System.Windows.Forms.Label companyIDL;
        private System.Windows.Forms.ComboBox IDDrop;
        private System.Windows.Forms.TextBox shareNameTxt;
        private System.Windows.Forms.Label shareNameL;
        private System.Windows.Forms.Label shareNameErr;
        private System.Windows.Forms.Label IDErr;
        private System.Windows.Forms.Label holdingQuantityL;
        private System.Windows.Forms.TextBox holdingsQuantityTxt;
        private System.Windows.Forms.Label quantityErr;
        private System.Windows.Forms.Label holdingCostL;
        private System.Windows.Forms.TextBox holdingsCostTxt;
        private System.Windows.Forms.Label holdingCostErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeInPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdingsCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdingsQuantity;
    }
}