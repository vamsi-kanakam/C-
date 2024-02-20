namespace Week9TestGrades
{
    partial class FrmTests
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcessGrades = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.ofdExamAnswers = new System.Windows.Forms.OpenFileDialog();
            this.ofdStudentResults = new System.Windows.Forms.OpenFileDialog();
            this.sfdstudentResults = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnProcessGrades
            // 
            this.btnProcessGrades.Location = new System.Drawing.Point(50, 70);
            this.btnProcessGrades.Name = "btnProcessGrades";
            this.btnProcessGrades.Size = new System.Drawing.Size(125, 74);
            this.btnProcessGrades.TabIndex = 0;
            this.btnProcessGrades.Text = "Process Grades";
            this.btnProcessGrades.UseVisualStyleBackColor = true;
            this.btnProcessGrades.Click += new System.EventHandler(this.btnProcessGrades_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(50, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 74);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 83);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(286, 70);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(477, 354);
            this.lstOutput.TabIndex = 3;
            // 
            // ofdExamAnswers
            // 
            this.ofdExamAnswers.FileName = "ofdExamAnswers";
            // 
            // ofdStudentResults
            // 
            this.ofdStudentResults.FileName = "ofdStudentResults";
            // 
            // FrmTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcessGrades);
            this.Name = "FrmTests";
            this.Text = "Test Scores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTests_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcessGrades;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.OpenFileDialog ofdExamAnswers;
        private System.Windows.Forms.OpenFileDialog ofdStudentResults;
        private System.Windows.Forms.SaveFileDialog sfdstudentResults;
    }
}

