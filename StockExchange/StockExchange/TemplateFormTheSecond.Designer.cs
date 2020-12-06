
namespace StockExchange
{
    partial class TemplateFormTheSecond
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
            this.rightPanelBottomTop = new System.Windows.Forms.Panel();
            this.fileControl = new System.Windows.Forms.TableLayoutPanel();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.GroupBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.leftPanelBottom.SuspendLayout();
            this.leftPanelTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.rightPanelBottom.SuspendLayout();
            this.rightPanelBottomTop.SuspendLayout();
            this.fileControl.SuspendLayout();
            this.search.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(267, 728);
            // 
            // leftPanelBottom
            // 
            this.leftPanelBottom.Controls.Add(this.panel1);
            this.leftPanelBottom.Size = new System.Drawing.Size(267, 673);
            // 
            // leftPanelTop
            // 
            this.leftPanelTop.Controls.Add(this.backBtn);
            this.leftPanelTop.Controls.SetChildIndex(this.welcomeText, 0);
            this.leftPanelTop.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1276, 728);
            // 
            // rightPanelBottom
            // 
            this.rightPanelBottom.Controls.Add(this.rightPanelBottomTop);
            this.rightPanelBottom.Size = new System.Drawing.Size(1276, 673);
            // 
            // rightPanelTop
            // 
            this.rightPanelTop.Size = new System.Drawing.Size(1276, 55);
            // 
            // rightPanelBottomTop
            // 
            this.rightPanelBottomTop.Controls.Add(this.fileControl);
            this.rightPanelBottomTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightPanelBottomTop.Location = new System.Drawing.Point(0, 0);
            this.rightPanelBottomTop.Name = "rightPanelBottomTop";
            this.rightPanelBottomTop.Size = new System.Drawing.Size(1276, 49);
            this.rightPanelBottomTop.TabIndex = 0;
            // 
            // fileControl
            // 
            this.fileControl.ColumnCount = 6;
            this.fileControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.fileControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.fileControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.fileControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.fileControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.fileControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.fileControl.Controls.Add(this.add, 0, 0);
            this.fileControl.Controls.Add(this.edit, 1, 0);
            this.fileControl.Controls.Add(this.save, 2, 0);
            this.fileControl.Controls.Add(this.delete, 3, 0);
            this.fileControl.Controls.Add(this.view, 4, 0);
            this.fileControl.Controls.Add(this.search, 5, 0);
            this.fileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileControl.Location = new System.Drawing.Point(0, 0);
            this.fileControl.Name = "fileControl";
            this.fileControl.RowCount = 1;
            this.fileControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileControl.Size = new System.Drawing.Size(1276, 49);
            this.fileControl.TabIndex = 0;
            // 
            // add
            // 
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.FlatAppearance.BorderSize = 2;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(3, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(206, 43);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit.FlatAppearance.BorderSize = 2;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Location = new System.Drawing.Point(215, 3);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(206, 43);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // save
            // 
            this.save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save.FlatAppearance.BorderSize = 2;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(427, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(206, 43);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.FlatAppearance.BorderSize = 2;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(639, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(206, 43);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // view
            // 
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.FlatAppearance.BorderSize = 2;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Location = new System.Drawing.Point(851, 3);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(206, 43);
            this.view.TabIndex = 4;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // search
            // 
            this.search.Controls.Add(this.searchText);
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Location = new System.Drawing.Point(1063, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(210, 43);
            this.search.TabIndex = 5;
            this.search.TabStop = false;
            this.search.Text = "Search";
            // 
            // searchText
            // 
            this.searchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.Location = new System.Drawing.Point(3, 23);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(204, 27);
            this.searchText.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 53);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = global::StockExchange.Properties.Resources._064_Back4;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(66, 55);
            this.backBtn.TabIndex = 12;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // TemplateFormTheSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 728);
            this.ControlBox = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "TemplateFormTheSecond";
            this.leftPanel.ResumeLayout(false);
            this.leftPanelBottom.ResumeLayout(false);
            this.leftPanelTop.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanelBottom.ResumeLayout(false);
            this.rightPanelBottomTop.ResumeLayout(false);
            this.fileControl.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel rightPanelBottomTop;
        public System.Windows.Forms.TableLayoutPanel fileControl;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.Button edit;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button delete;
        public System.Windows.Forms.Button view;
        public System.Windows.Forms.GroupBox search;
        public System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
    }
}