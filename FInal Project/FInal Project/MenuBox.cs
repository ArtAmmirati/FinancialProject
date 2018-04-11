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
    public partial class MenuBox : Form
    {
        public MenuBox()
        {
            InitializeComponent();
        }

        private void CompoundInterestBTN_Click(object sender, EventArgs e)
        {
            Form1 frmComp = new Form1();
            this.Hide();
            frmComp.Show();


        }

        private void mortgageBTN_Click(object sender, EventArgs e)
        {
            MortgageCalculator mortgage = new MortgageCalculator();
            this.Hide();
            mortgage.Show();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
