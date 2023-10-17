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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            int[] testScore = { 85,92,87,67,83,91,73,98,83,84};

            testScore[0] = 89;
            testScore[2] = 99;


            int totalScore = 0,currentScore;
            lstOutput.Items.Add("index" + " " + "Score");
            for(int i = 0; i <= testScore.Length - 1; i++)
            {
                currentScore = testScore[i];
                lstOutput.Items.Add(i +  " " + currentScore);
                totalScore += currentScore;
            }

            float avgScore = (float)totalScore / testScore.Length;
            lstOutput.Items.Add(" ");
            lstOutput.Items.Add("Average:" + avgScore.ToString("N"));
        }
    }
}
