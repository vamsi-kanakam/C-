using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8HomeWork
{
    public partial class frmIceCreamSundae : Form
    {
        public frmIceCreamSundae()
        {
            InitializeComponent();
        }

        private void btnComputePrice_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration
                int noOfScoops;
                float SundaeTypeCost, NutCost=0, totalCost;
                string flavour = "";
                string format = "{0,-25}{1,12}";
                string sundaeType = "";
                if (lstBoxSundaeType.SelectedIndex != -1)
                {
                    sundaeType = lstBoxSundaeType.SelectedItem.ToString().ToLower();
                } 

                noOfScoops = hsbScoops.Value;

                //Operation
                //sundaeType
                switch (sundaeType)
                {
                    case "custard":
                        SundaeTypeCost = 3.75f;
                        break;
                    case "ice cream":
                        SundaeTypeCost = 3.50f;
                        break;
                    case "yogurt":
                        SundaeTypeCost = 3.25f;
                        break;
                    case "sorbet":
                        SundaeTypeCost = 4.00f;

                        break;
                    default:
                        MessageBox.Show("Please Select a Sundae Type !!");
                        lstBoxSundaeType.Focus();
                        return;
                }
                //icecream flavour
                if (rdbChocolate.Checked)
                {
                    flavour = rdbChocolate.Text;
                }
                else if(rdbVanilla.Checked)
                {
                    flavour= rdbVanilla.Text;
                }
                else if(rdbStrawberry.Checked)
                {
                    flavour= rdbStrawberry.Text;
                }

                //Add nuts
                if (cbNuts.Checked)
                {
                    NutCost = 0.75f;
                }
                
                totalCost = SundaeTypeCost * noOfScoops + NutCost;

                //Display
                lstOutput.Items.Add(String.Format(format,"# of Scoops : ", noOfScoops));
                lstOutput.Items.Add(String.Format(format, "Type of Sundae: ", lstBoxSundaeType.SelectedItem.ToString()));
                lstOutput.Items.Add(String.Format(format,"Ice Cream Flavour: ",flavour));
                if (cbNuts.Checked)
                {
                    lstOutput.Items.Add("Nuts Add");
                }
                lstOutput.Items.Add(String.Format("{0,-25}{1,12:C}", "Total cost :",totalCost));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hsbScoops_ValueChanged(object sender, EventArgs e)
        {
            lblScoopsDisplay.Text = hsbScoops.Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            hsbScoops.Value = 1;
            lstBoxSundaeType.SelectedIndex = -1;
            rdbVanilla.Checked = true;
            cbNuts.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lstBoxSundaeType_Validating(object sender, CancelEventArgs e)
        {
            if (lstBoxSundaeType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Sundae Type !!");
                lstBoxSundaeType.Focus();
                return;
            }
        }
    }
}
