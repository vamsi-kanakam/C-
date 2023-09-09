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
    public partial class totalCost : Form
    {
        public totalCost()
        {
            InitializeComponent();
        }

        private void btnComputeCost_Click(object sender, EventArgs e)
        {
            try {
                double labour, material, subTotal, salesTax, totalCost;
                const double TAX_RATE = 6;

                labour = double.Parse(txtLabor.Text);
                material = double.Parse(txtMaterial.Text);

                subTotal = labour + material;
                salesTax = subTotal * TAX_RATE / 100;
                totalCost = subTotal + salesTax;

                txtSubTotal.Text = subTotal.ToString("C");
                txtSalesTax.Text = salesTax.ToString("C");
                txtTotalCost.Text = totalCost.ToString("C");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLabor.Text = null;
            txtMaterial.Text = null;
            txtSubTotal.Text = null;
            txtSalesTax.Text = null;
            txtTotalCost.Text = null;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
