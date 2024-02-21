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

namespace Week13HomeWork
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }
        //create the dictionary for the bookGenre dictionary
        Dictionary<string, string> bookGenres = new Dictionary<string, string>();

        //declare an object of the Output form
        frmOuput displayOutput;

        private void frmBooks_Load(object sender, EventArgs e)
        {
            try
            {
                //Read the data From the TXT File.
                string currentLine;

                StreamReader bookReader = new StreamReader("Books.txt");

                while (!bookReader.EndOfStream)
                {
                    currentLine = bookReader.ReadLine();
                    string[] fields = currentLine.Split(',');
                    int length = fields.Length;
                    string bookName = null, bookGenre = null;

                    if (currentLine[0] == '"')
                    {
                        bookName = GetBookName(currentLine).Trim();
                        bookGenre = fields[length - 1].Trim();
                        bookGenres.Add(bookName, bookGenre);
                    }
                    else
                    {
                        bookName = fields[0].Trim();
                        bookGenre = fields[length - 1].Trim();
                        bookGenres.Add(bookName, bookGenre);
                    }
                    cboBookName.Items.Add(bookName);
                }
                bookReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetBookName(string currentLine)
        {
            int Quotecount = 0;
            string text = "";
            for (int i = 0; i < currentLine.Length; i++)
            {
                if (currentLine[i] == '"')
                {
                    Quotecount++;
                }

                if (Quotecount % 2 != 0)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    text += currentLine[i];
                }
                if (Quotecount == 2)
                {
                    break;
                }
            }
            return text;
        }

        private void cboBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Create an object of the output form
                displayOutput = new frmOuput();

                if (cboBookName.SelectedIndex != -1)
                {
                    displayOutput.lstOutput.Items.Clear();
                    string fmtStr = "{0,-30}{1,20}";
                    displayOutput.lstOutput.Items.Add(string.Format(fmtStr, "Book Name", "Book Genre"));
                    displayOutput.lstOutput.Items.Add("");
                    string theBook = cboBookName.SelectedItem.ToString();

                    string gener = bookGenres[theBook];
                    displayOutput.lstOutput.Items.Add(string.Format(fmtStr, theBook, gener));
                    displayOutput.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unHideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                displayOutput.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cboBookName.SelectedIndex = -1;
        }
    }
}
