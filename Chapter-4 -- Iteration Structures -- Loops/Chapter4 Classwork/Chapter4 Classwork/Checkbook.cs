using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4_Classwork
{
    public partial class frmCheckbook : Form
    {
        public frmCheckbook()
        {
            InitializeComponent();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration
                decimal balance = 0m;
                string transactionType = "";

                //user input
                Console.WriteLine("Enter your Bank Balance: ");
                balance = decimal.Parse(Console.ReadLine());

                //Operatiton

                Console.WriteLine("Choose your tansaction Type: ");
                Console.WriteLine("Press 'C' -- for Checks");
                Console.WriteLine("Press 'D' -- for Deposite");
                Console.WriteLine("Press 'F' -- for Fee");
                Console.WriteLine("Press 'S' -- for Stopping the Transaction");

                transactionType = (Console.ReadLine()).ToUpper();

                /*while (transactionType != "S")
                {

                    Console.WriteLine("Enter your transaction amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    
                    if (transactionType == "C" || transactionType == "F")
                    {
                        balance -= amount;
                    }
                    else if (transactionType == "D")
                    {
                        balance += amount;
                    }
                    else
                    {
                        MessageBox.Show("Choose a Valid Transaction Type.");
                    }

                    Console.WriteLine("Choose your tansaction Type: ");
                    Console.WriteLine("Press 'C' -- for Checks");
                    Console.WriteLine("Press 'D' -- for Deposite");
                    Console.WriteLine("Press 'F' -- for Fee");
                    Console.WriteLine("Press 'S' -- for Stopping the Transaction");

                    transactionType = (Console.ReadLine()).ToUpper();
                }*/

                do
                {
                    Console.WriteLine("Choose your tansaction Type: ");
                    Console.WriteLine("Press 'C' -- for Checks");
                    Console.WriteLine("Press 'D' -- for Deposite");
                    Console.WriteLine("Press 'F' -- for Fee");
                    Console.WriteLine("Press 'S' -- for Stopping the Transaction");

                    transactionType = (Console.ReadLine()).ToUpper();
                    decimal amount = 0;

                    if (transactionType != "S")
                    {
                        Console.WriteLine("Enter your transaction amount: ");
                        amount = decimal.Parse(Console.ReadLine());
                    }

                    if (transactionType == "C" || transactionType == "F")
                    {
                        balance -= amount;
                    }
                    else if (transactionType == "D")
                    {
                        balance += amount;
                    }
                    else if (transactionType == "S")
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Choose a Valid Transaction Type.");
                    }
                }
                while (transactionType != "S");

                //Output
                lblOutput.Text = "The final balance : " + balance.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit the application
            this.Close();
        }
    }
}
