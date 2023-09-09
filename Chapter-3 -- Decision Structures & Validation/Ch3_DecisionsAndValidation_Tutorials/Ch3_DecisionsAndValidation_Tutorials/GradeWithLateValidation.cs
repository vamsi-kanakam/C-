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
    public partial class GradeWithLateValidation : Form
    {
        public GradeWithLateValidation()
        {
            InitializeComponent();
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            string letterGrade;
            float totalScore, attendance;
            if(float.TryParse(txtTotalScore.Text,out totalScore) == false)
            {
                MessageBox.Show("Plese Enter a valid number for Total Score.");
                txtTotalScore.Focus();
                txtTotalScore.SelectAll();
            }
            if(float.TryParse(txtAttendance.Text,out attendance) == false)
            {
                MessageBox.Show("Plese Enter a valid number for Attendance.");
                txtAttendance.Focus();
                txtAttendance.SelectAll();
            }

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
