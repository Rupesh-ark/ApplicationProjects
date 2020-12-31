
namespace SE_ManagementSystem
{
    partial class CustOrderWindow
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
            this.buyBtn = new System.Windows.Forms.Button();
            this.shareToBuy = new System.Windows.Forms.ComboBox();
            this.brokerToBuyFrom = new System.Windows.Forms.ComboBox();
            this.dipGraphics = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.commisionAdded = new System.Windows.Forms.Label();
            this.commisionAddedL = new System.Windows.Forms.Label();
            this.quantityAvailable = new System.Windows.Forms.Label();
            this.quantityAvailableL = new System.Windows.Forms.Label();
            this.balanceTag = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.finishTransaction = new System.Windows.Forms.Button();
            this.generateBill = new System.Windows.Forms.Button();
            this.quantityToBuy = new System.Windows.Forms.TextBox();
            this.shareToBuyErr = new System.Windows.Forms.Label();
            this.brokerToBuyFromErr = new System.Windows.Forms.Label();
            this.quantityErr = new System.Windows.Forms.Label();
            this.stockPrice = new System.Windows.Forms.Label();
            this.stockPriceL = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.totalAmountL = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.dipGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Controls.Add(this.buyBtn);
            this.left.Size = new System.Drawing.Size(350, 1033);
            this.left.Controls.SetChildIndex(this.buyBtn, 0);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            // 
            // right
            // 
            this.right.Controls.Add(this.quantityToBuy);
            this.right.Controls.Add(this.generateBill);
            this.right.Controls.Add(this.finishTransaction);
            this.right.Controls.Add(this.dipGraphics);
            this.right.Controls.Add(this.brokerToBuyFrom);
            this.right.Controls.Add(this.shareToBuy);
            this.right.Controls.Add(this.shareToBuyErr);
            this.right.Controls.Add(this.brokerToBuyFromErr);
            this.right.Controls.Add(this.quantityErr);
            this.right.Size = new System.Drawing.Size(1552, 1033);
            this.right.Controls.SetChildIndex(this.quantityErr, 0);
            this.right.Controls.SetChildIndex(this.brokerToBuyFromErr, 0);
            this.right.Controls.SetChildIndex(this.shareToBuyErr, 0);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.shareToBuy, 0);
            this.right.Controls.SetChildIndex(this.brokerToBuyFrom, 0);
            this.right.Controls.SetChildIndex(this.dipGraphics, 0);
            this.right.Controls.SetChildIndex(this.finishTransaction, 0);
            this.right.Controls.SetChildIndex(this.generateBill, 0);
            this.right.Controls.SetChildIndex(this.quantityToBuy, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(1552, 72);
            // 
            // buyBtn
            // 
            this.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBtn.Location = new System.Drawing.Point(12, 334);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(111, 63);
            this.buyBtn.TabIndex = 1;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // shareToBuy
            // 
            this.shareToBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shareToBuy.FormattingEnabled = true;
            this.shareToBuy.Location = new System.Drawing.Point(20, 420);
            this.shareToBuy.Name = "shareToBuy";
            this.shareToBuy.Size = new System.Drawing.Size(185, 31);
            this.shareToBuy.TabIndex = 1;
            this.shareToBuy.SelectedIndexChanged += new System.EventHandler(this.shareToBuy_SelectedIndexChanged);
            // 
            // brokerToBuyFrom
            // 
            this.brokerToBuyFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brokerToBuyFrom.FormattingEnabled = true;
            this.brokerToBuyFrom.Location = new System.Drawing.Point(20, 489);
            this.brokerToBuyFrom.Name = "brokerToBuyFrom";
            this.brokerToBuyFrom.Size = new System.Drawing.Size(185, 31);
            this.brokerToBuyFrom.TabIndex = 2;
            this.brokerToBuyFrom.SelectedIndexChanged += new System.EventHandler(this.brokerToBuyFrom_SelectedIndexChanged);
            // 
            // dipGraphics
            // 
            this.dipGraphics.Controls.Add(this.totalAmount);
            this.dipGraphics.Controls.Add(this.totalAmountL);
            this.dipGraphics.Controls.Add(this.stockPrice);
            this.dipGraphics.Controls.Add(this.stockPriceL);
            this.dipGraphics.Controls.Add(this.pictureBox1);
            this.dipGraphics.Controls.Add(this.commisionAdded);
            this.dipGraphics.Controls.Add(this.commisionAddedL);
            this.dipGraphics.Controls.Add(this.quantityAvailable);
            this.dipGraphics.Controls.Add(this.quantityAvailableL);
            this.dipGraphics.Controls.Add(this.balanceTag);
            this.dipGraphics.Controls.Add(this.balance);
            this.dipGraphics.Location = new System.Drawing.Point(273, 89);
            this.dipGraphics.Name = "dipGraphics";
            this.dipGraphics.Size = new System.Drawing.Size(1279, 517);
            this.dipGraphics.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SE_ManagementSystem.Properties.Resources.wp6795530;
            this.pictureBox1.Location = new System.Drawing.Point(544, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // commisionAdded
            // 
            this.commisionAdded.AutoSize = true;
            this.commisionAdded.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commisionAdded.Location = new System.Drawing.Point(251, 216);
            this.commisionAdded.Name = "commisionAdded";
            this.commisionAdded.Size = new System.Drawing.Size(33, 33);
            this.commisionAdded.TabIndex = 7;
            this.commisionAdded.Text = "-";
            // 
            // commisionAddedL
            // 
            this.commisionAddedL.AutoSize = true;
            this.commisionAddedL.Location = new System.Drawing.Point(3, 222);
            this.commisionAddedL.Name = "commisionAddedL";
            this.commisionAddedL.Size = new System.Drawing.Size(151, 23);
            this.commisionAddedL.TabIndex = 6;
            this.commisionAddedL.Text = "Commision Added";
            // 
            // quantityAvailable
            // 
            this.quantityAvailable.AutoSize = true;
            this.quantityAvailable.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityAvailable.Location = new System.Drawing.Point(251, 143);
            this.quantityAvailable.Name = "quantityAvailable";
            this.quantityAvailable.Size = new System.Drawing.Size(33, 33);
            this.quantityAvailable.TabIndex = 5;
            this.quantityAvailable.Text = "-";
            // 
            // quantityAvailableL
            // 
            this.quantityAvailableL.AutoSize = true;
            this.quantityAvailableL.Location = new System.Drawing.Point(3, 149);
            this.quantityAvailableL.Name = "quantityAvailableL";
            this.quantityAvailableL.Size = new System.Drawing.Size(149, 23);
            this.quantityAvailableL.TabIndex = 2;
            this.quantityAvailableL.Text = "Quantity Available";
            // 
            // balanceTag
            // 
            this.balanceTag.AutoSize = true;
            this.balanceTag.Location = new System.Drawing.Point(3, 81);
            this.balanceTag.Name = "balanceTag";
            this.balanceTag.Size = new System.Drawing.Size(69, 23);
            this.balanceTag.TabIndex = 0;
            this.balanceTag.Text = "Balance";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(251, 75);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(33, 33);
            this.balance.TabIndex = 1;
            this.balance.Text = "-";
            // 
            // finishTransaction
            // 
            this.finishTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishTransaction.Location = new System.Drawing.Point(34, 135);
            this.finishTransaction.Name = "finishTransaction";
            this.finishTransaction.Size = new System.Drawing.Size(171, 92);
            this.finishTransaction.TabIndex = 5;
            this.finishTransaction.Text = "Finish Transaction";
            this.finishTransaction.UseVisualStyleBackColor = true;
            this.finishTransaction.Click += new System.EventHandler(this.finishTransaction_Click);
            // 
            // generateBill
            // 
            this.generateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBill.Location = new System.Drawing.Point(20, 631);
            this.generateBill.Name = "generateBill";
            this.generateBill.Size = new System.Drawing.Size(171, 44);
            this.generateBill.TabIndex = 6;
            this.generateBill.Text = "Generate Bill";
            this.generateBill.UseVisualStyleBackColor = true;
            this.generateBill.Visible = false;
            this.generateBill.Click += new System.EventHandler(this.generateBill_Click);
            // 
            // quantityToBuy
            // 
            this.quantityToBuy.Location = new System.Drawing.Point(20, 550);
            this.quantityToBuy.Name = "quantityToBuy";
            this.quantityToBuy.Size = new System.Drawing.Size(185, 30);
            this.quantityToBuy.TabIndex = 7;
            this.quantityToBuy.TextChanged += new System.EventHandler(this.quantityToBuy_TextChanged);
            // 
            // shareToBuyErr
            // 
            this.shareToBuyErr.AutoSize = true;
            this.shareToBuyErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.shareToBuyErr.Location = new System.Drawing.Point(188, 402);
            this.shareToBuyErr.Name = "shareToBuyErr";
            this.shareToBuyErr.Size = new System.Drawing.Size(17, 23);
            this.shareToBuyErr.TabIndex = 8;
            this.shareToBuyErr.Text = "*";
            this.shareToBuyErr.Visible = false;
            // 
            // brokerToBuyFromErr
            // 
            this.brokerToBuyFromErr.AutoSize = true;
            this.brokerToBuyFromErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.brokerToBuyFromErr.Location = new System.Drawing.Point(188, 472);
            this.brokerToBuyFromErr.Name = "brokerToBuyFromErr";
            this.brokerToBuyFromErr.Size = new System.Drawing.Size(17, 23);
            this.brokerToBuyFromErr.TabIndex = 9;
            this.brokerToBuyFromErr.Text = "*";
            this.brokerToBuyFromErr.Visible = false;
            // 
            // quantityErr
            // 
            this.quantityErr.AutoSize = true;
            this.quantityErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quantityErr.Location = new System.Drawing.Point(188, 535);
            this.quantityErr.Name = "quantityErr";
            this.quantityErr.Size = new System.Drawing.Size(17, 23);
            this.quantityErr.TabIndex = 10;
            this.quantityErr.Text = "*";
            this.quantityErr.Visible = false;
            // 
            // stockPrice
            // 
            this.stockPrice.AutoSize = true;
            this.stockPrice.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPrice.Location = new System.Drawing.Point(251, 279);
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Size = new System.Drawing.Size(33, 33);
            this.stockPrice.TabIndex = 10;
            this.stockPrice.Text = "-";
            // 
            // stockPriceL
            // 
            this.stockPriceL.AutoSize = true;
            this.stockPriceL.Location = new System.Drawing.Point(3, 285);
            this.stockPriceL.Name = "stockPriceL";
            this.stockPriceL.Size = new System.Drawing.Size(112, 23);
            this.stockPriceL.TabIndex = 9;
            this.stockPriceL.Text = "Price of Stock";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("NSimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(251, 347);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(33, 33);
            this.totalAmount.TabIndex = 12;
            this.totalAmount.Text = "-";
            // 
            // totalAmountL
            // 
            this.totalAmountL.AutoSize = true;
            this.totalAmountL.Location = new System.Drawing.Point(3, 353);
            this.totalAmountL.Name = "totalAmountL";
            this.totalAmountL.Size = new System.Drawing.Size(46, 23);
            this.totalAmountL.TabIndex = 11;
            this.totalAmountL.Text = "Total";
            // 
            // CustOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Name = "CustOrderWindow";
            this.Text = "CustOrderWindow";
            this.Load += new System.EventHandler(this.CustOrderWindow_Load);
            this.left.ResumeLayout(false);
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            this.dipGraphics.ResumeLayout(false);
            this.dipGraphics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button generateBill;
        private System.Windows.Forms.Button finishTransaction;
        private System.Windows.Forms.Panel dipGraphics;
        private System.Windows.Forms.Label quantityAvailableL;
        private System.Windows.Forms.Label balanceTag;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.ComboBox brokerToBuyFrom;
        private System.Windows.Forms.ComboBox shareToBuy;
        private System.Windows.Forms.Label quantityAvailable;
        private System.Windows.Forms.Label commisionAddedL;
        private System.Windows.Forms.Label commisionAdded;
        private System.Windows.Forms.TextBox quantityToBuy;
        private System.Windows.Forms.Label shareToBuyErr;
        private System.Windows.Forms.Label brokerToBuyFromErr;
        private System.Windows.Forms.Label quantityErr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label totalAmountL;
        private System.Windows.Forms.Label stockPrice;
        private System.Windows.Forms.Label stockPriceL;
    }
}