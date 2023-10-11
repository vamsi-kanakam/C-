using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JagSales
{
    public partial class JagSales : Form
    {
        public JagSales()
        {
            InitializeComponent();
        }
        bool timeFlag; // FIELD or GLOBAL VARIABLE


// ---------------------------------------- MAIN METHOD (ProcessPay Click Event) --------------------------------------
        private void btnProcessPay_Click(object sender, EventArgs e)
        {
            try
            {
                timeFlag = false;
                //Declaration
                string name;
                float basePay;
                DateTime startDate, endDate;

                //get inputs
                (name, basePay, startDate, endDate) = GetInput();

                //validate inputs
                ValidateDate(startDate, endDate);
                if (timeFlag)
                    return;
                //Console items enter
                (int items, float grossTotal) = EnterItems(); //console

                // Processing
                (float commission, float GrossBonus, float ItemBonus, float totalPay) = GenerateProcess(basePay,items,grossTotal);

                //Display the Output
                DisplayResults(name,startDate,basePay,grossTotal,commission,GrossBonus,items,ItemBonus,totalPay);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


// ---------------------------- FUNCTIONS (or) METHODS -----------------------------------------------------------------
// ---------------------------------------- GET DATA -----------------------------------------------------------------
        //get inputs method
        private (string,float,DateTime,DateTime) GetInput()
        {
            string name = txtName.Text;
            float basePay = float.Parse(txtBasePay.Text);
            DateTime start = dtpStartingDate.Value;
            DateTime end = dtpEndingDate.Value;

            return(name,basePay,start,end);
        }

        //Console -- enter items
        private (int,float) EnterItems()
        {
            float price=0;
            int count = 0;
            float sum = 0;
            string line = null;

            do
            {
                count++;
                Console.WriteLine("Enter the Price of the Item Sold, Enter -1 when done");
                line = Console.ReadLine();
                price = float.Parse(line);

                if (line == "-1")
                {
                    count--;
                    break;
                }

                if (price < 0)
                {
                    Console.WriteLine(" !!!! Item Value MUST be positive !!!!");
                    count--;
                    continue;
                }
                else
                {
                    sum += price;
                }
            }
            while (line != "-1");

            return (count, sum);
        }

// ----------------------------------------- VALIDATION ---------------------------------------------------------------
        //Validate Date
        private void ValidateDate(DateTime start, DateTime end)
        {
            if(start > end)
            {
                timeFlag = true;
                MessageBox.Show("start date must be less than end date");
                dtpStartingDate.Focus();
                dtpStartingDate.Select();
                return;
            }

            TimeSpan noOfDays = end - start;
            if(noOfDays.Days > 7)
            {
                timeFlag = true;
                MessageBox.Show("End date MUST not exceed more than 7 days");
                dtpEndingDate.Focus();
                dtpEndingDate.Select();
                return;
            }
        }

        //BasePay validation
        private void txtBasePay_TextChanged(object sender, EventArgs e)
        {
            float pay;
            if (float.TryParse(txtBasePay.Text, out pay) == false)
            {
                erpBasePay.SetError(txtBasePay,"Enter valid Base pay!!");
                txtBasePay.Focus();
                txtBasePay.SelectAll();
                return;
            }

            //positive validation
            if(pay <= 0)
            {
                erpBasePay.SetError(txtBasePay,"Base pay MUST be positive!!");
                txtBasePay.Focus();
                txtBasePay.SelectAll();
                return;
            }
            else
            {
                erpBasePay.SetError(txtBasePay, "");
            }
        }

// -------------------------------------------- PROCESSING -----------------------------------------------------------------------

        private (float, float, float, float) GenerateProcess(float basePay,float noOfItems, float GrossTotal)
        {
            float commission = GrossTotal * 0.09f;
            float GrossBonus=0;
            if (GrossTotal > 10000)
                GrossBonus = 500;
            float itemBonus=0;
            if(noOfItems > 5)
            {
                itemBonus = (noOfItems - 5) * 25;
            }

            float totalPay = basePay + commission + GrossBonus + itemBonus;

            return (commission,GrossBonus,itemBonus,totalPay);
        }

// --------------------------------------------- DISPLAY OUTPUT ---------------------------------------------------------------------------

        private void DisplayResults(string name, DateTime start, float basePay, float saleAmount, float commission, float grossBonus, int items,float itemBonus, float totalPay)
        {
            lstOutput.Items.Add(string.Format("{0,10} {1,20}", "Employee Name: ", name));
            lstOutput.Items.Add(string.Format("{0,10} {1,20}", "Start Date: ", start));
            lstOutput.Items.Add(string.Format("{0,10} {1,20:c}", "Base Pay: ", basePay));
            lstOutput.Items.Add(string.Format("{0,10} {1,20:c}", "Amount of Sales:", saleAmount));
            lstOutput.Items.Add(string.Format("{0,10} {1,20:c}", "Commission", commission));
            lstOutput.Items.Add(string.Format("{0,10} {1,20:c}", "Bonus Pay on Gross: ", grossBonus));
            lstOutput.Items.Add(string.Format("{0,10} {1,20}", "Number of Items Sold: ", items));
            lstOutput.Items.Add(string.Format("{0,10} {1,20:c}", "Base Pay on Number of Items: ", itemBonus));
            lstOutput.Items.Add(string.Format("{0,10} {1,20:c}", "Total Pay: ", totalPay));
        }

//----------------------------------------------- CLEAR BUTTON -----------------------------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtBasePay.Clear();
            dtpStartingDate.Value = DateTime.Today;
            dtpEndingDate.Value = DateTime.Today;
            lstOutput.Items.Clear();
        }

//------------------------------------------------ EXIT BUTTON -----------------------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
