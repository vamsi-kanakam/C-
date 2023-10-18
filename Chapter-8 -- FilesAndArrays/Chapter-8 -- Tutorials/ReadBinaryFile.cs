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
    public partial class ReadBinaryFile : Form
    {
        public ReadBinaryFile()
        {
            InitializeComponent();
        }

        private void btnComputePercent_Click(object sender, EventArgs e)
        {
            string name, fmtStr;
            float score1, score2;
            float percentScore;



            fmtStr = "{0, 15}{1, 6}{2, 6}{3, 6:N1}";
            lstDisplay.Items.Clear();
            // while (examsReader.PeekChar() != -1)
            {
                // Read the next string (name)from Exams.bin

                // Read the next number (float type) from Exams.bin


                // percentScore = 100*(score1 + score2) / 200;
                //Display the data and average in the List  box
                // lstDisplay.Items.Add(string.Format(fmtStr, name, score1, score2, percentScore));
            }
            // examsReader.Close();
        }
    }
}
