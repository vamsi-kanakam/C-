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

namespace Week9TestGrades
{
    public partial class FrmTests : Form
    {
        public FrmTests()
        {
            InitializeComponent();
        }
        StreamWriter studentResultsWriter;
        private void btnProcessGrades_Click(object sender, EventArgs e)
        {
            //Declaration
            string currentLine; // use for reading in line from data file
            int lineCounter = 0, studentCounter = 0; // counter for process
            //a string array to hold student answer file
            string[] fields = new string[21];
            //Create an array to hold correct exam answers
            string[] examAnswerArray = new string[20];
            //create an array to hold the student exam answers
            string[] studentAnswerArray = new string[20];
            //Create an array to hold the student's names;
            string[] students = new string[15];
            double studentScore = 0;
            //create an array of scoresto hold student grades
            double[] studentGrade = new double[15];


            // read in the exam answer from the data file into array
            ofdExamAnswers.ShowDialog(); // displays dialog box

            //declare string to hold the name of the file to open
            string examAnswersFileName = ofdExamAnswers.FileName;
            //access the data file using streamReader - assign it a filename
            StreamReader examAnswersReader = new StreamReader(examAnswersFileName);
            //read in the data
            while (!examAnswersReader.EndOfStream) //while not at the end
            {
                examAnswerArray[lineCounter++] = examAnswersReader.ReadLine();
                // lineCounter++;

            }

            //read in the data from the student answers
            ofdStudentResults.ShowDialog();
            string studentResultsFileName = ofdStudentResults.FileName;
            StreamReader studentResultsReader = new StreamReader(studentResultsFileName);
            sfdstudentResults.ShowDialog();
            string fileName = sfdstudentResults.FileName;
            studentResultsWriter = new StreamWriter(fileName,false);

            while (!studentResultsReader.EndOfStream)
            {
                studentScore = 0;
                //read in the current student
                currentLine = studentResultsReader.ReadLine();
                //split line into individual data elements
                fields = currentLine.Split(';');
                //put student names in student array
                students[studentCounter] = fields[0];
                //loop through the fields and copy answwers to studentAnswerArray
                for(int i = 0; i < 20; i++)
                {
                    //add to student answers
                    studentAnswerArray[i] = fields[i+1]; // i+1 because 0 first element is name
                }
                //compare student answers to correct answers
                //inside the while loop to execute for each student
                for(int i = 0;i < 20; i++)
                {
                    if (studentAnswerArray[i] == examAnswerArray[i])
                    {
                        studentScore += 2.5;
                    }
                }

                //Add student Scores
                studentGrade[studentCounter] = studentScore;
                //write file
                studentResultsWriter.WriteLine(students[studentCounter] + ";" + studentGrade[studentCounter]);
                //increment the counter
                studentCounter++;

            }
            //close the connection to data files
            examAnswersReader.Close();
            studentResultsReader.Close();

            //Display the result
            lstOutput.Items.Clear();
            string fmtStr = "{0,-15}{1,8:N1}";
            lstOutput.Items.Add(String.Format(fmtStr,"Student Name","Grade"));

            for(int i = 0; i < 15; i++)
            {
                lstOutput.Items.Add(String.Format(fmtStr, students[i], studentGrade[i]));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTests_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(studentResultsWriter != null)
            {
                studentResultsWriter.Close();
            }
        }
    }
}
