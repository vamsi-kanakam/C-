using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week10Collections_Wed
{
    public partial class frmVendorList : Form
    {
        public frmVendorList()
        {
            InitializeComponent();
        }
        //create the list for he vendor array
        private List<string[]> vendorList = new List<string[]>();
        private void frmVendorList_Load(object sender, EventArgs e)
        {
            try
            {
                //read data from tct file
                string currentline;
                string[] fields = new string[7]; //7 fields in txtfile

                //Create the streamReader object
                StreamReader vendorReader = new StreamReader("Vendor.txt");

                while (!vendorReader.EndOfStream)
                {
                    currentline = vendorReader.ReadLine(); // read line
                    fields = currentline.Split(',');
                    //add vendor array to the list
                    vendorList.Add(fields);
                    //add vendor name to the comb box
                    cboVendor.Items.Add(fields[1]);
                }
                //close streamreader
                vendorReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cboVendor.SelectedIndex != -1)
                {
                    lstOutput.Items.Clear();
                    string fmtStr = "{0,-30}{1,-15}{2,20}";
                    lstOutput.Items.Add(string.Format(fmtStr, "Vendor Name", "Zip Code", "Phone Number"));
                    //get data from the combobox - which vender was clicked
                    string theVendor = cboVendor.SelectedItem.ToString();
                    //find the selected vendor in the list of arrays
                    foreach (string[] vendors in vendorList)
                    {
                        if (theVendor == vendors[1])
                        {
                            //get the zip code and phone number and output
                            lstOutput.Items.Add(string.Format(fmtStr, vendors[1], vendors[5], vendors[6]));
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboVendor.SelectedIndex = -1;
            lstOutput.Items.Clear();
        }
    }
}
