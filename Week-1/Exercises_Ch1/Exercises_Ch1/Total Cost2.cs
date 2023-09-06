using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_Ch1
{
    public partial class totalCost2 : Form
    {
        public totalCost2()
        {
            InitializeComponent();
        }

        private void btnComputeCost_Click(object sender, EventArgs e)
        {
            try
            {
                double labour, material, subTotal, salesTax, totalCost;
                const double TAX_RATE = 6;

                labour = double.Parse(txtLabor.Text);
                material = double.Parse(txtMaterial.Text);

                subTotal = labour + material;
                salesTax = subTotal * TAX_RATE / 100;
                totalCost = subTotal + salesTax;

                lstOutput.Items.Add(String.Format("{0,12}{1,10:C}","Sub Total:",subTotal));
                lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "Sales Tax:", salesTax));
                lstOutput.Items.Add(String.Format("{0,12}{1,10:C}", "Total Cost:", totalCost));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLabor.Text = null;
            txtMaterial.Text = null;
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
