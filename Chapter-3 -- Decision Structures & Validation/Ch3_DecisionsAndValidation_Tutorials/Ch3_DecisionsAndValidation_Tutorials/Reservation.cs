using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_DecisionsAndValidation_Tutorials
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string discountType = txtDiscountType.Text;
            float discountPercent;

            switch(discountType)
            {
                case "AAA":
                    discountPercent = 10;
                    break;
                case "Best Rate":
                    discountPercent= 5;
                    break;
                case "Government":
                    discountPercent = 15;
                    break;
                case "Senior":
                    discountPercent = 12.5f;
                    break;
                default:
                    discountPercent = 0;
                    break;
            }

            lblDiscountPercent.Text = discountPercent.ToString("N");
        }
    }
}
