namespace Week13Tutorials
{
    partial class EmployeeForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblHourlyPayRate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(28, 114);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(97, 25);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(28, 170);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(100, 25);
            this.lblJobTitle.TabIndex = 2;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // lblHourlyPayRate
            // 
            this.lblHourlyPayRate.AutoSize = true;
            this.lblHourlyPayRate.Location = new System.Drawing.Point(28, 239);
            this.lblHourlyPayRate.Name = "lblHourlyPayRate";
            this.lblHourlyPayRate.Size = new System.Drawing.Size(174, 25);
            this.lblHourlyPayRate.TabIndex = 3;
            this.lblHourlyPayRate.Text = "Hourly Pay Rate:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(241, 170);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(375, 31);
            this.txtJobTitle.TabIndex = 6;
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(241, 239);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(375, 31);
            this.txtHourlyPay.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(260, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 25;
            this.lstEmployee.Location = new System.Drawing.Point(33, 393);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(921, 229);
            this.lstEmployee.TabIndex = 9;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "";
            this.dtpBirthday.Location = new System.Drawing.Point(241, 114);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(375, 31);
            this.dtpBirthday.TabIndex = 10;
            this.dtpBirthday.Value = new System.DateTime(2023, 11, 29, 13, 23, 31, 0);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 645);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lstEmployee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHourlyPay);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHourlyPayRate);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblName);
            this.Name = "EmployeeForm";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblHourlyPayRate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtHourlyPay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}

