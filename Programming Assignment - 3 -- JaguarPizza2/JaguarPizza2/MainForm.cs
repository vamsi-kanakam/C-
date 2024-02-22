
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //---------------------------------- Process AN Order Button ---------------------------------------
        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                frmProcessAnOrder theProcess = new frmProcessAnOrder();
                theProcess.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------------- Add Customer Button ----------------------------------------
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddNewCustomer theNewCustomer = new frmAddNewCustomer();
                theNewCustomer.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ----------------------------- EXIT ---------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //--------------------------------- MENU STRIP ----------------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddNewCustomer theNewCustomer = new frmAddNewCustomer();
                theNewCustomer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void processOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProcessAnOrder theProcess = new frmProcessAnOrder();
                theProcess.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
