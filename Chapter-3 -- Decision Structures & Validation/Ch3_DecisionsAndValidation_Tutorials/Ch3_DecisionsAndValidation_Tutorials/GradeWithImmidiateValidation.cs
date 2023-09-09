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
    public partial class GradeWithImmidiateValidation : Form
    {
        public GradeWithImmidiateValidation()
        {
            InitializeComponent();
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            if((txtTotalScore.Text.Length == 0) || (txtAttendance.Text.Length == 0))
            {
                MessageBox.Show("Please Enter data.");
                return;
            }

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

        private void txtTotalScore_Validating(object sender, CancelEventArgs e)
        {
            float totalScore;

            if(float.TryParse(txtTotalScore.Text, out totalScore) == false)
            {
                MessageBox.Show("Please Enter a valid number for score.");
                txtTotalScore.Focus();
                txtTotalScore.SelectAll();
                return;
            }
        }

        private void txtAttendance_Validating(object sender, CancelEventArgs e)
        {
            float attendance;
            if(float.TryParse(txtAttendance.Text,out attendance) == false)
            {
                erpAttendance.SetError(txtAttendance, "Please enter a valid number for attendance");
                txtAttendance.Focus();
                txtAttendance.SelectAll();
                return;
            }
            else
            {
                erpAttendance.SetError(txtAttendance, "");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
