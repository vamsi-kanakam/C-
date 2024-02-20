using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Homework
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }
        //create the dictionary for the bookGenre dictionary
        Dictionary<string, string> bookGenres = new Dictionary<string, string>();

        private void frmBooks_Load(object sender, EventArgs e)
        {
            try
            {
                //Read the data From the TXT File.
                string currentLine;

                StreamReader bookReader = new StreamReader("Books.txt");

                while(!bookReader.EndOfStream)
                {
                    currentLine = bookReader.ReadLine();
                    string[] fields = currentLine.Split(',');
                    int length = fields.Length;
                    string bookName=null, bookGenre=null;

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
            catch(Exception ex)
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
                if(cboBookName.SelectedIndex != -1)
                {
                    lstOutput.Items.Clear();
                    string fmtStr = "{0,-30}{1,20}";
                    lstOutput.Items.Add(string.Format(fmtStr,"Book Name","Book Genre"));
                    lstOutput.Items.Add("");
                    string theBook = cboBookName.SelectedItem.ToString();

                    string gener = bookGenres[theBook];
                    lstOutput.Items.Add(string.Format(fmtStr,theBook,gener));
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            cboBookName.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
