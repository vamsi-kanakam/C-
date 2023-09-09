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
    public partial class IceCreamTotalWithDiscount : Form
    {
        public IceCreamTotalWithDiscount()
        {
            InitializeComponent();
        }

        private void btnComputeTotal_Click(object sender, EventArgs e)
        {
            int scoops;
            decimal unitPrice, subTotal, netCost,salesTax, totalCost;

            const decimal TAX_RATE = 5.5m;

            scoops = int.Parse(txtScoops.Text);
            unitPrice = decimal.Parse(txtUnitPrice.Text);

            subTotal = unitPrice * scoops;
            decimal discountPercentage, discount;
            bool freeToppings;
            if(!((subTotal < 10) && (scoops < 3)))
            {
                discountPercentage = 20;
                freeToppings = true;
            }
            else
            {
                discountPercentage= 0;
                freeToppings= false;
            }

            discount = subTotal * discountPercentage / 100;
            netCost = subTotal - discount;
            salesTax = netCost * TAX_RATE/100;
            totalCost = netCost + salesTax;

          //  float costPerUnit = 1234567890f; // valid, but loses precision.
          //  double price = costPerUnit;

            lstOutput.Items.Clear();
            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Sub Total:", subTotal));
            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Discount:", discount));
            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Net Cost:", netCost));
            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Sales Tax:", salesTax));
            lstOutput.Items.Add("");
            lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Total Cost:", totalCost));
            if (freeToppings)
                lstOutput.Items.Add("******* Free Toppings ********");
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
