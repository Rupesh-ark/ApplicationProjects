
namespace SE_ManagementSystem
{
    partial class SampleForm
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
            this.left = new System.Windows.Forms.Panel();
            this.topLeft = new System.Windows.Forms.Panel();
            this.welcomeText = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Panel();
            this.topRight = new System.Windows.Forms.Panel();
            this.left.SuspendLayout();
            this.topLeft.SuspendLayout();
            this.right.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Controls.Add(this.topLeft);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(350, 647);
            this.left.TabIndex = 0;
            // 
            // topLeft
            // 
            this.topLeft.Controls.Add(this.welcomeText);
            this.topLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLeft.Location = new System.Drawing.Point(0, 0);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(350, 72);
            this.topLeft.TabIndex = 0;
            // 
            // welcomeText
            // 
            this.welcomeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeText.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.welcomeText.Location = new System.Drawing.Point(0, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(350, 72);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // right
            // 
            this.right.Controls.Add(this.topRight);
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.Location = new System.Drawing.Point(350, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(793, 647);
            this.right.TabIndex = 1;
            // 
            // topRight
            // 
            this.topRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRight.Location = new System.Drawing.Point(0, 0);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(793, 72);
            this.topRight.TabIndex = 0;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1143, 647);
            this.ControlBox = false;
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SampleForm";
            this.left.ResumeLayout(false);
            this.topLeft.ResumeLayout(false);
            this.right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel left;
        public System.Windows.Forms.Panel topLeft;
        public System.Windows.Forms.Panel right;
        public System.Windows.Forms.Panel topRight;
        public System.Windows.Forms.Label welcomeText;
    }
}