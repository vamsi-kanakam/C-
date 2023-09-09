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
    public partial class AutoRentalCharge : Form
    {
        public AutoRentalCharge()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                //declaration
                double costPerDay, daysRented, totalCost;
                DateTime dateRented, dateReturned, timeRented, timeReturned, returnedDateTime, rentedDateTime;

                //user input
                costPerDay = double.Parse(txtChargePerDay.Text);
                dateRented = dtpDateRented.Value;
                timeRented = dtpTimeRented.Value;
                dateReturned = dtpDateReturned.Value;
                timeReturned = dtpTimeReturned.Value;

                //operation
                TimeSpan noOfDays = dateReturned - dateRented;
                //daysRented = (double)noOfDays.Days;

                TimeSpan tsReturnedTime = timeReturned.TimeOfDay;
                returnedDateTime = dateReturned.Add(tsReturnedTime);
                TimeSpan tsRentedTime = timeRented.TimeOfDay;
                rentedDateTime = dateRented.Add(tsRentedTime);

                noOfDays = returnedDateTime - rentedDateTime;
                double hrsTODays = noOfDays.Hours / 24.0;
                double minsTODays = (noOfDays.Minutes / 60.0) / 24.0;
                daysRented = noOfDays.Days + hrsTODays + minsTODays;

                totalCost = daysRented * costPerDay;

                //display
                lstOutput.Items.Clear();
                lstOutput.Items.Add(String.Format("{0,12}{1,10:f}", "No.of Days Rented:", daysRented));
                lstOutput.Items.Add("");
                lstOutput.Items.Add(String.Format("{0,12}{1,10:c}", "Total Cost:", totalCost));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
