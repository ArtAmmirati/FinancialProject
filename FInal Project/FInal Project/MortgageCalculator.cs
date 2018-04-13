using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class MortgageCalculator : Form
    {
        public MortgageCalculator()
        {
            InitializeComponent();
        }

        private void termLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            MenuBox menu = new MenuBox();
            this.Hide();
            menu.Show();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            inPurchasePriceTB.Text = "";
            inDownPymtTB.Text = "";
            rateTB.Text = "";
            monthlyPymtTB.Text = "";
            loanAmtTB.Text = "";
            termTB.Text = "";

        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {

                //declaring variables
                double PurchasePrice, DownPymt, Rate, MonthlyPymt, LoanAmt, Percent, TotalInterest; 
                    
                int Term;
                

                //parsing text
                PurchasePrice = double.Parse(inPurchasePriceTB.Text);

                DownPymt = double.Parse(inDownPymtTB.Text);

                Rate = double.Parse(rateTB.Text) / 100;

                Term = int.Parse(termTB.Text);
        
                Percent = double.Parse(inDownPymtTB.Text)/ 100;

              
                
                
                //Checking Percent of purchase price or dollar value
                if (percentRB.Checked)
                {
                    DownPymt = PurchasePrice * Percent;
                }
                else if (dollarsRB.Checked)
                {
                    DownPymt = double.Parse(inDownPymtTB.Text);
                }
                
                // checking Years or Months
                if (yearsRB.Checked)
                {
                    Term = Term * 12;
                     
                }
                else if (monthRB.Checked)
                {
                    Term = int.Parse(termTB.Text);

                }

                // assigning formula variables
             
                
                double interest = Rate / 12;
                LoanAmt = PurchasePrice - DownPymt;

                MonthlyPymt = LoanAmt * ((interest * (Math.Pow(1 + interest, Term))) /
                              (Math.Pow(1 + interest,Term) - 1));

                TotalInterest = (MonthlyPymt * Term) - LoanAmt;

                double totalAmtPaid = MonthlyPymt * Term;

                // Display the answers
                loanAmtTB.Text = LoanAmt.ToString();

                monthlyPymtTB.Text = MonthlyPymt.ToString("n2");

                totalInterestPaidTB.Text = TotalInterest.ToString("n2");

                totalAmtPaidTB.Text = totalAmtPaid.ToString("n2");

            }
            catch (Exception)
            {

                MessageBox.Show("Something is WRONG with your figures");
            }
        }

        private void loanAmtTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
