using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_GUIcontrols
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            string[] toppings = { "Pepperoni", "Sausage", "Onion", "Green Pepper", "Mushrooms", "Xtra Cheese", "Ham", "Anchovies" };
            foreach (string topping in toppings)
            {
                lstToppings.Items.Add(topping);
            }
            rdbDefault.Checked = true;
        }

        private void btnComputePrice_Click(object sender, EventArgs e)
        {
            if (rdbDefault.Checked== true)
            {
                MessageBox.Show("Please Select Size");
                return;
            }

            float basePrice = 0, costPerTopping = 0, totalPrice = 0;
            (basePrice, costPerTopping) = UnitPrice();
            totalPrice = basePrice +  (costPerTopping * lstToppings.SelectedItems.Count);
            lstOutput.Items.Clear();
            lstOutput.Items.Add("Price:  " + totalPrice.ToString("C2"));

            lstOutput.Items.Add("");
            lstOutput.Items.Add("Toppings: ");
            lstOutput.Items.Add("");
            if (lstToppings.SelectedItems.Count == 0)
            {
                lstOutput.Items.Add("     None");
            }
            else
            {
                foreach(string lstTopping in lstToppings.SelectedItems)
                {
                    lstOutput.Items.Add(" " + lstTopping);
                }
            }
        }

        private (float basePrice, float costPerTopping) UnitPrice()
        {
            float basePrice = 0, costPerTopping = 0;
            if (rdbSmall.Checked)
            {
                basePrice = 6.95f;
                costPerTopping = 1.5f;
            }
            else if(rdbMedium.Checked){
                basePrice = 8.95f;
                costPerTopping = 2.0f;
            }
            else if (rdbLarge.Checked) { 
                basePrice = 11.95f;
                costPerTopping = 2.5f;
            }
            return(basePrice, costPerTopping);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbDefault.Checked = true;
            lstToppings.SelectedIndex = -1;
            lstOutput.Items.Clear();
        }
    }
}
