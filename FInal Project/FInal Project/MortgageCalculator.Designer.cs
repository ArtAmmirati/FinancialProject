namespace FInal_Project
{
    partial class MortgageCalculator
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
            this.calculateBTN = new System.Windows.Forms.Button();
            this.menuBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.loanAmtTB = new System.Windows.Forms.TextBox();
            this.rateTB = new System.Windows.Forms.TextBox();
            this.inPurchasePriceTB = new System.Windows.Forms.TextBox();
            this.inDownPymtTB = new System.Windows.Forms.TextBox();
            this.monthlyPymtTB = new System.Windows.Forms.TextBox();
            this.termTB = new System.Windows.Forms.TextBox();
            this.percentRB = new System.Windows.Forms.RadioButton();
            this.dollarsRB = new System.Windows.Forms.RadioButton();
            this.yearsRB = new System.Windows.Forms.RadioButton();
            this.monthRB = new System.Windows.Forms.RadioButton();
            this.PurchaseLabel = new System.Windows.Forms.Label();
            this.DownPymtLabel = new System.Windows.Forms.Label();
            this.loanAmtLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.termLabel = new System.Windows.Forms.Label();
            this.monthlyPymtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(9, 560);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(92, 51);
            this.calculateBTN.TabIndex = 10;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // menuBTN
            // 
            this.menuBTN.Location = new System.Drawing.Point(142, 560);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(92, 51);
            this.menuBTN.TabIndex = 12;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = true;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(275, 560);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(92, 51);
            this.clearBTN.TabIndex = 11;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // loanAmtTB
            // 
            this.loanAmtTB.Location = new System.Drawing.Point(12, 193);
            this.loanAmtTB.Name = "loanAmtTB";
            this.loanAmtTB.ReadOnly = true;
            this.loanAmtTB.Size = new System.Drawing.Size(354, 20);
            this.loanAmtTB.TabIndex = 4;
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(12, 268);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(355, 20);
            this.rateTB.TabIndex = 5;
            // 
            // inPurchasePriceTB
            // 
            this.inPurchasePriceTB.Location = new System.Drawing.Point(13, 34);
            this.inPurchasePriceTB.Name = "inPurchasePriceTB";
            this.inPurchasePriceTB.Size = new System.Drawing.Size(354, 20);
            this.inPurchasePriceTB.TabIndex = 0;
            // 
            // inDownPymtTB
            // 
            this.inDownPymtTB.Location = new System.Drawing.Point(13, 108);
            this.inDownPymtTB.Name = "inDownPymtTB";
            this.inDownPymtTB.Size = new System.Drawing.Size(354, 20);
            this.inDownPymtTB.TabIndex = 1;
            // 
            // monthlyPymtTB
            // 
            this.monthlyPymtTB.Location = new System.Drawing.Point(13, 421);
            this.monthlyPymtTB.Name = "monthlyPymtTB";
            this.monthlyPymtTB.ReadOnly = true;
            this.monthlyPymtTB.Size = new System.Drawing.Size(354, 20);
            this.monthlyPymtTB.TabIndex = 9;
            // 
            // termTB
            // 
            this.termTB.Location = new System.Drawing.Point(13, 339);
            this.termTB.Name = "termTB";
            this.termTB.Size = new System.Drawing.Size(354, 20);
            this.termTB.TabIndex = 6;
            // 
            // percentRB
            // 
            this.percentRB.AutoSize = true;
            this.percentRB.Location = new System.Drawing.Point(13, 134);
            this.percentRB.Name = "percentRB";
            this.percentRB.Size = new System.Drawing.Size(76, 17);
            this.percentRB.TabIndex = 2;
            this.percentRB.TabStop = true;
            this.percentRB.Text = "Percent(%)";
            this.percentRB.UseVisualStyleBackColor = true;
            // 
            // dollarsRB
            // 
            this.dollarsRB.AutoSize = true;
            this.dollarsRB.Location = new System.Drawing.Point(95, 134);
            this.dollarsRB.Name = "dollarsRB";
            this.dollarsRB.Size = new System.Drawing.Size(69, 17);
            this.dollarsRB.TabIndex = 3;
            this.dollarsRB.TabStop = true;
            this.dollarsRB.Text = "Dollars($)";
            this.dollarsRB.UseVisualStyleBackColor = true;
            // 
            // yearsRB
            // 
            this.yearsRB.AutoSize = true;
            this.yearsRB.Location = new System.Drawing.Point(12, 365);
            this.yearsRB.Name = "yearsRB";
            this.yearsRB.Size = new System.Drawing.Size(52, 17);
            this.yearsRB.TabIndex = 7;
            this.yearsRB.TabStop = true;
            this.yearsRB.Text = "Years";
            this.yearsRB.UseVisualStyleBackColor = true;
            // 
            // monthRB
            // 
            this.monthRB.AutoSize = true;
            this.monthRB.Location = new System.Drawing.Point(83, 365);
            this.monthRB.Name = "monthRB";
            this.monthRB.Size = new System.Drawing.Size(60, 17);
            this.monthRB.TabIndex = 8;
            this.monthRB.TabStop = true;
            this.monthRB.Text = "Months";
            this.monthRB.UseVisualStyleBackColor = true;
            // 
            // PurchaseLabel
            // 
            this.PurchaseLabel.AutoSize = true;
            this.PurchaseLabel.Location = new System.Drawing.Point(13, 18);
            this.PurchaseLabel.Name = "PurchaseLabel";
            this.PurchaseLabel.Size = new System.Drawing.Size(94, 13);
            this.PurchaseLabel.TabIndex = 13;
            this.PurchaseLabel.Text = "Purchase Price ($)";
            // 
            // DownPymtLabel
            // 
            this.DownPymtLabel.AutoSize = true;
            this.DownPymtLabel.Location = new System.Drawing.Point(13, 84);
            this.DownPymtLabel.Name = "DownPymtLabel";
            this.DownPymtLabel.Size = new System.Drawing.Size(94, 13);
            this.DownPymtLabel.TabIndex = 14;
            this.DownPymtLabel.Text = "Down Payment ($)";
            // 
            // loanAmtLabel
            // 
            this.loanAmtLabel.AutoSize = true;
            this.loanAmtLabel.Location = new System.Drawing.Point(13, 177);
            this.loanAmtLabel.Name = "loanAmtLabel";
            this.loanAmtLabel.Size = new System.Drawing.Size(82, 13);
            this.loanAmtLabel.TabIndex = 15;
            this.loanAmtLabel.Text = "Loan Amount($)";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(13, 252);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(44, 13);
            this.rateLabel.TabIndex = 16;
            this.rateLabel.Text = "Rate(%)";
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(13, 323);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(88, 13);
            this.termLabel.TabIndex = 17;
            this.termLabel.Text = "Term of the Loan";
            this.termLabel.Click += new System.EventHandler(this.termLabel_Click);
            // 
            // monthlyPymtLabel
            // 
            this.monthlyPymtLabel.AutoSize = true;
            this.monthlyPymtLabel.Location = new System.Drawing.Point(13, 405);
            this.monthlyPymtLabel.Name = "monthlyPymtLabel";
            this.monthlyPymtLabel.Size = new System.Drawing.Size(88, 13);
            this.monthlyPymtLabel.TabIndex = 18;
            this.monthlyPymtLabel.Text = "Monthly Payment";
            // 
            // MortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 639);
            this.Controls.Add(this.monthlyPymtLabel);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.loanAmtLabel);
            this.Controls.Add(this.DownPymtLabel);
            this.Controls.Add(this.PurchaseLabel);
            this.Controls.Add(this.monthRB);
            this.Controls.Add(this.yearsRB);
            this.Controls.Add(this.dollarsRB);
            this.Controls.Add(this.percentRB);
            this.Controls.Add(this.termTB);
            this.Controls.Add(this.monthlyPymtTB);
            this.Controls.Add(this.inDownPymtTB);
            this.Controls.Add(this.inPurchasePriceTB);
            this.Controls.Add(this.rateTB);
            this.Controls.Add(this.loanAmtTB);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.menuBTN);
            this.Controls.Add(this.calculateBTN);
            this.Name = "MortgageCalculator";
            this.Text = "MortgageCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Button menuBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.TextBox loanAmtTB;
        private System.Windows.Forms.TextBox rateTB;
        private System.Windows.Forms.TextBox inPurchasePriceTB;
        private System.Windows.Forms.TextBox inDownPymtTB;
        private System.Windows.Forms.TextBox monthlyPymtTB;
        private System.Windows.Forms.TextBox termTB;
        private System.Windows.Forms.RadioButton percentRB;
        private System.Windows.Forms.RadioButton dollarsRB;
        private System.Windows.Forms.RadioButton yearsRB;
        private System.Windows.Forms.RadioButton monthRB;
        private System.Windows.Forms.Label PurchaseLabel;
        private System.Windows.Forms.Label DownPymtLabel;
        private System.Windows.Forms.Label loanAmtLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label monthlyPymtLabel;
    }
}