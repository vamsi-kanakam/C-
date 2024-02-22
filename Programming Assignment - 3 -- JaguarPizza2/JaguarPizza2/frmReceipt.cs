

//      Programmed BY: Kanakam Vamsi Krishna Prasad
//                  J00744483


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaguarPizza2
{
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        //---------------------------- CLEAR -------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            lvwReceipt.Items.Clear();
        }

        //------------------------------ EXIT --------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //---------------------------- Menu Strip --------------------------------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwReceipt.Items.Clear();
        }

        private void processOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
