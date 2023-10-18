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
    public partial class TwoDimArray : Form
    {
        public TwoDimArray()
        {
            InitializeComponent();
        }
        //Declare a 2-D array with 10 rows and 5 columns:
        string[,] sales = new string[10, 5];
        int recordCount;    // Actual number of records read

        private void TwoDimArray_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[2];
            int row = 0, column = 0;
            //Create StreamReader
            StreamReader SalesReader = new StreamReader("Sales.txt");

            //Read each line from the file, split and store in a row of the 2-D array.
            while (SalesReader.EndOfStream == false)
            {
                currentLine = SalesReader.ReadLine();//Read product# and 4 sales data
                fields = currentLine.Split(','); //Store Product# & sales in a temp array

                //Copy Product# and four sales to the five columns of the current row:
                sales[row, 0] = fields[0];  // product number stored in column 0
                sales[row, 1] = fields[1];  // Sales for qtr 1 stored in column 1
                sales[row, 2] = fields[2];  // Sales for qtr 2 stored in column 2
                sales[row, 3] = fields[3];  // Sales for qtr 3
                sales[row, 4] = fields[4];  // Sales for qtr 4
                
                // Or, use a loop to change the column of the array element:
                for(column = 0; column <= 4; column++)
                {
                    sales[row, column] = fields[column];
                }


                row = row + 1;
            }
            recordCount = row; // recordCount is the number of rows that has data in it.
            SalesReader.Close();
        }

        private void btnDisplaySales_Click(object sender, EventArgs e)
        {
            int row = 0, column, rowSum=0;
            string fmtStr = "{0,-20}{1,8}";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(string.Format(fmtStr, "Product#", "Total Sales"));

            for (row = 0; row < recordCount; row++) 
                // recordCount is the number of rows with data in it 
            {
                // Check whether column 0 of current row matches Prodduct#
                if (sales[row, 0] == txtProdNumber.Text) 
                {
                    // Add columns 1 - 4
                    rowSum = int.Parse(sales[row, 1]) + int.Parse(sales[row, 2]) +
                             int.Parse(sales[row, 3]) + int.Parse(sales[row, 4]); 
                    // Alternate method using a loop:
                    for(column = 0;column <= 4; column++)
                    {
                        rowSum = rowSum + int.Parse(sales[row, column]);
                    }

                    lstDisplay.Items.Add(string.Format(fmtStr, txtProdNumber.Text, rowSum));
                    return;     // Exit the method, if a matching product is found
                }
            }
        }
    }
}
