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
    public partial class GraduationDate : Form
    {
        public GraduationDate()
        {
            InitializeComponent();
        }

        private void btnGradInfo_Click(object sender, EventArgs e)
        {
            DateTime gradDate, gradDateTime, gradTime;
            float numberOfDays;

            gradDate = dtpGradDate.Value;
            gradTime = dtpGradTime.Value;


            //Display Current date & Time and graduation date:
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Current Date & Time:      " + DateTime.Now);
            lstDisplay.Items.Add("Date of graduation:       " + gradDate.ToLongDateString());
            lstDisplay.Items.Add("");
            //Display the month & day of graduation:
            lstDisplay.Items.Add("What day is the graduation?       " + gradDate.ToString("ddd"));
            lstDisplay.Items.Add("What month is it?                 " + gradDate.ToString("MMM"));
            lstDisplay.Items.Add("What day of the month?            " + gradDate.Day);
            //Format and display the time of graduation:
            lstDisplay.Items.Add("What time?                        " + gradTime.ToLongDateString());
            //Compute interval between today's date and graduation date
            TimeSpan tsGraduation = (gradDate - DateTime.Today);
            //OR TimeSpan tsGraduation = gradDate.Subtract(DateTime.Today);

            numberOfDays = (float) tsGraduation.Days;
            lstDisplay.Items.Add("");
            lstDisplay.Items.Add("How long?");
            lstDisplay.Items.Add("You have only " + numberOfDays + " more days to graduate.");

            //computing weeks,months and years
            float numberOfWeeks = numberOfDays / 7;
            float numberOfMonths = ((gradDate.Year - DateTime.Today.Year)*12) + (gradDate.Month - DateTime.Today.Month);
            float numberOfYears = (float) (numberOfDays / 365.25);

            //Display number of weeks,months & years
            lstDisplay.Items.Add("That is, about " + numberOfWeeks.ToString("NO") + " more weeks.");
            lstDisplay.Items.Add("That is, about " + numberOfMonths + " more months.");
            lstDisplay.Items.Add("That is, over " + numberOfYears + " Years.");

            //compute the day when he loan is due - Add 60 days to graduation date.
            lstDisplay.Items.Add("");
            lstDisplay.Items.Add("When is my due? " + gradDate.AddDays(60).ToLongDateString());

            TimeSpan tsgradTime = gradTime.TimeOfDay;
            gradDateTime = gradDate.Add(tsgradTime);
            lstDisplay.Items.Add("");
            lstDisplay.Items.Add("Again, graduation date & Time is: " + gradDateTime);

            tsGraduation = (gradDateTime - DateTime.Now);
            lstDisplay.Items.Add("Just " + tsGraduation.TotalDays.ToString("N") + "more days");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            dtpGradDate.Value = DateTime.Parse("01/01/1990");
            //OR
            dtpGradDate.Value = new DateTime(1900, 01, 01);
            //OR
            dtpGradDate.Value = DateTime.Today;
            dtpGradTime.Value = DateTime.Parse("12:00 AM");
        }
    }
}
