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

namespace Week13Sundaes_wed
{
    public partial class frmSundaes : Form
    {
        public frmSundaes()
        {
            InitializeComponent();
        }

        private void frmSundaes_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[2];
            StreamReader sundaeReader = new StreamReader("desserts.txt");

            while (sundaeReader.EndOfStream == false)
            {
                currentLine = sundaeReader.ReadLine();
                fields = currentLine.Split(';');
                ListViewItem sundaeLVI = new ListViewItem(fields);
                lvwSundaes.Items.Add(sundaeLVI);
            }
            sundaeReader.Close();
        }

        private void hsbScoops_Scroll(object sender, ScrollEventArgs e)
        {
            lblNoOfScoops.Text = hsbScoops.Value.ToString();
        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            processOrder();
        }

        private void processOrder()
        {
            try
            {
                //Create an object of the receipt form
                frmReceipt displayReceipt = new frmReceipt();

                int variable = hsbScoops.Value;
                double costPerScoop = double.Parse(lvwSundaes.SelectedItems[0].SubItems[1].Text);
                double costOfNuts = 0, costOfWhippedCream = 0;
                if (cbNuts.Checked)
                {
                    costOfNuts = 0.75;
                }
                if (cbWippedCream.Checked)
                {
                    costOfWhippedCream = 0.50;
                }

                //output the receipt and calculate the price
                //output listview has 2 columns
                string[] outputArray = new string[2];
                //1 line of output at a time
                outputArray[0] = "Number of Scoops: ";
                outputArray[1] = hsbScoops.Value.ToString();

                //create listview item to hold output
                ListViewItem scoops = new ListViewItem(outputArray);
                //add the list view items to the list view
                displayReceipt.lvwReceipt.Items.Add(scoops);
                outputArray[0] = lvwSundaes.SelectedItems[0].SubItems[0].Text;
                outputArray[1] = lvwSundaes.SelectedItems[0].SubItems[1].Text; // costPerScoop.ToString();

                ListViewItem sundae = new ListViewItem(outputArray);
                displayReceipt.lvwReceipt.Items.Add(sundae);
                //add nuts
                if (cbNuts.Checked)
                {
                    outputArray[0] = "Nuts Added";
                }
                else
                {
                    outputArray[0] = "No Nuts Added";
                }
                outputArray[1] = costOfNuts.ToString();

                ListViewItem nuts = new ListViewItem(outputArray);
                displayReceipt.lvwReceipt.Items.Add(nuts);

                //whipped Cream
                if (cbWippedCream.Checked)
                {
                    outputArray[0] = "Whipped Cream Added";
                }
                else
                {
                    outputArray[0] = "Whipped Cream NOT Added";
                }
                outputArray[1] = costOfWhippedCream.ToString();
                ListViewItem whipped = new ListViewItem(outputArray);
                displayReceipt.lvwReceipt.Items.Add(whipped);

                //open the other form receipt
                displayReceipt.ShowDialog();
                //tabInputs.SelectedTab = tabReceipt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearInputsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hsbScoops.Value = 1;
            //lblNoOfScoops.Text = null;
            cbNuts.Checked = false;
            cbWippedCream.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processOrder();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            hsbScoops.Value = 1;
            //lblNoOfScoops.Text = null;
            cbNuts.Checked = false;
            cbWippedCream.Checked = false;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
