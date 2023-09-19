using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Ch4
{
    public partial class Palindrome : Form
    {
        public Palindrome()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //User Input
            string input = txtInput.Text;
            bool flag = false;
            int n = input.Length;

            
            //Error Check
            if(n < 2)
            {
                MessageBox.Show("Invalid String. Please re-Enter your String.");
                txtInput.Focus();
                txtInput.SelectAll();
                return;
            }
            
            //operation

            for(int i = 0; i < n/2; i++)
            {
                if (input[i] == input[n - i - 1])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            //display
            if(flag)
            {
                lstOutput.Items.Add("The String " + input + " is a Palindrome!!");
            }
            else
            {
                lstOutput.Items.Add("The String " + input + " is a NOT a Palindrome!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
