using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_Ch2
{
    public partial class costOfOilChange : Form
    {
        public costOfOilChange()
        {
            InitializeComponent();
        }

        private void btnComputeCost_Click(object sender, EventArgs e)
        {
            //declaration
            decimal laborCharge, quartsUsed, costPerQuart, TAX_RATE, costOfOil, subTotal, salesTax, totalCost;

            //user input
            laborCharge = decimal.Parse(txtLaborCharge.Text);
            quartsUsed = decimal.Parse(txtQuartsUsed.Text);
            costPerQuart = decimal.Parse(txtCostPerQuart.Text);
            TAX_RATE = decimal.Parse(txtTaxRate.Text);

            //Operation
            costOfOil = quartsUsed * costPerQuart;
            subTotal = laborCharge + costOfOil;
            salesTax = subTotal * TAX_RATE/100;
            totalCost = subTotal + salesTax;

            //Display
            lstOutput.Items.Clear();
            lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "The Sub Total:", subTotal));
            lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "The Sales Tax:", salesTax));
            lstOutput.Items.Add("");
            lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "Your Total Cost:", totalCost));

        }
    }
}
