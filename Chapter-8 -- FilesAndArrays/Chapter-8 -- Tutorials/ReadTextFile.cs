using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ch8_FilesAndArrays
{
    public partial class ReadTextFile : Form
    {
        public ReadTextFile()
        {
            InitializeComponent();
        }

        private void btnDisplayRecords_Click(object sender, EventArgs e)
        {
            string currentLine;
            // Create StreamReader object to read Exams.txt
            StreamReader examsReader = new StreamReader("Exams.txt");

            lstDisplay.Items.Clear();
            while(examsReader.EndOfStream == false)
            {
                currentLine = examsReader.ReadLine();
                lstDisplay.Items.Add(currentLine); //Display current Line
            }
            examsReader.Close();







        }

        private void btnComputPercent_Click(object sender, EventArgs e)
        {
            float percentScore;
            string[] fields;  
            string fmtStr, currentLine;
            // Create  StreamReader object to read Exams.txt
            StreamReader ExamsReader = new StreamReader("Exams.txt");

            lstDisplay.Items.Clear();       //Clear ListBox
            // Print heading in the listbox
            fmtStr = "{0,-15}{1,8}{2,8}{3,8:N1}";
            lstDisplay.Items.Add(string.Format(fmtStr, "Name", "Exam1", "Exam2", "Percent"));

            while (ExamsReader.EndOfStream == false)
            {
                currentLine = ExamsReader.ReadLine();
                // Split currentLine to three string data items and store in a string array.
                fields = currentLine.Split(',');
       
                // percentScore =  (insert code to compute student's average score)
                percentScore = (float.Parse(fields[1]) + float.Parse(fields[2]))/2;
                //display the three data items and student total in the List  box
                lstDisplay.Items.Add(String.Format(fmtStr, fields[0], fields[1], fields[2],percentScore));

            }
            ExamsReader.Close();
        }

        private void btnAboveAvg_Click(object sender, EventArgs e)
        {
            //Declare two 1-D arrays
            string[] names = new string[10];
            float[] percentScores = new float[10];

            int recordCount, index = 0;

            string currentLine;
            string[] fields;
            float percentScore, classTotal = 0, classAvg; 
            //percentScore is percent for a student; percentScores is the array of all percents
            StreamReader ExamReader = new StreamReader("Exams.txt");

            while (ExamReader.EndOfStream == false)
            {
                currentLine = ExamReader.ReadLine();    // read current line & store in currentLine
                fields = currentLine.Split(','); // split current line & store in the array, fields
                percentScore = (float.Parse(fields[1]) + float.Parse(fields[2]))/2;

                names[index] = fields[0];  //Store name into current element of names array
                percentScores[index] = percentScore;  // Store percent into percentScores
                index++;    // increment index by one
                classTotal = classTotal + percentScore;    // Add current percent to classTotal
            }
            recordCount = index;
            classAvg = classTotal / (float) recordCount;

            string fmtStr = "{0,-15}{1,12:N1}{2,12:N1}";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Above average students");
            lstDisplay.Items.Add(string.Format(fmtStr, "Name", "Percent", "Class Avg"));

            //Find Above average students 
            for (int i = 0; i < recordCount; i++)
            {
                if (percentScores[i] > classAvg)
                {
                    lstDisplay.Items.Add(String.Format(fmtStr, names[i], percentScores[i],classAvg));
                }
            }

            ExamReader.Close();
        }
    }
}
