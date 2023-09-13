using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Hotel
{
    public partial class frmHotelStay : Form
    {
        public frmHotelStay()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration
                DateTime startDate, endDate;
                int noOfGuests, noOfdays;
                float totalCost, subtotal, costPerRoom, discount, parking = 0, tax;
                const float TAX_RATE = 12;

                //user Input
                startDate = dtpStartDate.Value;
                endDate = dtpEndTIme.Value;
                noOfGuests = int.Parse(txtNoOfGuests.Text);

                //Operation
                TimeSpan days = endDate - startDate;
                noOfdays = days.Days;

                //cost per people
                if (noOfGuests == 2)
                {
                    costPerRoom = 85;
                }
                else if (noOfGuests == 3)
                {
                    costPerRoom = 90;
                }
                else if (noOfGuests == 4)
                {
                    costPerRoom = 95;
                }
                else if (noOfGuests > 4)
                {
                    costPerRoom = 95 + (noOfGuests - 4) * 6;
                }
                else
                {
                    costPerRoom = 0;
                }

                //Discount
                if (rdBussiness.Checked == true)
                {
                    discount = 0.2f * costPerRoom;
                }
                else if (rdSenior.Checked == true)
                {
                    discount = 0.15f * costPerRoom;
                }
                else if (rdStudent.Checked == true)
                {
                    discount = 0.01f * costPerRoom;
                }
                else
                {
                    discount = 0;
                }

                //Parking
                if (cbParking.Checked == true)
                {
                    parking = 10 * noOfdays;
                }

                subtotal = (noOfdays * (costPerRoom - discount) + parking);
                tax = subtotal * TAX_RATE/100;
                totalCost = subtotal + tax;

                //Display
                lstOutput.Items.Add("# of Days: " + noOfdays);
                lstOutput.Items.Add("# of guests: " + noOfGuests);
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "The room rate per night:" , costPerRoom));
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "The discount per room per night: " , discount));
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "The parking charge,if any: " , parking));
                lstOutput.Items.Add("-------------------------------------------------------------------------------------");
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "The subtotal amount: ", subtotal));
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "Sales and Lodging Tax amount:", tax));
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "The Total Amount : ", totalCost));
                lstOutput.Items.Add("-------------------------------------------------------------------------------------");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            txtNoOfGuests.Clear();
            rdBussiness.Checked = false;
            rdSenior.Checked = false;
            rdStudent.Checked = false;
            cbParking.Checked = false;
            dtpStartDate.Value = DateTime.Now;
            dtpEndTIme.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtNoOfGuests_Validating(object sender, CancelEventArgs e)
        {
            int noOfGuests;
            if (int.TryParse(txtNoOfGuests.Text,out noOfGuests) == false)
            {
                MessageBox.Show("Enter a Valid Number");
                txtNoOfGuests.Focus();
                txtNoOfGuests.SelectAll();
                return;
            }
        }
    }
}
