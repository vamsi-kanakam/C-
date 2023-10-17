namespace Week8StudentInfo
{
    partial class frmStudents
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hsbAge = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMajor = new System.Windows.Forms.ListBox();
            this.chkAthlete = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbGrad = new System.Windows.Forms.RadioButton();
            this.rdbSenior = new System.Windows.Forms.RadioButton();
            this.rdbJunior = new System.Windows.Forms.RadioButton();
            this.rdbSophomore = new System.Windows.Forms.RadioButton();
            this.rdbFreshman = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 44);
            this.txtName.TabIndex = 0;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // hsbAge
            // 
            this.hsbAge.LargeChange = 5;
            this.hsbAge.Location = new System.Drawing.Point(176, 73);
            this.hsbAge.Minimum = 18;
            this.hsbAge.Name = "hsbAge";
            this.hsbAge.Size = new System.Drawing.Size(233, 46);
            this.hsbAge.TabIndex = 1;
            this.hsbAge.Value = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Major";
            // 
            // lstMajor
            // 
            this.lstMajor.FormattingEnabled = true;
            this.lstMajor.ItemHeight = 37;
            this.lstMajor.Items.AddRange(new object[] {
            "Allied Health",
            "Arts & Sciences",
            "Business",
            "Computing",
            "Education",
            "Engineering",
            "English",
            "History",
            "Marine Science",
            "Mathematics",
            "Nursing",
            "Pre-Med"});
            this.lstMajor.Location = new System.Drawing.Point(176, 143);
            this.lstMajor.Name = "lstMajor";
            this.lstMajor.Size = new System.Drawing.Size(243, 152);
            this.lstMajor.Sorted = true;
            this.lstMajor.TabIndex = 2;
            this.lstMajor.Validating += new System.ComponentModel.CancelEventHandler(this.lstMajor_Validating);
            // 
            // chkAthlete
            // 
            this.chkAthlete.AutoSize = true;
            this.chkAthlete.Location = new System.Drawing.Point(52, 321);
            this.chkAthlete.Name = "chkAthlete";
            this.chkAthlete.Size = new System.Drawing.Size(148, 41);
            this.chkAthlete.TabIndex = 3;
            this.chkAthlete.Text = "Athlete";
            this.chkAthlete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGrad);
            this.groupBox1.Controls.Add(this.rdbSenior);
            this.groupBox1.Controls.Add(this.rdbJunior);
            this.groupBox1.Controls.Add(this.rdbSophomore);
            this.groupBox1.Controls.Add(this.rdbFreshman);
            this.groupBox1.Location = new System.Drawing.Point(46, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year";
            // 
            // rdbGrad
            // 
            this.rdbGrad.AutoSize = true;
            this.rdbGrad.Location = new System.Drawing.Point(11, 187);
            this.rdbGrad.Name = "rdbGrad";
            this.rdbGrad.Size = new System.Drawing.Size(301, 41);
            this.rdbGrad.TabIndex = 4;
            this.rdbGrad.TabStop = true;
            this.rdbGrad.Text = "Graduate Student";
            this.rdbGrad.UseVisualStyleBackColor = true;
            // 
            // rdbSenior
            // 
            this.rdbSenior.AutoSize = true;
            this.rdbSenior.Location = new System.Drawing.Point(11, 152);
            this.rdbSenior.Name = "rdbSenior";
            this.rdbSenior.Size = new System.Drawing.Size(140, 41);
            this.rdbSenior.TabIndex = 3;
            this.rdbSenior.TabStop = true;
            this.rdbSenior.Text = "Senior";
            this.rdbSenior.UseVisualStyleBackColor = true;
            // 
            // rdbJunior
            // 
            this.rdbJunior.AutoSize = true;
            this.rdbJunior.Location = new System.Drawing.Point(11, 117);
            this.rdbJunior.Name = "rdbJunior";
            this.rdbJunior.Size = new System.Drawing.Size(136, 41);
            this.rdbJunior.TabIndex = 2;
            this.rdbJunior.TabStop = true;
            this.rdbJunior.Text = "Junior";
            this.rdbJunior.UseVisualStyleBackColor = true;
            // 
            // rdbSophomore
            // 
            this.rdbSophomore.AutoSize = true;
            this.rdbSophomore.Location = new System.Drawing.Point(11, 82);
            this.rdbSophomore.Name = "rdbSophomore";
            this.rdbSophomore.Size = new System.Drawing.Size(214, 41);
            this.rdbSophomore.TabIndex = 1;
            this.rdbSophomore.TabStop = true;
            this.rdbSophomore.Text = "Sophomore";
            this.rdbSophomore.UseVisualStyleBackColor = true;
            // 
            // rdbFreshman
            // 
            this.rdbFreshman.AutoSize = true;
            this.rdbFreshman.Checked = true;
            this.rdbFreshman.Location = new System.Drawing.Point(11, 47);
            this.rdbFreshman.Name = "rdbFreshman";
            this.rdbFreshman.Size = new System.Drawing.Size(193, 41);
            this.rdbFreshman.TabIndex = 1;
            this.rdbFreshman.TabStop = true;
            this.rdbFreshman.Text = "Freshman";
            this.rdbFreshman.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(52, 660);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(131, 86);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process Input";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(231, 656);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 95);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.CausesValidation = false;
            this.btnExit.Location = new System.Drawing.Point(415, 660);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 86);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 37;
            this.lstOutput.Location = new System.Drawing.Point(543, 378);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(299, 226);
            this.lstOutput.TabIndex = 11;
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 875);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAthlete);
            this.Controls.Add(this.lstMajor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hsbAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStudents";
            this.Text = "Student Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hsbAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMajor;
        private System.Windows.Forms.CheckBox chkAthlete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbGrad;
        private System.Windows.Forms.RadioButton rdbSenior;
        private System.Windows.Forms.RadioButton rdbJunior;
        private System.Windows.Forms.RadioButton rdbSophomore;
        private System.Windows.Forms.RadioButton rdbFreshman;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

