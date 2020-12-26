
namespace SE_ManagementSystem
{
    partial class AdminCompWin
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
            this.companyDetails = new System.Windows.Forms.DataGridView();
            this.sNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketCapital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearEstablished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDTxt = new System.Windows.Forms.TextBox();
            this.companyIDL = new System.Windows.Forms.Label();
            this.compIDErr = new System.Windows.Forms.Label();
            this.companyNameTxt = new System.Windows.Forms.TextBox();
            this.companyNameL = new System.Windows.Forms.Label();
            this.companyNameErr = new System.Windows.Forms.Label();
            this.companyTypeTxt = new System.Windows.Forms.TextBox();
            this.companyTypeL = new System.Windows.Forms.Label();
            this.companyTypeErr = new System.Windows.Forms.Label();
            this.marketCapitalTxt = new System.Windows.Forms.TextBox();
            this.marketCapitalL = new System.Windows.Forms.Label();
            this.marketCapErr = new System.Windows.Forms.Label();
            this.yearEstablishedTxt = new System.Windows.Forms.TextBox();
            this.yearEstablishedL = new System.Windows.Forms.Label();
            this.establishedErr = new System.Windows.Forms.Label();
            this.stockExchangeNameL = new System.Windows.Forms.Label();
            this.stockExErr = new System.Windows.Forms.Label();
            this.rolesDropDown = new System.Windows.Forms.ComboBox();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.detailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // middleRight
            // 
            this.middleRight.Size = new System.Drawing.Size(978, 70);
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
            this.left.Controls.Add(this.rolesDropDown);
            this.left.Controls.Add(this.stockExchangeNameL);
            this.left.Controls.Add(this.yearEstablishedTxt);
            this.left.Controls.Add(this.yearEstablishedL);
            this.left.Controls.Add(this.marketCapitalTxt);
            this.left.Controls.Add(this.marketCapitalL);
            this.left.Controls.Add(this.companyTypeTxt);
            this.left.Controls.Add(this.companyTypeL);
            this.left.Controls.Add(this.companyNameTxt);
            this.left.Controls.Add(this.companyNameL);
            this.left.Controls.Add(this.companyNameErr);
            this.left.Controls.Add(this.companyIDTxt);
            this.left.Controls.Add(this.companyIDL);
            this.left.Controls.Add(this.compIDErr);
            this.left.Controls.Add(this.establishedErr);
            this.left.Controls.Add(this.marketCapErr);
            this.left.Controls.Add(this.companyTypeErr);
            this.left.Controls.Add(this.stockExErr);
            this.left.Size = new System.Drawing.Size(350, 763);
            this.left.Controls.SetChildIndex(this.stockExErr, 0);
            this.left.Controls.SetChildIndex(this.companyTypeErr, 0);
            this.left.Controls.SetChildIndex(this.marketCapErr, 0);
            this.left.Controls.SetChildIndex(this.establishedErr, 0);
            this.left.Controls.SetChildIndex(this.compIDErr, 0);
            this.left.Controls.SetChildIndex(this.companyIDL, 0);
            this.left.Controls.SetChildIndex(this.companyIDTxt, 0);
            this.left.Controls.SetChildIndex(this.companyNameErr, 0);
            this.left.Controls.SetChildIndex(this.companyNameL, 0);
            this.left.Controls.SetChildIndex(this.companyNameTxt, 0);
            this.left.Controls.SetChildIndex(this.companyTypeL, 0);
            this.left.Controls.SetChildIndex(this.companyTypeTxt, 0);
            this.left.Controls.SetChildIndex(this.marketCapitalL, 0);
            this.left.Controls.SetChildIndex(this.marketCapitalTxt, 0);
            this.left.Controls.SetChildIndex(this.yearEstablishedL, 0);
            this.left.Controls.SetChildIndex(this.yearEstablishedTxt, 0);
            this.left.Controls.SetChildIndex(this.stockExchangeNameL, 0);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.middleLeft, 0);
            this.left.Controls.SetChildIndex(this.rolesDropDown, 0);
            // 
            // right
            // 
            this.right.Controls.Add(this.detailsGroup);
            this.right.Size = new System.Drawing.Size(978, 763);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.middleRight, 0);
            this.right.Controls.SetChildIndex(this.detailsGroup, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(978, 72);
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.companyDetails);
            this.detailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.detailsGroup.Location = new System.Drawing.Point(0, 142);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(978, 621);
            this.detailsGroup.TabIndex = 2;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "Details";
            // 
            // companyDetails
            // 
            this.companyDetails.AllowUserToAddRows = false;
            this.companyDetails.AllowUserToDeleteRows = false;
            this.companyDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.companyDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.companyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNo,
            this.companyID,
            this.companyName,
            this.companyType,
            this.marketCapital,
            this.yearEstablished,
            this.seName});
            this.companyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyDetails.Location = new System.Drawing.Point(3, 26);
            this.companyDetails.Name = "companyDetails";
            this.companyDetails.ReadOnly = true;
            this.companyDetails.RowHeadersWidth = 51;
            this.companyDetails.RowTemplate.Height = 24;
            this.companyDetails.Size = new System.Drawing.Size(972, 592);
            this.companyDetails.TabIndex = 0;
            this.companyDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyDetails_CellClick);
            // 
            // sNo
            // 
            this.sNo.HeaderText = "";
            this.sNo.MinimumWidth = 6;
            this.sNo.Name = "sNo";
            this.sNo.ReadOnly = true;
            this.sNo.Visible = false;
            // 
            // companyID
            // 
            this.companyID.HeaderText = "ID";
            this.companyID.MinimumWidth = 6;
            this.companyID.Name = "companyID";
            this.companyID.ReadOnly = true;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Name";
            this.companyName.MinimumWidth = 6;
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // companyType
            // 
            this.companyType.HeaderText = "Type";
            this.companyType.MinimumWidth = 6;
            this.companyType.Name = "companyType";
            this.companyType.ReadOnly = true;
            // 
            // marketCapital
            // 
            this.marketCapital.HeaderText = "Capital";
            this.marketCapital.MinimumWidth = 6;
            this.marketCapital.Name = "marketCapital";
            this.marketCapital.ReadOnly = true;
            // 
            // yearEstablished
            // 
            this.yearEstablished.HeaderText = "Year Established";
            this.yearEstablished.MinimumWidth = 6;
            this.yearEstablished.Name = "yearEstablished";
            this.yearEstablished.ReadOnly = true;
            // 
            // seName
            // 
            this.seName.HeaderText = "Stock Exchange";
            this.seName.MinimumWidth = 6;
            this.seName.Name = "seName";
            this.seName.ReadOnly = true;
            // 
            // companyIDTxt
            // 
            this.companyIDTxt.Enabled = false;
            this.companyIDTxt.Location = new System.Drawing.Point(12, 371);
            this.companyIDTxt.Name = "companyIDTxt";
            this.companyIDTxt.Size = new System.Drawing.Size(313, 30);
            this.companyIDTxt.TabIndex = 14;
            this.companyIDTxt.TextChanged += new System.EventHandler(this.companyIDTxt_TextChanged);
            // 
            // companyIDL
            // 
            this.companyIDL.AutoSize = true;
            this.companyIDL.Location = new System.Drawing.Point(8, 344);
            this.companyIDL.Name = "companyIDL";
            this.companyIDL.Size = new System.Drawing.Size(105, 23);
            this.companyIDL.TabIndex = 13;
            this.companyIDL.Text = "Company ID";
            // 
            // compIDErr
            // 
            this.compIDErr.AutoSize = true;
            this.compIDErr.ForeColor = System.Drawing.Color.Turquoise;
            this.compIDErr.Location = new System.Drawing.Point(308, 354);
            this.compIDErr.Name = "compIDErr";
            this.compIDErr.Size = new System.Drawing.Size(17, 23);
            this.compIDErr.TabIndex = 15;
            this.compIDErr.Text = "*";
            this.compIDErr.Visible = false;
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.Enabled = false;
            this.companyNameTxt.Location = new System.Drawing.Point(12, 436);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(313, 30);
            this.companyNameTxt.TabIndex = 17;
            this.companyNameTxt.TextChanged += new System.EventHandler(this.companyNameTxt_TextChanged);
            // 
            // companyNameL
            // 
            this.companyNameL.AutoSize = true;
            this.companyNameL.Location = new System.Drawing.Point(8, 409);
            this.companyNameL.Name = "companyNameL";
            this.companyNameL.Size = new System.Drawing.Size(134, 23);
            this.companyNameL.TabIndex = 16;
            this.companyNameL.Text = "Company Name";
            // 
            // companyNameErr
            // 
            this.companyNameErr.AutoSize = true;
            this.companyNameErr.ForeColor = System.Drawing.Color.Turquoise;
            this.companyNameErr.Location = new System.Drawing.Point(308, 419);
            this.companyNameErr.Name = "companyNameErr";
            this.companyNameErr.Size = new System.Drawing.Size(17, 23);
            this.companyNameErr.TabIndex = 18;
            this.companyNameErr.Text = "*";
            this.companyNameErr.Visible = false;
            // 
            // companyTypeTxt
            // 
            this.companyTypeTxt.Enabled = false;
            this.companyTypeTxt.Location = new System.Drawing.Point(12, 504);
            this.companyTypeTxt.Name = "companyTypeTxt";
            this.companyTypeTxt.Size = new System.Drawing.Size(313, 30);
            this.companyTypeTxt.TabIndex = 20;
            this.companyTypeTxt.TextChanged += new System.EventHandler(this.companyTypeTxt_TextChanged);
            // 
            // companyTypeL
            // 
            this.companyTypeL.AutoSize = true;
            this.companyTypeL.Location = new System.Drawing.Point(8, 478);
            this.companyTypeL.Name = "companyTypeL";
            this.companyTypeL.Size = new System.Drawing.Size(123, 23);
            this.companyTypeL.TabIndex = 19;
            this.companyTypeL.Text = "Company Type";
            // 
            // companyTypeErr
            // 
            this.companyTypeErr.AutoSize = true;
            this.companyTypeErr.ForeColor = System.Drawing.Color.Turquoise;
            this.companyTypeErr.Location = new System.Drawing.Point(309, 488);
            this.companyTypeErr.Name = "companyTypeErr";
            this.companyTypeErr.Size = new System.Drawing.Size(17, 23);
            this.companyTypeErr.TabIndex = 21;
            this.companyTypeErr.Text = "*";
            this.companyTypeErr.Visible = false;
            // 
            // marketCapitalTxt
            // 
            this.marketCapitalTxt.Enabled = false;
            this.marketCapitalTxt.Location = new System.Drawing.Point(12, 571);
            this.marketCapitalTxt.Name = "marketCapitalTxt";
            this.marketCapitalTxt.Size = new System.Drawing.Size(313, 30);
            this.marketCapitalTxt.TabIndex = 23;
            this.marketCapitalTxt.TextChanged += new System.EventHandler(this.maketCapitalTxt_TextChanged);
            // 
            // marketCapitalL
            // 
            this.marketCapitalL.AutoSize = true;
            this.marketCapitalL.Location = new System.Drawing.Point(8, 545);
            this.marketCapitalL.Name = "marketCapitalL";
            this.marketCapitalL.Size = new System.Drawing.Size(121, 23);
            this.marketCapitalL.TabIndex = 22;
            this.marketCapitalL.Text = "Market Capital";
            // 
            // marketCapErr
            // 
            this.marketCapErr.AutoSize = true;
            this.marketCapErr.ForeColor = System.Drawing.Color.Turquoise;
            this.marketCapErr.Location = new System.Drawing.Point(308, 555);
            this.marketCapErr.Name = "marketCapErr";
            this.marketCapErr.Size = new System.Drawing.Size(17, 23);
            this.marketCapErr.TabIndex = 24;
            this.marketCapErr.Text = "*";
            this.marketCapErr.Visible = false;
            // 
            // yearEstablishedTxt
            // 
            this.yearEstablishedTxt.Enabled = false;
            this.yearEstablishedTxt.Location = new System.Drawing.Point(13, 636);
            this.yearEstablishedTxt.Name = "yearEstablishedTxt";
            this.yearEstablishedTxt.Size = new System.Drawing.Size(313, 30);
            this.yearEstablishedTxt.TabIndex = 26;
            this.yearEstablishedTxt.TextChanged += new System.EventHandler(this.yearEstablishedErr_TextChanged);
            // 
            // yearEstablishedL
            // 
            this.yearEstablishedL.AutoSize = true;
            this.yearEstablishedL.Location = new System.Drawing.Point(9, 610);
            this.yearEstablishedL.Name = "yearEstablishedL";
            this.yearEstablishedL.Size = new System.Drawing.Size(132, 23);
            this.yearEstablishedL.TabIndex = 25;
            this.yearEstablishedL.Text = "Year Established";
            // 
            // establishedErr
            // 
            this.establishedErr.AutoSize = true;
            this.establishedErr.ForeColor = System.Drawing.Color.Turquoise;
            this.establishedErr.Location = new System.Drawing.Point(308, 619);
            this.establishedErr.Name = "establishedErr";
            this.establishedErr.Size = new System.Drawing.Size(17, 23);
            this.establishedErr.TabIndex = 27;
            this.establishedErr.Text = "*";
            this.establishedErr.Visible = false;
            // 
            // stockExchangeNameL
            // 
            this.stockExchangeNameL.AutoSize = true;
            this.stockExchangeNameL.Location = new System.Drawing.Point(9, 673);
            this.stockExchangeNameL.Name = "stockExchangeNameL";
            this.stockExchangeNameL.Size = new System.Drawing.Size(128, 23);
            this.stockExchangeNameL.TabIndex = 28;
            this.stockExchangeNameL.Text = "Stock Exchange";
            // 
            // stockExErr
            // 
            this.stockExErr.AutoSize = true;
            this.stockExErr.ForeColor = System.Drawing.Color.Turquoise;
            this.stockExErr.Location = new System.Drawing.Point(308, 682);
            this.stockExErr.Name = "stockExErr";
            this.stockExErr.Size = new System.Drawing.Size(17, 23);
            this.stockExErr.TabIndex = 30;
            this.stockExErr.Text = "*";
            this.stockExErr.Visible = false;
            // 
            // rolesDropDown
            // 
            this.rolesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesDropDown.Enabled = false;
            this.rolesDropDown.FormattingEnabled = true;
            this.rolesDropDown.Location = new System.Drawing.Point(13, 699);
            this.rolesDropDown.Name = "rolesDropDown";
            this.rolesDropDown.Size = new System.Drawing.Size(313, 31);
            this.rolesDropDown.TabIndex = 31;
            this.rolesDropDown.SelectedIndexChanged += new System.EventHandler(this.rolesDropDown_SelectedIndexChanged);
            // 
            // AdminCompWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 763);
            this.Name = "AdminCompWin";
            this.Text = "AdminCompWin";
            this.Load += new System.EventHandler(this.AdminCompWin_Load);
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.detailsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.DataGridView companyDetails;
        private System.Windows.Forms.TextBox companyIDTxt;
        private System.Windows.Forms.Label companyIDL;
        private System.Windows.Forms.Label compIDErr;
        private System.Windows.Forms.ComboBox rolesDropDown;
        private System.Windows.Forms.Label stockExchangeNameL;
        private System.Windows.Forms.TextBox yearEstablishedTxt;
        private System.Windows.Forms.Label yearEstablishedL;
        private System.Windows.Forms.TextBox marketCapitalTxt;
        private System.Windows.Forms.Label marketCapitalL;
        private System.Windows.Forms.TextBox companyTypeTxt;
        private System.Windows.Forms.Label companyTypeL;
        private System.Windows.Forms.TextBox companyNameTxt;
        private System.Windows.Forms.Label companyNameL;
        private System.Windows.Forms.Label companyNameErr;
        private System.Windows.Forms.Label establishedErr;
        private System.Windows.Forms.Label marketCapErr;
        private System.Windows.Forms.Label companyTypeErr;
        private System.Windows.Forms.Label stockExErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketCapital;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearEstablished;
        private System.Windows.Forms.DataGridViewTextBoxColumn seName;
    }
}