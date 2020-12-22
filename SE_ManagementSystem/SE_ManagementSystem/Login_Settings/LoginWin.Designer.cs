
namespace SE_ManagementSystem
{
    partial class LoginWin
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
            this.usernameL = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordL = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.left.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Controls.Add(this.login);
            this.left.Controls.Add(this.passwordText);
            this.left.Controls.Add(this.passwordL);
            this.left.Controls.Add(this.usernameText);
            this.left.Controls.Add(this.usernameL);
            this.left.Size = new System.Drawing.Size(350, 610);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.usernameL, 0);
            this.left.Controls.SetChildIndex(this.usernameText, 0);
            this.left.Controls.SetChildIndex(this.passwordL, 0);
            this.left.Controls.SetChildIndex(this.passwordText, 0);
            this.left.Controls.SetChildIndex(this.login, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(640, 610);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(640, 72);
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameL.Location = new System.Drawing.Point(11, 309);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(87, 23);
            this.usernameL.TabIndex = 1;
            this.usernameL.Text = "Username";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(15, 335);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(278, 30);
            this.usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(15, 408);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(278, 30);
            this.passwordText.TabIndex = 4;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passwordL.Location = new System.Drawing.Point(11, 382);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(80, 23);
            this.passwordL.TabIndex = 3;
            this.passwordL.Text = "Password";
            // 
            // login
            // 
            this.login.FlatAppearance.BorderSize = 2;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.login.Location = new System.Drawing.Point(101, 478);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(98, 44);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 610);
            this.Name = "LoginWin";
            this.Text = "Login";
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label usernameL;
    }
}