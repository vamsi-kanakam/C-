using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_Loops
{
    public partial class FinancialPlanner : Form
    {
        public FinancialPlanner()
        {
            InitializeComponent();
        }

        private void btnHowLong_Click(object sender, EventArgs e)
        {
            //declaration
            double yearlyInvestment, yearlyGrowthPecent, target;

            //user Input
            yearlyInvestment = double.Parse(txtInvestment.Text);
            yearlyGrowthPecent = double.Parse(txtGrowth.Text);
            target = double.Parse(txtTargetAmt.Text);

            //Print heading
            string formatCode= "{0,7}  {1,20}";
            lstOutput.Items.Add(string.Format(formatCode,"years","Investment Value"));
            lstOutput.Items.Add("");

            int year = 0;
            double investmentValue = 0;

            do
            {
                year = year + 1;
                investmentValue = (investmentValue + yearlyInvestment) * (1 + yearlyGrowthPecent / 100);
                lstOutput.Items.Add(string.Format(formatCode, year, investmentValue.ToString("c")));
            } 
            while (investmentValue < target);
        }
    }
}
