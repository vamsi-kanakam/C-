using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2_DataTypes
{
    public partial class UserNameString : Form
    {
        public UserNameString()
        {
            InitializeComponent();
        }

        private void btnUserName_Click(object sender, EventArgs e)
        {
            String fName = txtFname.Text;
            String lName = txtLname.Text.Trim();
            String id = txtID.Text.Trim();

            String userName = lName.Substring(0, 5).ToLower() + fName.Substring(0, 1).ToLower() + id.Substring((id.Length - 2), 2);

            // userName = string.Concat(lName.Substring(0,5).ToLower(), fName.Substring(0, 1).ToLower() , id.Substring((id.Length - 2), 2));

            lblUserName.Text = userName;
        }
    }
}
