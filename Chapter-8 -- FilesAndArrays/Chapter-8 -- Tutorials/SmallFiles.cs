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
namespace Ch8_FilesAndArrays
{
    public partial class SmallFiles : Form
    {
        public SmallFiles()
        {
            InitializeComponent();
        }
        string[] names, phoneNumbers; //Declare arrays
        int recordCount = 0;

        private void SmallFiles_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[7];   // Declare array named fields
            StreamReader vendorReader = new StreamReader("Vendor.txt"); 

            names = new string[10];
            phoneNumbers = new string[10];
            // Read each line, split & store name and phone number into two arrays.
            while (vendorReader.EndOfStream == false)
            {
                currentLine = vendorReader.ReadLine();
                fields = currentLine.Split(',');

                names[recordCount] = fields[1];  //Store name into the array, names
                phoneNumbers[recordCount] = fields[6];  //Store phone# into phoneNumbers

                cboVendorNames.Items.Add(fields[1]);// Add names to the ComboBox
                recordCount = recordCount + 1;
            }
            vendorReader.Close();
        }

        private void cboVendorNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected vendor name from the ComboBox
            string searchName = cboVendorNames.SelectedItem.ToString();
            string fmtStr = "{0,-15}{1,8}";
            lstDisplay.Items.Clear();

            // Use IndexOf method to find the record
            int index = Array.IndexOf(names, searchName);
            //if there is no match, index would be -1.

            // (enter code to display phone number, if found)
            if (index >= 0)
            {
                lstDisplay.Items.Add(String.Format(fmtStr, searchName, phoneNumbers[index]));
            }
            else
            {
                MessageBox.Show("Sorry,name not found");
            }
        }
    }
}
