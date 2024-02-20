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

namespace Week11Sundaes
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

            while(sundaeReader.EndOfStream == false)
            {
                currentLine = sundaeReader.ReadLine();
                fields = currentLine.Split(';');
                ListViewItem sundaeLVI = new ListViewItem(fields);
                lvwSundaes.Items.Add(sundaeLVI);
            }
            sundaeReader.Close();
        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            int variable = hsbScoops.Value;
            double costPerScoop = double.Parse(lvwSundaes.SelectedItems[0].SubItems[1].Text);
            double costOfNuts=0, costOfWhippedCream=0;
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
            lvwReceipt.Items.Add(scoops);
            outputArray[0] = lvwSundaes.SelectedItems[0].SubItems[0].Text;
            outputArray[1] = lvwSundaes.SelectedItems[0].SubItems[1].Text; // costPerScoop.ToString();

            ListViewItem sundae = new ListViewItem(outputArray);
            lvwReceipt.Items.Add(sundae);
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
            lvwReceipt.Items.Add(nuts);

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
            lvwReceipt.Items.Add(whipped);

            //open the tab
            tabInputs.SelectedTab = tabReceipt;

        }

        private void hsbScoops_Scroll(object sender, ScrollEventArgs e)
        {
            lblNoOfScoops.Text = hsbScoops.Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvwReceipt.Items.Clear();
            lblNoOfScoops.Text = null;
            cbNuts.Checked = false;
            cbWippedCream.Checked = false;
        }
    }
}
