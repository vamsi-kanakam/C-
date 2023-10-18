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
    public partial class PassingArrays : Form
    {
        public PassingArrays()
        {
            InitializeComponent();
        }

        private int ComputePercent(string[] names, float[] percentScores)
        {
            int index = 0;
            string currentLine;
            string[] fields;
            float percentScore;
            StreamReader ExamReader = new StreamReader("Exams.txt");
            
            while (ExamReader.EndOfStream == false)
            {
                currentLine = ExamReader.ReadLine(); //Read current line & store in currentLine
                fields = currentLine.Split(',');     // split current line & store fields array
                percentScore = 100*(float.Parse(fields[1]) + float.Parse(fields[2]))/200;

                names[index] = fields[0];  //Store name into current element of names array
                percentScores[index] = percentScore;  // Store percent into percentScores
                index = index + 1;
            }
            return index;
        }

        private void btnDisplayPercent_Click(object sender, EventArgs e)
        {
            string[] names = new string[10];        //Declare names array
            float[] percentScores = new float[10];  // Declare percentScores array
            int recordCount = 0;
            // Invoke ComputePercent to load arrays and get record count
            recordCount = ComputePercent(names, percentScores);

            lstDisplay.Items.Clear();       
            string fmtStr = "{0,-15}{1,8:N1}";
            lstDisplay.Items.Add(string.Format(fmtStr, "Name", "Percent"));
            // Get names and percent scores from arrays and display them
            for (int index=0; index < recordCount; index ++)
                lstDisplay.Items.Add(string.Format(fmtStr, names[index], percentScores[index]));
        } 

        private void btnDisplayAboveAvg_Click(object sender, EventArgs e)
        {
            string[] names = new string[10];
            float[] percentScores = new float[10];
            int index, recordCount = 0;
            // Get names and percent scores from arrays and display them
            recordCount = ComputePercent(names,percentScores);

            // Compute class average:
            float classTotal = 0, classAvg;
            foreach (float percentScore in percentScores)
                classTotal += percentScore;
            classAvg = classTotal / recordCount;

            lstDisplay.Items.Clear();      
            string fmtStr = "{0,-15}{1,8:N1}{2,12:N1}";
            lstDisplay.Items.Add(string.Format(fmtStr, "Name", "Percent", "class Avg"));
            // Display above average:
            for (index = 0; index < recordCount; index++)
            {
                if (percentScores[index] > classAvg)
                    lstDisplay.Items.Add(string.Format(fmtStr, names[index],                                                        percentScores[index], classAvg)); 
            }
        }
    }
}
