
namespace SE_ManagementSystem
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
            this.order = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            this.left.Size = new System.Drawing.Size(350, 1033);
            // 
            // right
            // 
            this.right.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            this.right.Controls.Add(this.tableLayoutPanel1);
            this.right.Size = new System.Drawing.Size(1552, 1033);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // topRight
            // 
            this.topRight.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            this.topRight.Size = new System.Drawing.Size(1552, 72);
            // 
            // welcomeText
            // 
            this.welcomeText.Image = global::SE_ManagementSystem.Properties.Resources.unnamed;
            // 
            // order
            // 
            this.order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(3, 3);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(770, 955);
            this.order.TabIndex = 5;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.Location = new System.Drawing.Point(779, 3);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(770, 955);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.order, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.profileBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1552, 961);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // CustHomeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Name = "CustHomeWin";
            this.Text = "CustHomeWin";
            this.left.ResumeLayout(false);
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}