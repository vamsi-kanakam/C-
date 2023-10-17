using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8StudentInfo
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name");
                txtName.Focus();
                return;

           }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            hsbAge.Value = 18;
            lstMajor.SelectedIndex = -1;
            chkAthlete.Checked = false;
            rdbFreshman.Checked = true;
            lstOutput.Items.Clear();

        }

        private void lstMajor_Validating(object sender, CancelEventArgs e)
        {
            if (lstMajor.SelectedIndex== -1)
            {
                MessageBox.Show("Please select a Major");
                lstMajor.Focus();
                return;

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string name, major, year;
            int age = 0;
            bool athlete = false;

            //get input from controls
            name = txtName.Text;
            age = hsbAge.Value;
            major = lstMajor.SelectedItem.ToString();
            if (rdbFreshman.Checked)
                year = "Freshman";
            else if (rdbSophomore.Checked)
                year = "Sophomore";
            else if (rdbJunior.Checked)
                year = "Junior";
            else if (rdbSenior.Checked)
                year = "Senior";
            else
                year = "Grad Student";
            if (chkAthlete.Checked)
                athlete = true;

            //output
            lstOutput.Items.Add("Student's name is: " + name);
            lstOutput.Items.Add("Student's age is: " + age.ToString());
            lstOutput.Items.Add("Student's major is: " + major);
            lstOutput.Items.Add("Student's year is: " + year);
            if (athlete)
                lstOutput.Items.Add("Student is an athlete");
            else
                lstOutput.Items.Add("Student is not an athlete");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//exit the program
        }
    }
}
