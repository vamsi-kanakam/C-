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
    public partial class FinPlannerForLoop : Form
    {
        public FinPlannerForLoop()
        {
            InitializeComponent();
        }

        private void btnComputeInvestment_Click(object sender, EventArgs e)
        {
            double yearlyInvestment, yearlyGrowth;
            int noOfYears;

            yearlyInvestment = double.Parse(txtInvestment.Text);
            yearlyGrowth = double.Parse(txtGrowth.Text);
            noOfYears = int.Parse(txtnoOfYears.Text);

            string formatCode = "{0,7}  {1,20}";
            lstOutput.Items.Add(string.Format(formatCode, "years", "Investment Value"));
            lstOutput.Items.Add("");

            int year;
            double investmentValue = 0;
            for(year=1; year<=noOfYears; year++)
            {
                if (investmentValue > 100000)
                    continue;
                investmentValue = (investmentValue + yearlyInvestment) * (1 + yearlyGrowth / 100);
                lstOutput.Items.Add(string.Format(formatCode, year, investmentValue.ToString("c")));
                
            }
            lstOutput.Items.Add(string.Format(formatCode, year, investmentValue.ToString("c")));

        }
    }
}
