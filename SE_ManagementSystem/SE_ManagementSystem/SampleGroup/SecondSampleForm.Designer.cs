
namespace SE_ManagementSystem
{
    partial class SecondSampleForm
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
            this.middleLeft = new System.Windows.Forms.Panel();
            this.middleRight = new System.Windows.Forms.Panel();
            this.menuOptions = new System.Windows.Forms.TableLayoutPanel();
            this.viewBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.middleLeft.SuspendLayout();
            this.middleRight.SuspendLayout();
            this.menuOptions.SuspendLayout();
            this.searchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Controls.Add(this.middleLeft);
            this.left.Size = new System.Drawing.Size(350, 619);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.middleLeft, 0);
            // 
            // right
            // 
            this.right.Controls.Add(this.middleRight);
            this.right.Size = new System.Drawing.Size(830, 619);
            this.right.Controls.SetChildIndex(this.topRight, 0);
            this.right.Controls.SetChildIndex(this.middleRight, 0);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(830, 72);
            // 
            // middleLeft
            // 
            this.middleLeft.BackgroundImage = global::SE_ManagementSystem.Properties.Resources.unnamed;
            this.middleLeft.Controls.Add(this.backBtn);
            this.middleLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.middleLeft.Location = new System.Drawing.Point(0, 72);
            this.middleLeft.Name = "middleLeft";
            this.middleLeft.Size = new System.Drawing.Size(350, 70);
            this.middleLeft.TabIndex = 1;
            // 
            // middleRight
            // 
            this.middleRight.Controls.Add(this.menuOptions);
            this.middleRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.middleRight.Location = new System.Drawing.Point(0, 72);
            this.middleRight.Name = "middleRight";
            this.middleRight.Size = new System.Drawing.Size(830, 70);
            this.middleRight.TabIndex = 1;
            // 
            // menuOptions
            // 
            this.menuOptions.ColumnCount = 6;
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.menuOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66319F));
            this.menuOptions.Controls.Add(this.viewBtn, 0, 0);
            this.menuOptions.Controls.Add(this.deleteBtn, 3, 0);
            this.menuOptions.Controls.Add(this.saveBtn, 2, 0);
            this.menuOptions.Controls.Add(this.editBtn, 1, 0);
            this.menuOptions.Controls.Add(this.addBtn, 0, 0);
            this.menuOptions.Controls.Add(this.searchGroup, 5, 0);
            this.menuOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.RowCount = 1;
            this.menuOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuOptions.Size = new System.Drawing.Size(830, 70);
            this.menuOptions.TabIndex = 0;
            // 
            // viewBtn
            // 
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewBtn.Location = new System.Drawing.Point(141, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(132, 64);
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
            this.deleteBtn.Location = new System.Drawing.Point(555, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 64);
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
            this.saveBtn.Location = new System.Drawing.Point(417, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(132, 64);
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
            this.editBtn.Location = new System.Drawing.Point(279, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(132, 64);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 64);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchGroup
            // 
            this.searchGroup.BackColor = System.Drawing.Color.Transparent;
            this.searchGroup.Controls.Add(this.searchText);
            this.searchGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchGroup.Location = new System.Drawing.Point(693, 3);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(134, 64);
            this.searchGroup.TabIndex = 4;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            // 
            // searchText
            // 
            this.searchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.Location = new System.Drawing.Point(3, 26);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(128, 30);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::SE_ManagementSystem.Properties.Resources._064_Back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(71, 67);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SecondSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 619);
            this.Name = "SecondSampleForm";
            this.left.ResumeLayout(false);
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.middleLeft.ResumeLayout(false);
            this.middleRight.ResumeLayout(false);
            this.menuOptions.ResumeLayout(false);
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel middleLeft;
        protected System.Windows.Forms.Panel middleRight;
        protected System.Windows.Forms.TableLayoutPanel menuOptions;
        protected System.Windows.Forms.Button deleteBtn;
        protected System.Windows.Forms.Button saveBtn;
        protected System.Windows.Forms.Button editBtn;
        protected System.Windows.Forms.Button addBtn;
        protected System.Windows.Forms.GroupBox searchGroup;
        protected System.Windows.Forms.TextBox searchText;
        protected System.Windows.Forms.Button viewBtn;
        protected System.Windows.Forms.Button backBtn;
    }
}