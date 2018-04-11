namespace FInal_Project
{
    partial class Form1
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
            this.compoundIntrestGroupBox = new System.Windows.Forms.GroupBox();
            this.additionsLabel = new System.Windows.Forms.Label();
            this.outAdditionsTB = new System.Windows.Forms.TextBox();
            this.compoundFreqGB = new System.Windows.Forms.GroupBox();
            this.annuallyRB = new System.Windows.Forms.RadioButton();
            this.semiannuallyRB = new System.Windows.Forms.RadioButton();
            this.quarterlyRB = new System.Windows.Forms.RadioButton();
            this.monthlyRB = new System.Windows.Forms.RadioButton();
            this.outFutureValueTB = new System.Windows.Forms.TextBox();
            this.futureValueLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.clearBTN = new System.Windows.Forms.Button();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.inPrincipalTB = new System.Windows.Forms.TextBox();
            this.inYearsGrowthTB = new System.Windows.Forms.TextBox();
            this.inAdditionsTB = new System.Windows.Forms.TextBox();
            this.inInterestRateTB = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.growthLabel = new System.Windows.Forms.Label();
            this.additionLabel = new System.Windows.Forms.Label();
            this.prinLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.compoundIntrestGroupBox.SuspendLayout();
            this.compoundFreqGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // compoundIntrestGroupBox
            // 
            this.compoundIntrestGroupBox.Controls.Add(this.additionsLabel);
            this.compoundIntrestGroupBox.Controls.Add(this.outAdditionsTB);
            this.compoundIntrestGroupBox.Controls.Add(this.compoundFreqGB);
            this.compoundIntrestGroupBox.Controls.Add(this.outFutureValueTB);
            this.compoundIntrestGroupBox.Controls.Add(this.futureValueLabel);
            this.compoundIntrestGroupBox.Controls.Add(this.resultsLabel);
            this.compoundIntrestGroupBox.Controls.Add(this.clearBTN);
            this.compoundIntrestGroupBox.Controls.Add(this.calculateBTN);
            this.compoundIntrestGroupBox.Controls.Add(this.inPrincipalTB);
            this.compoundIntrestGroupBox.Controls.Add(this.inYearsGrowthTB);
            this.compoundIntrestGroupBox.Controls.Add(this.inAdditionsTB);
            this.compoundIntrestGroupBox.Controls.Add(this.inInterestRateTB);
            this.compoundIntrestGroupBox.Controls.Add(this.rateLabel);
            this.compoundIntrestGroupBox.Controls.Add(this.growthLabel);
            this.compoundIntrestGroupBox.Controls.Add(this.additionLabel);
            this.compoundIntrestGroupBox.Controls.Add(this.prinLabel);
            this.compoundIntrestGroupBox.Controls.Add(this.inputLabel);
            this.compoundIntrestGroupBox.Location = new System.Drawing.Point(13, 13);
            this.compoundIntrestGroupBox.Name = "compoundIntrestGroupBox";
            this.compoundIntrestGroupBox.Size = new System.Drawing.Size(350, 425);
            this.compoundIntrestGroupBox.TabIndex = 0;
            this.compoundIntrestGroupBox.TabStop = false;
            this.compoundIntrestGroupBox.Text = "Compound Interest";
            this.compoundIntrestGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // additionsLabel
            // 
            this.additionsLabel.AutoSize = true;
            this.additionsLabel.Location = new System.Drawing.Point(11, 388);
            this.additionsLabel.Name = "additionsLabel";
            this.additionsLabel.Size = new System.Drawing.Size(82, 13);
            this.additionsLabel.TabIndex = 17;
            this.additionsLabel.Text = "Yearly Additions";
            // 
            // outAdditionsTB
            // 
            this.outAdditionsTB.Location = new System.Drawing.Point(122, 385);
            this.outAdditionsTB.Name = "outAdditionsTB";
            this.outAdditionsTB.ReadOnly = true;
            this.outAdditionsTB.Size = new System.Drawing.Size(197, 20);
            this.outAdditionsTB.TabIndex = 8;
            this.outAdditionsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // compoundFreqGB
            // 
            this.compoundFreqGB.Controls.Add(this.annuallyRB);
            this.compoundFreqGB.Controls.Add(this.semiannuallyRB);
            this.compoundFreqGB.Controls.Add(this.quarterlyRB);
            this.compoundFreqGB.Controls.Add(this.monthlyRB);
            this.compoundFreqGB.Location = new System.Drawing.Point(227, 39);
            this.compoundFreqGB.Name = "compoundFreqGB";
            this.compoundFreqGB.Size = new System.Drawing.Size(117, 174);
            this.compoundFreqGB.TabIndex = 18;
            this.compoundFreqGB.TabStop = false;
            this.compoundFreqGB.Text = "Compound Frequency";
            // 
            // annuallyRB
            // 
            this.annuallyRB.AutoSize = true;
            this.annuallyRB.Location = new System.Drawing.Point(16, 129);
            this.annuallyRB.Name = "annuallyRB";
            this.annuallyRB.Size = new System.Drawing.Size(65, 17);
            this.annuallyRB.TabIndex = 3;
            this.annuallyRB.TabStop = true;
            this.annuallyRB.Text = "Annually";
            this.annuallyRB.UseVisualStyleBackColor = true;
            // 
            // semiannuallyRB
            // 
            this.semiannuallyRB.AutoSize = true;
            this.semiannuallyRB.Location = new System.Drawing.Point(16, 94);
            this.semiannuallyRB.Name = "semiannuallyRB";
            this.semiannuallyRB.Size = new System.Drawing.Size(87, 17);
            this.semiannuallyRB.TabIndex = 2;
            this.semiannuallyRB.TabStop = true;
            this.semiannuallyRB.Text = "Semiannually";
            this.semiannuallyRB.UseVisualStyleBackColor = true;
            // 
            // quarterlyRB
            // 
            this.quarterlyRB.AutoSize = true;
            this.quarterlyRB.Location = new System.Drawing.Point(16, 62);
            this.quarterlyRB.Name = "quarterlyRB";
            this.quarterlyRB.Size = new System.Drawing.Size(67, 17);
            this.quarterlyRB.TabIndex = 1;
            this.quarterlyRB.TabStop = true;
            this.quarterlyRB.Text = "Quarterly";
            this.quarterlyRB.UseVisualStyleBackColor = true;
            // 
            // monthlyRB
            // 
            this.monthlyRB.AutoSize = true;
            this.monthlyRB.Location = new System.Drawing.Point(16, 32);
            this.monthlyRB.Name = "monthlyRB";
            this.monthlyRB.Size = new System.Drawing.Size(62, 17);
            this.monthlyRB.TabIndex = 0;
            this.monthlyRB.TabStop = true;
            this.monthlyRB.Text = "Monthly";
            this.monthlyRB.UseVisualStyleBackColor = true;
            // 
            // outFutureValueTB
            // 
            this.outFutureValueTB.Location = new System.Drawing.Point(122, 323);
            this.outFutureValueTB.Name = "outFutureValueTB";
            this.outFutureValueTB.ReadOnly = true;
            this.outFutureValueTB.Size = new System.Drawing.Size(197, 20);
            this.outFutureValueTB.TabIndex = 6;
            this.outFutureValueTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // futureValueLabel
            // 
            this.futureValueLabel.AutoSize = true;
            this.futureValueLabel.Location = new System.Drawing.Point(11, 326);
            this.futureValueLabel.Name = "futureValueLabel";
            this.futureValueLabel.Size = new System.Drawing.Size(70, 13);
            this.futureValueLabel.TabIndex = 15;
            this.futureValueLabel.Text = "Future Value ";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resultsLabel.Location = new System.Drawing.Point(3, 295);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(347, 16);
            this.resultsLabel.TabIndex = 14;
            this.resultsLabel.Text = "RESULTS";
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(121, 233);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(88, 49);
            this.clearBTN.TabIndex = 5;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(10, 235);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(88, 47);
            this.calculateBTN.TabIndex = 4;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // inPrincipalTB
            // 
            this.inPrincipalTB.Location = new System.Drawing.Point(121, 39);
            this.inPrincipalTB.Name = "inPrincipalTB";
            this.inPrincipalTB.Size = new System.Drawing.Size(100, 20);
            this.inPrincipalTB.TabIndex = 0;
            this.inPrincipalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inPrincipalTB.TextChanged += new System.EventHandler(this.inPrincipalTB_TextChanged);
            // 
            // inYearsGrowthTB
            // 
            this.inYearsGrowthTB.Location = new System.Drawing.Point(122, 133);
            this.inYearsGrowthTB.Name = "inYearsGrowthTB";
            this.inYearsGrowthTB.Size = new System.Drawing.Size(100, 20);
            this.inYearsGrowthTB.TabIndex = 2;
            this.inYearsGrowthTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inAdditionsTB
            // 
            this.inAdditionsTB.Location = new System.Drawing.Point(121, 86);
            this.inAdditionsTB.Name = "inAdditionsTB";
            this.inAdditionsTB.Size = new System.Drawing.Size(100, 20);
            this.inAdditionsTB.TabIndex = 1;
            this.inAdditionsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inInterestRateTB
            // 
            this.inInterestRateTB.Location = new System.Drawing.Point(121, 180);
            this.inInterestRateTB.Name = "inInterestRateTB";
            this.inInterestRateTB.Size = new System.Drawing.Size(100, 20);
            this.inInterestRateTB.TabIndex = 3;
            this.inInterestRateTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rateLabel
            // 
            this.rateLabel.Location = new System.Drawing.Point(11, 183);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(133, 13);
            this.rateLabel.TabIndex = 13;
            this.rateLabel.Text = "Intrest Rate ";
            // 
            // growthLabel
            // 
            this.growthLabel.Location = new System.Drawing.Point(7, 136);
            this.growthLabel.Name = "growthLabel";
            this.growthLabel.Size = new System.Drawing.Size(133, 13);
            this.growthLabel.TabIndex = 12;
            this.growthLabel.Text = "Years to Grow";
            // 
            // additionLabel
            // 
            this.additionLabel.Location = new System.Drawing.Point(6, 89);
            this.additionLabel.Name = "additionLabel";
            this.additionLabel.Size = new System.Drawing.Size(133, 13);
            this.additionLabel.TabIndex = 11;
            this.additionLabel.Text = "Monthly Additions ";
            // 
            // prinLabel
            // 
            this.prinLabel.Location = new System.Drawing.Point(6, 42);
            this.prinLabel.Name = "prinLabel";
            this.prinLabel.Size = new System.Drawing.Size(133, 13);
            this.prinLabel.TabIndex = 10;
            this.prinLabel.Text = "Current Principal";
            // 
            // inputLabel
            // 
            this.inputLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.inputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputLabel.Location = new System.Drawing.Point(3, 16);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(347, 16);
            this.inputLabel.TabIndex = 9;
            this.inputLabel.Text = "INPUTS";
            this.inputLabel.Click += new System.EventHandler(this.inputLabel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(393, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 395);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.compoundIntrestGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.compoundIntrestGroupBox.ResumeLayout(false);
            this.compoundIntrestGroupBox.PerformLayout();
            this.compoundFreqGB.ResumeLayout(false);
            this.compoundFreqGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox compoundIntrestGroupBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.TextBox inPrincipalTB;
        private System.Windows.Forms.TextBox inYearsGrowthTB;
        private System.Windows.Forms.TextBox inAdditionsTB;
        private System.Windows.Forms.TextBox inInterestRateTB;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label growthLabel;
        private System.Windows.Forms.Label additionLabel;
        private System.Windows.Forms.Label prinLabel;
        private System.Windows.Forms.TextBox outFutureValueTB;
        private System.Windows.Forms.Label futureValueLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.GroupBox compoundFreqGB;
        private System.Windows.Forms.RadioButton annuallyRB;
        private System.Windows.Forms.RadioButton semiannuallyRB;
        private System.Windows.Forms.RadioButton quarterlyRB;
        private System.Windows.Forms.RadioButton monthlyRB;
        private System.Windows.Forms.TextBox outAdditionsTB;
        private System.Windows.Forms.Label additionsLabel;
    }
}

