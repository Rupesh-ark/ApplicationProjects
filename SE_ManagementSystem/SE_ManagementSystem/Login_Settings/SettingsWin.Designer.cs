
namespace SE_ManagementSystem
{
    partial class SettingsWin
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
            this.save = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordL = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameL = new System.Windows.Forms.Label();
            this.databaseNameTxt = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.Label();
            this.databaseName = new System.Windows.Forms.Label();
            this.serverNameTxt = new System.Windows.Forms.TextBox();
            this.isCV = new System.Windows.Forms.CheckBox();
            this.serverNameError = new System.Windows.Forms.Label();
            this.databaseError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.left.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Controls.Add(this.isCV);
            this.left.Controls.Add(this.serverName);
            this.left.Controls.Add(this.serverNameTxt);
            this.left.Controls.Add(this.databaseName);
            this.left.Controls.Add(this.databaseNameTxt);
            this.left.Controls.Add(this.save);
            this.left.Controls.Add(this.serverNameError);
            this.left.Controls.Add(this.databaseError);
            this.left.Controls.Add(this.passwordText);
            this.left.Controls.Add(this.usernameL);
            this.left.Controls.Add(this.passwordL);
            this.left.Controls.Add(this.usernameText);
            this.left.Controls.Add(this.usernameError);
            this.left.Controls.Add(this.passwordError);
            this.left.Size = new System.Drawing.Size(350, 650);
            this.left.Controls.SetChildIndex(this.passwordError, 0);
            this.left.Controls.SetChildIndex(this.usernameError, 0);
            this.left.Controls.SetChildIndex(this.usernameText, 0);
            this.left.Controls.SetChildIndex(this.passwordL, 0);
            this.left.Controls.SetChildIndex(this.usernameL, 0);
            this.left.Controls.SetChildIndex(this.passwordText, 0);
            this.left.Controls.SetChildIndex(this.topLeft, 0);
            this.left.Controls.SetChildIndex(this.databaseError, 0);
            this.left.Controls.SetChildIndex(this.serverNameError, 0);
            this.left.Controls.SetChildIndex(this.save, 0);
            this.left.Controls.SetChildIndex(this.databaseNameTxt, 0);
            this.left.Controls.SetChildIndex(this.databaseName, 0);
            this.left.Controls.SetChildIndex(this.serverNameTxt, 0);
            this.left.Controls.SetChildIndex(this.serverName, 0);
            this.left.Controls.SetChildIndex(this.isCV, 0);
            // 
            // right
            // 
            this.right.Size = new System.Drawing.Size(860, 650);
            // 
            // topRight
            // 
            this.topRight.Size = new System.Drawing.Size(860, 72);
            // 
            // save
            // 
            this.save.FlatAppearance.BorderSize = 2;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.save.Location = new System.Drawing.Point(12, 550);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(278, 44);
            this.save.TabIndex = 10;
            this.save.Text = "&Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(12, 459);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(278, 30);
            this.passwordText.TabIndex = 9;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passwordL.Location = new System.Drawing.Point(8, 433);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(80, 23);
            this.passwordL.TabIndex = 8;
            this.passwordL.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(12, 386);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(278, 30);
            this.usernameText.TabIndex = 7;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameL.Location = new System.Drawing.Point(8, 360);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(87, 23);
            this.usernameL.TabIndex = 6;
            this.usernameL.Text = "Username";
            // 
            // databaseNameTxt
            // 
            this.databaseNameTxt.Location = new System.Drawing.Point(12, 314);
            this.databaseNameTxt.Name = "databaseNameTxt";
            this.databaseNameTxt.Size = new System.Drawing.Size(278, 30);
            this.databaseNameTxt.TabIndex = 14;
            this.databaseNameTxt.UseSystemPasswordChar = true;
            this.databaseNameTxt.TextChanged += new System.EventHandler(this.databaseNameTxt_TextChanged_1);
            // 
            // serverName
            // 
            this.serverName.AutoSize = true;
            this.serverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.serverName.Location = new System.Drawing.Point(8, 215);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(108, 23);
            this.serverName.TabIndex = 11;
            this.serverName.Text = "Server Name";
            // 
            // databaseName
            // 
            this.databaseName.AutoSize = true;
            this.databaseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.databaseName.Location = new System.Drawing.Point(8, 288);
            this.databaseName.Name = "databaseName";
            this.databaseName.Size = new System.Drawing.Size(81, 23);
            this.databaseName.TabIndex = 13;
            this.databaseName.Text = "Database";
            // 
            // serverNameTxt
            // 
            this.serverNameTxt.Location = new System.Drawing.Point(12, 241);
            this.serverNameTxt.Name = "serverNameTxt";
            this.serverNameTxt.Size = new System.Drawing.Size(278, 30);
            this.serverNameTxt.TabIndex = 12;
            this.serverNameTxt.TextChanged += new System.EventHandler(this.serverNameTxt_TextChanged);
            // 
            // isCV
            // 
            this.isCV.AutoSize = true;
            this.isCV.Location = new System.Drawing.Point(13, 510);
            this.isCV.Name = "isCV";
            this.isCV.Size = new System.Drawing.Size(177, 27);
            this.isCV.TabIndex = 15;
            this.isCV.Text = "Integreted Security";
            this.isCV.UseVisualStyleBackColor = true;
            // 
            // serverNameError
            // 
            this.serverNameError.AutoSize = true;
            this.serverNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.serverNameError.Location = new System.Drawing.Point(273, 222);
            this.serverNameError.Name = "serverNameError";
            this.serverNameError.Size = new System.Drawing.Size(17, 23);
            this.serverNameError.TabIndex = 16;
            this.serverNameError.Text = "*";
            this.serverNameError.Visible = false;
            // 
            // databaseError
            // 
            this.databaseError.AutoSize = true;
            this.databaseError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.databaseError.Location = new System.Drawing.Point(273, 295);
            this.databaseError.Name = "databaseError";
            this.databaseError.Size = new System.Drawing.Size(17, 23);
            this.databaseError.TabIndex = 17;
            this.databaseError.Text = "*";
            this.databaseError.Visible = false;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameError.Location = new System.Drawing.Point(273, 367);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(17, 23);
            this.usernameError.TabIndex = 18;
            this.usernameError.Text = "*";
            this.usernameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passwordError.Location = new System.Drawing.Point(273, 440);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(17, 23);
            this.passwordError.TabIndex = 19;
            this.passwordError.Text = "*";
            this.passwordError.Visible = false;
            // 
            // SettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 650);
            this.Name = "SettingsWin";
            this.Text = "SettingsWin";
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox isCV;
        private System.Windows.Forms.Label serverName;
        private System.Windows.Forms.TextBox serverNameTxt;
        private System.Windows.Forms.Label databaseName;
        private System.Windows.Forms.TextBox databaseNameTxt;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label serverNameError;
        private System.Windows.Forms.Label databaseError;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.TextBox usernameText;
    }
}