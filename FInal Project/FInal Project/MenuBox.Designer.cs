namespace FInal_Project
{
    partial class MenuBox
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
            this.CompoundInterestBTN = new System.Windows.Forms.Button();
            this.mortgageBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompoundInterestBTN
            // 
            this.CompoundInterestBTN.Location = new System.Drawing.Point(12, 62);
            this.CompoundInterestBTN.Name = "CompoundInterestBTN";
            this.CompoundInterestBTN.Size = new System.Drawing.Size(106, 92);
            this.CompoundInterestBTN.TabIndex = 0;
            this.CompoundInterestBTN.Text = "Compound Interest";
            this.CompoundInterestBTN.UseVisualStyleBackColor = true;
            this.CompoundInterestBTN.Click += new System.EventHandler(this.CompoundInterestBTN_Click);
            // 
            // mortgageBTN
            // 
            this.mortgageBTN.Location = new System.Drawing.Point(165, 62);
            this.mortgageBTN.Name = "mortgageBTN";
            this.mortgageBTN.Size = new System.Drawing.Size(106, 92);
            this.mortgageBTN.TabIndex = 1;
            this.mortgageBTN.Text = "Mortgage Calculator";
            this.mortgageBTN.UseVisualStyleBackColor = true;
            this.mortgageBTN.Click += new System.EventHandler(this.mortgageBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(67, 175);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(160, 58);
            this.exitBTN.TabIndex = 2;
            this.exitBTN.Text = "EXIT";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // MenuBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.mortgageBTN);
            this.Controls.Add(this.CompoundInterestBTN);
            this.Name = "MenuBox";
            this.Text = "MenuBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CompoundInterestBTN;
        private System.Windows.Forms.Button mortgageBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}