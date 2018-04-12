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
            double PurchasePrice, DownPymt, Rate, MonthlyPymt, LoanAmt, DnPay, Percent;
                
            int Term, n, LoanTerms;

                //parsing text
                PurchasePrice = double.Parse(inPurchasePriceTB.Text);
                DownPymt = double.Parse(inDownPymtTB.Text);
                Rate = double.Parse(rateTB.Text);
                MonthlyPymt = double.Parse(monthlyPymtTB.Text);

                LoanAmt = double.Parse(loanAmtTB.Text);
              
                Term = Int32.Parse(termTB.Text);
                Percent = double.Parse(inDownPymtTB.Text)/ 100;
                

                //establishing checked boxes
                if (percentRB.Checked)
                {
                    DnPay = PurchasePrice * Percent;
                }
                else if (dollarsRB.Checked)
                {
                    DnPay = DownPymt;
                }
                else
                    DnPay = 0;

                LoanAmt = PurchasePrice - DnPay;

                if (yearsRB.Checked)
                {
                    LoanTerms = Term * 12;
                     n = LoanTerms;
                }
                else if (monthRB.Checked)
                {
                    LoanTerms = Term;
                    n = LoanTerms;
                }

                // assigning formula variables
             
                double P = LoanAmt;
                double r = Rate / 1200;
                double x = Math.Pow(1 + r, Term);
                double A = (P * r * x) / (x - 1);


            }
            catch (Exception)
            {

                MessageBox.Show("Something is WRONG with your figures");
            }
        }
    }
}
