using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_DecisionsAndValidation_Tutorials
{
    public partial class ComputeGrade : Form
    {
        public ComputeGrade()
        {
            InitializeComponent();
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            string letterGrade;
            float totalScore = float.Parse(txtTotalScore.Text);
            float attendance = float.Parse(txtAttendance.Text);

            if (totalScore >= 90f)
            {
                if (attendance >= 90f)
                    letterGrade = "A";
                else
                    letterGrade = "B";
            }
            else if (totalScore >= 80f)
            {
                letterGrade = "B";
            }
            else if (totalScore >= 70f)
                letterGrade = "C";
            else
                letterGrade = "F";

            txtGrade.Text = null;
            txtGrade.Text = letterGrade;
        }
    }
}
