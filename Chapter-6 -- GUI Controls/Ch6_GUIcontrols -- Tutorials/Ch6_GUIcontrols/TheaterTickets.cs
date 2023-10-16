using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_GUIcontrols
{
    public partial class TheaterTickets : Form
    {
        public TheaterTickets()
        {
            InitializeComponent();
        }

        float amtDue;
        private void hsbNumOfTickets_ValueChanged(object sender, EventArgs e)
        {
            lblNumOfTickets.Text = hsbNumOfTickets.Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hsbNumOfTickets.Value = 0;
            lblNumOfTickets.Text = "";
            chkMember.CheckState = CheckState.Indeterminate;
            rdbDefault.Checked = true;
            lblAmtDue.Text = "";
            cboShow.SelectedIndex = -1;
        }

        private void TheaterTickets_Load(object sender, EventArgs e)
        {
            chkMember.CheckState = CheckState.Indeterminate;
            rdbDefault.Checked = true;
            string[] shows = { "Mamma Mia", "Rock of Ages", "Les Miserables", "Motown", "The Lion King", "The Phantom of the Opera" };
            foreach (string show in shows)
            {
                cboShow.Items.Add(show);
            }
        }

        private void btnComputePrice_Click(object sender, EventArgs e)
        {
            if(hsbNumOfTickets.Value == 0)
            {
                MessageBox.Show("Please specify number of tickets");
                return;
            }
            if(chkMember.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("Please specify membership");
                return;
            }
            if(rdbDefault.Checked == true)
            {
                MessageBox.Show("Please specify Section");
                return;
            }

            int numOfTickets = hsbNumOfTickets.Value;

            float discount = Discount();
            float unitPrice = UnitPrice();

            amtDue = numOfTickets * (unitPrice - discount);
            lblAmtDue.Text = amtDue.ToString("$#,###.00");
        }

        float Discount()
        {
            switch (chkMember.CheckState)
            {
                case CheckState.Checked:
                    return 20;
                default:
                    return 0;
            }
        }

        float UnitPrice()
        {
            if (rdbSec1.Checked)
            {
                return 70;
            }
            else if (rdbSec2.Checked)
            {
                return 60;
            }
            else if (rdbSec3.Checked)
            {
                return 52;
            }
            else if (rdbSec4.Checked)
            {
                return 45;
            }
            else
            {
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboShow.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a show");
                return;
            }
            if (amtDue == 0)
            {
                MessageBox.Show("Please compute amount");
                return;
            }
            string fmtstr = "{0,-25}{1,12:C}";
            lstOutput.Items.Clear();
            lstOutput.Items.Add(String.Format(fmtstr, "Show", "Total Price"));
            lstOutput.Items.Add(String.Format(fmtstr, cboShow.SelectedItem, amtDue));
        }
        private void cboShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(amtDue == 0)
            {
                MessageBox.Show("Please compute amount");
                return;
            }
            string fmtstr = "{0,-25}{1,12:C}";
            lstOutput.Items.Clear();
            lstOutput.Items.Add(String.Format(fmtstr,"Show","Total Price"));
            lstOutput.Items.Add(String.Format(fmtstr, cboShow.SelectedItem, amtDue));
        }
       
    }
}
