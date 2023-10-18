using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
                       // using Directive to include System.IO

namespace Ch8_FilesAndArrays
{
    public partial class WriteToTextFile : Form
    {
        public WriteToTextFile()
        {
            InitializeComponent();
        }
        // Declare variable ExamsWriter at class level:
        StreamWriter ExamsWriter;
        private void WriteToTextFiles_Load(object sender, EventArgs e)
        {
            ExamsSaveDialog.ShowDialog();
            string fileName = ExamsSaveDialog.FileName;

            // Create StreamWriter object
            if(fileName.Length > 0)
            {
                ExamsWriter= new StreamWriter("Exams.txt",false);
            }
            else
            {
                MessageBox.Show("No file selected");
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name, score1, score2;
            // Store all data in string variables to be stored in the text file.
            name = txtName.Text;
            score1 = txtScore1.Text;
            score2 = txtScore2.Text;
            // Combine name, score1 & score2 into a single string and store in Exams.txt
            ExamsWriter.WriteLine(name + "," + score1 + "," + score2);
            MessageBox.Show("Data Saved");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtScore1.Text = "";
            txtScore2.Text = "";
        }

        private void WriteToTextFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ExamsWriter != null)
            {
                ExamsWriter.Close();
            }
        }
    }
}
