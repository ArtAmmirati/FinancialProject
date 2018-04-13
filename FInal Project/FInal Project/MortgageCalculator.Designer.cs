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
            this.DownGB = new System.Windows.Forms.GroupBox();
            this.termGB = new System.Windows.Forms.GroupBox();
            this.totalInterestPaidLabel = new System.Windows.Forms.Label();
            this.totalInterestPaidTB = new System.Windows.Forms.TextBox();
            this.loanPaidTB = new System.Windows.Forms.TextBox();
            this.loanPaidLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.totalAmtPaidLabel = new System.Windows.Forms.Label();
            this.totalAmtPaidTB = new System.Windows.Forms.TextBox();
            this.DownGB.SuspendLayout();
            this.termGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(192, 352);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(80, 42);
            this.calculateBTN.TabIndex = 4;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // menuBTN
            // 
            this.menuBTN.Location = new System.Drawing.Point(292, 352);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(80, 42);
            this.menuBTN.TabIndex = 5;
            this.menuBTN.Text = "Menu";
            this.menuBTN.UseVisualStyleBackColor = true;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(192, 404);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(80, 42);
            this.clearBTN.TabIndex = 6;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // loanAmtTB
            // 
            this.loanAmtTB.Location = new System.Drawing.Point(11, 183);
            this.loanAmtTB.Name = "loanAmtTB";
            this.loanAmtTB.ReadOnly = true;
            this.loanAmtTB.Size = new System.Drawing.Size(161, 20);
            this.loanAmtTB.TabIndex = 17;
            this.loanAmtTB.TextChanged += new System.EventHandler(this.loanAmtTB_TextChanged);
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(11, 253);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(161, 20);
            this.rateTB.TabIndex = 2;
            // 
            // inPurchasePriceTB
            // 
            this.inPurchasePriceTB.Location = new System.Drawing.Point(14, 25);
            this.inPurchasePriceTB.Name = "inPurchasePriceTB";
            this.inPurchasePriceTB.Size = new System.Drawing.Size(158, 20);
            this.inPurchasePriceTB.TabIndex = 0;
            // 
            // inDownPymtTB
            // 
            this.inDownPymtTB.Location = new System.Drawing.Point(15, 81);
            this.inDownPymtTB.Name = "inDownPymtTB";
            this.inDownPymtTB.Size = new System.Drawing.Size(157, 20);
            this.inDownPymtTB.TabIndex = 1;
            // 
            // monthlyPymtTB
            // 
            this.monthlyPymtTB.Location = new System.Drawing.Point(11, 420);
            this.monthlyPymtTB.Name = "monthlyPymtTB";
            this.monthlyPymtTB.ReadOnly = true;
            this.monthlyPymtTB.Size = new System.Drawing.Size(157, 20);
            this.monthlyPymtTB.TabIndex = 18;
            // 
            // termTB
            // 
            this.termTB.Location = new System.Drawing.Point(11, 312);
            this.termTB.Name = "termTB";
            this.termTB.Size = new System.Drawing.Size(161, 20);
            this.termTB.TabIndex = 3;
            // 
            // percentRB
            // 
            this.percentRB.AutoSize = true;
            this.percentRB.Location = new System.Drawing.Point(2, 13);
            this.percentRB.Name = "percentRB";
            this.percentRB.Size = new System.Drawing.Size(76, 17);
            this.percentRB.TabIndex = 7;
            this.percentRB.TabStop = true;
            this.percentRB.Text = "Percent(%)";
            this.percentRB.UseVisualStyleBackColor = true;
            // 
            // dollarsRB
            // 
            this.dollarsRB.AutoSize = true;
            this.dollarsRB.Location = new System.Drawing.Point(84, 13);
            this.dollarsRB.Name = "dollarsRB";
            this.dollarsRB.Size = new System.Drawing.Size(69, 17);
            this.dollarsRB.TabIndex = 8;
            this.dollarsRB.TabStop = true;
            this.dollarsRB.Text = "Dollars($)";
            this.dollarsRB.UseVisualStyleBackColor = true;
            // 
            // yearsRB
            // 
            this.yearsRB.AutoSize = true;
            this.yearsRB.Location = new System.Drawing.Point(6, 14);
            this.yearsRB.Name = "yearsRB";
            this.yearsRB.Size = new System.Drawing.Size(52, 17);
            this.yearsRB.TabIndex = 9;
            this.yearsRB.TabStop = true;
            this.yearsRB.Text = "Years";
            this.yearsRB.UseVisualStyleBackColor = true;
            // 
            // monthRB
            // 
            this.monthRB.AutoSize = true;
            this.monthRB.Location = new System.Drawing.Point(81, 14);
            this.monthRB.Name = "monthRB";
            this.monthRB.Size = new System.Drawing.Size(60, 17);
            this.monthRB.TabIndex = 10;
            this.monthRB.TabStop = true;
            this.monthRB.Text = "Months";
            this.monthRB.UseVisualStyleBackColor = true;
            // 
            // PurchaseLabel
            // 
            this.PurchaseLabel.AutoSize = true;
            this.PurchaseLabel.Location = new System.Drawing.Point(12, 9);
            this.PurchaseLabel.Name = "PurchaseLabel";
            this.PurchaseLabel.Size = new System.Drawing.Size(94, 13);
            this.PurchaseLabel.TabIndex = 11;
            this.PurchaseLabel.Text = "Purchase Price ($)";
            // 
            // DownPymtLabel
            // 
            this.DownPymtLabel.AutoSize = true;
            this.DownPymtLabel.Location = new System.Drawing.Point(14, 65);
            this.DownPymtLabel.Name = "DownPymtLabel";
            this.DownPymtLabel.Size = new System.Drawing.Size(94, 13);
            this.DownPymtLabel.TabIndex = 12;
            this.DownPymtLabel.Text = "Down Payment ($)";
            // 
            // loanAmtLabel
            // 
            this.loanAmtLabel.AutoSize = true;
            this.loanAmtLabel.Location = new System.Drawing.Point(8, 167);
            this.loanAmtLabel.Name = "loanAmtLabel";
            this.loanAmtLabel.Size = new System.Drawing.Size(82, 13);
            this.loanAmtLabel.TabIndex = 13;
            this.loanAmtLabel.Text = "Loan Amount($)";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(11, 237);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(44, 13);
            this.rateLabel.TabIndex = 14;
            this.rateLabel.Text = "Rate(%)";
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(8, 296);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(88, 13);
            this.termLabel.TabIndex = 15;
            this.termLabel.Text = "Term of the Loan";
            this.termLabel.Click += new System.EventHandler(this.termLabel_Click);
            // 
            // monthlyPymtLabel
            // 
            this.monthlyPymtLabel.AutoSize = true;
            this.monthlyPymtLabel.Location = new System.Drawing.Point(11, 404);
            this.monthlyPymtLabel.Name = "monthlyPymtLabel";
            this.monthlyPymtLabel.Size = new System.Drawing.Size(88, 13);
            this.monthlyPymtLabel.TabIndex = 16;
            this.monthlyPymtLabel.Text = "Monthly Payment";
            // 
            // DownGB
            // 
            this.DownGB.Controls.Add(this.dollarsRB);
            this.DownGB.Controls.Add(this.percentRB);
            this.DownGB.Location = new System.Drawing.Point(15, 107);
            this.DownGB.Name = "DownGB";
            this.DownGB.Size = new System.Drawing.Size(157, 42);
            this.DownGB.TabIndex = 19;
            this.DownGB.TabStop = false;
            // 
            // termGB
            // 
            this.termGB.Controls.Add(this.monthRB);
            this.termGB.Controls.Add(this.yearsRB);
            this.termGB.Location = new System.Drawing.Point(11, 338);
            this.termGB.Name = "termGB";
            this.termGB.Size = new System.Drawing.Size(161, 42);
            this.termGB.TabIndex = 9;
            this.termGB.TabStop = false;
            // 
            // totalInterestPaidLabel
            // 
            this.totalInterestPaidLabel.AutoSize = true;
            this.totalInterestPaidLabel.Location = new System.Drawing.Point(216, 9);
            this.totalInterestPaidLabel.Name = "totalInterestPaidLabel";
            this.totalInterestPaidLabel.Size = new System.Drawing.Size(93, 13);
            this.totalInterestPaidLabel.TabIndex = 20;
            this.totalInterestPaidLabel.Text = "Total Interest Paid";
            // 
            // totalInterestPaidTB
            // 
            this.totalInterestPaidTB.Location = new System.Drawing.Point(219, 25);
            this.totalInterestPaidTB.Name = "totalInterestPaidTB";
            this.totalInterestPaidTB.ReadOnly = true;
            this.totalInterestPaidTB.Size = new System.Drawing.Size(137, 20);
            this.totalInterestPaidTB.TabIndex = 21;
            // 
            // loanPaidTB
            // 
            this.loanPaidTB.Location = new System.Drawing.Point(203, 312);
            this.loanPaidTB.Name = "loanPaidTB";
            this.loanPaidTB.ReadOnly = true;
            this.loanPaidTB.Size = new System.Drawing.Size(137, 20);
            this.loanPaidTB.TabIndex = 24;
            // 
            // loanPaidLabel
            // 
            this.loanPaidLabel.AutoSize = true;
            this.loanPaidLabel.Location = new System.Drawing.Point(200, 296);
            this.loanPaidLabel.Name = "loanPaidLabel";
            this.loanPaidLabel.Size = new System.Drawing.Size(72, 13);
            this.loanPaidLabel.TabIndex = 25;
            this.loanPaidLabel.Text = "Loan Paid Off";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(203, 113);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // totalAmtPaidLabel
            // 
            this.totalAmtPaidLabel.AutoSize = true;
            this.totalAmtPaidLabel.Location = new System.Drawing.Point(219, 64);
            this.totalAmtPaidLabel.Name = "totalAmtPaidLabel";
            this.totalAmtPaidLabel.Size = new System.Drawing.Size(94, 13);
            this.totalAmtPaidLabel.TabIndex = 27;
            this.totalAmtPaidLabel.Text = "Total Amount Paid";
            // 
            // totalAmtPaidTB
            // 
            this.totalAmtPaidTB.Location = new System.Drawing.Point(219, 81);
            this.totalAmtPaidTB.Name = "totalAmtPaidTB";
            this.totalAmtPaidTB.ReadOnly = true;
            this.totalAmtPaidTB.Size = new System.Drawing.Size(137, 20);
            this.totalAmtPaidTB.TabIndex = 28;
            // 
            // MortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 467);
            this.Controls.Add(this.totalAmtPaidTB);
            this.Controls.Add(this.totalAmtPaidLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.loanPaidLabel);
            this.Controls.Add(this.loanPaidTB);
            this.Controls.Add(this.totalInterestPaidTB);
            this.Controls.Add(this.totalInterestPaidLabel);
            this.Controls.Add(this.termGB);
            this.Controls.Add(this.DownGB);
            this.Controls.Add(this.monthlyPymtLabel);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.loanAmtLabel);
            this.Controls.Add(this.DownPymtLabel);
            this.Controls.Add(this.PurchaseLabel);
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
            this.DownGB.ResumeLayout(false);
            this.DownGB.PerformLayout();
            this.termGB.ResumeLayout(false);
            this.termGB.PerformLayout();
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
        private System.Windows.Forms.GroupBox DownGB;
        private System.Windows.Forms.GroupBox termGB;
        private System.Windows.Forms.Label totalInterestPaidLabel;
        private System.Windows.Forms.TextBox totalInterestPaidTB;
        private System.Windows.Forms.TextBox loanPaidTB;
        private System.Windows.Forms.Label loanPaidLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label totalAmtPaidLabel;
        private System.Windows.Forms.TextBox totalAmtPaidTB;
    }
}