using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_Arrays
{
    public partial class LookUpUsingArrays : Form
    {
        public LookUpUsingArrays()
        {
            InitializeComponent();
        }

        string[] months = { "January","Febuary","March","April","May","June","July","August","September","October","November","December"};
        int[] unitSold = { 572, 645, 693, 564, 580, 756, 859, 756, 663, 678, 745, 958 };
        private void btnDisplayUnitSold_Click(object sender, EventArgs e)
        {
            string month = txtMonth.Text;
            int monthIndex, unitSoldinMonth;

            int i = 0;
            for(i=0;i<months.Length;i++) {
                if (months[i] == month)
                {
                    unitSoldinMonth = unitSold[i];
                    lblUnitSold.Text = unitSoldinMonth.ToString();
                    break;
                }
                
            }
            if (i >= months.Length)
            {
                MessageBox.Show("Month not found");
                return;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMonth.Clear();
            lblUnitSold.Text = null;
        }
    }
}
