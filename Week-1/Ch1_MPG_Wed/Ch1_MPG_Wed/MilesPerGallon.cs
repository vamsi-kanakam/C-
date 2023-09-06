using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch1_MPG_Wed
{
    public partial class MilesPerGallon : Form
    {
        public MilesPerGallon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variable
                float miles, gallons, MPG;

                //Take user input
                miles = float.Parse(txtMiles.Text);
                gallons = float.Parse(txtGallons.Text);

                //Calculate MPG
                MPG = miles / gallons;

                //Dislay
                lblMPG.Text = MPG.ToString("F"); //F - format
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGallons.Clear();
            txtMiles.Clear();
            lblMPG.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
