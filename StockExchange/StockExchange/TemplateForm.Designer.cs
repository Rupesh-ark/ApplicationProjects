
namespace StockExchange
{
    partial class TemplateForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftPanelBottom = new System.Windows.Forms.Panel();
            this.leftPanelTop = new System.Windows.Forms.Panel();
            this.welcomeText = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightPanelBottom = new System.Windows.Forms.Panel();
            this.rightPanelTop = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.leftPanelTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.leftPanelBottom);
            this.leftPanel.Controls.Add(this.leftPanelTop);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(267, 901);
            this.leftPanel.TabIndex = 0;
            // 
            // leftPanelBottom
            // 
            this.leftPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanelBottom.Location = new System.Drawing.Point(0, 55);
            this.leftPanelBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftPanelBottom.Name = "leftPanelBottom";
            this.leftPanelBottom.Size = new System.Drawing.Size(267, 846);
            this.leftPanelBottom.TabIndex = 3;
            // 
            // leftPanelTop
            // 
            this.leftPanelTop.Controls.Add(this.welcomeText);
            this.leftPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelTop.Location = new System.Drawing.Point(0, 0);
            this.leftPanelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftPanelTop.Name = "leftPanelTop";
            this.leftPanelTop.Size = new System.Drawing.Size(267, 55);
            this.leftPanelTop.TabIndex = 0;
            // 
            // welcomeText
            // 
            this.welcomeText.Dock = System.Windows.Forms.DockStyle.Right;
            this.welcomeText.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(72, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(195, 55);
            this.welcomeText.TabIndex = 11;
            this.welcomeText.Text = "Welcome,";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightPanelBottom);
            this.rightPanel.Controls.Add(this.rightPanelTop);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(267, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(739, 901);
            this.rightPanel.TabIndex = 1;
            // 
            // rightPanelBottom
            // 
            this.rightPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelBottom.Location = new System.Drawing.Point(0, 55);
            this.rightPanelBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightPanelBottom.Name = "rightPanelBottom";
            this.rightPanelBottom.Size = new System.Drawing.Size(739, 846);
            this.rightPanelBottom.TabIndex = 2;
            // 
            // rightPanelTop
            // 
            this.rightPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightPanelTop.Location = new System.Drawing.Point(0, 0);
            this.rightPanelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightPanelTop.Name = "rightPanelTop";
            this.rightPanelTop.Size = new System.Drawing.Size(739, 55);
            this.rightPanelTop.TabIndex = 1;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 901);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.leftPanel.ResumeLayout(false);
            this.leftPanelTop.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel leftPanel;
        public System.Windows.Forms.Panel leftPanelBottom;
        public System.Windows.Forms.Panel leftPanelTop;
        public System.Windows.Forms.Panel rightPanel;
        public System.Windows.Forms.Panel rightPanelBottom;
        public System.Windows.Forms.Panel rightPanelTop;
        public System.Windows.Forms.Label welcomeText;
    }
}

