
//      Programmed BY: Kanakam Vamsi Krishna Prasad
//                  J00744483


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaguarPizza2
{
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        //Declare variable CustomerReader at class Level
        StreamWriter customerWriter;

        //---------------------------------- ADD CUSTOMER BUTTON -----------------------------------------------------
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                frmProcessAnOrder theProcess = new frmProcessAnOrder();

                //-------------------------- VAILDATION ---------------------------------------------------------------
                if (txtCustomerName.Text.Length == 0)
                {
                    MessageBox.Show("Customer Name Need Not be null");
                    return;
                }

                if (txtStreetAddress.Text.Length == 0)
                {
                    MessageBox.Show("Street Name is empty");
                    return;
                }

                if (txtZipCode.Text.Length == 0)
                {
                    MessageBox.Show("ZipCode should no be empty");
                    return;
                }
                long zipCode;
                if (long.TryParse(txtZipCode.Text, out zipCode) == false)
                {
                    MessageBox.Show("ZipCode is a numeric type");
                    return;
                }

                long phoneNumber;
                if (long.TryParse(txtPhoneNumber.Text, out phoneNumber) == false)
                {
                    MessageBox.Show("PhoneNumber is a numeric type");
                    return;
                }

                if (txtPhoneNumber.Text.Length == 0)
                {
                    MessageBox.Show("PhoneNumber should not be null");
                    return;
                }

                if (zipCode < 0)
                {
                    MessageBox.Show("ZipCode is a positive numeric type");
                    return;
                }
                if (phoneNumber < 0)
                {
                    MessageBox.Show("PhoneNumber must not be a negative number.");
                    return;
                }

                //---------------------------------- Add Customer Logic ------------------------------------------
                ofdAddCustomer.ShowDialog();
                string fileName = ofdAddCustomer.FileName;
                customerWriter = new StreamWriter(fileName, true);
                int customerNum = frmProcessAnOrder.customerNumber + 1;
                frmProcessAnOrder.customerNumber = customerNum;
                customerWriter.WriteLine(customerNum + "," + txtCustomerName.Text + "," + txtStreetAddress.Text + "," + txtZipCode.Text + "," + txtPhoneNumber.Text);
                theProcess.cboCustomerName.Items.Add(txtCustomerName.Text);
                string[] newfield = { customerNum.ToString(), txtCustomerName.Text, txtStreetAddress.Text, txtZipCode.Text, txtPhoneNumber.Text };
                frmProcessAnOrder.customers.Add(newfield);
                MessageBox.Show("New Customer Added.");
                ClearInputs();
                customerWriter.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        //-------------------------------CLEAR BUTTON --------------------------------------------
        private void btnClearInput_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        public void ClearInputs()
        {
            txtCustomerName.Clear();
            txtStreetAddress.Clear();
            txtZipCode.Clear();
            txtPhoneNumber.Clear();
        }

        //------------------------------------- EXIT BUTTON ---------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------- MENU STRIP ----------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
