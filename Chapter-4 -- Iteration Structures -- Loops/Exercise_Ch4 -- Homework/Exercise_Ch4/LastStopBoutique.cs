using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Ch4
{
    public partial class LastStopBoutique : Form
    {
        public LastStopBoutique()
        {
            InitializeComponent();
        }

        private void btnPredictCost_Click(object sender, EventArgs e)
        {
            //Taking user input
            string productName=txtProductName.Text;
            float cost,discount;
            if(float.TryParse(txtOriginalPrice.Text,out cost) == false)
            {
                MessageBox.Show("Please Enter Valid Price Value.");
                txtOriginalPrice.Focus();
                txtOriginalPrice.SelectAll();
                return;
            }

            //Error Checking
            if (cost <= 0)
            {
                MessageBox.Show("Invalid Price!!");
                return;
            }

            string formatCode = "{0,7}  {1,20}";
            lstOutput.Items.Add("The cost of the " + productName + " on: ");
            lstOutput.Items.Add("");
            lstOutput.Items.Add(string.Format(formatCode, "Day", "Price"));
            lstOutput.Items.Add("-----------------------------------------------------------------------------");

            //operation
            int count =1;
            string day = "";
            


            while (count <= 5)
            {
                switch(count)
                {
                    case 1:
                        day = "Monday:";
                        break;
                    case 2:
                        day = "Tuesday:";
                        break;
                    case 3:
                        day = "Wednesday:";
                        break;
                    case 4:
                        day = "Thursday:";
                        break;
                    case 5:
                        day = "Friday:";
                        break;
                    default:
                        break;
                }

                discount = cost * 0.1f;
                cost = cost - discount;
                count = count + 1;

                lstOutput.Items.Add(string.Format("{0,7} {1,20:c}", day, cost));
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOriginalPrice.Clear();
            txtProductName.Clear();
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
