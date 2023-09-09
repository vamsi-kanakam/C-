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
    public partial class IceCreamCost : Form
    {
        public IceCreamCost()
        {
            InitializeComponent();
        }

        private void btnComputeCost_Click(object sender, EventArgs e)
        {
            int scoops;
            double unitPrice, cost;

            //using Parse Method
            scoops = int.Parse(txtScoops.Text);
            unitPrice = double.Parse(txtUnitPrice.Text);

            /*using convert class (.Net Class)
            scoops = Convert.ToInt32(txtScoops.Test);
            unitPrice = Convert.ToDouble(txtUnitPrice.Text);
            */

            cost = unitPrice * scoops;

            lblCost.Text = cost.ToString("C");  
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScoops.Clear();
            txtUnitPrice.Clear();
            lblCost.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
