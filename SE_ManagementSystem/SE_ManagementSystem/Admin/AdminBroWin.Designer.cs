
namespace SE_ManagementSystem
{
    partial class AdminBroWin
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
            this.brokerIDTxt = new System.Windows.Forms.TextBox();
            this.brokerIDL = new System.Windows.Forms.Label();
            this.broIDErr = new System.Windows.Forms.Label();
            this.brokerNameTxt = new System.Windows.Forms.TextBox();
            this.brokerNameL = new System.Windows.Forms.Label();
            this.broNameErr = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordL = new System.Windows.Forms.Label();
            this.commisionTxt = new System.Windows.Forms.TextBox();
            this.commisionL = new System.Windows.Forms.Label();
            this.passErr = new System.Windows.Forms.Label();
            this.commisionErr = new System.Windows.Forms.Label();
            this.seDropDown = new System.Windows.Forms.ComboBox();
            this.stockExchangeL = new System.Windows.Forms.Label();
            this.brokerDataSet = new System.Windows.Forms.DataGridView();
            this.sNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brokerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brokerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seErr = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brokerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // middleRight
            // 
            this.middleRight.Size = new System.Drawing.Size(807, 70);
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(125, 30);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // left
            // 
            this.left.Controls.Add(this.stockExchangeL);
            this.left.Controls.Add(this.seDropDown);
            this.left.Controls.Add(this.commisionTxt);
            this.left.Controls.Add(this.commisionL);
            this.left.Controls.Add(this.passwordTxt);
            this.left.Controls.Add(this.passwordL);
            this.left.Controls.Add(this.brokerNameTxt);
            this.left.Controls.Add(this.brokerNameL);
            this.left.Controls.Add(this.broNameErr);
            this.left.Controls.Add(this.brokerIDTxt);
            this.left.Controls.Add(this.brokerIDL);
            this.left.Controls.Add(this.passErr);
            this.left.Controls.Add(this.commisionErr);
            this.left.Controls.Add(this.seErr);
            this.left.Controls.Add(this.broIDErr);
            this.left.Size = new System.Drawing.Size(350, 720);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.broIDErr, 0);
            this.left.Controls.SetChildIndex(this.middleLeft, 0);
            this.left.Controls.SetChildIndex(this.seErr, 0);
            this.left.Controls.SetChildIndex(this.commisionErr, 0);
            this.left.Controls.SetChildIndex(this.passErr, 0);
            this.left.Controls.SetChildIndex(this.brokerIDL, 0);
            this.left.Controls.SetChildIndex(this.brokerIDTxt, 0);
            this.left.Controls.SetChildIndex(this.broNameErr, 0);
            this.left.Controls.SetChildIndex(this.brokerNameL, 0);
            this.left.Controls.SetChildIndex(this.brokerNameTxt, 0);
            this.left.Controls.SetChildIndex(this.passwordL, 0);
            this.left.Controls.SetChildIndex(this.passwordTxt, 0);
            this.left.Controls.SetChildIndex(this.commisionL, 0);
            this.left.Controls.SetChildIndex(this.commisionTxt, 0);
            this.left.Controls.SetChildIndex(this.seDropDown, 0);
            this.left.Controls.SetChildIndex(this.stockExchangeL, 0);
            // 
            // right
            // 
            this.right.Controls.Add(this.brokerDataSet);
            this.right.Size = new System.Drawing.Size(807, 720);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.middleRight, 0);
            this.right.Controls.SetChildIndex(this.brokerDataSet, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(807, 72);
            // 
            // brokerIDTxt
            // 
            this.brokerIDTxt.Enabled = false;
            this.brokerIDTxt.Location = new System.Drawing.Point(12, 355);
            this.brokerIDTxt.Name = "brokerIDTxt";
            this.brokerIDTxt.Size = new System.Drawing.Size(313, 30);
            this.brokerIDTxt.TabIndex = 14;
            this.brokerIDTxt.TextChanged += new System.EventHandler(this.brokerIDTxt_TextChanged);
            // 
            // brokerIDL
            // 
            this.brokerIDL.AutoSize = true;
            this.brokerIDL.Location = new System.Drawing.Point(8, 328);
            this.brokerIDL.Name = "brokerIDL";
            this.brokerIDL.Size = new System.Drawing.Size(81, 23);
            this.brokerIDL.TabIndex = 13;
            this.brokerIDL.Text = "Broker ID";
            // 
            // broIDErr
            // 
            this.broIDErr.AutoSize = true;
            this.broIDErr.ForeColor = System.Drawing.Color.Turquoise;
            this.broIDErr.Location = new System.Drawing.Point(308, 338);
            this.broIDErr.Name = "broIDErr";
            this.broIDErr.Size = new System.Drawing.Size(17, 23);
            this.broIDErr.TabIndex = 15;
            this.broIDErr.Text = "*";
            this.broIDErr.Visible = false;
            // 
            // brokerNameTxt
            // 
            this.brokerNameTxt.Enabled = false;
            this.brokerNameTxt.Location = new System.Drawing.Point(12, 429);
            this.brokerNameTxt.Name = "brokerNameTxt";
            this.brokerNameTxt.Size = new System.Drawing.Size(313, 30);
            this.brokerNameTxt.TabIndex = 17;
            this.brokerNameTxt.TextChanged += new System.EventHandler(this.brokerNameTxt_TextChanged);
            // 
            // brokerNameL
            // 
            this.brokerNameL.AutoSize = true;
            this.brokerNameL.Location = new System.Drawing.Point(8, 402);
            this.brokerNameL.Name = "brokerNameL";
            this.brokerNameL.Size = new System.Drawing.Size(110, 23);
            this.brokerNameL.TabIndex = 16;
            this.brokerNameL.Text = "Broker Name";
            // 
            // broNameErr
            // 
            this.broNameErr.AutoSize = true;
            this.broNameErr.ForeColor = System.Drawing.Color.Turquoise;
            this.broNameErr.Location = new System.Drawing.Point(308, 412);
            this.broNameErr.Name = "broNameErr";
            this.broNameErr.Size = new System.Drawing.Size(17, 23);
            this.broNameErr.TabIndex = 18;
            this.broNameErr.Text = "*";
            this.broNameErr.Visible = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Enabled = false;
            this.passwordTxt.Location = new System.Drawing.Point(12, 503);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(313, 30);
            this.passwordTxt.TabIndex = 20;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(8, 476);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(80, 23);
            this.passwordL.TabIndex = 19;
            this.passwordL.Text = "Password";
            // 
            // commisionTxt
            // 
            this.commisionTxt.Enabled = false;
            this.commisionTxt.Location = new System.Drawing.Point(12, 573);
            this.commisionTxt.Name = "commisionTxt";
            this.commisionTxt.Size = new System.Drawing.Size(313, 30);
            this.commisionTxt.TabIndex = 22;
            this.commisionTxt.TextChanged += new System.EventHandler(this.commisionTxt_TextChanged);
            // 
            // commisionL
            // 
            this.commisionL.AutoSize = true;
            this.commisionL.Location = new System.Drawing.Point(8, 546);
            this.commisionL.Name = "commisionL";
            this.commisionL.Size = new System.Drawing.Size(96, 23);
            this.commisionL.TabIndex = 21;
            this.commisionL.Text = "Commision";
            // 
            // passErr
            // 
            this.passErr.AutoSize = true;
            this.passErr.ForeColor = System.Drawing.Color.Turquoise;
            this.passErr.Location = new System.Drawing.Point(308, 486);
            this.passErr.Name = "passErr";
            this.passErr.Size = new System.Drawing.Size(17, 23);
            this.passErr.TabIndex = 23;
            this.passErr.Text = "*";
            this.passErr.Visible = false;
            // 
            // commisionErr
            // 
            this.commisionErr.AutoSize = true;
            this.commisionErr.ForeColor = System.Drawing.Color.Turquoise;
            this.commisionErr.Location = new System.Drawing.Point(308, 556);
            this.commisionErr.Name = "commisionErr";
            this.commisionErr.Size = new System.Drawing.Size(17, 23);
            this.commisionErr.TabIndex = 24;
            this.commisionErr.Text = "*";
            this.commisionErr.Visible = false;
            // 
            // seDropDown
            // 
            this.seDropDown.FormattingEnabled = true;
            this.seDropDown.Location = new System.Drawing.Point(12, 639);
            this.seDropDown.Name = "seDropDown";
            this.seDropDown.Size = new System.Drawing.Size(313, 31);
            this.seDropDown.TabIndex = 25;
            this.seDropDown.SelectedIndexChanged += new System.EventHandler(this.seDropDown_SelectedIndexChanged);
            // 
            // stockExchangeL
            // 
            this.stockExchangeL.AutoSize = true;
            this.stockExchangeL.Location = new System.Drawing.Point(8, 613);
            this.stockExchangeL.Name = "stockExchangeL";
            this.stockExchangeL.Size = new System.Drawing.Size(128, 23);
            this.stockExchangeL.TabIndex = 26;
            this.stockExchangeL.Text = "Stock Exchange";
            // 
            // brokerDataSet
            // 
            this.brokerDataSet.AllowUserToAddRows = false;
            this.brokerDataSet.AllowUserToDeleteRows = false;
            this.brokerDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brokerDataSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.brokerDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brokerDataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNo,
            this.brokerID,
            this.brokerName,
            this.password,
            this.commision,
            this.seName});
            this.brokerDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brokerDataSet.Location = new System.Drawing.Point(0, 142);
            this.brokerDataSet.Name = "brokerDataSet";
            this.brokerDataSet.ReadOnly = true;
            this.brokerDataSet.RowHeadersWidth = 51;
            this.brokerDataSet.RowTemplate.Height = 24;
            this.brokerDataSet.Size = new System.Drawing.Size(807, 578);
            this.brokerDataSet.TabIndex = 2;
            this.brokerDataSet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brokerDataSet_CellClick);
            // 
            // sNo
            // 
            this.sNo.HeaderText = "";
            this.sNo.MinimumWidth = 6;
            this.sNo.Name = "sNo";
            this.sNo.ReadOnly = true;
            this.sNo.Visible = false;
            // 
            // brokerID
            // 
            this.brokerID.HeaderText = "ID";
            this.brokerID.MinimumWidth = 6;
            this.brokerID.Name = "brokerID";
            this.brokerID.ReadOnly = true;
            // 
            // brokerName
            // 
            this.brokerName.HeaderText = "Name";
            this.brokerName.MinimumWidth = 6;
            this.brokerName.Name = "brokerName";
            this.brokerName.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // commision
            // 
            this.commision.HeaderText = "Commision";
            this.commision.MinimumWidth = 6;
            this.commision.Name = "commision";
            this.commision.ReadOnly = true;
            // 
            // seName
            // 
            this.seName.HeaderText = "Stock Exchange";
            this.seName.MinimumWidth = 6;
            this.seName.Name = "seName";
            this.seName.ReadOnly = true;
            // 
            // seErr
            // 
            this.seErr.AutoSize = true;
            this.seErr.ForeColor = System.Drawing.Color.Turquoise;
            this.seErr.Location = new System.Drawing.Point(308, 622);
            this.seErr.Name = "seErr";
            this.seErr.Size = new System.Drawing.Size(17, 23);
            this.seErr.TabIndex = 27;
            this.seErr.Text = "*";
            this.seErr.Visible = false;
            // 
            // AdminBroWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 720);
            this.Name = "AdminBroWin";
            this.Text = "AdminBroWin";
            this.Load += new System.EventHandler(this.AdminBroWin_Load);
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brokerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label stockExchangeL;
        private System.Windows.Forms.ComboBox seDropDown;
        private System.Windows.Forms.TextBox commisionTxt;
        private System.Windows.Forms.Label commisionL;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox brokerNameTxt;
        private System.Windows.Forms.Label brokerNameL;
        private System.Windows.Forms.Label broNameErr;
        private System.Windows.Forms.TextBox brokerIDTxt;
        private System.Windows.Forms.Label brokerIDL;
        private System.Windows.Forms.Label passErr;
        private System.Windows.Forms.Label commisionErr;
        private System.Windows.Forms.Label broIDErr;
        private System.Windows.Forms.DataGridView brokerDataSet;
        private System.Windows.Forms.Label seErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn brokerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn brokerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn commision;
        private System.Windows.Forms.DataGridViewTextBoxColumn seName;
    }
}