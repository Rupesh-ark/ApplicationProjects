
namespace StockExchange
{
    partial class Settings
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
            this.saveButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.dataSource = new System.Windows.Forms.Label();
            this.databaseText = new System.Windows.Forms.TextBox();
            this.dataSourceText = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.Label();
            this.isCV = new System.Windows.Forms.CheckBox();
            this.dataSourceError = new System.Windows.Forms.Label();
            this.databaseError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.leftPanelBottom.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(267, 614);
            // 
            // leftPanelBottom
            // 
            this.leftPanelBottom.Controls.Add(this.dataSource);
            this.leftPanelBottom.Controls.Add(this.dataSourceText);
            this.leftPanelBottom.Controls.Add(this.database);
            this.leftPanelBottom.Controls.Add(this.databaseText);
            this.leftPanelBottom.Controls.Add(this.username);
            this.leftPanelBottom.Controls.Add(this.usernameText);
            this.leftPanelBottom.Controls.Add(this.password);
            this.leftPanelBottom.Controls.Add(this.passwordText);
            this.leftPanelBottom.Controls.Add(this.saveButton);
            this.leftPanelBottom.Controls.Add(this.isCV);
            this.leftPanelBottom.Controls.Add(this.dataSourceError);
            this.leftPanelBottom.Controls.Add(this.databaseError);
            this.leftPanelBottom.Controls.Add(this.usernameError);
            this.leftPanelBottom.Controls.Add(this.passwordError);
            this.leftPanelBottom.Size = new System.Drawing.Size(267, 559);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(890, 614);
            // 
            // rightPanelBottom
            // 
            this.rightPanelBottom.Size = new System.Drawing.Size(890, 559);
            // 
            // rightPanelTop
            // 
            this.rightPanelTop.Size = new System.Drawing.Size(890, 55);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(16, 480);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(203, 40);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(16, 402);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(205, 26);
            this.passwordText.TabIndex = 3;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(15, 381);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 18);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(18, 350);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(203, 26);
            this.usernameText.TabIndex = 2;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(14, 327);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(75, 18);
            this.username.TabIndex = 5;
            this.username.Text = "Username";
            // 
            // dataSource
            // 
            this.dataSource.AutoSize = true;
            this.dataSource.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSource.Location = new System.Drawing.Point(15, 225);
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(88, 18);
            this.dataSource.TabIndex = 10;
            this.dataSource.Text = "Data Source";
            // 
            // databaseText
            // 
            this.databaseText.Location = new System.Drawing.Point(18, 298);
            this.databaseText.Name = "databaseText";
            this.databaseText.Size = new System.Drawing.Size(203, 26);
            this.databaseText.TabIndex = 1;
            this.databaseText.TextChanged += new System.EventHandler(this.databaseText_TextChanged);
            // 
            // dataSourceText
            // 
            this.dataSourceText.Location = new System.Drawing.Point(16, 246);
            this.dataSourceText.Name = "dataSourceText";
            this.dataSourceText.Size = new System.Drawing.Size(205, 26);
            this.dataSourceText.TabIndex = 0;
            this.dataSourceText.TextChanged += new System.EventHandler(this.dataSourceText_TextChanged);
            // 
            // database
            // 
            this.database.AutoSize = true;
            this.database.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database.Location = new System.Drawing.Point(15, 275);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(70, 18);
            this.database.TabIndex = 12;
            this.database.Text = "Database";
            // 
            // isCV
            // 
            this.isCV.AutoSize = true;
            this.isCV.Location = new System.Drawing.Point(18, 443);
            this.isCV.Name = "isCV";
            this.isCV.Size = new System.Drawing.Size(155, 22);
            this.isCV.TabIndex = 4;
            this.isCV.Text = "Integrated Security";
            this.isCV.UseVisualStyleBackColor = true;
            this.isCV.CheckedChanged += new System.EventHandler(this.isCV_CheckedChanged);
            // 
            // dataSourceError
            // 
            this.dataSourceError.AutoSize = true;
            this.dataSourceError.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataSourceError.ForeColor = System.Drawing.Color.Crimson;
            this.dataSourceError.Location = new System.Drawing.Point(197, 225);
            this.dataSourceError.Name = "dataSourceError";
            this.dataSourceError.Size = new System.Drawing.Size(27, 30);
            this.dataSourceError.TabIndex = 15;
            this.dataSourceError.Text = "*";
            this.dataSourceError.Visible = false;
            // 
            // databaseError
            // 
            this.databaseError.AutoSize = true;
            this.databaseError.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseError.ForeColor = System.Drawing.Color.Crimson;
            this.databaseError.Location = new System.Drawing.Point(197, 275);
            this.databaseError.Name = "databaseError";
            this.databaseError.Size = new System.Drawing.Size(27, 30);
            this.databaseError.TabIndex = 16;
            this.databaseError.Text = "*";
            this.databaseError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.ForeColor = System.Drawing.Color.Crimson;
            this.passwordError.Location = new System.Drawing.Point(197, 381);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(27, 30);
            this.passwordError.TabIndex = 18;
            this.passwordError.Text = "*";
            this.passwordError.Visible = false;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameError.ForeColor = System.Drawing.Color.Crimson;
            this.usernameError.Location = new System.Drawing.Point(197, 327);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(27, 30);
            this.usernameError.TabIndex = 17;
            this.usernameError.Text = "*";
            this.usernameError.Visible = false;
            // 
            // Settings
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 614);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanelBottom.ResumeLayout(false);
            this.leftPanelBottom.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dataSource;
        private System.Windows.Forms.TextBox dataSourceText;
        private System.Windows.Forms.Label database;
        private System.Windows.Forms.TextBox databaseText;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox isCV;
        private System.Windows.Forms.Label dataSourceError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label databaseError;
        private System.Windows.Forms.Label usernameError;
    }
}