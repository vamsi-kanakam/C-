using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_Loops
{
    public partial class VerifyPassword : Form
    {
        public VerifyPassword()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string password = null;
            int count = 0;

            while(password != "easy")
            {
                count = count + 1;
                if (count > 3)
                {
                    MessageBox.Show("Incorrect Password. Only 3 atempts allowed.");
                    Environment.Exit(0);
                }
                Console.WriteLine("Please enter password.");
                password = Console.ReadLine();
            }
            MessageBox.Show(count + "Attempts. You may proceed now");

        }
    }
}
