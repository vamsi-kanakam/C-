using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    // Add this line
namespace Ch8_FilesAndArrays
{
    public partial class WriteToBinaryFile : Form
    {
        public WriteToBinaryFile()
        {
            InitializeComponent();
        }
                                // Declare variable to reference FileStream object
                               // Declare variable to reference BinaryWriter object
        private void WriteToBinaryFile_Load(object sender, EventArgs e)
        {
            ExamsSaveDialog.ShowDialog();   // Display Save As Dialog box
            // Get the file name selected by the user and save in the variable fileName
            string fileName = ExamsSaveDialog.FileName;

            if (fileName.Length > 0)    // if the user selected a file
            {
                //Create FileStream object and assign to examsStream:
                
                //Create BinaryWriter objects and assign to examsWriter:
                
            }
            else
            {
                MessageBox.Show("No file selected");
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name;
            float score1, score2;
            // Store data from TextBoxes in variables
            name = txtName.Text;
            score1 = float.Parse(txtScore1.Text);
            score2 = float.Parse(txtScore2.Text);
            // Write data to file:



            MessageBox.Show("Data Saved");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   // "this" represents the current form
        }
        private void WriteToBinaryFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (examsWriter != null)
                // examsWriter.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtScore1.Text = "";
            txtScore2.Text = "";
        }
    }
}
