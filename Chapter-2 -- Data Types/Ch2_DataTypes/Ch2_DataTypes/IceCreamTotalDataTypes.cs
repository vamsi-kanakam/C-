using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2_DataTypes
{
    public partial class IceCreamTotalDataTypes : Form
    {
        public IceCreamTotalDataTypes()
        {
            InitializeComponent();
        }

        private void btnComputeTotal_Click(object sender, EventArgs e)
        {
            int scoops;
            decimal unitPrice, subTotal, salesTax, totalCost;

            const decimal TAX_RATE = (decimal) 5.5;

            scoops = int.Parse(txtScoops.Text);
            unitPrice = decimal.Parse(txtUnitPrice.Text);

            subTotal = unitPrice * scoops;
            salesTax = subTotal * TAX_RATE/100;
            totalCost = subTotal + salesTax;
          //  float costPerUnit = 1234567890f; // valid, but loses precision.
          //  double price = costPerUnit;

            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Sub Total:", subTotal));
            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Sales Tax:", salesTax));
            lstOutput.Items.Add("");
            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Total Cost:", totalCost));
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
