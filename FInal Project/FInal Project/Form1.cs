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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inputLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                double Principal, Additions, FutureValue, annualContrib;
                double InterestRate, InterestEarned, RatePerPeriod;
                int YearsToGrow, CompoundType;
               

                Principal = Double.Parse(inPrincipalTB.Text);
                InterestRate = Double.Parse(inInterestRateTB.Text) / 100;
                Additions = Double.Parse(inAdditionsTB.Text);
                YearsToGrow = Int32.Parse(inYearsGrowthTB.Text);

                if (monthlyRB.Checked)
                    CompoundType = 12;
                else if (quarterlyRB.Checked)
                    CompoundType = 4;
                else if (semiannuallyRB.Checked)
                    CompoundType = 2;
                else
                    CompoundType = 1;

                
                double i = InterestRate / CompoundType;
                
                int n = YearsToGrow;
                int c = CompoundType;
                double l = (n * c);
                double R = Additions;
                double x = Math.Pow(1 + i, n);
                double y = Math.Pow(1 + i, l);
                double P = Principal;
             
                

                RatePerPeriod = InterestRate / YearsToGrow;

                FutureValue = (P * y) + ((R * (y - 1)) / i);
                outFutureValueTB.Text = FutureValue.ToString("C");

                annualContrib = R * (YearsToGrow * 12);
                outAdditionsTB.Text = annualContrib.ToString("C");

                //InterestEarned =  (FutureValue - annualContrib) - P ;
                if (P > (FutureValue - annualContrib))
                    {
                    InterestEarned = P - (FutureValue - annualContrib);
                    }
                 else
                    {
                        InterestEarned = (FutureValue - annualContrib) - P;
                    }

                outInterestEarnedTB.Text = InterestEarned.ToString("C");

                inPrincipalTB.Text = Principal.ToString("C");

                inInterestRateTB.Text = InterestRate.ToString("P");

                inAdditionsTB.Text = Additions.ToString("C");
                




                //monthlyContrib = (((Additions * x) - 1)/ i);
                //FutureValue = (Principal * x) + (monthlyContrib);
                //InterestEarned = FutureValue - (Principal + monthlyContrib);

            }
            catch (Exception )
            {
                MessageBox.Show("Some Information was given in the wrong format!");

               
            }
        }

        private void compIntLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            inPrincipalTB.Text = "";
            inAdditionsTB.Text = "";
            inYearsGrowthTB.Text = "";
            inInterestRateTB.Text = "";
            outFutureValueTB.Text = "";
            outInterestEarnedTB.Text = "";
            outAdditionsTB.Text = "";
        }

        private void inPrincipalTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
