namespace Week9HomeWork
{
    partial class frmAverageSalary
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
            this.lstFirstName = new System.Windows.Forms.ListBox();
            this.lstAge = new System.Windows.Forms.ListBox();
            this.lstMajor = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lstSalary = new System.Windows.Forms.Label();
            this.cboMajor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnClearlst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAverageSalary = new System.Windows.Forms.Label();
            this.ofdresponses = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sfdresponse = new System.Windows.Forms.SaveFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFirstName
            // 
            this.lstFirstName.FormattingEnabled = true;
            this.lstFirstName.ItemHeight = 25;
            this.lstFirstName.Location = new System.Drawing.Point(19, 73);
            this.lstFirstName.Name = "lstFirstName";
            this.lstFirstName.Size = new System.Drawing.Size(245, 254);
            this.lstFirstName.TabIndex = 0;
            this.lstFirstName.SelectedIndexChanged += new System.EventHandler(this.lstFirstName_SelectedIndexChanged);
            // 
            // lstAge
            // 
            this.lstAge.FormattingEnabled = true;
            this.lstAge.ItemHeight = 25;
            this.lstAge.Location = new System.Drawing.Point(295, 73);
            this.lstAge.Name = "lstAge";
            this.lstAge.Size = new System.Drawing.Size(246, 254);
            this.lstAge.TabIndex = 1;
            this.lstAge.SelectedIndexChanged += new System.EventHandler(this.lstAge_SelectedIndexChanged);
            // 
            // lstMajor
            // 
            this.lstMajor.FormattingEnabled = true;
            this.lstMajor.ItemHeight = 25;
            this.lstMajor.Location = new System.Drawing.Point(592, 73);
            this.lstMajor.Name = "lstMajor";
            this.lstMajor.Size = new System.Drawing.Size(259, 254);
            this.lstMajor.TabIndex = 2;
            this.lstMajor.SelectedIndexChanged += new System.EventHandler(this.lstMajor_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.lstSalary);
            this.groupBox1.Controls.Add(this.cboMajor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Location = new System.Drawing.Point(954, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 427);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpNewInput";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(159, 267);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(157, 31);
            this.txtSalary.TabIndex = 7;
            // 
            // lstSalary
            // 
            this.lstSalary.AutoSize = true;
            this.lstSalary.Location = new System.Drawing.Point(17, 270);
            this.lstSalary.Name = "lstSalary";
            this.lstSalary.Size = new System.Drawing.Size(79, 25);
            this.lstSalary.TabIndex = 6;
            this.lstSalary.Text = "Salary:";
            // 
            // cboMajor
            // 
            this.cboMajor.FormattingEnabled = true;
            this.cboMajor.Items.AddRange(new object[] {
            "Business",
            "Computing",
            "Medicine",
            "Arts & Sciences"});
            this.cboMajor.Location = new System.Drawing.Point(170, 188);
            this.cboMajor.Name = "cboMajor";
            this.cboMajor.Size = new System.Drawing.Size(146, 33);
            this.cboMajor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "College Major:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(159, 114);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(157, 31);
            this.txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 121);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 25);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(159, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(157, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnClearlst
            // 
            this.btnClearlst.Location = new System.Drawing.Point(189, 391);
            this.btnClearlst.Name = "btnClearlst";
            this.btnClearlst.Size = new System.Drawing.Size(202, 65);
            this.btnClearlst.TabIndex = 4;
            this.btnClearlst.Text = "Clear Inputs";
            this.btnClearlst.UseVisualStyleBackColor = true;
            this.btnClearlst.Click += new System.EventHandler(this.btnClearlst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Average Salary:";
            // 
            // lblAverageSalary
            // 
            this.lblAverageSalary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAverageSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageSalary.Location = new System.Drawing.Point(281, 518);
            this.lblAverageSalary.Name = "lblAverageSalary";
            this.lblAverageSalary.Size = new System.Drawing.Size(207, 64);
            this.lblAverageSalary.TabIndex = 6;
            // 
            // ofdresponses
            // 
            this.ofdresponses.FileName = "ofdresponses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "College Major:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(491, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 65);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAverageSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 629);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAverageSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearlst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstMajor);
            this.Controls.Add(this.lstAge);
            this.Controls.Add(this.lstFirstName);
            this.Name = "frmAverageSalary";
            this.Text = "Average Salary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAverageSalary_FormClosing);
            this.Load += new System.EventHandler(this.frmAverageSalary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFirstName;
        private System.Windows.Forms.ListBox lstAge;
        private System.Windows.Forms.ListBox lstMajor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lstSalary;
        private System.Windows.Forms.ComboBox cboMajor;
        private System.Windows.Forms.Button btnClearlst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAverageSalary;
        private System.Windows.Forms.OpenFileDialog ofdresponses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog sfdresponse;
        private System.Windows.Forms.Button btnExit;
    }
}

