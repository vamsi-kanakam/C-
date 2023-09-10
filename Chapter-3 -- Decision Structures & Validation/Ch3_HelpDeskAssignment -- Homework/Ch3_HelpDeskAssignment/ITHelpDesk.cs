using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_HelpDeskAssignment
{
    public partial class ITHelpDesk : Form
    {
        public ITHelpDesk()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            try
            {
                //Declaration
                string dptCode, areaOfSupport;
                DateTime startTime, endTime;
                float fixedCost, minutes, CostPerMin = 0, totalCost;

                //user input
                dptCode = txtDptCode.Text;
                areaOfSupport = txtAreaOfSupport.Text;
                startTime = dtpStartTime.Value;
                endTime = dtpEndTime.Value;
                fixedCost = float.Parse(txtFixedCost.Text);

                //Operation
                char k = dptCode[0]; //-- taking 1st character of department code as input;
                /*if(k != 'A' || k != 'F' || k != 'G' || k != 'N')
                {
                    lstOutput.Items.Add(k); -- Notworking
                }*/

                //Restriction for department code length.
                if(dptCode.Length > 3 )
                {
                    MessageBox.Show("Department Code length not exceed 3 characters");
                    txtDptCode.Focus();
                    txtDptCode.SelectAll();
                    return;
                }

                //Department code 1st letter rule
                switch (k)
                {
                    case 'A':
                        break;
                    case 'F':
                        break;
                    case 'G':
                        break;
                    case 'N':
                        break;
                    default:
                        MessageBox.Show("The 1st character of department code only valid when A,F,G,N");
                        txtDptCode.Focus();
                        txtDptCode.SelectAll();
                        return;
                }

                //start time can't exceed end time
                if (startTime > endTime)
                {
                    MessageBox.Show("Start Time can't be latter than End time");
                    dtpStartTime.Focus();
                    dtpStartTime.Select();
                    return;
                }

                TimeSpan diff = endTime - startTime;
                minutes = (float)diff.TotalMinutes;

                switch (areaOfSupport)
                {
                    case "computer System":
                        CostPerMin = 1.00f;
                        break;
                    case "ERP":
                        CostPerMin = 1.25f;
                        break;
                    case "BI":
                        CostPerMin = 1.5f;
                        break;
                    case "cloud":
                        CostPerMin = 1.25f;
                        break;
                    default:
                        CostPerMin = 0;
                        break;
                }

                totalCost = fixedCost + (minutes * CostPerMin);

                //Display
                lstOutput.Items.Add(String.Format("{0,12} {1,10:N}", "Total duration of time in minutes :", minutes));
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "Charge per minute :", CostPerMin));
                lstOutput.Items.Add("--------------------------------------------------------------------------------------------------");
                lstOutput.Items.Add(String.Format("{0,12} {1,10:c}", "The total cost for the service opted :", totalCost));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFixedCost_Validating(object sender, CancelEventArgs e)
        {
            float fixedCost;
            if (float.TryParse(txtFixedCost.Text, out fixedCost) == false)
            {
                erpFixedCost.SetError(txtFixedCost, "Please Enter Valid Number");
                txtFixedCost.Focus();
                txtFixedCost.SelectAll();
                return;
            }
            else
                erpFixedCost.SetError(txtFixedCost, "");
        }
    }
}
