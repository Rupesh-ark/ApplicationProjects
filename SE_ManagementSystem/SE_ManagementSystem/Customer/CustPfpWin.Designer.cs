
namespace SE_ManagementSystem
{
    partial class CustPfpWin
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
            this.detailsP = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.customerMobileL = new System.Windows.Forms.Label();
            this.mobileNumber = new System.Windows.Forms.Label();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.mobErr = new System.Windows.Forms.Label();
            this.customerNameL = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.nameErr = new System.Windows.Forms.Label();
            this.balanceTag = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.balanceTxt = new System.Windows.Forms.TextBox();
            this.balErr = new System.Windows.Forms.Label();
            this.addBalanceBtn = new System.Windows.Forms.Button();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.detailsP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Size = new System.Drawing.Size(350, 1033);
            // 
            // right
            // 
            this.right.Controls.Add(this.addBalanceBtn);
            this.right.Controls.Add(this.editBtn);
            this.right.Controls.Add(this.detailsP);
            this.right.Controls.Add(this.balanceTag);
            this.right.Controls.Add(this.balanceTxt);
            this.right.Controls.Add(this.balance);
            this.right.Controls.Add(this.balErr);
            this.right.Size = new System.Drawing.Size(1552, 1033);
            this.right.Controls.SetChildIndex(this.balErr, 0);
            this.right.Controls.SetChildIndex(this.balance, 0);
            this.right.Controls.SetChildIndex(this.balanceTxt, 0);
            this.right.Controls.SetChildIndex(this.balanceTag, 0);
            this.right.Controls.SetChildIndex(this.detailsP, 0);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.editBtn, 0);
            this.right.Controls.SetChildIndex(this.addBalanceBtn, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(1552, 72);
            // 
            // detailsP
            // 
            this.detailsP.Controls.Add(this.pictureBox1);
            this.detailsP.Controls.Add(this.customerMobileL);
            this.detailsP.Controls.Add(this.mobileNumber);
            this.detailsP.Controls.Add(this.mobileTxt);
            this.detailsP.Controls.Add(this.mobErr);
            this.detailsP.Controls.Add(this.customerNameL);
            this.detailsP.Controls.Add(this.name);
            this.detailsP.Controls.Add(this.customerNameTxt);
            this.detailsP.Controls.Add(this.nameErr);
            this.detailsP.Location = new System.Drawing.Point(34, 100);
            this.detailsP.Name = "detailsP";
            this.detailsP.Size = new System.Drawing.Size(945, 383);
            this.detailsP.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(573, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 297);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(34, 523);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(185, 100);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // customerMobileL
            // 
            this.customerMobileL.AutoSize = true;
            this.customerMobileL.Location = new System.Drawing.Point(3, 190);
            this.customerMobileL.Name = "customerMobileL";
            this.customerMobileL.Size = new System.Drawing.Size(94, 23);
            this.customerMobileL.TabIndex = 19;
            this.customerMobileL.Text = "Mobile No.";
            // 
            // mobileNumber
            // 
            this.mobileNumber.AutoSize = true;
            this.mobileNumber.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumber.Location = new System.Drawing.Point(344, 235);
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(33, 33);
            this.mobileNumber.TabIndex = 20;
            this.mobileNumber.Text = "-";
            // 
            // mobileTxt
            // 
            this.mobileTxt.Location = new System.Drawing.Point(7, 235);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(185, 30);
            this.mobileTxt.TabIndex = 21;
            this.mobileTxt.TextChanged += new System.EventHandler(this.mobileTxt_TextChanged);
            // 
            // mobErr
            // 
            this.mobErr.AutoSize = true;
            this.mobErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mobErr.Location = new System.Drawing.Point(175, 220);
            this.mobErr.Name = "mobErr";
            this.mobErr.Size = new System.Drawing.Size(17, 23);
            this.mobErr.TabIndex = 22;
            this.mobErr.Text = "*";
            this.mobErr.Visible = false;
            // 
            // customerNameL
            // 
            this.customerNameL.AutoSize = true;
            this.customerNameL.Location = new System.Drawing.Point(3, 56);
            this.customerNameL.Name = "customerNameL";
            this.customerNameL.Size = new System.Drawing.Size(56, 23);
            this.customerNameL.TabIndex = 15;
            this.customerNameL.Text = "Name";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(344, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 33);
            this.name.TabIndex = 16;
            this.name.Text = "-";
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(7, 101);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(185, 30);
            this.customerNameTxt.TabIndex = 17;
            this.customerNameTxt.TextChanged += new System.EventHandler(this.customerNameTxt_TextChanged);
            // 
            // nameErr
            // 
            this.nameErr.AutoSize = true;
            this.nameErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nameErr.Location = new System.Drawing.Point(175, 84);
            this.nameErr.Name = "nameErr";
            this.nameErr.Size = new System.Drawing.Size(17, 23);
            this.nameErr.TabIndex = 18;
            this.nameErr.Text = "*";
            this.nameErr.Visible = false;
            // 
            // balanceTag
            // 
            this.balanceTag.AutoSize = true;
            this.balanceTag.Location = new System.Drawing.Point(756, 569);
            this.balanceTag.Name = "balanceTag";
            this.balanceTag.Size = new System.Drawing.Size(69, 23);
            this.balanceTag.TabIndex = 11;
            this.balanceTag.Text = "Balance";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(1004, 559);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(33, 33);
            this.balance.TabIndex = 12;
            this.balance.Text = "-";
            // 
            // balanceTxt
            // 
            this.balanceTxt.Location = new System.Drawing.Point(760, 614);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.Size = new System.Drawing.Size(185, 30);
            this.balanceTxt.TabIndex = 13;
            this.balanceTxt.TextChanged += new System.EventHandler(this.balanceTxt_TextChanged);
            // 
            // balErr
            // 
            this.balErr.AutoSize = true;
            this.balErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.balErr.Location = new System.Drawing.Point(928, 598);
            this.balErr.Name = "balErr";
            this.balErr.Size = new System.Drawing.Size(17, 23);
            this.balErr.TabIndex = 14;
            this.balErr.Text = "*";
            this.balErr.Visible = false;
            // 
            // addBalanceBtn
            // 
            this.addBalanceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBalanceBtn.FlatAppearance.BorderSize = 0;
            this.addBalanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBalanceBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBalanceBtn.Location = new System.Drawing.Point(760, 676);
            this.addBalanceBtn.Name = "addBalanceBtn";
            this.addBalanceBtn.Size = new System.Drawing.Size(190, 86);
            this.addBalanceBtn.TabIndex = 6;
            this.addBalanceBtn.Text = "+ Balance";
            this.addBalanceBtn.UseVisualStyleBackColor = true;
            this.addBalanceBtn.Click += new System.EventHandler(this.addBalanceBtn_Click);
            // 
            // CustPfpWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Name = "CustPfpWin";
            this.Text = "CustPfpWin";
            this.Load += new System.EventHandler(this.CustPfpWin_Load);
            this.left.ResumeLayout(false);
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            this.detailsP.ResumeLayout(false);
            this.detailsP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailsP;
        private System.Windows.Forms.Button addBalanceBtn;
        private System.Windows.Forms.Label balanceTag;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.TextBox balanceTxt;
        private System.Windows.Forms.Label balErr;
        private System.Windows.Forms.Label customerNameL;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label nameErr;
        private System.Windows.Forms.Label customerMobileL;
        private System.Windows.Forms.Label mobileNumber;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.Label mobErr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editBtn;
    }
}