
namespace SE_ManagementSystem
{
    partial class AdminCustWin
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
            this.customerData = new System.Windows.Forms.DataGridView();
            this.sNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDL = new System.Windows.Forms.Label();
            this.customerIDTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.customerNameL = new System.Windows.Forms.Label();
            this.customerAddTxt = new System.Windows.Forms.TextBox();
            this.customerAddressL = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.cusPassL = new System.Windows.Forms.Label();
            this.customerMobTxt = new System.Windows.Forms.TextBox();
            this.customerMobL = new System.Windows.Forms.Label();
            this.custIDErr = new System.Windows.Forms.Label();
            this.nameErr = new System.Windows.Forms.Label();
            this.passErr = new System.Windows.Forms.Label();
            this.AddErr = new System.Windows.Forms.Label();
            this.numErr = new System.Windows.Forms.Label();
            this.middleLeft.SuspendLayout();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.detailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).BeginInit();
            this.SuspendLayout();
            // 
            // middleLeft
            // 
            this.middleLeft.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            // 
            // middleRight
            // 
            this.middleRight.Size = new System.Drawing.Size(973, 70);
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(151, 30);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // left
            // 
            this.left.Controls.Add(this.customerMobTxt);
            this.left.Controls.Add(this.customerMobL);
            this.left.Controls.Add(this.customerAddTxt);
            this.left.Controls.Add(this.customerAddressL);
            this.left.Controls.Add(this.passwordTxt);
            this.left.Controls.Add(this.cusPassL);
            this.left.Controls.Add(this.customerNameTxt);
            this.left.Controls.Add(this.customerNameL);
            this.left.Controls.Add(this.customerIDTxt);
            this.left.Controls.Add(this.customerIDL);
            this.left.Controls.Add(this.custIDErr);
            this.left.Controls.Add(this.nameErr);
            this.left.Controls.Add(this.passErr);
            this.left.Controls.Add(this.AddErr);
            this.left.Controls.Add(this.numErr);
            this.left.Size = new System.Drawing.Size(350, 757);
            this.left.Controls.SetChildIndex(this.numErr, 0);
            this.left.Controls.SetChildIndex(this.AddErr, 0);
            this.left.Controls.SetChildIndex(this.passErr, 0);
            this.left.Controls.SetChildIndex(this.nameErr, 0);
            this.left.Controls.SetChildIndex(this.custIDErr, 0);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.middleLeft, 0);
            this.left.Controls.SetChildIndex(this.customerIDL, 0);
            this.left.Controls.SetChildIndex(this.customerIDTxt, 0);
            this.left.Controls.SetChildIndex(this.customerNameL, 0);
            this.left.Controls.SetChildIndex(this.customerNameTxt, 0);
            this.left.Controls.SetChildIndex(this.cusPassL, 0);
            this.left.Controls.SetChildIndex(this.passwordTxt, 0);
            this.left.Controls.SetChildIndex(this.customerAddressL, 0);
            this.left.Controls.SetChildIndex(this.customerAddTxt, 0);
            this.left.Controls.SetChildIndex(this.customerMobL, 0);
            this.left.Controls.SetChildIndex(this.customerMobTxt, 0);
            // 
            // right
            // 
            this.right.Controls.Add(this.detailsGroup);
            this.right.Size = new System.Drawing.Size(973, 757);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.middleRight, 0);
            this.right.Controls.SetChildIndex(this.detailsGroup, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(973, 72);
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.customerData);
            this.detailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroup.ForeColor = System.Drawing.Color.Cyan;
            this.detailsGroup.Location = new System.Drawing.Point(0, 142);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(973, 615);
            this.detailsGroup.TabIndex = 2;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "Details";
            // 
            // customerData
            // 
            this.customerData.AllowUserToAddRows = false;
            this.customerData.AllowUserToDeleteRows = false;
            this.customerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNo,
            this.customerID,
            this.customerName,
            this.cusPass,
            this.customerAddress,
            this.customerNum});
            this.customerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerData.Location = new System.Drawing.Point(3, 26);
            this.customerData.Name = "customerData";
            this.customerData.ReadOnly = true;
            this.customerData.RowHeadersWidth = 51;
            this.customerData.Size = new System.Drawing.Size(967, 586);
            this.customerData.TabIndex = 0;
            this.customerData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerData_CellClick);
            // 
            // sNo
            // 
            this.sNo.HeaderText = "";
            this.sNo.MinimumWidth = 6;
            this.sNo.Name = "sNo";
            this.sNo.ReadOnly = true;
            this.sNo.Visible = false;
            // 
            // customerID
            // 
            this.customerID.HeaderText = "ID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // cusPass
            // 
            this.cusPass.HeaderText = "Password";
            this.cusPass.MinimumWidth = 6;
            this.cusPass.Name = "cusPass";
            this.cusPass.ReadOnly = true;
            // 
            // customerAddress
            // 
            this.customerAddress.HeaderText = "Address";
            this.customerAddress.MinimumWidth = 6;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.ReadOnly = true;
            // 
            // customerNum
            // 
            this.customerNum.HeaderText = "Mobile Number";
            this.customerNum.MinimumWidth = 6;
            this.customerNum.Name = "customerNum";
            this.customerNum.ReadOnly = true;
            // 
            // customerIDL
            // 
            this.customerIDL.AutoSize = true;
            this.customerIDL.Location = new System.Drawing.Point(8, 411);
            this.customerIDL.Name = "customerIDL";
            this.customerIDL.Size = new System.Drawing.Size(106, 23);
            this.customerIDL.TabIndex = 2;
            this.customerIDL.Text = "Customer ID";
            // 
            // customerIDTxt
            // 
            this.customerIDTxt.Enabled = false;
            this.customerIDTxt.Location = new System.Drawing.Point(12, 438);
            this.customerIDTxt.Name = "customerIDTxt";
            this.customerIDTxt.Size = new System.Drawing.Size(313, 30);
            this.customerIDTxt.TabIndex = 3;
            this.customerIDTxt.TextChanged += new System.EventHandler(this.customerIDTxt_TextChanged);
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Enabled = false;
            this.customerNameTxt.Location = new System.Drawing.Point(12, 502);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(313, 30);
            this.customerNameTxt.TabIndex = 5;
            this.customerNameTxt.TextChanged += new System.EventHandler(this.customerNameTxt_TextChanged);
            // 
            // customerNameL
            // 
            this.customerNameL.AutoSize = true;
            this.customerNameL.Location = new System.Drawing.Point(8, 475);
            this.customerNameL.Name = "customerNameL";
            this.customerNameL.Size = new System.Drawing.Size(56, 23);
            this.customerNameL.TabIndex = 4;
            this.customerNameL.Text = "Name";
            // 
            // customerAddTxt
            // 
            this.customerAddTxt.Enabled = false;
            this.customerAddTxt.Location = new System.Drawing.Point(12, 635);
            this.customerAddTxt.Name = "customerAddTxt";
            this.customerAddTxt.Size = new System.Drawing.Size(313, 30);
            this.customerAddTxt.TabIndex = 9;
            this.customerAddTxt.TextChanged += new System.EventHandler(this.customerAddTxt_TextChanged);
            // 
            // customerAddressL
            // 
            this.customerAddressL.AutoSize = true;
            this.customerAddressL.Location = new System.Drawing.Point(8, 608);
            this.customerAddressL.Name = "customerAddressL";
            this.customerAddressL.Size = new System.Drawing.Size(70, 23);
            this.customerAddressL.TabIndex = 8;
            this.customerAddressL.Text = "Address";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Enabled = false;
            this.passwordTxt.Location = new System.Drawing.Point(12, 571);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(313, 30);
            this.passwordTxt.TabIndex = 7;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // cusPassL
            // 
            this.cusPassL.AutoSize = true;
            this.cusPassL.Location = new System.Drawing.Point(8, 544);
            this.cusPassL.Name = "cusPassL";
            this.cusPassL.Size = new System.Drawing.Size(80, 23);
            this.cusPassL.TabIndex = 6;
            this.cusPassL.Text = "Password";
            // 
            // customerMobTxt
            // 
            this.customerMobTxt.Enabled = false;
            this.customerMobTxt.Location = new System.Drawing.Point(12, 704);
            this.customerMobTxt.Name = "customerMobTxt";
            this.customerMobTxt.Size = new System.Drawing.Size(313, 30);
            this.customerMobTxt.TabIndex = 11;
            this.customerMobTxt.TextChanged += new System.EventHandler(this.customerMobTxt_TextChanged);
            // 
            // customerMobL
            // 
            this.customerMobL.AutoSize = true;
            this.customerMobL.Location = new System.Drawing.Point(8, 677);
            this.customerMobL.Name = "customerMobL";
            this.customerMobL.Size = new System.Drawing.Size(130, 23);
            this.customerMobL.TabIndex = 10;
            this.customerMobL.Text = "Mobile Number";
            // 
            // custIDErr
            // 
            this.custIDErr.AutoSize = true;
            this.custIDErr.ForeColor = System.Drawing.Color.Turquoise;
            this.custIDErr.Location = new System.Drawing.Point(308, 421);
            this.custIDErr.Name = "custIDErr";
            this.custIDErr.Size = new System.Drawing.Size(17, 23);
            this.custIDErr.TabIndex = 12;
            this.custIDErr.Text = "*";
            this.custIDErr.Visible = false;
            // 
            // nameErr
            // 
            this.nameErr.AutoSize = true;
            this.nameErr.ForeColor = System.Drawing.Color.Turquoise;
            this.nameErr.Location = new System.Drawing.Point(308, 486);
            this.nameErr.Name = "nameErr";
            this.nameErr.Size = new System.Drawing.Size(17, 23);
            this.nameErr.TabIndex = 13;
            this.nameErr.Text = "*";
            this.nameErr.Visible = false;
            // 
            // passErr
            // 
            this.passErr.AutoSize = true;
            this.passErr.ForeColor = System.Drawing.Color.Turquoise;
            this.passErr.Location = new System.Drawing.Point(308, 555);
            this.passErr.Name = "passErr";
            this.passErr.Size = new System.Drawing.Size(17, 23);
            this.passErr.TabIndex = 14;
            this.passErr.Text = "*";
            this.passErr.Visible = false;
            // 
            // AddErr
            // 
            this.AddErr.AutoSize = true;
            this.AddErr.ForeColor = System.Drawing.Color.Turquoise;
            this.AddErr.Location = new System.Drawing.Point(308, 619);
            this.AddErr.Name = "AddErr";
            this.AddErr.Size = new System.Drawing.Size(17, 23);
            this.AddErr.TabIndex = 15;
            this.AddErr.Text = "*";
            this.AddErr.Visible = false;
            // 
            // numErr
            // 
            this.numErr.AutoSize = true;
            this.numErr.ForeColor = System.Drawing.Color.Turquoise;
            this.numErr.Location = new System.Drawing.Point(308, 689);
            this.numErr.Name = "numErr";
            this.numErr.Size = new System.Drawing.Size(17, 23);
            this.numErr.TabIndex = 16;
            this.numErr.Text = "*";
            this.numErr.Visible = false;
            // 
            // AdminCustWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 757);
            this.Name = "AdminCustWin";
            this.Text = "AdminCustWin";
            this.middleLeft.ResumeLayout(false);
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.detailsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox customerIDTxt;
        private System.Windows.Forms.Label customerIDL;
        private System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.DataGridView customerData;
        private System.Windows.Forms.TextBox customerMobTxt;
        private System.Windows.Forms.Label customerMobL;
        private System.Windows.Forms.TextBox customerAddTxt;
        private System.Windows.Forms.Label customerAddressL;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label cusPassL;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label customerNameL;
        private System.Windows.Forms.Label custIDErr;
        private System.Windows.Forms.Label nameErr;
        private System.Windows.Forms.Label passErr;
        private System.Windows.Forms.Label AddErr;
        private System.Windows.Forms.Label numErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNum;
    }
}