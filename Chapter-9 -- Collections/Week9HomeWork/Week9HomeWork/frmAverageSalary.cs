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

namespace Week9HomeWork
{
    public partial class frmAverageSalary : Form
    {
        public frmAverageSalary()
        {
            InitializeComponent();
        }

        StreamWriter responseWriter;

        //Declaration

        string currentLine;
        double avg_salary = 0;
        int lineCounter = 0;
        string[] fields = new string[4];
        string[] firstName = new string[10];
        string[] age = new string[10];
        string[] major = new string[10];
        string[] salary = new string[10];

        private void frmAverageSalary_Load(object sender, EventArgs e)
        {
            try
            {
                //Read input file
                ofdresponses.ShowDialog();
                string inputFileName = ofdresponses.FileName;

                //stream reader
                StreamReader responsesReader = new StreamReader(inputFileName);

                while (!responsesReader.EndOfStream)
                {
                    if (firstName.Length == lineCounter)
                    {
                        Array.Resize(ref firstName, firstName.Length + 25);
                        Array.Resize(ref age, age.Length + 25);
                        Array.Resize(ref major, major.Length + 25);
                        Array.Resize(ref salary, salary.Length + 25);
                    }

                    currentLine = responsesReader.ReadLine();
                    fields = currentLine.Split(';');

                    firstName[lineCounter] = fields[0];
                    age[lineCounter] = fields[1];
                    major[lineCounter] = fields[2];
                    salary[lineCounter] = fields[3];

                    //To check weather the the items present in the listbox.
                    if (isPresent(firstName[lineCounter], lstFirstName) || isPresent(age[lineCounter], lstAge) || isPresent(major[lineCounter], lstMajor))
                    {
                        lineCounter++;
                    }
                    else
                    {
                        lstFirstName.Items.Add(firstName[lineCounter]);
                        lstAge.Items.Add(age[lineCounter]);
                        lstMajor.Items.Add(major[lineCounter]);

                        lineCounter++;
                    }

                }
                responsesReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //method for checking the items in the listbox.
        private bool isPresent(string Checkitem,ListBox lst)
        {
            foreach(var item in lst.Items)
            {
                if(item.ToString() == Checkitem)
                {
                    return true;
                }
            }
            return false;
        }

        private void lstFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstFirstName.SelectedIndex > 0)
            {
                string selected = lstFirstName.SelectedItem.ToString();
                CalculateAverage(selected, firstName);
            }
        }

        private void lstAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstAge.SelectedIndex > 0)
            {
                string selected = lstAge.SelectedItem.ToString();
                CalculateAverage(selected, age);
            }

        }

        private void lstMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMajor.SelectedIndex > 0)
            {
                string selected = lstMajor.SelectedItem.ToString();
                CalculateAverage(selected, major);
            }
        }

        private void CalculateAverage(string selected,string[] items)
        {
            int count = 0;
            double total = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (selected == items[i])
                {
                    count++;
                    total += double.Parse(salary[i]);
                }
            }

            avg_salary = total / count;

            lblAverageSalary.Text = avg_salary.ToString("c");
        }

        private void btnClearlst_Click(object sender, EventArgs e)
        {
            lstFirstName.SelectedIndex = -1;
            lstAge.SelectedIndex = -1;
            lstMajor.SelectedIndex = -1;
            lblAverageSalary.Text = null;
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFirstName.Text;
                string age = txtAge.Text;
                string major = cboMajor.SelectedItem.ToString();
                string salary = txtSalary.Text;

                /*if (txtFirstName.Text == null)
                {
                    MessageBox.Show("Please enter the Name!");
                }

                if (float.TryParse(txtAge.Text, out age))
                {
                    txtAge.Focus();
                    txtAge.SelectAll();
                    return;
                }
                else
                {
                    MessageBox.Show("Age must be numeric.");
                }

                if (double.TryParse(txtSalary.Text, out salary))
                {
                    txtSalary.Focus();
                    txtSalary.SelectAll();
                    return;
                }
                else
                {
                    MessageBox.Show("Salary must be numeric.");
                }
                */
                sfdresponse.ShowDialog();
                string fileName = sfdresponse.FileName;
                responseWriter = new StreamWriter(fileName, true);
                responseWriter.Write(name + ";" + age.ToString() + ";" + major + ";" + salary.ToString());
                MessageBox.Show("New Input appended.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmAverageSalary_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(responseWriter != null)
            {
                responseWriter.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Text = null;
            txtSalary.Text = null;
            txtFirstName.Text = null;
            cboMajor.SelectedIndex=-1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
