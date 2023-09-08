using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3DogSitting
{
    public partial class frmDogSitter : Form
    {
        public frmDogSitter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration
                DateTime startDate;
                float noOfDays, noOfDogs, costPerDog, subTotal, tipAmount, totalCost;

                //User Input
                startDate = dtpStartDate.Value;
                noOfDogs = float.Parse(txtNoOfDogs.Text);
                costPerDog = float.Parse(txtCostPerDog.Text);
                tipAmount = float.Parse(txtTipAmount.Text);

                //Operation
                TimeSpan tsdays = DateTime.Today - startDate;
                noOfDays = tsdays.Days;
                subTotal = noOfDogs * noOfDays * costPerDog;
                totalCost = subTotal + tipAmount;

                //Display
                lstOutput.Items.Clear();
                lstOutput.Items.Add("Cost for Dog Sitting:");
                lstOutput.Items.Add("# of Days:\t" + noOfDays);
                lstOutput.Items.Add("# of Dogs:\t" + noOfDogs);
                lstOutput.Items.Add("Cost/Dog:\t" + costPerDog);
                lstOutput.Items.Add("Sub Total:\t" + subTotal);
                lstOutput.Items.Add("Tip Amount:\t" + tipAmount);
                lstOutput.Items.Add("-------------------------------------");
                lstOutput.Items.Add("Total Amount:\t" + totalCost);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCostPerDog.Clear();
            txtTipAmount.Clear();
            txtNoOfDogs.Clear();
            lstOutput.Items.Clear();
            dtpStartDate.Value = DateTime.Today;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
