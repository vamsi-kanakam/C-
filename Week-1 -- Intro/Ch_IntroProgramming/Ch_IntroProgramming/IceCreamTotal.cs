using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_IntroProgramming
{
    public partial class IceCreamTotal : Form
    {
        public IceCreamTotal()
        {
            InitializeComponent();
        }

        private void btnComputeCost_Click(object sender, EventArgs e)
        {
            //Variable Declaration
            int scoops;
            double unitPrice,subTotal,salesTax,totalCost;

            const double TAX_RATE = 5.5;

            //User Input
            unitPrice = double.Parse(txtUnitPrice.Text);
            scoops = int.Parse(txtScoops.Text);

            //compute
            subTotal = unitPrice * scoops;
            salesTax = subTotal * TAX_RATE / 100;
            totalCost = subTotal + salesTax;

            //Display Output
            lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "Sub Total:", subTotal));
            lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "Sales Tax:", salesTax));
            lstOutput.Items.Add("");
            lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "Total Cost:", totalCost));

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScoops.Clear();
            txtUnitPrice.Clear();
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
