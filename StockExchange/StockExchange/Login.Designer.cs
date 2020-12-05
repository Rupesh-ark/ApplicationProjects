
namespace StockExchange
{
    partial class Login
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
            this.userName = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.leftPanelBottom.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(267, 649);
            // 
            // leftPanelBottom
            // 
            this.leftPanelBottom.Controls.Add(this.loginButton);
            this.leftPanelBottom.Controls.Add(this.password);
            this.leftPanelBottom.Controls.Add(this.passwordText);
            this.leftPanelBottom.Controls.Add(this.userName);
            this.leftPanelBottom.Controls.Add(this.usernameText);
            this.leftPanelBottom.Size = new System.Drawing.Size(267, 594);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1307, 649);
            // 
            // rightPanelBottom
            // 
            this.rightPanelBottom.Size = new System.Drawing.Size(1307, 594);
            // 
            // rightPanelTop
            // 
            this.rightPanelTop.Size = new System.Drawing.Size(1307, 55);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(8, 339);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(75, 18);
            this.userName.TabIndex = 0;
            this.userName.Text = "Username";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(12, 362);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(203, 26);
            this.usernameText.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(12, 456);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(203, 26);
            this.passwordText.TabIndex = 3;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(8, 433);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 18);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 2;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(12, 514);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(203, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 649);
            this.ControlBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanelBottom.ResumeLayout(false);
            this.leftPanelBottom.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button loginButton;
    }
}