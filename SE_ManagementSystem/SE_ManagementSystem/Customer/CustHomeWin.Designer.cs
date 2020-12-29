
namespace SE_ManagementSystem.Customer
{
    partial class CustHomeWin
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
            this.pfpL = new System.Windows.Forms.Label();
            this.stocksL = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.stocksBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.orderL = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            this.left.Size = new System.Drawing.Size(350, 642);
            // 
            // right
            // 
            this.right.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            this.right.Controls.Add(this.orderL);
            this.right.Controls.Add(this.order);
            this.right.Controls.Add(this.stocksL);
            this.right.Controls.Add(this.pfpL);
            this.right.Controls.Add(this.stocksBtn);
            this.right.Controls.Add(this.profileBtn);
            this.right.Size = new System.Drawing.Size(924, 642);
            this.right.Controls.SetChildIndex(this.profileBtn, 0);
            this.right.Controls.SetChildIndex(this.stocksBtn, 0);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.pfpL, 0);
            this.right.Controls.SetChildIndex(this.stocksL, 0);
            this.right.Controls.SetChildIndex(this.order, 0);
            this.right.Controls.SetChildIndex(this.orderL, 0);
            // 
            // topRight
            // 
            this.topRight.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            this.topRight.Size = new System.Drawing.Size(924, 72);
            // 
            // welcomeText
            // 
            this.welcomeText.Image = global::SE_ManagementSystem.Properties.Resources.unnamed;
            // 
            // pfpL
            // 
            this.pfpL.AutoSize = true;
            this.pfpL.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfpL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pfpL.Location = new System.Drawing.Point(405, 510);
            this.pfpL.Name = "pfpL";
            this.pfpL.Size = new System.Drawing.Size(109, 39);
            this.pfpL.TabIndex = 3;
            this.pfpL.Text = "Profile";
            // 
            // stocksL
            // 
            this.stocksL.AutoSize = true;
            this.stocksL.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stocksL.Location = new System.Drawing.Point(108, 510);
            this.stocksL.Name = "stocksL";
            this.stocksL.Size = new System.Drawing.Size(109, 39);
            this.stocksL.TabIndex = 4;
            this.stocksL.Text = "Stocks";
            // 
            // order
            // 
            this.order.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.kisspng_computer_icons_scalable_vector_graphics_portable_n_5c18b6ce2017d12;
            this.order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Location = new System.Drawing.Point(624, 228);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(288, 258);
            this.order.TabIndex = 5;
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // stocksBtn
            // 
            this.stocksBtn.BackgroundImage = global::SE_ManagementSystem.Properties.Resources._21_5121;
            this.stocksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stocksBtn.FlatAppearance.BorderSize = 0;
            this.stocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocksBtn.Location = new System.Drawing.Point(20, 236);
            this.stocksBtn.Name = "stocksBtn";
            this.stocksBtn.Size = new System.Drawing.Size(288, 250);
            this.stocksBtn.TabIndex = 2;
            this.stocksBtn.UseVisualStyleBackColor = true;
            this.stocksBtn.Click += new System.EventHandler(this.stocksBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.general_pack_NEW_glyph_profile_512;
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Location = new System.Drawing.Point(332, 236);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(250, 250);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // orderL
            // 
            this.orderL.AutoSize = true;
            this.orderL.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderL.Location = new System.Drawing.Point(680, 510);
            this.orderL.Name = "orderL";
            this.orderL.Size = new System.Drawing.Size(98, 39);
            this.orderL.TabIndex = 6;
            this.orderL.Text = "Order";
            // 
            // CustHomeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 642);
            this.Name = "CustHomeWin";
            this.Text = "CustHomeWin";
            this.left.ResumeLayout(false);
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button stocksBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label stocksL;
        private System.Windows.Forms.Label pfpL;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label orderL;
    }
}