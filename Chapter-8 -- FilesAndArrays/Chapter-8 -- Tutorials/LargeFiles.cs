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
    public partial class LargeFiles : Form
    {
        public LargeFiles()
        {
            InitializeComponent();
        }
        string[] names, phoneNumbers; //Declare arrays.
        int recordCount = 0;

        private void LargeFiles_Load(object sender, EventArgs e)
        {
            string currentLine;
            int arrayInitialSize = 10000, arrayIncrement = 5000;
            string[]fields  = new string[7]; // Declare array named fields
            StreamReader vendorReader = new StreamReader("Vendor.txt"); 

            names = new string[arrayInitialSize];
            phoneNumbers = new string[arrayInitialSize];

            // Read each line, split it, and store name & phone number into two arrays.
            while (vendorReader.EndOfStream == false)
            {
                // If the names array is full, increase the size of arrays.
                if (recordCount == names.Length)
                {
                    Array.Resize(ref names, names.Length + arrayIncrement);
                    Array.Resize(ref phoneNumbers, phoneNumbers.Length + arrayIncrement);
                }
                currentLine = vendorReader.ReadLine();
                fields = currentLine.Split(',');  // split the line, & store in the array, fields

                names[recordCount] = fields[1]; //Store name into the array, names
                phoneNumbers[recordCount] = fields[6]; //Store phone number into phoneNumbers
                recordCount = recordCount + 1;
            }
            vendorReader.Close();
        }

        private void btnFindPhone_Click(object sender, EventArgs e)
        {
            string searchName = txtVendorName.Text;
            string fmtStr = "{0,-15}{1,8}";
            lstDisplay.Items.Clear();

            // Method 1: Use IndexOf method to find the record
            int index = Array.IndexOf(names, searchName); 
                        //if there is no match, index would be -1.
            if (index >= 0)
                lstDisplay.Items.Add(string.Format(fmtStr, searchName, 
                                                phoneNumbers[index]));
            else
                MessageBox.Show("Sorry, name not found");

            // Method 2: Use for loop to find the record
            /* for (index = 0; index < recordCount; index++)
             {
                 if (searchName == names[index])
                 {
                     lstDisplay.Items.Add(String.Format(fmtStr, names[index], 
                                                     phoneNumbers[index]));
                     return;
                 }
            MessageBox.Show("Sorry, there is no Vendor by that name");
             }*/
        }
    }
}
