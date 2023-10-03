using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5HomeWork
{
    public partial class frmComputeGrade : Form
    {
        public frmComputeGrade()
        {
            InitializeComponent();
        }

        bool flag;
        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                float score;
                flag = false;

                //call Validscore
                (name, score) = ValidScore();

                //if invalid score terminate program
                if (flag)
                {
                    return;
                }
                //call CalculateGrate
                string grade = CalculateGrade(score);
                //call DisplayResult
                DisplayResult(name, grade);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private (string , float) ValidScore()
        {
            //user input
            string name = txtName.Text;
            float score;
            
            if((float.TryParse(txtScore.Text,out score)) == false)
            {
                MessageBox.Show("Invalid Score!!");
                txtScore.Focus();
                txtScore.SelectAll();
            }
            //score validation
            if (score < 0 || score > 100)
            {
                MessageBox.Show("Invalid Score!!");
                txtScore.Focus();
                txtScore.SelectAll();
                flag = true;
            }

            return (name, score);
        }

        private string CalculateGrade(float score)
        {
            string grade=null;
            if(score>=90 && score <= 100)
            {
                grade = "A";
            }
            else if(score>=80 && score < 90)
            {
                grade = "B";
            }
            else if(score>=70 && score < 80)
            {
                grade = "C";
            }
            else if(score>=60 && score < 70)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            return grade;
        }

        private void DisplayResult(string name,string grade)
        {
            lstOutput.Items.Add(string.Format("{0,20}{1,10}","Subject: ",name));
            lstOutput.Items.Add("");
            lstOutput.Items.Add(string.Format("{0,20}{1,10}", "Grade: ", grade));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            txtName.Clear();
            txtScore.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
